namespace TaxiPark.Services.Abstraction
{
    using TaxiPark.Models;
    public interface INewestCar
    {
        public Car GetNewest();
    }
}
