using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PizzaMizza.Core.Models.ESize;

namespace PizzaMizza.Core.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Ingredients { get; set; }

        public  PizzaSize PizzaSize{ get; set; }
    }
}
