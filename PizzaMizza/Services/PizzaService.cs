using PizzaMizza.Core.Models;
using PizzaMizza.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Services
{
    public class PizzaService : IPizzaService
    {

        public int count = 1;
        public List<Pizza> pizzas = new List<Pizza>();    


        public void Create(Pizza pizza)
        {
            pizza.Id = count++;
            pizzas.Add(pizza);
          
        }

      

        public List<Pizza> GetAll()
        {
           return pizzas;
        }


        public Pizza GetById(int id)
        {
            for (int i = 0; i < pizzas.Count; i++)
            {
                if (pizzas[i].Id == id)
                {
                    return pizzas[i];   

                }
            }

            return null;
             

        }




    }
}
