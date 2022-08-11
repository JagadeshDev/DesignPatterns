namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var openings = new Factory.Factory();
            var opening = openings.RequirementDetailsForPosition(EmployeeType.Developer,new Factory.Fresher());
            Console.WriteLine($"Job Description : {opening.JobDescription()}");
            Console.WriteLine($"Roles And Responsibilities : {opening.RolesAndResponsibilities()}");
            Console.WriteLine($"Interview Procedure : {opening.Procedure.InterviewProcedure()}");
            Console.ReadLine();
        }
    }
}