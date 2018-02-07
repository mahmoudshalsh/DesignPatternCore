using System;

namespace Decorator
{
    public class Cheese : PizzaDecorator
    {
        public Cheese(IPizza pizza):base(pizza) => Description="Cheese";

        public override string GetDescription()=> String.Format("{0}, {1}", Pizza.GetDescription(), Description); 
        public override double CalculateCost() => Pizza.CalculateCost() + 1.25;
    }
}
