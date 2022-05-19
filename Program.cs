using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaLess1
{
    class Program
    {
       

        static void Main(string[] args)
        {
            try
            {
                Meat m = new Meat(Meat.ProductType.Mutton.ToString(), 33, 3.5,DateTime.Parse("17.05.2022"), Meat.Category.TopGrade, Meat.ProductType.Mutton);
                Console.WriteLine(DateTime.Parse("19.05.2022"));
                Console.WriteLine("Name of a product: {0}\nPrice: {1}\nWeight: {2}", m.Name, m.Price, m.Weight);
                Console.WriteLine("Changing price...");

                Console.WriteLine("Price after changing: {0}", m.ChangePrice(20));
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                throw new ArgumentException();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }


    }
}