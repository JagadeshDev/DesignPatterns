namespace Factory.Employees
{
    public class Tester : IEmployee
    {
        public void JobDescription()
        {
            Console.WriteLine("Looking for automation testers");
        }

        public void RolesAndResponsibilities()
        {
            Console.WriteLine("Write E2E test cases");
        }
    }
}
