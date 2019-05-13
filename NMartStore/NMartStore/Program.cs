using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMartStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to  NMart store");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("Enter the name of item :");
            string NameOfItem = Console.ReadLine();
            Console.WriteLine("Enter the quantity of item :");
            int QuantityOfItem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rate per producct item : ");
            double RatePerProductOfItem = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("_________________________________________________");

            Console.WriteLine("Billing details for {0} ", NameOfItem);
            Console.WriteLine("_________________________________________________");
            Category objItem = null; ;
            switch (NameOfItem.ToUpper())
            {
                case "RICE":
                case "WHEAT":
                    objItem = new FoodGrains();
                    break;

                case "TABLES":
                case "SOFAS":
                case "CHAIRS":
                    objItem = new Furniture();
                    break;

                case "MOBILES":
                case "TVS":
                case "TABLETS":

                    objItem = new Electronics();
                    break;

                case "BEAUTY PRODUCTS":
                case "CREAMS":
                case "PERFUMES":
                    objItem = new Cosmetics();
                    break;
            }

            if (objItem == null)
                Console.WriteLine("Item category not present.");
            else
            {
                objItem.Name = NameOfItem;
                objItem.PricePerUnit = RatePerProductOfItem;
                objItem.Quantity = QuantityOfItem;
                //objItem.FinalRate = (objItem.PricePerUnit * objItem.Quantity) + ((objItem.PricePerUnit * objItem.Quantity) * (objItem.GSTPercentage / 100));

                Console.WriteLine("Quantity : " + objItem.Quantity);
                Console.WriteLine("Price per unit : " + objItem.PricePerUnit);
                Console.WriteLine("Final Rate : " + objItem.FinalRate);
            }

            Console.WriteLine("_________________________________________________");
            Console.ReadLine();
        }
    }
}
