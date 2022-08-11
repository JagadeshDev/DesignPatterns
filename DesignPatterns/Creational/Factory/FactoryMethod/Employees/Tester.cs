namespace FactoryMethod.Employees
{
    public class Tester : AbstractEmployee
    {
        public Tester(IProcedure procedure) : base(procedure)
        {
        }

        public override string JobDescription()
        {
            return "Looking for automation testers";
        }

        public override string RolesAndResponsibilities()
        {
            return "Write E2E test cases";
        }
    }
}
