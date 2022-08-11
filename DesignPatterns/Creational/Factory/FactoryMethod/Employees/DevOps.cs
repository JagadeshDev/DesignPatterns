namespace FactoryMethod.Employees
{
    public class DevOps : AbstractEmployee
    {
        public DevOps(IProcedure procedure) : base(procedure)
        {
        }

        public override string JobDescription()
        {
            return "Looking for Devops";
        }

        public override string RolesAndResponsibilities()
        {
            return "Automate the development lifecycles";
        }
    }
}
