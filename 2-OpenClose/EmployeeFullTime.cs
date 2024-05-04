
namespace OpenClose
{
    public class EmployeeFullTime : IEmployeeFullTime
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public EmployeeFullTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public void Salary (EmployeeFullTime employee)
        {
            
                decimal hourValue = 30000M;
                EmployeeFullTime employeeFullTime = ((EmployeeFullTime)employee);
                decimal salary = hourValue * employeeFullTime.HoursWorked;
                Console.WriteLine($"Empleado: {employeeFullTime.Fullname}, Pago: {salary:C1} ");
            
            
        }
    }
}