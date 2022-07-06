using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Dogs
    {
        public string name;
        public byte age;
        public string color;
        
       
        public string GetDetails()
        {
            return $"{name} {age} {color}";
        }
    }
}
