using System;

namespace Decorator
{
    public class Pepper : PizzaDecorator
    {
        public Pepper(IPizza pizza):base(pizza) => Description="Pepper";

        public override string GetDescription()=> String.Format("{0}, {1}", Pizza.GetDescription(), Description); 
        public override double CalculateCost() => Pizza.CalculateCost() + 2.00;
    }
}
