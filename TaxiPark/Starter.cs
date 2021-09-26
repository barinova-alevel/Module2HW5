using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiPark.Services;
using TaxiPark.Services.Abstraction;
using static System.Net.Mime.MediaTypeNames;

namespace TaxiPark
{
    using Microsoft.Extensions.DependencyInjection;
    using System.Collections;
    using TaxiPark.Providers;
    using TaxiPark.Providers.Abstractions;

    public class Starter
    {
        private Application _application;

        public void StartApplication()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<ITotalPriceService, TotalPriceService>()
                .AddTransient<ISortService, SortService>()
                .AddTransient<INewestCar, NewestCarService>()
                .AddTransient<ICarsProvider, CarsProvider>()
                .AddTransient<Application>()
                .BuildServiceProvider();

            _application = serviceProvider.GetService<Application>();
            _application.Run();
        }
        
    }
}
