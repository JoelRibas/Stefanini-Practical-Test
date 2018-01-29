using System;

namespace Stefanini.Domain.Entities
{
    public partial class UserRole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAdmin { get; set; }

    }
}
