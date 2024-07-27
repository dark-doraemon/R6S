

using Microsoft.EntityFrameworkCore;

namespace back_end;

public class R6SContext : DbContext
{
    public R6SContext(DbContextOptions<R6SContext> options) : base(options)
    {

    }

    public DbSet<Ability> Ability{ get; set; }
    public DbSet<Biography> Biography { get; set; }
    public DbSet<Gadget> Gadget { get; set; }
    public DbSet<GameMode> GameMode { get; set; }
    public DbSet<Operator> Operator { get; set; }
    public DbSet<Side> Side { get; set; }
    public DbSet<Squad> Squad { get; set; }
    public DbSet<Weapon> Weapon { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ability>(e => 
        {
            e.HasKey(a => a.AbilityId);
        });
        modelBuilder.Entity<Biography>(e =>
        {
            e.HasKey(b => b.BiographyId);
        });
        modelBuilder.Entity<Gadget>(e =>
        {
            e.HasKey(g => g.GadgetId);
        });
        modelBuilder.Entity<GameMode>(e =>
        {
            e.HasKey(g =>g.GameModeId); 
        });
        modelBuilder.Entity<Operator>(e =>
        {
            e.HasKey(o => o.OperatorId);    
        });
        modelBuilder.Entity<Side>(e =>
        {
            e.HasKey(s => s.SideId);
        });
        modelBuilder.Entity<Squad>(e =>
        {
            e.HasKey(s => s.SquadId);
        });
        modelBuilder.Entity<Weapon>(e =>
        {
            e.HasKey(w => w.WeaponId);
        });
    }
}
