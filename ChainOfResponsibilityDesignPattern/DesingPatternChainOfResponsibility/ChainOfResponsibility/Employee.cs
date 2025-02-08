using DesingPatternChainOfResponsibility.Models;

namespace DesingPatternChainOfResponsibility.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover;

        public void SetNextApprover(Employee Supervisor)
        {
            this.NextApprover= Supervisor;
        }

        public abstract void ProcessReques(CustomerProcessViewModel req);
    }
}
