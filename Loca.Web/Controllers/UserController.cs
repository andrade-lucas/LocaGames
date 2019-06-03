using System;
using System.Threading.Tasks;
using Loca.Domain.Entities;
using Loca.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Loca.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _repository;

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                await _repository.Create(user);
            }
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Edit(string id)
        {
            if (ModelState.IsValid)
            {
                var user = await _repository.GetByID(Guid.Parse(id));
                return View(user);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(User user)
        {
            if (ModelState.IsValid)
            {
                await _repository.Edit(user);
                return RedirectToAction("Index", "Home");
            }

            return View(user);
        }

        public async Task<IActionResult> Delete(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                await _repository.Delete(Guid.Parse(id));
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index", "User");
        }
    }
}