namespace InnoTraining.Shared;

public class EmployeeValidation : BaseSettingValidator<Employee>
{
	public EmployeeValidation()
	{
		RuleFor(e => e.Mobile).NotEmpty();
	}
}
