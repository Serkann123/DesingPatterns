namespace DesignPattern.Template.TemplatePattern
{
    public class StandartPlan : NetflixPlan
    {
        public override string Content(string content)
        {
            return content;
        }

        public override int CountPerson(int countPerson)
        {
            return countPerson;
        }

        public override string PlanType(string planType)
        {
            return planType;
        }

        public override double Price(double price)
        {
            return price;
        }

        public override string Resulition(string resulition)
        {
            return resulition;
        }
    }
}
