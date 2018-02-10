using System;

namespace TemplateMethod
{
    public class FedExOrderShipment : OrderShipment
    {
        protected override void GetShippingLabelFromCarrier()
        {
            // Call FedEx Web Service
            Label = String.Format("FedEx:[{0}]", ShippingAddress);
        }
    }
}