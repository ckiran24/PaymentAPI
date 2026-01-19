using PaymentAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PaymentAPI.Services
{
    public class PaymentServiceResolver
    {
        private readonly IEnumerable<IPaymentService> _services;

        public PaymentServiceResolver(IEnumerable<IPaymentService> services)
        {
            _services = services;
        }

        public IPaymentService Resolve(string type)
        {
            var service = _services.FirstOrDefault(
                s => s.PaymentType.Equals(type, StringComparison.OrdinalIgnoreCase)
            );

            if (service == null)
                throw new ArgumentException("Invalid payment type");

            return service;
        }
    }
}
