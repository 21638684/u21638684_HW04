using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWASS4.Models
{
    // Base class
    public class Involvement
    {
   
        public string Header { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public InfoButton MoreInfo { get; set; }
    }
}
