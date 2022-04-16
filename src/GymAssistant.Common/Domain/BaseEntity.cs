namespace GymAssistant.Common.Domain
{
    public class BaseEntity
    {
        /// <summary>
        /// Id of the entity
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Created date of the current entity
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public DateTime? LastUpdatedDate { get; set; }
    }
}
