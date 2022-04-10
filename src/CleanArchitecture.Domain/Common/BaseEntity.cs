namespace CleanArchitecture.Domain.Common
{
    public class BaseEntity
    {
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
