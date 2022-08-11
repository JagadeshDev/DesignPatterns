namespace FactoryMethod.Employees
{
    public class HumanResource : AbstractEmployee
    {
        public HumanResource(IProcedure procedure) : base(procedure)
        {
        }

        public override string JobDescription()
        {
            return "Looking for HR";
        }

        public override string RolesAndResponsibilities()
        {
            return "Help in hiring";
        }
    }
}
