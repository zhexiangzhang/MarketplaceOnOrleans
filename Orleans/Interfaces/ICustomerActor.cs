﻿using Common.Entities;
using Common.Events;

namespace Orleans.Interfaces
{
    public interface ICustomerActor : IGrainWithIntegerKey
    {
        // API
        public Task SetCustomer(Customer customer);
        Task Clear();
        public Task<Customer> GetCustomer();

        public Task NotifyPaymentConfirmed(PaymentConfirmed paymentConfirmed);
        public Task NotifyPaymentFailed(PaymentFailed paymentFailed);
        public Task NotifyDelivery(DeliveryNotification deliveryNotification);

    }
}
