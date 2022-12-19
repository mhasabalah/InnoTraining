namespace InnoTraining.Server;

public class EmployeeConfigration : BaseSettingsEntityConfiguration<Employee>
{
    public override void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employees");

        builder.Property(e => e.BirthDate).IsRequired();
        builder.Property(e => e.Mobile).HasMaxLength(20);
        builder.Property(e => e.Telephone).HasMaxLength(20);

        base.Configure(builder);
    }

}