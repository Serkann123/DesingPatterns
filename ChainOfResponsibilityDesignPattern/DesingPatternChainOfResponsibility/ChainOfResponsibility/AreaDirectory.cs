using DesingPatternChainOfResponsibility.DAL;
using DesingPatternChainOfResponsibility.Models;

namespace DesingPatternChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirectory : Employee
    {
        public override void ProcessReques(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount < 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.Description = "Para çekme işlemi başarılı bir şekilde yapıldı";
                customerProcess.EmployeeName = "Böge Directorü  - Hakan Altunay";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount;
                customerProcess.Name = req.Name;
                customerProcess.Description = "Para çekme işlemi Yapılamadı Bölge Directorü " +
                    "ödeyecegi miktarını aştıgından Gerçekleştiremedi güle güle";
                customerProcess.EmployeeName = "Şube Müdürü - Şafak Altunay";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}
