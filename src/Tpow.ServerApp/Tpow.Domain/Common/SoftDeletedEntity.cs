namespace Tpow.Domain.Common;

public class SoftDeletedEntity : Entity, ISoftDeletedEntity
{
    public bool IsDeleted { get; set; }
    
    public DateTime? DeletedTime { get; set; }
}