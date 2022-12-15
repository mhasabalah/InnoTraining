using InnoTraining.Shared;
using Microsoft.EntityFrameworkCore;

namespace InnoTraining.Server;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Employee> Employees { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().ToTable("OurEmployees");
        modelBuilder.Entity<Employee>().HasKey(e => e.Id);

        modelBuilder.Entity<Employee>().Property(e => e.Name).IsRequired();
        modelBuilder.Entity<Employee>().Property(e => e.BirthDate).IsRequired();
        modelBuilder.Entity<Employee>().Property(e => e.Name).HasMaxLength(50);
        modelBuilder.Entity<Employee>().Property(e => e.Mobile).HasMaxLength(20);
        modelBuilder.Entity<Employee>().Property(e => e.Telephone).HasMaxLength(20);

        base.OnModelCreating(modelBuilder);
    }


    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Employee>().ToTable("OurEmployees");














}
