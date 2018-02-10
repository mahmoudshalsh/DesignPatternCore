using System;

namespace TemplateMethod
{
    public abstract class OrderShipment
    {
        protected string ShippingAddress { get; set; }
        protected string Label { get; set; }
        public void Ship()
        {
            VerifyShippingData();
            GetShippingLabelFromCarrier();
            PrintLabel();
        }

        protected virtual void VerifyShippingData()
        {
            if (String.IsNullOrEmpty(ShippingAddress))
                throw new Exception("Invalid address.");
        }
        protected abstract void GetShippingLabelFromCarrier();
        protected virtual void PrintLabel() => Console.WriteLine(Label);
    }
}