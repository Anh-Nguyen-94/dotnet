using Microsoft.EntityFrameworkCore;

public class PetProjectContext : DbContext
{
    public PetProjectContext(DbContextOptions<PetProjectContext> options)
        : base(options)
    {
    }
}