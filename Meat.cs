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

        public Category MeatCategory { get; }
        public ProductType Type { get; }

        public Meat() : this(null, default, default, default, default, default) { }
        public Meat(string name, double price, double weight,DateTime date, Category category, ProductType productType) : base(name, price, weight, date)
        {
           
            MeatCategory = category;
            Type = productType;
        }

        public override void IsOverdue(DateTime timeToOverdue,ref double percent)
        {
            if (DateTime.Today > timeToOverdue)
            {
                percent -= 30;
            }
            
        }
        public override double ChangePrice( double percent)
        {
            if (percent < 0)
                throw new ArgumentException();
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
            IsOverdue(Date, ref percent);
            Price = Price + (Price * (percent / 100.0));
            return Price;

        }
        public override string ToString()
        {
            return base.ToString() + string.Format("\nMeat category: {0}\nType of meet: {1}", MeatCategory, Type);
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Meat m)) return false;
            else
            {
                return base.Equals((Meat)obj) && MeatCategory == m.MeatCategory && Type == m.Type;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode() + Tuple.Create(MeatCategory,Type).GetHashCode();
        }

    }
}
