using System;

namespace Stefanini.Domain.Views
{
    public class View_Customer
    {
        public int CustomerId { get; set; }
        public int GenderId { get; set; }



        public string Classification { get; set; }
        public string Customer { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public DateTime? LastPurchase { get; set; }
        public string Seller { get; set; }

        public int? CityId { get; set; }
        public int? RegionId { get; set; }
        public int? ClassificationId { get; set; }
        public int? SellerId { get; set; }

    }
}
