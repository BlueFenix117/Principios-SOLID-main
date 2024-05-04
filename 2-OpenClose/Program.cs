using OpenClose;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

CalculateSalaryMonthly(new List<object>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeePartTime("Manuel Lopera", 180),
    new EmployeeContractor("Gabriel Estrada", 120)
});


void CalculateSalaryMonthly(List<object> employees) {

    foreach (var employee in employees)
    {
        if (employee is EmployeeFullTime) 
        {
            IEmployeeFullTime employeeFullTime = (IEmployeeFullTime)employee;

            employeeFullTime.Salary((EmployeeFullTime)employee);
        }
        else if (employee is EmployeePartTime)
        {
            IEmployeePartTime employeePartTime = (IEmployeePartTime)employee;
            employeePartTime.Salary((EmployeePartTime)employee);
        } else
        {
            IEmployeeContractor employeeContractor = (IEmployeeContractor)employee;
            employeeContractor.Salary((EmployeeContractor)employee);
        }
    }
}