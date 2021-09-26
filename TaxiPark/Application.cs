using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiPark.Services.Abstraction;

namespace TaxiPark
{
    public class Application
    {
        private readonly ITotalPriceService _totalPriceService; 
        private readonly ISortService _sortService; 
        private readonly INewestCar _newestCarService;

        public Application(ITotalPriceService priceService,
                            ISortService sortService,
                            INewestCar newestCar)
        {
            _totalPriceService = priceService;
            _sortService = sortService;
            _newestCarService = newestCar;
        }

        public void Run()
        {
            var totalPrice = _totalPriceService.GetTotalPrice().ToString();
            Console.WriteLine($"Total cost of taxi park: {totalPrice}");
        }
    }
}
