using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using BookWeb.Models;
using BookWeb.Interface;
using BookWeb.Entities;
using BookWeb.Dtos;

namespace BookWeb.Controllers
{
    public class UserController : Controller
    {
        private IUser _userService;
        private IConfiguration _config;

        public UserController(IUser userService, IConfiguration config)
        {
            _userService = userService;
            _config = config;
        }
        // GET: /<controller>/

        [HttpPost]
        public IActionResult Create([FromBody] UserDtos UserDtos)
        {
            // map dto to entity
            // var userdto = _mapper.Map<User>(UserDtos);

            var user = new User
            {
                FirstName = UserDtos.FirstName,
                LastName = UserDtos.LastName,
                Email = UserDtos.Email,
                Username = UserDtos.Username,
                PhoneNo = UserDtos.PhoneNo
            };
            try
            {
                // save 
                var userCreated = _userService.Create(user, UserDtos.Password);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                // return error message if there was an exception
                return View();
            }
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await _userService.GetAll();
            if (model != null)
            {
                return View(model);
            }
            return View();
        }

        /* [HttpPost]
         public async Task<IActionResult> Create(Book b)
         {
             var createBook = await _book.AddAsync(b);

             if (createBook)
             {
                 return RedirectToAction("Index");
             }
             return View();
         }*/

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteUser = await _userService.Delete(id);
            if (deleteUser)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

