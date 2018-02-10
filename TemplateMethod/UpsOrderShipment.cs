using System;

namespace TemplateMethod
{
    public class UpsOrderShipment : OrderShipment
    {
        protected override void GetShippingLabelFromCarrier()
        {
            // Call UPS Web Service
            Label = String.Format("UPS:[{0}]", ShippingAddress);
        }
    }
}