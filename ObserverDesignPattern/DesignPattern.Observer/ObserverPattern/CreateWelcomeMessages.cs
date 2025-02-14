using DesignPattern.Observer.DAL;
using System;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateWelcomeMessages : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context _context = new Context();

        public CreateWelcomeMessages(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            _context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Content = "Dergi bültenimize abone olduğunuz için çok teşekkür ederiz," +
                "Dergilerimize web sitemizden uşabilirsiniz"
            });

            _context.SaveChanges();
        }
    }
}
