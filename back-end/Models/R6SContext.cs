

using back_end.Models;
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

    #region many-many tables
    public DbSet<OperatorGadget> OperatorGadget { get; set; }
    public DbSet<OperatorSecondaryWeapon> operatorSecondaryWeapon { get; set; }
    public DbSet<OperatorPrimaryWeapon> OperatorPrimaryWeapon { get; set; }
    #endregion

    public DbSet<PrimaryWeapon> PrimaryWeapon {get ;set ;}
    public DbSet<SecondaryWeapon> SecondaryWeapon { get; set; }
    public DbSet<Side> Side { get; set; }
    public DbSet<Squad> Squad { get; set; }
    public DbSet<WeaponType> WeaponType { get; set; }




    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        #region Gamemode relationship 
        modelBuilder.Entity<GameMode>(e =>
        {
            e.HasKey(g => g.GameModeId);
        });

        #endregion

        #region Ability relationship
        modelBuilder.Entity<Ability>(e =>
        {
            e.HasKey(a => a.AbilityId);
            e.HasOne(a => a.Operator)
            .WithOne(o => o.Ability)
            .HasForeignKey<Ability>(a => a.OperatorId);

            //in this one-one relationship, the table has foreign key is "Ability" which is OperatorId
        });
        #endregion

        #region Biography relationship 
        modelBuilder.Entity<Biography>(e =>
        {
            e.HasKey(b => b.BiographyId);
            e.HasOne(e => e.Operator)
            .WithOne(o => o.Biography)
            .HasForeignKey<Biography>(o => o.OperatorId);

            //in this one-one relationship, the table has foreign key is "Biography" which is OperatorId
        });
        #endregion

        #region Gadget table 
        modelBuilder.Entity<Gadget>(e =>
        {
            e.HasKey(g => g.GadgetId);
        });
        #endregion

        #region OperatorGadget relationship
        modelBuilder.Entity<OperatorGadget>(e =>
        {
            e.HasKey(og => new { og.GadgetId, og.OperatorId });
        });

        modelBuilder.Entity<OperatorGadget>()
        .HasOne(og => og.Operator)
        .WithMany(o => o.Gadgets)
        .HasForeignKey(g => g.OperatorId);

        modelBuilder.Entity<OperatorGadget>()
        .HasOne(og => og.Gadget)
        .WithMany(g => g.Operators)
        .HasForeignKey(og => og.GadgetId);
        #endregion

        #region Operator table 
        modelBuilder.Entity<Operator>(e =>
        {
            e.HasKey(o => o.OperatorId);
        });

        #endregion

        #region PrimaryWeapon table
        modelBuilder.Entity<PrimaryWeapon>(e => 
        {
            e.HasKey(pw => pw.WeaponId);
        });
        #endregion

        #region OperatorPrimaryWeapon relationship
        modelBuilder.Entity<OperatorPrimaryWeapon>().HasKey(opw => new { opw.OperatorId, opw.PrimaryWeaponId});

        modelBuilder.Entity<OperatorPrimaryWeapon>()
        .HasOne(opw => opw.Operator)
        .WithMany(o => o.PrimaryWeapons)
        .HasForeignKey(opw => opw.OperatorId);

        modelBuilder.Entity<OperatorPrimaryWeapon>()
        .HasOne(opw => opw.PrimaryWeapon)
        .WithMany(pw => pw.Operators)
        .HasForeignKey(opw => opw.PrimaryWeaponId);
        #endregion

        #region SecondaryWeapon table
        modelBuilder.Entity<SecondaryWeapon>(e =>
        {
            e.HasKey(sw => sw.WeaponId);
        });
        #endregion

        #region OpeartorSecondaryWeapon relationship
        modelBuilder.Entity<OperatorSecondaryWeapon>(e =>
        {
            e.HasKey(osw => new {osw.OperatorId, osw.SecondaryWeaponId});
        });

        modelBuilder.Entity<OperatorSecondaryWeapon>(e => 
        {
            e.HasOne(osw => osw.Operator)
            .WithMany(o => o.SecondaryWeapons)
            .HasForeignKey(o => o.OperatorId);
        });

        modelBuilder.Entity<OperatorSecondaryWeapon>()
        .HasOne(osw => osw.SecondaryWeapon)
        .WithMany(sw => sw.Operators)
        .HasForeignKey(osw => osw.SecondaryWeaponId);
        #endregion

        #region Secondary Weapon relationship


        #endregion

        #region PrimaryWeapon table
        modelBuilder.Entity<PrimaryWeapon>(e =>
        {
            e.HasKey(pw => pw.WeaponId);
        });

        #endregion

        #region Side relationship
        modelBuilder.Entity<Side>(e =>
        {
            e.HasKey(s => s.SideId);
            e.HasMany(s => s.Operators)
            .WithOne(o => o.Side)
            .HasForeignKey(o => o.SideId);
        });
        #endregion

        #region Squad Relationship
        modelBuilder.Entity<Squad>(e =>
        {
            e.HasKey(s => s.SquadId);
            e.HasMany(s => s.Operators)
            .WithOne(o => o.Squad)
            .HasForeignKey(o => o.SquadId);
        });
        #endregion

        #region WeaponType relationship
        modelBuilder.Entity<WeaponType>(e =>
        {
            e.HasKey(w => w.WeaponTypeId);

            e.HasMany(wt => wt.PrimaryWeapons)
            .WithOne(pw => pw.WeaponType)
            .HasForeignKey(w => w.WeaponTypeId);

            e.HasMany(wt => wt.SecondaryWeapon)
            .WithOne(sw => sw.WeaponType)
            .HasForeignKey(sw => sw.WeaponTypeId);
        });
        #endregion
    }
}
