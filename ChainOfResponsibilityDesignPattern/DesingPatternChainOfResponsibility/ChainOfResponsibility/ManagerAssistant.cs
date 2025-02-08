using DesingPatternChainOfResponsibility.DAL;
using DesingPatternChainOfResponsibility.Models;

namespace DesingPatternChainOfResponsibility.ChainOfResponsibility
{
    public class ManagerAssistant : Employee
    {
        public override void ProcessReques(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount < 150000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.Description = "Para çekme işlemi başarılı bir şekilde yapıldı";
                customerProcess.EmployeeName = "Şube Müdürü Yardımcısı - Mızık Altunay";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.Description = "Para çekme işlemi Yapılamadı Şube müdürü yardımcının" +
                    "ödeyecegi miktarını aştıgından Şube müdürüne yönlendirildi";
                customerProcess.EmployeeName = "Şube Müdürü - Mızık Altunay";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessReques(req);
            }
        }
    }
}
