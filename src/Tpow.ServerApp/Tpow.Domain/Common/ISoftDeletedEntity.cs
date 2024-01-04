namespace Tpow.Domain.Common;

public interface ISoftDeletedEntity : IEntity
{
    bool IsDeleted { get; set; }
    
    DateTime? DeletedTime { get; set; }
}