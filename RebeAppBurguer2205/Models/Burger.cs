using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebeAppBurguer2205.Models
{
    public class Burger
    {
        public int burgerId { get; set; }
        public string? name { get; set; }
        public bool withCheese { get; set; }
        public int precio { get; set; }
        public List<object> promos { get; set; }
    }
    }
