namespace Liskov
{
    public class EmployeeFullTime : Employee
    {

        private int ExtraHours;

        public EmployeeFullTime(string fullname, int hoursWorked, int extrahours) : base(fullname, hoursWorked)
        {
            ExtraHours = extrahours;
        }

        public override decimal CalculateSalary()
        {
            return 50 * (HoursWorked + ExtraHours);
        }
    }
}