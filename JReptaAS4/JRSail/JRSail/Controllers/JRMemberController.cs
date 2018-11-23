/*ProgramID - PROG2230 Assignment 2 
 * 
 * Purpose - Learning Persistance, Sorting, Filtering
 * 
 * Revision History - 
 *  Written by Joel Repta October 2018
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
using JRClassLibrary;

namespace JRSail.Controllers
{
    public class JRMemberController : Controller
    {
        private readonly SailContext _context;

        public JRMemberController(SailContext context)
        {
            _context = context;
        }

        // GET: JRMember
        public async Task<IActionResult> Index()
        {
            TempData["message"] = TempData.Peek("message");
            var sailContext = _context.Member.Include(m => m.ProvinceCodeNavigation).OrderBy(x => x.FullName);
            return View(await sailContext.ToListAsync());
        }

        // GET: JRMember/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Member
                .Include(m => m.ProvinceCodeNavigation)
                .FirstOrDefaultAsync(m => m.MemberId == id);
            if (member == null)
            {
                return NotFound();
            }
            ViewBag.memberFullName = member.FullName;
            return View(member);
        }

        // GET: JRMember/Create
        public IActionResult Create()
        {
            ViewData["NewMemberId"] = _context.Member.OrderByDescending(x => x.MemberId).First().MemberId + 1;
            //ViewData["ProvinceCode"] = new SelectList(_context.Province, "ProvinceCode", "ProvinceCode");
            return View();
        }

        // POST: JRMember/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MemberId,FullName,FirstName,LastName,SpouseFirstName,SpouseLastName,Street,City,ProvinceCode,PostalCode,HomePhone,Email,YearJoined,Comment,TaskExempt,UseCanadaPost")] Member member)
        {
            if (ModelState.IsValid)
            {
                _context.Add(member);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProvinceCode"] = new SelectList(_context.Province, "ProvinceCode", "Name", member.ProvinceCode);
            return View(member);

            
        }

        // GET: JRMember/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var member = await _context.Member.FindAsync(id);
            ViewBag.memberFullName = member.FullName;
            if (member == null)
            {
                return NotFound();
            }
            ViewData["ProvinceCode"] = new SelectList(_context.Province.OrderBy(x => x.Name), "ProvinceCode", "Name", member.ProvinceCode);
            return View(member);
        }

        // POST: JRMember/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MemberId,FullName,FirstName,LastName,SpouseFirstName,SpouseLastName,Street,City,ProvinceCode,PostalCode,HomePhone,Email,YearJoined,Comment,TaskExempt,UseCanadaPost")] Member member)
        {
            if (id != member.MemberId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(member);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemberExists(member.MemberId))
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
            ViewData["ProvinceCode"] = new SelectList(_context.Province.OrderBy(x => x.Name), "ProvinceCode", "Name", member.ProvinceCode);
            return View(member);
        }

        // GET: JRMember/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Member
                .Include(m => m.ProvinceCodeNavigation)
                .FirstOrDefaultAsync(m => m.MemberId == id);
            if (member == null)
            {
                return NotFound();
            }
            ViewBag.memberFullName = member.FullName;
            return View(member);
        }

        // POST: JRMember/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            
            try
            {
                var member = await _context.Member.FindAsync(id);

                try
                {
                    _context.Member.Remove(member);
                    await _context.SaveChangesAsync();
                    TempData["message"] = $"Successfully deleted member {member.FullName}";
                }
                catch (Exception)
                {
                    throw new Exception("Unable to delete member, references likely exist in another table.");
                }
            }
            catch (Exception e)
            {

                if (e.InnerException != null)
                {
                    TempData["message"] = e.InnerException.Message;
                }
                else
                    TempData["message"] = e.Message;
                return RedirectToAction(nameof(Delete));
            }
            
            return RedirectToAction(nameof(Delete), id);

            //var member = await _context.Member.FindAsync(id);

            //try
            //{
            //    _context.Member.Remove(member);
            //    await _context.SaveChangesAsync();
            //}
            //catch (Exception)
            //{
            //    TempData["message"] = "Unable to delete member, references likely exist in another table.";
            //    return RedirectToAction(nameof(Index));
            //}

            //return RedirectToAction(nameof(Index));
        }

        private bool MemberExists(int id)
        {
            return _context.Member.Any(e => e.MemberId == id);
        }
    }
}
