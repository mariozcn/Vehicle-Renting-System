using VehicleRentalSystem.Models;
using VehicleRentingSystem.Models;
namespace VehicalRentingSystem
{
    class Program
    {
        static List<Vehicle> vehicles = new List<Vehicle>();
        static void Main()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("1.Add Vehicle ");
                Console.WriteLine("2.Remove Vehicle ");
                Console.WriteLine("3.Show All Vehicles ");
                Console.WriteLine("4.Rent Vehicle ");
                Console.WriteLine("5.Return Vehicle ");
                Console.WriteLine("6.Exit ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddVehicle();
                        break;
                    case "2":
                        RemoveVehicle();
                        break;
                    case "3":
                        foreach (var v in vehicles) { v.DisplayInfo(); }
                        break;
                    case "4":
                        RentVehicle();
                        break;
                    case "5":
                        ReturnVehicle();
                        break;
                    case "6":
                        running = false;
                        break;
                }
            }
        }
        static void AddVehicle()
        {
            Console.WriteLine("Specify vehicle type: [car/motorcycle]: ");
            string type = Console.ReadLine().ToLower();
            Console.WriteLine("License plate: ");
            string plate = Console.ReadLine().ToUpper();
            Console.WriteLine("Brand: ");
            string brand = Console.ReadLine().ToUpper();
            Console.WriteLine("Model: ");
            string model = Console.ReadLine().ToUpper();
            Console.WriteLine("Year: ");
            int year = int.Parse(Console.ReadLine());
            bool status = true;


            if (type == "car")
            {
                string fuel;
                while (true)
                {
                    Console.WriteLine("Fuel Type: [GASOLINE/DIESEL]");
                    fuel = Console.ReadLine().ToUpper();

                    if (fuel == "GASOLINE" || fuel == "DIESEL")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid fuel type!");
                    }
                }

                vehicles.Add(new Car(plate, brand, model, status, year, fuel));
            }
            else if (type == "motorcycle")
            {
                Console.WriteLine("Has passager seat: [true/false]");
                bool passager = bool.Parse(Console.ReadLine().ToLower());
                vehicles.Add(new Motorcycle(plate, brand, model, status, year, passager));
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }

        static void RemoveVehicle()
        {
            Console.WriteLine("Enter license plate: ");
            string plate = Console.ReadLine().ToUpper();

            var vehicleToRemove = vehicles.FirstOrDefault(v => v.LicensePlate == plate);
            if (vehicleToRemove != null)
            {
                vehicles.Remove(vehicleToRemove);
                Console.WriteLine("Vehicle removed!");
            }
            else
            {
                Console.WriteLine("Vehicle not found!");
            }
        }

        static void RentVehicle()
        {
            Console.WriteLine("Enter vehicle license plate: ");
            string plate = Console.ReadLine().ToUpper();
            var vehicleToRent = vehicles.FirstOrDefault(v => v.LicensePlate == plate);
            if (vehicleToRent != null)
            {
                vehicleToRent.Rent();
            }
            else { Console.WriteLine("Vehicle not found!"); }
        }

        static void ReturnVehicle()
        {
            Console.WriteLine("Enter vehicle license plate: ");
            string plate = Console.ReadLine().ToUpper();
            var vehicleToReturn = vehicles.FirstOrDefault(v => v.LicensePlate == plate);
            if (vehicleToReturn != null)
            {
                vehicleToReturn.Return();
            }
            else
            {
                Console.WriteLine("Vehicle has not been rented!");
            }
        }
    }
}