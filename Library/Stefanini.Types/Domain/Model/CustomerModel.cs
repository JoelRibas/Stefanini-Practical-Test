using System;

namespace Stefanini.Domain.Model
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        public string Classification { get; set; }
        public string Customer { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public DateTime? LastPurchase { get; set; }
        public string Seller { get; set; }
    }
}
