namespace TaxiPark.Models
{
    public abstract class Car
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public FuelConsumption FuelConsumption { get; set; }
    }
}
