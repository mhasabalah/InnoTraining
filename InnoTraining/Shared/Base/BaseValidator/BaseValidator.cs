namespace InnoTraining.Shared;

public class BaseValidator<TEntity> : AbstractValidator<TEntity>, IValidator<TEntity>
    where TEntity : BaseEntity
{
}
