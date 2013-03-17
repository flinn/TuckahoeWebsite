using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;


namespace TuckahoeLodge.Models
{
    public class Beerchug
    {
        public int Id { get; set; }

        [DisplayName("Drinker's Name")]
        public string DrinkerName { get; set; }

        [DisplayName("Drinker's School")]
        public string DrinkerSchool { get; set; }

        [DisplayName("Drinker's Graduation Year")]
        public string DrinkerGraduationYear { get; set; }

        [DisplayName("Approving Lodger")]
        public string ApprovingLodger { get; set; }

        [DisplayName("Comments")]
        public string Comment { get; set; }

        [DisplayName("ABC Time")]
        public string Time { get { return FormatTimeSpan(TimeTaken); } }

        public TimeSpan TimeTaken { get; set; }

        #region Private Helper Methods
        
        private string FormatTimeSpan(TimeSpan time)
        {
            return string.Format("{0}{1}", FormatSeconds(), FormatMilliseconds());
        }

        private string FormatMilliseconds()
        {
            return TimeTaken.Milliseconds > 0 ? String.Concat(", ", TimeTaken.Milliseconds.ToString(), " ms") : "";
        }

        private string FormatSeconds()
        {
            return TimeTaken.Seconds > 0 ? String.Concat(TimeTaken.Seconds.ToString(), " seconds") : "";
        }

        #endregion

        public int DrinkerId { get; set; }
    }    
}