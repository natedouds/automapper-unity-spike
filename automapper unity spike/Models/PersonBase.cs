using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace automapper_unity_spike.Models
{
    public class PersonBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Superhero : PersonBase
    {
        public string SuperPower { get; set; }
    }
}