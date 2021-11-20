using intergalactic_airways_api.Models;
using intergalactic_airways_api.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace intergalactic_airways_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StarshipController : Controller
    {

        // GET: StarshipController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        [HttpGet("{passengerCount}")]
        public async Task<IActionResult> Get(int passengerCount)
        {
            var starships = await StarshipServices.GetStarships(passengerCount);

            return Ok(starships);

        }

     

        //// GET: StarshipController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: StarshipController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: StarshipController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: StarshipController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: StarshipController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: StarshipController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
