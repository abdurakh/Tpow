namespace Tpow.Domain.Common;

public interface IAuditableEntity : IEntity
{
    DateTime CreatedTime { get; set; }
    
    DateTime? ModifiedTime { get; set; }
}