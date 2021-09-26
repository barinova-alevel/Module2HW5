using System;

namespace TaxiPark.Models.Cars.MotorCars
{
    public class StandardMotoCar : MotorCar
    {
        public int CarAge()
        {
            int issued = this.YearOfIssue;
            int currentYear = DateTime.Now.Year;
            return currentYear - issued;
        }
    }
}
