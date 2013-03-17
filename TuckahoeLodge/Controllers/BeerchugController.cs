using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TuckahoeLodge.Models;
using TuckahoeLodge.Repository;

namespace TuckahoeLodge.Controllers
{
    public class BeerchugController : Controller
    {
        public BeerchugController()
        {
            //beerchugRepository = new BeerchugRepository();
        }

        public ActionResult Wall()
        {
            var beerchugs = BeerchugRepository.GetAllBeerchugs();
            return View(beerchugs);        
        }

        [HttpGet]
        public ActionResult CreateBeerchug()
        {
            return View(new Beerchug());
        }

        [HttpPost]
        public ActionResult CreateBeerchug(Beerchug model)
        {
            BeerchugRepository.AddBeerChug(model);
            return RedirectToAction("AllBeerchugs");
        }

        [HttpGet]
        public ActionResult EditBeerchug(int id)
        {
            var beerchug = BeerchugRepository.GetBeerchugById(id);
            return View("Create", beerchug);
        }


        public ActionResult Guidelines()
        {
            return View();
        }
    }
}
