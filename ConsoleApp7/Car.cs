using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Car:Vehicle
   
    {
        public override void Company()
        {
            Console.WriteLine("Car - Сompany");
        }
        public override void Type()
        {
            Console.WriteLine("Car - Type");
        }
        public void Racing()
        {
            Console.WriteLine("Car - Racing");
        }
        public void Model()
        {
            Console.WriteLine("Car - Model");
        }
        public void Price()
        {
            Console.WriteLine("Car- Price");
        }
    }
}
