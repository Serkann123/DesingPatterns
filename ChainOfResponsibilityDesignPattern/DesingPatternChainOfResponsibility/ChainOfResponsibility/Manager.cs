using DesingPatternChainOfResponsibility.DAL;
using DesingPatternChainOfResponsibility.Models;

namespace DesingPatternChainOfResponsibility.ChainOfResponsibility
{
    public class Manager : Employee
    {
        public override void ProcessReques(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount < 250000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.Description = "Para çekme işlemi başarılı bir şekilde yapıldı";
                customerProcess.EmployeeName = "Şube Müdürü  - Şafak Altunay";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.Description = "Para çekme işlemi Yapılamadı Şube müdürü " +
                    "ödeyecegi miktarını aştıgından Bölge müdürüne yönlendirildi";
                customerProcess.EmployeeName = "Şube Müdürü - Şafak Altunay";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessReques(req);
            }
        }
    }
}
