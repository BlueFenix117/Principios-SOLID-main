namespace OpenClose
{
    public class EmployeePartTime : IEmployeePartTime
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public EmployeePartTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }
        
        public void Salary(EmployeePartTime employee)
        {
            decimal hourValue = 20000M;
                    EmployeePartTime employeePartTime = ((EmployeePartTime)employee);
                    decimal salary = hourValue * employeePartTime.HoursWorked;
                    if (employeePartTime.HoursWorked > 160) {
                        decimal effortCompensation = 5000M;
                        int extraDays = employeePartTime.HoursWorked - 160;
                        salary += effortCompensation * extraDays;
                    }
                    Console.WriteLine($"Empleado: {employeePartTime.Fullname}, Pago: {salary:C1} ");
        }
    }
}