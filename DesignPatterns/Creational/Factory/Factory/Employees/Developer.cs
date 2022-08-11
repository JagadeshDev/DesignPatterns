namespace Factory.Employees
{
    public class Developer : IEmployee
    {
        public void JobDescription()
        {
            Console.WriteLine("Looking for c# devlopers");
        }

        public void RolesAndResponsibilities()
        {
            Console.WriteLine("Need to work on WEB API using .net core");
        }
    }
}
