using VehicleRentingSystem.Models;

namespace VehicleRentalSystem.Models
{
    public class Motorcycle : Vehicle
    {
        private bool HasPassager { get; set; }

        public Motorcycle(string licensePlate, string brand, string model, bool status, int year, bool hasPassager) :
            base(licensePlate, brand, model, status, year)
        {
            HasPassager = hasPassager;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Motorcycle] {Brand} - {Model} - {LicensePlate} - Has passager: {HasPassager}\t Is available: {Status}");
        }
    }
}