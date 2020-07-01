using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookWeb.Models;
using BookWeb.Interface;
using BookWeb.Entities;

namespace BookWeb.Controllers
{
    public class CharacteristicsController : Controller
    {
        private ICharacteristics _characteristics;
        public CharacteristicsController(ICharacteristics characteristics)
        {
            _characteristics = characteristics;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _characteristics.GetAll();
            if (model != null)
                return View(model);
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Characteristics characteristics)
        {
            var createCharacteristics = await _characteristics.AddAsync(characteristics);

            if (createCharacteristics)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editCharacteristics = await _characteristics.GetById(id);

            if (editCharacteristics == null)
            {
                return RedirectToAction("Index");
            }
            return View(editCharacteristics);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Characteristics characteristics)
        {

            var editCharacteristics = await _characteristics.Update(characteristics);

            if (editCharacteristics && ModelState.IsValid)
            {
                return RedirectToAction("Index");

            }
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var deleteCharacteristics = await _characteristics.Delete(id);
            if (deleteCharacteristics)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
