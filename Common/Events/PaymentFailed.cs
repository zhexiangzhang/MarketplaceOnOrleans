﻿using Common.Entities;
using Common.Requests;

namespace Common.Events
{
    public class PaymentFailed
    {
        public string status { get; set; }
        public CustomerCheckout customer { get; set; }
        public int orderId { get; set; }
        public IList<OrderItem> items { get; set; }
        public float totalAmount { get; set; }
        public int instanceId { get; set; }

        public PaymentFailed(string status, CustomerCheckout customer, int orderId, IList<OrderItem> items, float totalAmount, int instanceId)
        {
            this.status = status;
            this.customer = customer;
            this.orderId = orderId;
            this.items = items;
            this.totalAmount = totalAmount;
            this.instanceId = instanceId;
        }
    }
}

