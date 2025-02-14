using DesignPattern.Observer.DAL;
using System;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateMagazineAnnocument : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context _context = new Context();

        public CreateMagazineAnnocument(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            _context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Magazine = "Bilim Dergisi",
                Content = "Bilim dergimizin Mart sayısı 1 Martta evinize ulaştırılacaktır."
            });

            _context.SaveChanges();
        }
    }
}