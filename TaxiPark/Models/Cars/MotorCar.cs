namespace TaxiPark.Models.Cars
{
    using Enums;
    public class MotorCar : Car
    {
        public CarType CarType { get; set; }

        public int YearOfIssue { get; set; }
    }
}
