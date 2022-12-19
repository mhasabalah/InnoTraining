namespace InnoTraining.Shared;

public class BaseSettingValidator<TEntity> : BaseValidator<TEntity>, IValidator<TEntity>
    where TEntity : BaseSettingsEntity
{
    public BaseSettingValidator()
    {
        RuleFor(e => e.Name).NotEmpty().MaximumLength(20);
    }
}
