using System;
using System.Collections.Generic;

namespace TestMidTerm_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string check = "0";
            string selectFlower;
            FlowerStore flowerStore = new FlowerStore();
            do
            {
                Console.Clear();
                Console.WriteLine("Select number for buy flower :");
                foreach (string i in flowerStore.flowerList)
                {
                    Console.Write((flowerStore.flowerList.IndexOf(i) + 1) + ".");
                    Console.WriteLine(i);
                }
                
                Console.Write("What do add flower : ");
                selectFlower = Console.ReadLine();
                switch (selectFlower)
                {
                    case "1":
                        flowerStore.addToCart(flowerStore.flowerList[0]);
                        Console.WriteLine("Added : " + flowerStore.flowerList[0]);
                        break;
                    case "2":
                        flowerStore.addToCart(flowerStore.flowerList[1]);
                        Console.WriteLine("Added : " + flowerStore.flowerList[1]);
                        break;
                    default:
                        Console.WriteLine("Not Added to cart. found select number of flower");
                        break;
                }
                if (decide() == "exit")
                {
                    Console.Write("Current my cart");
                    flowerStore.showCart();
                    check = "exit";   
                }
            }
            while (check != "exit");
        }
        static string decide()
        {
            Console.WriteLine("You can stop this progress ? exit for >> exit << progress and press  any key for continue");
            return Console.ReadLine();
        }
    }

    class FlowerStore
    {
        public List<string> flowerList = new List<string>();
        List<string> cart = new List<string>();
        int Many_Rose = 0;
        int Many_Lotus = 0;
        public FlowerStore()
        {
            flowerList.Add("Rose");
            flowerList.Add("Lotus");
        }
        public void addToCart(string name)
        {
            cart.Add(name);
        }

        public void showCart()
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is empty");
            }
            else
            {
                Console.WriteLine("My Cart :");
                foreach (string i in cart)
                {
                    if (i == "Rose")
                    {
                        Many_Rose++;
                    }
                    else if (i == "Lotus")
                    {
                        Many_Lotus++;
                    }
                    else;
                }
                Console.WriteLine("Rose = "+ Many_Rose);
                Console.WriteLine("Lotus = "+ Many_Lotus);

            }
        }
    }
}
