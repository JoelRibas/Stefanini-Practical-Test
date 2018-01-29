using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stefanini.Domain.QueryParameter
{
    public class CustomerQueryParameter
    {
        public string Name { get; set; }
        public int? GenderId { get; set; }
        public int? CityId { get; set; }
        public int? RegionId { get; set; }
        public DateTime? LastPurchaseStart { get; set; }
        public DateTime? LastPurchaseEnd { get; set; }
        public int? ClassificationId { get; set; }
        public int? UserId { get; set; }
    }
}
