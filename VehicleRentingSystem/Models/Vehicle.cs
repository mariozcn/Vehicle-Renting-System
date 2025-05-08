namespace VehicleRentingSystem.Models
{
    public abstract class Vehicle
    {
        public string LicensePlate { get; set; }
        protected string Brand { get; set; }
        protected string Model { get; set; }
        protected bool Status { get; set; }

        protected int Year { get; set; }

        public Vehicle(string licensePlate, string brand, string model, bool status, int year)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Model = model;
            Status = status;
            Year = year;
        }

        public virtual void DisplayInfo()
        {
        }

        public void Rent()
        {
            if (Status)
            {
                Console.WriteLine("Vehicle rented!");
                Status = false;
            }
            else
            {
                Console.WriteLine("Vehicle is not available!");
            }
        }

        public void Return()
        {
            if (!Status)
            {
                Console.WriteLine("You've returned the vehicle!");
                Status = true;
            }
            else
            {
                Console.WriteLine("ERROR!");
            }
        }
    }
}