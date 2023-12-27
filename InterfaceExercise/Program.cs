using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            string cVehicle;
           
            do
            {
                var car = new Car();
                var truck = new Truck();
                var suv = new SUV();
                Console.WriteLine("Choose a selection: \n1. Make a Vehicle \n2. Exit ");
                if(int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            bool escape = false;                            
                            do
                            {
                                Console.WriteLine("What type of Vehicle do you want to make?");
                                cVehicle = Console.ReadLine();
                                if (cVehicle == "Car")
                                {
                                    Console.Clear();
                                    Console.WriteLine("How many Chair do you want in it?");
                                    car.NumberofChairs = int.Parse(Console.ReadLine());
                                    Console.WriteLine("How many wheels does it need?");
                                    car.NumberofWheels = int.Parse(Console.ReadLine());
                                    Console.WriteLine("What model is the car?");
                                    car.Model = Console.ReadLine();
                                    Console.WriteLine("What year is the car?");
                                    car.year = int.Parse(Console.ReadLine());
                                    Console.WriteLine("What the name of the Company that make the vehicle?");
                                    car.Logo = Console.ReadLine();
                                    Console.WriteLine("What location did the vehicle come from?");
                                    car.location = Console.ReadLine();
                                    Console.WriteLine("Does the Car have a trunk? Please enter 1 for yes and 0 for no");
                                    int YesNo = int.Parse(Console.ReadLine());
                                    if(YesNo == 0)
                                    {
                                        car.hasTrunk = false;

                                    }
                                    else
                                    {
                                        car.hasTrunk = true;
                                    }
                                    Console.WriteLine($"The Model of the Car is {car.Model} \nThe year is {car.year} \nThe Company that made it is{car.Logo} \nThe location {car.location} \n it has number of chairs and number of wheels {car.NumberofChairs} {car.NumberofWheels}.\n Is there a trunk? {car.hasTrunk} ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    escape = true;
                                }
                                else if (cVehicle == "Truck")
                                {
                                    Console.Clear();
                                    Console.WriteLine("How many Chair do you want in it?");
                                    truck.NumberofChairs = int.Parse(Console.ReadLine());
                                    Console.WriteLine("How many wheels does it need?");
                                    truck.NumberofWheels = int.Parse(Console.ReadLine());
                                    Console.WriteLine("What model is the Truck?");
                                    truck.Model = Console.ReadLine();
                                    Console.WriteLine("What year is the Truck?");
                                    truck.year = int.Parse(Console.ReadLine());
                                    Console.WriteLine("What the name of the Company that make the vehicle?");
                                    truck.Logo = Console.ReadLine();
                                    Console.WriteLine("What location did the vehicle come from?");
                                    truck.location = Console.ReadLine();
                                    Console.WriteLine("Does the Truck have a bed? Please enter 1 for yes and 0 for no");
                                    int YesNo = int.Parse(Console.ReadLine());
                                    if (YesNo == 0)
                                    {
                                        
                                        truck.hasBed = false;
                                    }
                                    else
                                    {
                                        
                                        truck.hasBed = true;
                                    }
                                    Console.WriteLine($"The Model of the Truck is {truck.Model} \nThe year is {truck.year} \nThe Company that made it is{truck.Logo} \nThe location {truck.location} \n it has number of chairs and number of wheels {truck.NumberofChairs} {truck.NumberofWheels}.\n Is there a bed? {truck.hasBed} ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    escape = true;
                                }
                                else if (cVehicle == "SUV")
                                {
                                    Console.Clear();
                                    Console.WriteLine("How many Chair do you want in it?");
                                    suv.NumberofChairs = int.Parse(Console.ReadLine());
                                    Console.WriteLine("How many wheels does it need?");
                                    suv.NumberofWheels = int.Parse(Console.ReadLine());
                                    Console.WriteLine("What model is the Truck?");
                                    suv.Model = Console.ReadLine();
                                    Console.WriteLine("What year is the Truck?");
                                    suv.year = int.Parse(Console.ReadLine());
                                    Console.WriteLine("What the name of the Company that make the vehicle?");
                                    suv.Logo = Console.ReadLine();
                                    Console.WriteLine("What location did the vehicle come from?");
                                    suv.location = Console.ReadLine();
                                    Console.WriteLine("Does the Truck have a bed? Please enter 1 for yes and 0 for no");
                                    int YesNo = int.Parse(Console.ReadLine());
                                    if (YesNo == 0)
                                    {

                                        suv.hasThirdRow = false;
                                    }
                                    else
                                    {

                                        suv.hasThirdRow = true;
                                    }
                                    Console.WriteLine($"The Model of the SUV is {suv.Model} \nThe year is {suv.year} \nThe Company that made it is{suv.Logo} \nThe location {suv.location} \n it has number of chairs and number of wheels {suv.NumberofChairs} {suv.NumberofWheels}.\n Is there a third row? {suv.hasThirdRow} ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    escape = true;
                                }
                                else
                                {
                                   Console.Clear ();
                                    Console.WriteLine("Wrong input....press a key to retry again!");
                                    Console.ReadKey ();
                                    Console.Clear ();   
                                }

                            } while(escape != true);

                           

                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Thank you for making a vehicle. Please use the app again! Press any key to exit");
                            Console.ReadKey();
                            Console.Clear ();   
                        break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Wrong input...press a key to try again!");
                            Console.ReadKey();  
                            Console.Clear () ;
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Choice. Please select the given option! Press a key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }



            } while (choice != 2);
            
            



        }

        
     
    }
}