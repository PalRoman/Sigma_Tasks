using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaLess1
{
   public class Product
    {
        private string _name;
        private double _price;
        private double _weight;
        private DateTime _date;
       
        public Product():this(null, default, default, default)
        { }
        
        public Product(string name, double price, double weight,DateTime date)
        {
   
            Name = name;
            Price = price;
            Weight = weight;
            Date = date;
        }
        

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Price
        {
            get { return _price; }
            set {
                if (_price < 0 )
                    throw new ArgumentException();
                _price = value;
            }
        }
        public double Weight
        {
            get { return _weight; }
            set 
            {
                if (_weight < 0) throw new ArgumentException();
                _weight = value; 
            }
        }
        

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public virtual void IsOverdue(DateTime timeToOverdue, ref double percent)
        {
            if (DateTime.Now > timeToOverdue)  
                percent -= 10;
            


        }

        public virtual double ChangePrice( double percent)
        {
                IsOverdue(Date, ref percent);
                Price = Price + (Price * (percent / 100.0));
                return Price;
            
        }
       

        public override string ToString()
        {
            return string.Format("Name: {0}\nPrice: {1} UAH\nWeight: {2} kg\nDate: {3}", Name, Weight, Price, Date);
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) return false;

            else 
            {
                Product p = (Product)obj;
                return (_name == p._name) && (_price == p._price) && (_weight == p._weight) && (_date == p._date);
            }

        }
        public override int GetHashCode()
        {
            return Tuple.Create(_name, _price, _weight, _date).GetHashCode();

        }

        public void Parse(string str)
        {
            if (str == null)
            {
                throw new ArgumentException();
            }
            string[] arrayString = str.Split(' ');
            Name = arrayString[0];
            Price = Convert.ToDouble(arrayString[1]);

            if(!double.TryParse(arrayString[2], out _weight))
            {
                throw new ArgumentException();
            }
        }

        
    }
}





