using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class Product
    {

        public string Property1 { get; set; }
        public string Property2 { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("Product::ShowInfo");
            Console.WriteLine(Property1);
            Console.WriteLine(Property2);
        }
    }
}
