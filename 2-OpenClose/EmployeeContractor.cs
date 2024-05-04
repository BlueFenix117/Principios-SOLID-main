
namespace OpenClose
{
    public class EmployeeContractor : IEmployeeContractor
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }


        public EmployeeContractor(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public void Salary(EmployeeContractor employee)
        {

            decimal hourValue = 30000M;
            EmployeeContractor employeeContractorTime = ((EmployeeContractor)employee);
            decimal salary = hourValue * employeeContractorTime.HoursWorked;
            Console.WriteLine($"Empleado: {employeeContractorTime.Fullname}, Pago: {salary:C1} ");


        }
    }
}
