using System.Security.Cryptography.Xml;

namespace DesignPattern.Template.TemplatePattern
{
    public abstract class NetflixPlan
    {
        public abstract string PlanType(string planType);
        public abstract int CountPerson(int countPerson);
        public abstract double Price(double price);
        public abstract string Resulition(string resulition);
        public abstract string Content(string content);

        public void CreatePlan()
        {
            PlanType(string.Empty);
            CountPerson(0);
            Price(0);
            Resulition(string.Empty);
            Content(string.Empty);
        }
    }
}
