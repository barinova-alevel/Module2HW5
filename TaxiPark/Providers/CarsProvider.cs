namespace TaxiPark.Providers
{
    using TaxiPark.Enums;
    using TaxiPark.Models;
    using TaxiPark.Models.Cars.MotorCars;
    using TaxiPark.Models.Cars.MotorCars.StandardMotoCars;
    using TaxiPark.Providers.Abstractions;

    public class CarsProvider : ICarsProvider
    {
        public CarsProvider()
        {
            Cars = new Car[]
        {
                    new Delivery
                    {
                        Name = "Fiat",
                        Price = 25,
                        FuelConsumption = new FuelConsumption { FuelType = FuelType.Petrol, Value = 10 },
                        AllovedBaggageVolume = 7.5,
                        YearOfIssue = 2010
                    },

                    new Delivery
                    {
                        Name = "Kia",
                        Price = 22,
                        FuelConsumption = new FuelConsumption { FuelType = FuelType.Petrol, Value = 8.5 },
                        AllovedBaggageVolume = 10.6,
                        YearOfIssue = 2015
                    },

                    new Delivery
                    {
                        Name = "Reno",
                        Price = 20,
                        FuelConsumption = new FuelConsumption { FuelType = FuelType.Diesel, Value = 12.3 },
                        AllovedBaggageVolume = 15,
                        YearOfIssue = 2018
                    },

                    new Passengers
                    {
                        Name = "Fiat",
                        Price = 25.55,
                        FuelConsumption = new FuelConsumption { FuelType = FuelType.Petrol, Value = 10 },
                        NumberOfSeats = 4,
                        YearOfIssue = 2020
                    },

                    new Passengers
                    {
                        Name = "Ford",
                        Price = 28,
                        FuelConsumption = new FuelConsumption { FuelType = FuelType.Petrol, Value = 7.8 },
                        NumberOfSeats = 5,
                        YearOfIssue = 2019
                    },

                    new ComfortMotoCar
                    {
                        Name = "Ford",
                        Price = 28,
                        FuelConsumption = new FuelConsumption { FuelType = FuelType.Petrol, Value = 7.8 },
                        SalonType = SalonType.Textile,
                        YearOfIssue = 2019
                    },
                    new ComfortMotoCar
                    {
                        Name = "Nissan",
                        Price = 21.6,
                        FuelConsumption = new FuelConsumption { FuelType = FuelType.Petrol, Value = 5.89 },
                        SalonType = SalonType.Combined,
                        YearOfIssue = 2017
                    }
            };
        }
        public Car[] Cars { get; }
    }
}


