namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var openings = new Factory();
            var opening = openings.RequirementDetailsForPosition(EmployeeType.Developer);
            opening.JobDescription();
            opening.RolesAndResponsibilities();
            Console.ReadLine();
        }
    }
}
