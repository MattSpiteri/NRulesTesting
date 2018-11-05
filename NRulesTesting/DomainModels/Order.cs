﻿namespace NRulesTesting.DomainModels
{
    public class Order
    {
        public int Id { get; private set; }
        public Customer Customer { get; private set; }
        public int Quantity { get; private set; }
        public double UnitPrice { get; private set; }
        public double PercentDiscount { get; private set; }
        public bool IsDiscounted { get { return PercentDiscount > 0; } }

        public double Price
        {
            get { return UnitPrice * Quantity * (1.0 - PercentDiscount / 100.0); }
        }

        public Order(int id, Customer customer, int quantity, double unitPrice)
        {
            Id = id;
            Customer = customer;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public void ApplyDiscount(double percentDiscount)
        {
            PercentDiscount = percentDiscount;
        }
    }
}
