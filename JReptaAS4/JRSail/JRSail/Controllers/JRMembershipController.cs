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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JRSail.Models;

namespace JRSail.Controllers
{
    public class JRMembershipController : Controller
    {
        private readonly SailContext _context;

        public JRMembershipController(SailContext context)
        {
            _context = context;
        }

        // GET: JRMembership
        //Only opens page if redirected from Members Index page with MemberId
        //Use session variables to store MemberId and Fullname for use on Views
        public async Task<IActionResult> Index(int? memberId, string fullName = "")
        {
            //Allows tempdata to persist from other actions in same controller
            TempData["message"] = TempData.Peek("message");

            //If statement either sets session variable for memberId or redirects with error
            if (memberId != null)
            {
                HttpContext.Session.SetInt32("MemberId", (int)memberId);
            }
            else if (HttpContext.Session.GetInt32("MemberId") == null)
            {
                TempData["message"] = "Please select a member to see it's memberships";
                return RedirectToAction(nameof(Index), "JRMember");
            }

            //
            memberId = HttpContext.Session.GetInt32("MemberId");
            if (fullName != "")
            {
                HttpContext.Session.SetString("FullName", fullName);
                var sailContext = _context.Membership.Include(m => m.Member)
                    .Include(m => m.MembershipTypeNameNavigation)
                    .Where(x => x.MemberId == memberId)
                    .OrderByDescending(x => x.Year);
                return View(await sailContext.ToListAsync());

            }
            else
            {
                
                var sailContext = _context.Membership.Include(m => m.Member)
                    .Include(m => m.MembershipTypeNameNavigation)
                    .Where(x => x.MemberId == memberId);

                //Grab fullName from database and set it to session variable
                HttpContext.Session.SetString("FullName", _context.Member.Where(x => x.MemberId == memberId).FirstOrDefault().FullName);
                return View(await sailContext.ToListAsync());
            }
        }

        // GET: JRMembership/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membership = await _context.Membership
                .Include(m => m.Member)
                .Include(m => m.MembershipTypeNameNavigation)
                .FirstOrDefaultAsync(m => m.MembershipId == id);
            if (membership == null)
            {
                return NotFound();
            }

            return View(membership);
        }

        // GET: JRMembership/Create
        public IActionResult Create()
        {
            ViewData["MemberId"] = new SelectList(_context.Member, "MemberId", "FirstName");
            ViewData["MembershipTypeName"] = new SelectList(_context.MembershipType, "MembershipTypeName", "MembershipTypeName");
            return View();
        }

        // POST: JRMembership/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MembershipId,MemberId,Year,MembershipTypeName,Fee,Comments,Paid")] Membership membership)
        {
            if (ModelState.IsValid)
            {
                var annualFee = _context.AnnualFeeStructure.Where(x => x.Year == membership.Year).First();
                double discount = _context.MembershipType.Where(x => x.MembershipTypeName == membership.MembershipTypeName).Select(x => x.RatioToFull).First();
                int numberOfBoats = _context.Boat.Where(x => x.MemberId == membership.MemberId).Count();

                float totalFee = (float)annualFee.AnnualFee;


                if (numberOfBoats > 1)
                {
                    switch (numberOfBoats)
                    {
                        case 2:
                            totalFee += (float)annualFee.SecondBoatFee;
                            break;
                        case 3:
                            totalFee += (float)annualFee.SecondBoatFee + (float)annualFee.ThirdBoatFee;
                            break;
                        default:
                            totalFee += (float)annualFee.SecondBoatFee + (float)annualFee.ThirdBoatFee + (float)annualFee.ForthAndSubsequentBoatFee*(numberOfBoats - 3);
                            break;
                    } 
                }

                membership.Fee = (float)(totalFee * discount);

                _context.Add(membership);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MembershipTypeName"] = new SelectList(_context.MembershipType.OrderBy(x => x.MembershipTypeName), "MembershipTypeName", "MembershipTypeName", membership.MembershipTypeName);
            return View(membership);
        }

        // GET: JRMembership/Edit/5
        //Redirects if membership is prior to the current year
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membership = await _context.Membership.FindAsync(id);
            if (membership == null)
            {
                return NotFound();
            }

            if (membership.Year < DateTime.Now.Year)
            {
                TempData["message"] = "Cannot edit membership records from prior years";
                return RedirectToAction(nameof(Index));
            }
            ViewData["MembershipTypeName"] = new SelectList(_context.MembershipType.OrderBy(X => X.MembershipTypeName), "MembershipTypeName", "MembershipTypeName", membership.MembershipTypeName);
            return View(membership);
        }

        // POST: JRMembership/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MembershipId,MemberId,Year,MembershipTypeName,Fee,Comments,Paid")] Membership membership)
        {
            if (id != membership.MembershipId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(membership);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MembershipExists(membership.MembershipId))
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
            ViewData["MemberId"] = new SelectList(_context.Member, "MemberId", "FirstName", membership.MemberId);
            ViewData["MembershipTypeName"] = new SelectList(_context.MembershipType, "MembershipTypeName", "MembershipTypeName", membership.MembershipTypeName);
            return View(membership);
        }

        // GET: JRMembership/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membership = await _context.Membership
                .Include(m => m.Member)
                .Include(m => m.MembershipTypeNameNavigation)
                .FirstOrDefaultAsync(m => m.MembershipId == id);
            if (membership == null)
            {
                return NotFound();
            }
            
            return View(membership);
        }

        // POST: JRMembership/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var membership = await _context.Membership.FindAsync(id);


            try
            {
                _context.Membership.Remove(membership);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                TempData["message"] = "Unable to delete membership, references exist in other tables.";
                return RedirectToAction(nameof(Index));
            }


            return RedirectToAction(nameof(Index));
        }

        private bool MembershipExists(int id)
        {
            return _context.Membership.Any(e => e.MembershipId == id);
        }
    }
}
