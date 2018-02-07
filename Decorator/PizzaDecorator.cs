namespace Decorator
{
    public class PizzaDecorator : IPizza
    {
        public string Description{get;set;}
        protected IPizza Pizza;

        public PizzaDecorator(IPizza pizza) => Pizza = pizza;
        
        public virtual string GetDescription()=> Pizza.Description;
        public virtual double CalculateCost() => Pizza.CalculateCost();
    }
}
