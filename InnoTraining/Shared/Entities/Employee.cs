namespace InnoTraining.Shared;

public class Employee : BaseSettingsEntity
{
    public string? Mobile { get; set; }
    public int Age { get; set; }
    public string? Telephone { get; set; }
    public DateTime BirthDate { get; set; }
}
