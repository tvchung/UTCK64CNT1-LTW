using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TvcDay09LabCF.Models;

namespace TvcDay09LabCF.Controllers
{
    public class TvcLoai_San_PhamController : Controller
    {
        private readonly TvcDay09LabCFContext _context;

        public TvcLoai_San_PhamController(TvcDay09LabCFContext context)
        {
            _context = context;
        }

        // GET: TvcLoai_San_Pham
        public async Task<IActionResult> tvcIndex()
        {
            return View(await _context.tvcLoai_San_Phams.ToListAsync());
        }

        // GET: TvcLoai_San_Pham/Details/5
        public async Task<IActionResult> tvcDetails(long? tvcId)
        {
            if (tvcId == null)
            {
                return NotFound();
            }

            var tvcLoai_San_Pham = await _context.tvcLoai_San_Phams
                .FirstOrDefaultAsync(m => m.tvcId == tvcId);
            if (tvcLoai_San_Pham == null)
            {
                return NotFound();
            }

            return View(tvcLoai_San_Pham);
        }

        // GET: TvcLoai_San_Pham/Create
        public IActionResult tvcCreate()
        {
            return View();
        }

        // POST: TvcLoai_San_Pham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> tvcCreate([Bind("tvcId,tvcMaLoai,tvcTenLoai,tvcTrangThai")] TvcLoai_San_Pham tvcLoai_San_Pham)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tvcLoai_San_Pham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(tvcIndex));
            }
            return View(tvcLoai_San_Pham);
        }

        // GET: TvcLoai_San_Pham/Edit/5
        public async Task<IActionResult> tvcEdit(long? tvcId)
        {
            if (tvcId == null)
            {
                return NotFound();
            }

            var tvcLoai_San_Pham = await _context.tvcLoai_San_Phams.FindAsync(tvcId);
            if (tvcLoai_San_Pham == null)
            {
                return NotFound();
            }
            return View(tvcLoai_San_Pham);
        }

        // POST: TvcLoai_San_Pham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> tvcEdit(long tvcId, [Bind("tvcId,tvcMaLoai,tvcTenLoai,tvcTrangThai")] TvcLoai_San_Pham tvcLoai_San_Pham)
        {
            if (tvcId != tvcLoai_San_Pham.tvcId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tvcLoai_San_Pham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TvcLoai_San_PhamExists(tvcLoai_San_Pham.tvcId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(tvcIndex));
            }
            return View(tvcLoai_San_Pham);
        }

        // GET: TvcLoai_San_Pham/Delete/5
        public async Task<IActionResult> tvcDelete(long? tvcId)
        {
            if (tvcId == null)
            {
                return NotFound();
            }

            var tvcLoai_San_Pham = await _context.tvcLoai_San_Phams
                .FirstOrDefaultAsync(m => m.tvcId == tvcId);
            if (tvcLoai_San_Pham == null)
            {
                return NotFound();
            }

            return View(tvcLoai_San_Pham);
        }

        // POST: TvcLoai_San_Pham/Delete/5
        [HttpPost, ActionName("tvcDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long tvcId)
        {
            var tvcLoai_San_Pham = await _context.tvcLoai_San_Phams.FindAsync(tvcId);
            if (tvcLoai_San_Pham != null)
            {
                _context.tvcLoai_San_Phams.Remove(tvcLoai_San_Pham);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(tvcIndex));
        }

        private bool TvcLoai_San_PhamExists(long tvcId)
        {
            return _context.tvcLoai_San_Phams.Any(e => e.tvcId == tvcId);
        }
    }
}
