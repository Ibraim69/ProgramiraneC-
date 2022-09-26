using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Truck
    {
        private string name;
        private double capacity;
        private double weight;

        public string Name
        {
            get { return name; }
            set { if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }

        }
        public double Capacity
        {
            get { return capacity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Capacity cannot be negative");
                }
                capacity = value;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {

                if (value < 0)
                {
                    throw new ArgumentException("Weight cannot be negative");
                }
                weight = value;
            }
        }
        public Truck(string name, double capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Weight = 0;
        }


            public bool canLoading(double weight)
        {
            if (this.weight + weight <= capacity)
                return true;
            else return false;
        }
        public void Loading (double weight)
        { this.weight = weight; }
    }

}
        
    

