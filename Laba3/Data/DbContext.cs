using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<SchoolContext>
{
    public SchoolContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<SchoolContext>();
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EcommerceDb;Trusted_Connection=True;MultipleActiveResultSets=true");

        return new SchoolContext(optionsBuilder.Options);
    }
}