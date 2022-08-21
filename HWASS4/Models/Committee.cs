using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWASS4.Models
{
    //my inheritated class 
    public class Committee:Team
    {
        private int _AvailabilityWeekly;
        public Committee(string name, int weeklydays, string position, string email) : base(name,position,email)
        {
            _AvailabilityWeekly = weeklydays;
        }

        public int AvailabilityWeekly
        {
            get { return _AvailabilityWeekly; }
            set { _AvailabilityWeekly = value; }
        }
    }
}
