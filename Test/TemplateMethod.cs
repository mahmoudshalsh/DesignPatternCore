using System;
using NUnit.Framework;
using TemplateMethod;

namespace Tests
{
    public class TemplateMethod
    {
        [Test]
        public void TemplateMethodTest()
        {
            // Arrange
            OrderShipment order=new FedExOrderShipment();

            // Act
            order.Ship();
        }
    }
}