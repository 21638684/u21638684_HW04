using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HWASS4.Models
{  // base class
    public class Team
    {

        private string _Name;
        private string _Position;
        private string  _Email;

        public Team(string name, string position, string email)
        {
            _Name = name;
            _Position = position;
            _Email = email;

        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Position
        {
            get { return _Position; }
            set { _Position = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
    }
}

