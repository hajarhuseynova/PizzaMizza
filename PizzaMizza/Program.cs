
using PizzaMizza.Core.Models;
using PizzaMizza.Services;
using static PizzaMizza.Core.Models.ESize;

PizzaService pizzaService = new PizzaService();

ESize sizePizza = new ESize();

Console.WriteLine("1-Show All Pizzas");
Console.WriteLine("2-Add a Pizza");
Console.WriteLine("0-end");

string request = Console.ReadLine();



while (request != "0")
{
    switch (request)
    {
        case "1":
           var pizzas = pizzaService.GetAll();
            foreach (var Pizza in pizzas)
            {
                Console.WriteLine($@"Pizza's Id:{Pizza.Id};
Pizza's name:{Pizza.Name};
Pizza's mediumSizePrice:{Pizza.Price}
Pizza's size:{Pizza.PizzaSize}");
            }

            Console.WriteLine("If you want to know ingredients of pizza and price of each size you write ID of pizza,else write 0 ");
            int id=int.Parse(Console.ReadLine());
            if(id != 0)
            {
            Pizza selectedPizza=pizzaService.GetById(id);
                if(selectedPizza != null)
                {
                    Console.WriteLine($@"Pizza's ingredients:{selectedPizza.Ingredients};
Pizza's smallSizePrice :{selectedPizza.Price-3}$,
Pizza's mediumSizePrice :{selectedPizza.Price}$,
Pizza's bigSizePrice :{selectedPizza.Price+3}$");
                }
                else
                {
                    Console.WriteLine("Something wrong!");
                }
            }
            break;

        case "2":

            Console.WriteLine("Enter Pizza's name:");
            string PizzaName = Console.ReadLine();

            Console.WriteLine("Enter Pizza's ingredients:");
            string Ingredients = Console.ReadLine();

            Console.WriteLine("Enter Pizza's MediumSizeprice:");
            double Price = double.Parse(Console.ReadLine());

            Console.WriteLine("Select one of them (size): 14,17,20");
            string givenSize = Console.ReadLine();
            PizzaSize givensize = (PizzaSize)Convert.ToInt32(givenSize);

            Pizza pizza = new Pizza
            {
                Name = PizzaName,
                Ingredients = Ingredients,
                Price = Price,
                PizzaSize = givensize
            };

            pizzaService.Create(pizza);

            break;
        default:
            Console.WriteLine("You only write 0,1,2");
            break;
    }
    Console.WriteLine("1-Show All Pizzas");
    Console.WriteLine("2-Add a Pizza");
    Console.WriteLine("0-end");
    request = Console.ReadLine();
}

