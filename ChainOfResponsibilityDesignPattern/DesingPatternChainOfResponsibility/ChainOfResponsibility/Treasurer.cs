using DesingPatternChainOfResponsibility.DAL;
using DesingPatternChainOfResponsibility.Models;

namespace DesingPatternChainOfResponsibility.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessReques(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount < 100000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.Description = "Para çekme işlemi başarılı bir şekilde yapıldı";
                customerProcess.EmployeeName = "Veznedar - Serkan Altunay";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover!=null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.Description = "Para çekme işlemi Yapılamadı Veznedar ödeyemedi" +
                    "Şube müdürü yardımcınınıa yönlendiriliyorsınızn";
                customerProcess.EmployeeName = "Veznedar - Serkan Altunay";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessReques(req);
            }
        }
    }
}
