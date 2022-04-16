namespace GymAssistant.User.Domain
{
    public class AddressInformation
    {
        public long UserId { get; set; }
        public string? Street1 { get; set; }
        public string? Street2 { get; set; }
        public long CountryId { get; set; }
        public long StateId { get; set; }
    }
}
