using System;
using System.Collections.Generic;
using System.Text;

namespace kur
{
    internal class product
    {
        public string Name { get; set; }
        public int Sum { get; set; }
        public string Image { get; set; }

        public product(string name, int sum, string image) 
        {
            Name = name;
            Sum = sum;
            Image = image;
        }
    }
    
}
