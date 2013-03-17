using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuckahoeLodge.Models;

namespace TuckahoeLodge.ViewModels
{
    public class LodgerBioViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime MoveInDate { get; set; }
        public DateTime? MoveOutDate { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string CollegeAttended { get; set; }
        public Beerchug BestABC { get; set; }
    }
}
