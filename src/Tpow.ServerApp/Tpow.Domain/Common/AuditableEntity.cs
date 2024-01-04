namespace Tpow.Domain.Common;

public class AuditableEntity : SoftDeletedEntity, IAuditableEntity
{
    public DateTime CreatedTime { get; set; }
    
    public DateTime? ModifiedTime { get; set; }
}