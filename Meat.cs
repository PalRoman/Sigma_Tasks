using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaLess1
{
    internal class Meat : Product
    {

        public enum Category
        {
            TopGrade,
            FirstGrade,
            SecondGrade
        }
        public enum ProductType
        {
            Mutton,
            Veal,
            Pork,
            Chicken
        }

        public DateTime Date { get; }
        public Category MeatCategory { get; }
        public ProductType Type { get; }

        public Meat() : this(null, default, default, default, default, default) { }
        public Meat(string name, double price, double weight,DateTime date, Category category, ProductType productType) : base(name, price, weight)
        {
            Date = date;
            MeatCategory = category;
            Type = productType;
        }

        public override double IsOverdue(DateTime timeToOverdue, double percent)
        {
            if (DateTime.Now > timeToOverdue)
            {
                percent -= 30;
            }
            return percent;
        }
        public override double ChangePrice( double percent)
        {
            IsOverdue(Date,percent);
            if (percent < 0)
                throw new ArgumentException("Percent must be equal or greater than '0'");

            switch (MeatCategory)
            {
                case Category.TopGrade:
                    percent += 15;
                    break;
                case Category.FirstGrade:
                    percent += 10;
                    break;
                case Category.SecondGrade:
                    percent += 5;
                    break;
            }

            Price = Price + (Price * (percent / 100.0));
            return Price;

        }
        public override string ToString()
        {
            return null;
        }

    }
}
