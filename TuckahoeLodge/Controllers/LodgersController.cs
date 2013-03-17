using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TuckahoeLodge.ViewModels;

namespace TuckahoeLodge.Controllers
{
    public class LodgersController : Controller
    {



        public ActionResult Current()
        {
            var viewModel = new LodgersViewModel();

            #region Create Lodgers
            
            viewModel.Lodgers.Add(new LodgerBioViewModel
            {
                Id = 1,
                FirstName = "Matt",
                LastName = "Flinn",
                Description = "Blah, Blah, Blah",
                MoveInDate = DateTime.Now,
                CollegeAttended = "Virginia Tech",
                ImageUrl = "",
                MoveOutDate = null
            });

            viewModel.Lodgers.Add(new LodgerBioViewModel
            {
                Id = 1,
                FirstName = "Daniel",
                LastName = "Turko",
                Description = "Blah, Blah, Blah",
                MoveInDate = DateTime.Now,
                CollegeAttended = "Virginia Tech",
                ImageUrl = "",
                MoveOutDate = null
            });

            viewModel.Lodgers.Add(new LodgerBioViewModel
            {
                Id = 1,
                FirstName = "Nick",
                LastName = "Orozco",
                Description = "Blah, Blah, Blah",
                MoveInDate = DateTime.Now,
                CollegeAttended = "William & Mary",
                ImageUrl = "",
                MoveOutDate = null
            });

            #endregion

            return View(viewModel);
        }

        public ActionResult HallOfHonor()
        {
            return View();
        }

    }
}
