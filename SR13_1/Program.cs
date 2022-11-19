using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR13_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Москва, Ленина, 6", 130, 50, 30);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("Москва, Фрунзе, 33", -5, -5, -5, 1000);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();

        }
    }
}
