
namespace TaxiPark.Services
{
    using TaxiPark.Providers;
    using TaxiPark.Providers.Abstractions;
    using TaxiPark.Services.Abstraction;

    public class TotalPriceService : ITotalPriceService
    {
        private const int _taxiParkSize = 7;
        private readonly ICarsProvider _carsProvider;

        public TotalPriceService()
        {
            _carsProvider = new CarsProvider();
        }



        public double GetTotalPrice()
        {
            double totalPrice = 0;
            for (int i = 0; i < _taxiParkSize; i++)
            {
                double temp = _carsProvider.Cars[i].Price;
                totalPrice += temp;
            }
            return totalPrice;
        }
    }
}
