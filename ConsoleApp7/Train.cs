using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Train : Vehicle
    {
        public override void Company()
        {
            Console.WriteLine(" Train - Company");
        }

        public override void Type()
        {
            Console.WriteLine("Train - Type ");
        }

        public void max_speed()
        {
            Console.WriteLine("Train - Max Speed");
        }

    }
}
