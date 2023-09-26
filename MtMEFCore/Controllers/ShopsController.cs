using Microsoft.AspNetCore.Mvc;
using MtMEFCore.Data.Services;
using MtMEFCore.Models;

namespace MtMEFCore.Controllers
{
    public class ShopsController : Controller
    {
        private readonly IShopService _shopService;

        public ShopsController(IShopService shopServic)
        {
            _shopService = shopServic;
        }

        public async Task<IActionResult> Index()
        {
            var Data = await _shopService.GetAll();
            return View(Data);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name","address")] Shop shop)
        {
            if (!ModelState.IsValid)
            {

                return View(shop);
            }

            _shopService.Add(shop);
            return RedirectToAction(nameof(Index));



        }



    }
}
