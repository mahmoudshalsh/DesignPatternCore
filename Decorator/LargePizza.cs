namespace Decorator
{
    public class LargePizza : IPizza
    {
        public string Description{get;set;}

        public LargePizza() => Description = "Large Pizza";
        public string GetDescription()=> Description; 
        public double CalculateCost() => 9.00;
    }
}
