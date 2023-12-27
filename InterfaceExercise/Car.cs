using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public Car() 
        {            
        }
        public int NumberofChairs {  get; set; }
        public int NumberofWheels { get; set; }
        public string Model { get; set; }
        public int year { get; set; }
        public string Logo { get; set; }
        public string location { get; set; }
        public bool hasTrunk { get; set; }


        public void Drive() 
        {
            Console.WriteLine($" {GetType().Name} now driving forward");
        }
        public void Reverse() 
        {
            Console.WriteLine($" {GetType().Name} now reversing");
        }
        public void park() 
        {
            Console.WriteLine($" {GetType().Name} now in park");
        }


    }
}
