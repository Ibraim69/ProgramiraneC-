using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDriving
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car = new Car("rr6969ab", 20, 8, 8069);
            Console.WriteLine("Input need km: ");
            double needkm = Double.Parse(Console.ReadLine());
            if (Car.CanDrive(needkm))
            {
                Car.Drive(needkm);
                Console.WriteLine("You drove {0}km",needkm);
            }
            else
            {
                Console.WriteLine("You can not drive {0}km", needkm);
            }
        }
    }
}
