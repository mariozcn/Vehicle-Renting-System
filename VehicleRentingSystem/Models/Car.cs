namespace VehicleRentingSystem.Models
{

    public class Car : Vehicle
    {
        private string Fuel { get; set; }

        public Car(string licensePlate, string brand, string model, bool status, int year, string fuel) : base(
            licensePlate, brand, model, status, year)
        {
            Fuel = fuel;
        }


        public override void DisplayInfo()
        {
            Console.WriteLine(
                $"[Car] {Brand} - {Model} - {LicensePlate} - Fuel Type: {Fuel} \t Is available: {Status}");
        }
    }
}