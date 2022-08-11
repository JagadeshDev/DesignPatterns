using Factory.Employees;

namespace Factory
{
    public class Factory
    {
        public IEmployee RequirementDetailsForPosition(EmployeeType employeeType)
        {
            return employeeType switch
            {
                EmployeeType.Developer => new Developer(),
                EmployeeType.Tester => new Tester(),
                EmployeeType.HR => new HumanResource(),
                EmployeeType.DevOps => new DevOps(),
                _ => throw new ArgumentOutOfRangeException(nameof(employeeType), $"Employeetype was not available: {employeeType}")
            };
        }
    }
}
