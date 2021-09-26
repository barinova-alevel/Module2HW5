using System.Collections;
using TaxiPark.Models;

namespace TaxiPark.Services.Abstraction
{
    public interface ISortService
    {
       void SortByFuelConsumption(Car[] cars, IComparer comparer);
    }
}
