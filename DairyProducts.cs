using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaLess1
{
    internal class DairyProducts : Product
    {
        public DateTime ExpirationDate { get; }
        public DairyProducts():this(null, default, default,default)
        {

        }
        public DairyProducts(string name, double price, double weight, DateTime expirationDate):base(name, price,weight)
        {
            ExpirationDate = expirationDate;
        }
        public override double IsOverdue(DateTime timeToOverdue, double percent)
        {
            if( DateTime.Now > timeToOverdue)
            {
                percent -= 20;
            }
            return percent;
        }
        public override double ChangePrice( double percent)
        {
            IsOverdue(ExpirationDate, percent);
            Price = Price + (Price * (percent / 100.0));
            return Price;
        }
        public override string ToString()
        {
            return ExpirationDate.ToString();
        }
    }
}
