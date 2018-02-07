namespace Decorator
{
    public class MeduimPizza : IPizza
    {
        public string Description{get;set;}

        public MeduimPizza() => Description = "Meduim Pizza";
        public string GetDescription()=> Description; 
        public double CalculateCost() => 6.00;
    }
}
