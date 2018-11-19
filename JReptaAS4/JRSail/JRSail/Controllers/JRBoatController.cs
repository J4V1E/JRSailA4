/*ProgramID - PROG2230 Assignment 3 
 * 
 * Purpose - Filtering Dropdowns
 * 
 * Revision History - 
 *  Written by Joel Repta November 2018
 *  
 *  Email - jrepta2339@conestogac.on.ca
 *  Student Number - 7842339
 *  PROG2230 Section 4
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JRSail.Models;
using Microsoft.AspNetCore.Http;

namespace JRSail.Controllers
{
    public class JRBoatController : Controller
    {
        private readonly SailContext _context;

        public JRBoatController(SailContext context)
        {
            _context = context;
        }

        // GET: JRBoat
        public async Task<IActionResult> Index(int? MemberId, string FullName)
        {
            if (MemberId != null)
            {
                HttpContext.Session.SetInt32("MemberId", (int)MemberId);
            }
            else if (HttpContext.Session.GetInt32("MemberId") == null)
            {
                TempData["message"] = "Select a member to see their boats";
                return RedirectToAction(nameof(Index), "JRMember");
            }

            //else
            MemberId = HttpContext.Session.GetInt32("MemberId");

            if (!string.IsNullOrEmpty(FullName))
            {
                HttpContext.Session.SetString("FullName", FullName);
            }
            else
            {
                HttpContext.Session.SetString("FullName", _context.Member
                    .Where(x => x.MemberId == MemberId).First().FullName);
            }

            var sailContext = _context.Boat
                .Include(b => b.BoatType)
                .Include(b => b.Member)
                .Include(b => b.ParkingCodeNavigation)
                .Where(x => x.MemberId == MemberId)
                .OrderBy(x => x.BoatClass);

            return View(await sailContext.ToListAsync());
        }

        // GET: JRBoat/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boat = await _context.Boat
                .Include(b => b.BoatType)
                .Include(b => b.Member)
                .Include(b => b.ParkingCodeNavigation)
                .FirstOrDefaultAsync(m => m.BoatId == id);
            if (boat == null)
            {
                return NotFound();
            }

            return View(boat);
        }

        // GET: JRBoat/Create
        public IActionResult Create()
        {
            ViewData["BoatTypeId"] = new SelectList(_context.BoatType.OrderBy(x => x.Name), "BoatTypeId", "Name");
            ViewData["MemberId"] = new SelectList(_context.Member, "MemberId", "FirstName");
             ViewData["ParkingCode"] = new SelectList(_context.Parking
                .Where(x => string.IsNullOrEmpty(x.ActualBoatId)), "ParkingCode", "ParkingCode")
                .Prepend(new SelectListItem() { Value = null, Text = "" });
            return View();  
        }

        // POST: JRBoat/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BoatId,MemberId,BoatClass,HullColour,SailNumber,HullLength,BoatTypeId,ParkingCode")] Boat boat)
        {
            boat.MemberId = HttpContext.Session.GetInt32("MemberId");
            if (ModelState.IsValid)
            {
                _context.Add(boat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BoatTypeId"] = new SelectList(_context.BoatType.OrderBy(x => x.Name), "BoatTypeId", "Name", boat.BoatTypeId);
            ViewData["MemberId"] = new SelectList(_context.Member, "MemberId", "FirstName", boat.MemberId);
            ViewData["ParkingCode"] = new SelectList(_context.Parking
               .Where(x => string.IsNullOrEmpty(x.ActualBoatId)), "ParkingCode", "ParkingCode", boat.ParkingCode)
               .Prepend(new SelectListItem() { Value = "null", Text = "" });
            return View(boat);
        }

        // GET: JRBoat/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boat = await _context.Boat.FindAsync(id);
            if (boat == null)
            {
                return NotFound();
            }
            ViewData["BoatTypeId"] = new SelectList(_context.BoatType.OrderBy(x => x.Name), "BoatTypeId", "Name", boat.BoatTypeId);
            ViewData["MemberId"] = new SelectList(_context.Member, "MemberId", "FirstName", boat.MemberId);

            if (string.IsNullOrEmpty(boat.ParkingCode))
            {
                ViewData["ParkingCode"] = new SelectList(_context.Parking
                       .Where(x => string.IsNullOrEmpty(x.ActualBoatId)), "ParkingCode", "ParkingCode")
                       .Prepend(new SelectListItem() { Value = "null", Text = "" }); 
            }
            else
            {

                ViewData["ParkingCode"] = new SelectList(_context.Parking.Where(x => x.BoatTypeId == boat.BoatTypeId), "ParkingCode", "ParkingCode", boat.ParkingCode);
            }

            return View(boat);
        }

        // POST: JRBoat/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BoatId,MemberId,BoatClass,HullColour,SailNumber,HullLength,BoatTypeId,ParkingCode")] Boat boat)
        {
            if (id != boat.BoatId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(boat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoatExists(boat.BoatId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["BoatTypeId"] = new SelectList(_context.BoatType.OrderBy(x => x.Name), "BoatTypeId", "Name", boat.BoatTypeId);
            ViewData["MemberId"] = new SelectList(_context.Member, "MemberId", "FirstName", boat.MemberId);

            if (string.IsNullOrEmpty(boat.ParkingCode))
            {
                ViewData["ParkingCode"] = new SelectList(_context.Parking
                        .Where(x => string.IsNullOrEmpty(x.ActualBoatId)), "ParkingCode", "ParkingCode", boat.ParkingCode)
                        .Prepend(new SelectListItem() { Value = "null", Text = "" }); 
            }

            return View(boat);
        }

        // GET: JRBoat/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boat = await _context.Boat
                .Include(b => b.BoatType)
                .Include(b => b.Member)
                .Include(b => b.ParkingCodeNavigation)
                .FirstOrDefaultAsync(m => m.BoatId == id);
            if (boat == null)
            {
                return NotFound();
            }

            return View(boat);
        }

        // POST: JRBoat/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var boat = await _context.Boat.FindAsync(id);
            _context.Boat.Remove(boat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BoatExists(int id)
        {
            return _context.Boat.Any(e => e.BoatId == id);
        }
    }
}
