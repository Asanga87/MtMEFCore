using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MtMEFCore.Data.Services;
using MtMEFCore.Models;

namespace MtMEFCore.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomersService _service;

        public CustomersController(ICustomersService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        public async Task<IActionResult> Create()
        {
            var moviedropdowndata =await _service.GetNewCustomerDropDownValues();
            ViewBag.Shops = new SelectList(moviedropdowndata.Shops, "ID", "Name");
            return View();

        }


        [HttpPost]
        public async Task<IActionResult> Create(NewCustomerVM customer)
        {
            if (!ModelState.IsValid)
            {
              
                return View();
            }

            await _service.Add(customer);
            return RedirectToAction(nameof(Index));
        }

    }
}
