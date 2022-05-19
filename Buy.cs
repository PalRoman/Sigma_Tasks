using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaLess1
{
  internal  class Buy
    {
        private int _countOfProduct;
        private double _totalPrice;
        private double _totalWeight;
        public Buy() { }
      
        public Buy(int countOfProduct, double totalPrice, double totalWeight)
        {
            
            _countOfProduct = countOfProduct;
            _totalPrice = totalPrice;
            _totalWeight = totalWeight;
        }
        public int CountOfProduct { get;  }

        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }
        public double TotalWeight
        {
            get { return _totalWeight; }
            set { _totalWeight = value; }
        }



    }
}
