using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train();
            Car car = new Car();
            Express express = new Express();

            train.Company();
            train.Type();
            train.max_speed();

            express.Company();
            express.Type();
            express.Passanger_capacity();
            express.Weight();

            car.Company();
            car.Type();
            car.Racing();
            car.Model();
            car.Price();
        }
    }
}
