using Microsoft.EntityFrameworkCore;
namespace FlyWise.Data.Contexts;
public class FlyWiseDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=OYBEK8605;Database=myDataBase;User Id=myUsername;Password=myPassword;");
    }
}