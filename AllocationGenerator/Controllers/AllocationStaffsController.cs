using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AllocationGenerator.Models;
using Microsoft.AspNetCore.Http;

namespace AllocationGenerator.Controllers
{
    public class AllocationStaffsController : Controller
    {
        private readonly Interface_ImportContext _context;

        public AllocationStaffsController(Interface_ImportContext context)
        {
            _context = context;
        }

        // GET: AllocationStaffs

        public IActionResult Index()
        {
           
        var viewModels = (from S in _context.AllocationStaff
                              join C in _context.EmployeeCeridian on S.Emplid equals C.EmplId
                              orderby C.LastName, C.EmplId
                              select new AllocationStaffGrid()
                              {
                                  Emplid = S.Emplid,
                                  HourstoAllocate = S.HourstoAllocate,
                                  EffectiveDate = S.EffectiveDate,
                                  ExpirationDate = S.ExpirationDate,
                                  FirstName = C.FirstName,
                                  LastName = C.LastName,
                                  AllocationStaffId = S.AllocationStaffId
                              }).ToList();
            
            return View(viewModels);

        }

        // GET: AllocationStaffs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var allocationStaff = await _context.AllocationStaff
                .FirstOrDefaultAsync(m => m.AllocationStaffId == id);
            if (allocationStaff == null)
            {
                return NotFound();
            }

            return View(allocationStaff);
        }

        // GET: AllocationStaffs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AllocationStaffs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Emplid,HourstoAllocate,EffectiveDate,ExpirationDate,InsertBy,InsertDate,AllocationStaffId")] AllocationStaff allocationStaff)
        {
            if (ModelState.IsValid)
            {
                _context.Add(allocationStaff);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(allocationStaff);
        }

        // GET: AllocationStaffs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {        

            if (id == null)
            {
                return NotFound();
            }

            var result = (from S in _context.AllocationStaff
                          join C in _context.EmployeeCeridian on S.Emplid equals C.EmplId
                          where S.AllocationStaffId == id select C).Single();

            var allocationStaff = await _context.AllocationStaff.FindAsync(id);

            TempData["NameEmplId"] = result.FirstName + result.LastName + " | " + result.EmplId;
            

            if (allocationStaff == null)
            {
                return NotFound();
            }

            return View(allocationStaff);
        }

        // POST: AllocationStaffs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Emplid,HourstoAllocate,EffectiveDate,ExpirationDate,LastUpdateBy,LastUpdateDate,AllocationStaffId")] AllocationStaff allocationStaff)
        {


            ViewBag.name = HttpContext.Session.GetString("name");
            ViewBag.emplid = HttpContext.Session.GetString("emplid");

            if (id != allocationStaff.AllocationStaffId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(allocationStaff);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AllocationStaffExists(allocationStaff.AllocationStaffId))
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
            return View(allocationStaff);
        }

        // GET: AllocationStaffs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var allocationStaff = await _context.AllocationStaff
                .FirstOrDefaultAsync(m => m.AllocationStaffId == id);
            if (allocationStaff == null)
            {
                return NotFound();
            }

            return View(allocationStaff);
        }

        // POST: AllocationStaffs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var allocationStaff = await _context.AllocationStaff.FindAsync(id);
            _context.AllocationStaff.Remove(allocationStaff);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AllocationStaffExists(int id)
        {
            return _context.AllocationStaff.Any(e => e.AllocationStaffId == id);
        }

        public IActionResult StaffSearch(string term)
        {
            var result = (from C in _context.EmployeeCeridian
                          join S in _context.AllocationStaff on C.EmplId equals S.Emplid
                          into staffsearch
                          from emplstaff in staffsearch.DefaultIfEmpty()
                              where emplstaff.Emplid.Contains(term) || C.LastName.Contains(term) || C.FirstName.Contains(term)
                              || C.DeptId.Contains(term)
                              orderby C.LastName
                          select new { firstname = C.FirstName, lastname = C.LastName, emplid = emplstaff.Emplid, deptid = C.DeptId, expirationdate = emplstaff.ExpirationDate, insertdate = C.InsertDate }).ToList().Distinct();

            return Json(result);



        }
    }
}
