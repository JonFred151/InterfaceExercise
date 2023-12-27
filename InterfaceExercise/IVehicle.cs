using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    
        public interface IVehicle
        {
            public int NumberofChairs { get; set; }
            public int NumberofWheels { get; set; }
            public string Model { get; set; }
            public int year { get; set; }

        public void Drive();
        public void Reverse();
        public void park();
        }
    }
