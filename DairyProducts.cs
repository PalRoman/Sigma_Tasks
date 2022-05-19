using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaLess1
{
    internal class DairyProducts : Product
    {
        
        public DairyProducts():this(null, default, default,default)
        {

        }
        public DairyProducts(string name, double price, double weight, DateTime date) : base(name, price, weight, date) { }
        

        public override void IsOverdue(DateTime timeToOverdue,ref double percent)
        {
            
            if( DateTime.Now > timeToOverdue)
            {
                percent -= 20;
            }
            
        }
        public override double ChangePrice( double percent)
        {
            IsOverdue(Date,ref percent);
            Price = Price + (Price * (percent / 100.0));
            return Price;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is DairyProducts)) return false;
             return base.Equals((DairyProducts)obj);
            
        }dfg
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
