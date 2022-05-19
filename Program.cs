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
                Meat m = new Meat(Meat.ProductType.Mutton.ToString(), 33, 3.5, DateTime.Parse("20.05.2022"), Meat.Category.TopGrade, Meat.ProductType.Mutton);

                DairyProducts d = new DairyProducts("milk", 33, 2, new DateTime(2022, 5, 18));

                //Console.WriteLine(m.ToString());
                Console.WriteLine(d);
                //Console.WriteLine("Changing price...");

                //Console.WriteLine("Price after changing: {0}", m.ChangePrice(20));
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("Percent must be equal or greater than '0'");
            }
            //catch (Exception)
            //{
            //    throw new Exception();
            //}
        }


    }
}