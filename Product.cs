using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaLess1
{
   internal class Product
    {
        private string _name;
        private double _price;
        private double _weight;
        
        public Product():this(null, default, default)
        { }
        
        public Product(string name, double price, double weight)
        {
   
            Name = name;
            Price = price;
            Weight = weight;
            
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
        public virtual double IsOverdue(DateTime timeToOverdue, double percent)
        {
            if (DateTime.Now > timeToOverdue) return percent -= 10;
            return 0;


        }

        public virtual double ChangePrice( double percent)
        {
            
                Price = Price + (Price * (percent / 100.0));
                return Price;
            
        }
       

        public override string ToString()
        {
            return Name.ToString() + Price.ToString() + Weight.ToString();
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





