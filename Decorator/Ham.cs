using System;

namespace Decorator
{
    public class Ham : PizzaDecorator
    {
        public Ham(IPizza pizza):base(pizza) => Description="Ham";

        public override string GetDescription()=> String.Format("{0}, {1}", Pizza.GetDescription(), Description); 
        public override double CalculateCost() => Pizza.CalculateCost() + 1.00;
    }
}
