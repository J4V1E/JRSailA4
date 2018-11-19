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

namespace JRSail.Controllers
{
    public class JRAnnualFeeStructureController : Controller
    {
        private readonly SailContext _context;

        public JRAnnualFeeStructureController(SailContext context)
        {
            _context = context;
        }

        // GET: JRAnnualFeeStructure
        public async Task<IActionResult> Index()
        {
            TempData["message"] = TempData.Peek("message");
            return View(await _context.AnnualFeeStructure.OrderByDescending(t => t.Year).ToListAsync());
        }

        // GET: JRAnnualFeeStructure/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var annualFeeStructure = await _context.AnnualFeeStructure
                .FirstOrDefaultAsync(m => m.Year == id);
            if (annualFeeStructure == null)
            {
                return NotFound();
            }

            return View(annualFeeStructure);
        }

        // GET: JRAnnualFeeStructure/Create
        public IActionResult Create()
        {
            AnnualFeeStructure mt = _context.AnnualFeeStructure.LastOrDefault();
            return View(mt);
        }

        // POST: JRAnnualFeeStructure/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Year,AnnualFee,EarlyDiscountedFee,EarlyDiscountEndDate,RenewDeadlineDate,TaskExemptionFee,SecondBoatFee,ThirdBoatFee,ForthAndSubsequentBoatFee,NonSailFee,NewMember25DiscountDate,NewMember50DiscountDate,NewMember75DiscountDate")] AnnualFeeStructure annualFeeStructure)
        {
            if (ModelState.IsValid)
            {
                var annualFees = _context.AnnualFeeStructure.Where(x => x.Year == annualFeeStructure.Year).FirstOrDefault();
                //Database does not auto increment, cannot allow creation for existing year
                if (annualFees != null)
                {
                    TempData["message"] = $"Annual Fee Structure already exists for {annualFeeStructure.Year.ToString()}";
                    return RedirectToAction(nameof(Index));
                }

                _context.Add(annualFeeStructure);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(annualFeeStructure);
        }

        // GET: JRAnnualFeeStructure/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var annualFeeStructure = await _context.AnnualFeeStructure.FindAsync(id);
            //Restricts user from editing info from a previous year
            if (annualFeeStructure.Year < DateTime.Now.Year)
            {
                TempData["message"] = "Cannot edit a previous year's information.";
                return View(nameof(Index), await _context.AnnualFeeStructure.OrderBy(t => t.Year).ToListAsync());
            }
            if (annualFeeStructure == null)
            {
                return NotFound();
            }
            return View(annualFeeStructure);
        }

        // POST: JRAnnualFeeStructure/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Year,AnnualFee,EarlyDiscountedFee,EarlyDiscountEndDate,RenewDeadlineDate,TaskExemptionFee,SecondBoatFee,ThirdBoatFee,ForthAndSubsequentBoatFee,NonSailFee,NewMember25DiscountDate,NewMember50DiscountDate,NewMember75DiscountDate")] AnnualFeeStructure annualFeeStructure)
        {
            if (id != annualFeeStructure.Year)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(annualFeeStructure);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnnualFeeStructureExists(annualFeeStructure.Year))
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
            return View(annualFeeStructure);
        }

        // GET: JRAnnualFeeStructure/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var annualFeeStructure = await _context.AnnualFeeStructure
                .FirstOrDefaultAsync(m => m.Year == id);
            if (annualFeeStructure == null)
            {
                return NotFound();
            }

            return View(annualFeeStructure);
        }

        // POST: JRAnnualFeeStructure/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var annualFeeStructure = await _context.AnnualFeeStructure.FindAsync(id);
            _context.AnnualFeeStructure.Remove(annualFeeStructure);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnnualFeeStructureExists(int id)
        {
            return _context.AnnualFeeStructure.Any(e => e.Year == id);
        }
    }
}
