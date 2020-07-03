using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Prueba.Data;
using Prueba.Models;

namespace Prueba.Controllers
{
    public class InvenariosController : Controller
    {
        private readonly MvcInventarioContext _context;

        public InvenariosController(MvcInventarioContext context)
        {
            _context = context;
        }

        // GET: Invenarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Inventario.ToListAsync());
        }

        // GET: Invenarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invenario = await _context.Inventario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invenario == null)
            {
                return NotFound();
            }

            return View(invenario);
        }

        // GET: Invenarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Invenarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Id_Producto,Existencia")] Invenario invenario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(invenario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(invenario);
        }

        // GET: Invenarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invenario = await _context.Inventario.FindAsync(id);
            if (invenario == null)
            {
                return NotFound();
            }
            return View(invenario);
        }

        // POST: Invenarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Id_Producto,Existencia")] Invenario invenario)
        {
            if (id != invenario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(invenario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvenarioExists(invenario.Id))
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
            return View(invenario);
        }

        // GET: Invenarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invenario = await _context.Inventario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invenario == null)
            {
                return NotFound();
            }

            return View(invenario);
        }

        // POST: Invenarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var invenario = await _context.Inventario.FindAsync(id);
            _context.Inventario.Remove(invenario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvenarioExists(int id)
        {
            return _context.Inventario.Any(e => e.Id == id);
        }
    }
}
