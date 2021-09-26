namespace TaxiPark.Models
{
    using TaxiPark.Enums;

    public class FuelConsumption
    {
        public FuelType FuelType { get; init; }

        public double Value { get; init; }
    }
}
