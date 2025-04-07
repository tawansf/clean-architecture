namespace CleanArc.Application.Abstractions;

public interface IApplicationDbContext
{
    // Add yours DbSet here
    // public DbSet<ApplicationUser> Users { get; set; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}