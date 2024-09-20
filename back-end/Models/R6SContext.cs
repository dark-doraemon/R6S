

using Microsoft.EntityFrameworkCore;

namespace back_end;

public class R6SContext : DbContext
{
    public R6SContext(DbContextOptions<R6SContext> options) : base(options)
    {
        
    }

    public DbSet<Ability> Ability { get; set; }
    public DbSet<Biography> Biography { get; set; }
    public DbSet<Gadget> Gadget { get; set; }
    public DbSet<GameMode> GameMode { get; set; }
    public DbSet<Operator> Operator { get; set; }
    public DbSet<Side> Side { get; set; }
    public DbSet<Squad> Squad { get; set; }
    public DbSet<Weapon> Weapon { get; set; }
    public DbSet<WeaponType> WeaponType { get; set; }
    public DbSet<OperatorGadget> OperatorGadget { get; set; }
    public DbSet<OperatorWeapon> OperatorWeapon { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GameMode>(e =>
        {
            e.HasKey(g => g.GameModeId);
        });

        modelBuilder.Entity<Ability>(e =>
        {
            e.HasKey(a => a.AbilityId);
            e.HasOne(e => e.Operator)
            .WithOne(e => e.Ability)
            .HasForeignKey<Ability>(a => a.OperatorId);
        });

        modelBuilder.Entity<Biography>(e =>
        {
            e.HasKey(b => b.BiographyId);
            e.HasOne(e => e.Operator)
            .WithOne(o => o.Biography)
            .HasForeignKey<Biography>(o => o.OperatorId);
        });

        modelBuilder.Entity<Gadget>(e =>
        {
            e.HasKey(g => g.GadgetId);
        });

        modelBuilder.Entity<OperatorGadget>(e =>
        {
            e.HasKey(og => new { og.GadgetId, og.OperatorId });
        });

        modelBuilder.Entity<OperatorGadget>()
        .HasOne(og => og.Operator)
        .WithMany(o => o.OperatorGadget)
        .HasForeignKey(g => g.OperatorId);

        modelBuilder.Entity<OperatorGadget>()
        .HasOne(og => og.Gadget)
        .WithMany( g => g.OperatorGadget)
        .HasForeignKey(og => og.GadgetId);


        modelBuilder.Entity<Operator>(e =>
        {
            e.HasKey(o => o.OperatorId);
        });

        modelBuilder.Entity<OperatorWeapon>().HasKey( ow => new {ow.OperatorId,ow.WeaponId});

        modelBuilder.Entity<OperatorWeapon>()
        .HasOne(ow => ow.Operator)
        .WithMany(o => o.OperatorWeapon)
        .HasForeignKey(ow => ow.OperatorId);

        modelBuilder.Entity<OperatorWeapon>()
        .HasOne(ow => ow.Weapon)
        .WithMany(w => w.OperatorWeapon)
        .HasForeignKey(ow => ow.WeaponId);

        modelBuilder.Entity<Weapon>(e =>
        {
            e.HasKey(w => w.WeaponId);
        });

        modelBuilder.Entity<Side>(e =>
        {
            e.HasKey(s => s.SideId);
            e.HasMany(s => s.Operators)
            .WithOne(o => o.Side)
            .HasForeignKey(o => o.SideId);  
        });

        modelBuilder.Entity<Squad>(e =>
        {
            e.HasKey(s => s.SquadId);
            e.HasMany(s => s.Operators)
            .WithOne(o => o.Squad)
            .HasForeignKey(o => o.SquadId);
        });
        
        modelBuilder.Entity<WeaponType>(e =>
        {
            e.HasKey(w => w.WeaponTypeId);
            e.HasMany(wt => wt.Weapons)
            .WithOne(w => w.WeaponType)
            .HasForeignKey(w => w.WeaponTypeId);
        });
    }
}
