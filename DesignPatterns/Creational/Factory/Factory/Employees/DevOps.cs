namespace Factory.Employees
{
    public class DevOps : IEmployee
    {
        public void JobDescription()
        {
            Console.WriteLine("Looking for Devops");
        }

        public void RolesAndResponsibilities()
        {
            Console.WriteLine("Automate the development lifecycles");
        }
    }
}
