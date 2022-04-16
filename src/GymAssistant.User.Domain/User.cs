using GymAssistant.Common.Domain;

namespace GymAssistant.User.Domain
{
    public class User : BaseEntity
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public AddressInformation AddressInformation { get; set; } = new();
    }
}
