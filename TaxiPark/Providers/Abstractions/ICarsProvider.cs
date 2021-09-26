namespace TaxiPark.Providers.Abstractions
{
   using TaxiPark.Models;
   public interface ICarsProvider
    {
        Car[] Cars { get; }
    }
}
