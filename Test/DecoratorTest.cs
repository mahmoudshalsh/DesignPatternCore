using System;
using NUnit.Framework;
using Decorator;

namespace Tests
{
    public class DecoratorTest
    {
        [Test]
        public void Test()
        {
            // Arrange
            IPizza pizza=new LargePizza();
            pizza=new Cheese(pizza);
            pizza=new Ham(pizza);
            pizza=new Cheese(pizza);

            // Act
            var description=pizza.GetDescription();
            var cost=pizza.CalculateCost();
            
            // Assert
            Assert.AreEqual("Large Pizza, Cheese, Ham, Cheese",description);
            Assert.AreEqual(12.5,cost);

            // Analysis
            Console.WriteLine(description);
            Console.WriteLine("{0:C2}",cost);
        }
    }
}