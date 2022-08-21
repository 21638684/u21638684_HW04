using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWASS4.Models
{
    public class BeInvolved
    {
        // list of class details that needs to be displayed on getinvolved view
        public static List<Involvement> GetInvolvement()
        {
            List<Involvement> Inv = new List<Involvement>();
            Inv.Add(
            new Involvement
            {
                Image = "~/Pictures/Cash.jpg", 
                Header = "Donate Cash",
                Description = "Monetary gifts are the most useful, as they can immediately be channeled into the area of greatest need. Even small amounts are greatly appreciated",
                MoreInfo= new InfoButton { Action="xxxx"}
            });
            Inv.Add(
           new Involvement
           {
               Image="~/Pictures/Gift.jpg",
               Header = "Donate Gifts",
               Description = "Gifts of non-perishable food, clothing, blankets, cleaning materials and toiletries are greatly appreciated.",
               MoreInfo = new InfoButton {Action="xxxx"}
           });
            Inv.Add(
           new Involvement
           {
               Image ="~/Pictures/Volunteer.jpg",
               Header = "Volunteer",
               Description = "Anyone with certain skills and ready to dedicate their time can volunteer to be part of the program and equipped others with the skills ",
               MoreInfo = new InfoButton { Action = "xxxxx" }
           });
            Inv.Add(
           new Involvement
           {
               Image ="~/Pictures/Will.jpg",
               Header = "Leave a Bequest",
               Description = "When you make your Will, you have a unique opportunity to help others in a way you perhaps can't manage right now.You can leave your money or property to those in need ",
               MoreInfo = new InfoButton { Action = "xxxxx" }
           });

            return Inv;


        }
    }
}

    