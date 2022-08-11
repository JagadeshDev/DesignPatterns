namespace FactoryMethod
{
    public abstract class AbstractEmployee
    {
        public IProcedure Procedure { get; private set; }
        public AbstractEmployee(IProcedure procedure)
        {
            Procedure = procedure;
        }
        public abstract string JobDescription();
        public abstract string RolesAndResponsibilities();
    }
}
