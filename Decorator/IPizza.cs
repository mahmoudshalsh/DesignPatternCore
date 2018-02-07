namespace Decorator
{
    public interface IPizza
    {
        string Description{get;set;}
        string GetDescription();
        double CalculateCost();
    }
}
