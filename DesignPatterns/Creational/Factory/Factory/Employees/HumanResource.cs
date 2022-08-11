namespace Factory.Employees
{
    public class HumanResource : IEmployee
    {
        public void JobDescription()
        {
            Console.WriteLine("Looking for HR");
        }

        public void RolesAndResponsibilities()
        {
            Console.WriteLine("Help in hiring");
        }
    }
}
