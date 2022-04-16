namespace GymAssistant.User.Domain
{
    public class State
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int PostalCode { get; set; }
    }
}
