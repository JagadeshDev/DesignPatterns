using FactoryMethod.Employees;

namespace FactoryMethod.Factory
{
    public class Factory
    {
        public AbstractEmployee RequirementDetailsForPosition(EmployeeType employeeType,IProcedure procedure)
        {
            AbstractEmployee employee = null;
            
            return employeeType switch
            {
                EmployeeType.Developer => new Developer(procedure),
                EmployeeType.Tester => new Tester(procedure),
                EmployeeType.HR => new HumanResource(procedure),
                EmployeeType.DevOps => new DevOps(procedure),
                _ => throw new ArgumentOutOfRangeException(nameof(employeeType), $"Employeetype was not available: {employeeType}")
            };

            return employee;
        }
    }
}
