namespace InnoTraining.Server;

[Route("api/[controller]")]
[ApiController]

public class EmployeesController : ControllerBase
{
    private readonly ApplicationDbContext _applicationDbContext;

    public EmployeesController(ApplicationDbContext applicationDbContext) => _applicationDbContext = applicationDbContext;

    [HttpGet]
    public List<Employee> Get() => _applicationDbContext.Employees.ToList();

    [HttpGet("{id}")]
    public Employee Get(Guid id) => _applicationDbContext.Employees.FirstOrDefault(e => e.Id == id) ?? new();

    [HttpPost]
    public void Post(Employee employee)
    {
        if (employee == null) throw new ArgumentNullException();

        employee.Id = Guid.NewGuid();
        employee.BirthDate= DateTime.Now;

        _applicationDbContext.Employees.Add(employee);
        _applicationDbContext.SaveChanges();
    }

    [HttpPut]
    public Employee Put(Employee employee)
    {
        Employee? employeeFromDb = _applicationDbContext.Employees.FirstOrDefault(e=>e.Id == employee.Id);
        if (employeeFromDb is null) throw new ArgumentNullException();

        _applicationDbContext.Employees.Update(employee);
        _applicationDbContext.SaveChanges();

        return employee;
    }

    [HttpDelete("{id}")]
    public void Delete(Guid id)
    {
        Employee? employeeFromDb = _applicationDbContext.Employees.FirstOrDefault(e => e.Id == id);
        if (employeeFromDb is null) throw new ArgumentNullException();

        _applicationDbContext.Employees.Remove(employeeFromDb);
        _applicationDbContext.SaveChanges();
    }
}