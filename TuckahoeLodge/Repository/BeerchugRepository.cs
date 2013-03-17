using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TuckahoeLodge.Models;

namespace TuckahoeLodge.Repository
{
    public static class BeerchugRepository
    {
        public static List<Beerchug> Beerchugs;

        static BeerchugRepository()
        {
            Beerchugs = new List<Beerchug>();

            Beerchugs.Add(new Beerchug() { Id = 1, DrinkerId = 1, DrinkerName = "Nick Orozco", ApprovingLodger = "Flinn", DrinkerSchool = "William and Mary", DrinkerGraduationYear = "2011", TimeTaken = new TimeSpan(0, 0, 0, 4, 0) });
            Beerchugs.Add(new Beerchug() { Id = 2, DrinkerId = 2, DrinkerName = "Matt Flinn", ApprovingLodger = "Ole Greg", DrinkerSchool = "Virginia Tech", DrinkerGraduationYear = "2011", TimeTaken = new TimeSpan(0, 0, 0, 3, 2) });
        }

        public static Beerchug GetBestBeerchugTime(int DrinkerId)
        {
            return Beerchugs.Where(b => b.DrinkerId == DrinkerId).OrderBy(b => b.TimeTaken).FirstOrDefault();
        }

        public static List<Beerchug> GetAllBeerchugs()
        {
            return Beerchugs;
        }

        public static void AddBeerChug(Beerchug beerchug)
        {
            Beerchugs.Add(beerchug);
        }

        internal static object GetBeerchugById(int id)
        {
            return Beerchugs.Where(b => b.Id == id);
        }
    }
}