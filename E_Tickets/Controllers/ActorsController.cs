using E_Tickets.Data;
using E_Tickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tickets.Controllers
{
    public class ActorsController : Controller
    {
       //remove AppDbContext from here and inject it in ActorService
       //and inject IActorsService
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data =await _service.GetAll();
            return View(data);
        }
    }
}
