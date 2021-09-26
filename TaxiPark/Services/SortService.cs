using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiPark.Models;
using TaxiPark.Services.Abstraction;

namespace TaxiPark.Services
{
    public class SortService : ISortService
    {
        public void SortByFuelConsumption(Car[] cars, IComparer comparer)
        {
            Array.Sort(cars, comparer);
        }
    }
}
