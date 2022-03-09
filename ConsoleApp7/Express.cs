using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Express : Vehicle
    {
        public override void Company()
        {
            Console.WriteLine("Express-Company");
        }
        public override void Type()
        {
            Console.WriteLine("Express-Type");
        }
        public void Passanger_capacity()
        {
            Console.WriteLine("Express- Passanger Capacity");
        }
        public void Weight()
        {
            Console.WriteLine("Express - Weight");
        }
    }
}
