using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod2Lab14
{
    public enum Categories
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string Name {get; set;}
        public int Price {get; set;}
        public string ImagePath {get; set;}
        public Categories Category {get; set;}
    }
}
