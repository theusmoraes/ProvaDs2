using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Prova.Models;
using Prova.Models.ViewModels;

namespace Prova.Controllers
{
    public class PlacarsController : Controller
    {
        private readonly ProvaContext _context;

        public PlacarsController(ProvaContext context)
        {
            _context = context;
        }

        // GET: Placars
        public async Task<IActionResult> Index()
        {
            List<Placar> placares = await _context.Placar.ToListAsync();
            foreach (var item in placares) {
                item.Jogador = await _context.Jogador.FindAsync(item.IdJogador);
            }
            return View(placares);
        }

        // GET: Placars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var placar = await _context.Placar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (placar == null)
            {
                return NotFound();
            }

            return View(placar);
        }

        // GET: Placars/Create
        public IActionResult Create()
        {
            List<Jogador> jogadores = new List<Jogador>();
            ViewBag.jogadores = _context.Jogador.ToList();
            return View();
        }
         public async Task<IActionResult> Ranking() {
            List<Placar> placares = await _context.Placar.OrderByDescending(x => x.Pontos).ToListAsync();
            List<Placar> top10 = new List<Placar>();
            if (placares.Count() >= 10) {
                for (int i = 0; i < 10; i++) {
                    placares[i].Jogador =  await _context.Jogador.FindAsync(placares[i].IdJogador);
                    top10.Add(placares[i]);
                }
            } else {
                for (int i = 0; i < placares.Count(); i++) {
                    placares[i].Jogador = await _context.Jogador.FindAsync(placares[i].IdJogador);
                    top10.Add(placares[i]);
                }
            }
            return View(top10);
        }

        // POST: Placars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdJogador,Pontos,DataPonto")] Placar placar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(placar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(placar);
        }

        // GET: Placars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var placar = await _context.Placar.FindAsync(id);
            if (placar == null)
            {
                return NotFound();
            }
            ViewBag.jogadores = _context.Jogador.ToList();
            return View(placar);
        }

        // POST: Placars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdJogador,Pontos,DataPonto")] Placar placar)
        {
            if (id != placar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(placar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlacarExists(placar.Id))
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
            return View(placar);
        }

        // GET: Placars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var placar = await _context.Placar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (placar == null)
            {
                return NotFound();
            }

            return View(placar);
        }

        // POST: Placars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var placar = await _context.Placar.FindAsync(id);
            _context.Placar.Remove(placar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlacarExists(int id)
        {
            return _context.Placar.Any(e => e.Id == id);
        }
    }
}
