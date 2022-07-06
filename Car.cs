using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Car
    {
        public string model;
        public int price;
        public int speed;
        public string color;


        public string GetDetails()
        {
            return $"{model} {price} {speed} {color}";
        }
    }
}
