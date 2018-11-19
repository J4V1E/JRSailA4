/*Program ID: JRSail Web MVC
 * 
 *Purpose: Controls for Boat Type data
 * 
 * Revision History
 *  September 13 2018 - Joel Repta
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
    public class JRBoatTypeController : Controller
    {
        private readonly SailContext _context;

        //Creates an instance of the database context to use within the controller
        public JRBoatTypeController(SailContext context)
        {
            _context = context;
        }

        // GET: JRBoatType
        //Generates Boat Type Index page from asynchronous database call
        public async Task<IActionResult> Index()
        {
            return View(await _context.BoatType.ToListAsync());
        }

        // GET: JRBoatType/Details/5
        //Attempts to find Boat Type details asynchronously from database and return info to details page
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boatType = await _context.BoatType
                .FirstOrDefaultAsync(m => m.BoatTypeId == id);
            if (boatType == null)
            {
                return NotFound();
            }

            return View(boatType);
        }

        // GET: JRBoatType/Create
        //Redirects to Create Boat Type page
        public IActionResult Create()
        {
            return View();
        }

        // POST: JRBoatType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //Posts new boat type info to database, asynchronously saves changes and navigates to Boat Type Index
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BoatTypeId,Name,Description,Chargeable,Sail,Image")] BoatType boatType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(boatType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(boatType);
        }

        // GET: JRBoatType/Edit/5
        //Attempts to find boat type from id, returns Edit view with database information
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boatType = await _context.BoatType.FindAsync(id);
            if (boatType == null)
            {
                return NotFound();
            }
            return View(boatType);
        }

        // POST: JRBoatType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //Updates a boat type information, asychronously saving changes and returns to boat type index page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BoatTypeId,Name,Description,Chargeable,Sail,Image")] BoatType boatType)
        {
            if (id != boatType.BoatTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(boatType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoatTypeExists(boatType.BoatTypeId))
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
            return View(boatType);
        }

        // GET: JRBoatType/Delete/5
        //Gets Boat Type information from database and directs to Delete page for confirmation
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boatType = await _context.BoatType
                .FirstOrDefaultAsync(m => m.BoatTypeId == id);
            if (boatType == null)
            {
                return NotFound();
            }

            return View(boatType);
        }

        // POST: JRBoatType/Delete/5
        //Delete action that removes Boat Type from database from id, redirects to Boat Type Index page
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var boatType = await _context.BoatType.FindAsync(id);
            _context.BoatType.Remove(boatType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //Verifies if database contains a boat type with given id
        private bool BoatTypeExists(int id)
        {
            return _context.BoatType.Any(e => e.BoatTypeId == id);
        }
    }
}
