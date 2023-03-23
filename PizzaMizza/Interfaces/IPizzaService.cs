using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaMizza.Core.Models;

namespace PizzaMizza.Interfaces
{
    public interface IPizzaService
    {
        public void Create(Pizza pizza);

        public List<Pizza> GetAll();

        public Pizza GetById(int id);   


    }
}
