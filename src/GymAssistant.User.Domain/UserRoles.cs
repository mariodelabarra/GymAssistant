using GymAssistant.Common.Domain;

namespace GymAssistant.User.Domain
{
    public class UserRoles : BaseEntity
    {
        public long UserId { get; set; }
        public Roles Rol { get; set; }
    }
}
