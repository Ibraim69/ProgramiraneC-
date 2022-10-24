using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDriving
{
    class Car
    {
        private string number;
        private double fuel;
        private double fuelkm;
        private double km;
        public string Number
        {
            get { return number; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 8)

                {
                    throw new ArgumentException("Number cannot be empty");

                }
                number = value;
            }
        }
        public double Fuel
        {
            get { return fuel; }
            set { if (value < 0) throw new ArgumentException("Fuel cannot be negative");
                fuel = value;
            }

        }
        public double Fuelkm
        {
            get { return fuelkm; }
            set
            {
                if (value < 3) throw new ArgumentException("fuel km cannot be lower than 3");
                fuelkm = value;
            }
        }

        public double Km
        {
            get { return km; }
            set
            {
                if (value < 0) throw new ArgumentException("Km cannot be negative");
                km = value;
            }
        }
        public Car(string number, double fuel, double fuelkm, double km)
        {
            this.Number = number;
            this.Fuel = fuel;
            this.Fuelkm = fuelkm;
            this.Km = km;
        }

        public Car() : this("xxxxxx", 10,10,10)
        {

        }
        public bool CanDrive(double needkm)
        {
            double maxkm = fuel * (100 / fuelkm);
            if (needkm <= maxkm)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Drive (double runkm)
        {
            km += runkm;
            fuel -= runkm * fuelkm / 100;
        }
        




 }
}





    

     
            

            
        
    
            

    

