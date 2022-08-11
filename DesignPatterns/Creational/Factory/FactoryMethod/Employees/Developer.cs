namespace FactoryMethod.Employees
{
    public class Developer : AbstractEmployee
    {
        public Developer(IProcedure procedure) : base(procedure)
        {
        }

        public override string JobDescription()
        {
            return "Looking for c# devlopers";
        }

        public override string RolesAndResponsibilities()
        {
            return "Need to work on WEB API using .net core";
        }
    }
}
