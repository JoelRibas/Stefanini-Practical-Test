using System;

namespace Stefanini.Domain.Entities
{
    public partial class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegionId { get; set; }

    }
}
