using System;

namespace Stefanini.Domain.Entities
{
    public partial class UserSys
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserRoleId { get; set; }

    }
}
