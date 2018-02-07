namespace Decorator
{
    public class SmallPizza : IPizza
    {
        public string Description{get;set;}

        public SmallPizza() => Description = "Small Pizza";
        public string GetDescription()=> Description; 
        public double CalculateCost() => 3.00;
    }
}
