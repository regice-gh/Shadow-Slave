using Microsoft.EntityFrameworkCore;
using ShadowSlave.Shared.Models;

public class ShadowSlaveDbContext : DbContext
{
    public ShadowSlaveDbContext(DbContextOptions<ShadowSlaveDbContext> options)
        : base(options) { }

    // --- Core Entities ---
    public DbSet<Awakened> Awakeneds { get; set; }
    public DbSet<Aspect> Aspects { get; set; }
    public DbSet<AspectAbility> AspectAbilities { get; set; }
    public DbSet<Flaw> Flaws { get; set; }
    public DbSet<Clan> Clans { get; set; }
    public DbSet<SoulAttribute> SoulAttributes { get; set; }

    // --- Inventory & Summons ---
    public DbSet<Memory> Memories { get; set; }
    public DbSet<Enchantment> Enchantments { get; set; }
    public DbSet<Echo> Echoes { get; set; }

    // --- World Data ---
    public DbSet<Location> Locations { get; set; }
    public DbSet<NightmareCreature> NightmareCreatures { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // --- Awakened Configuration ---
        modelBuilder.Entity<Awakened>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
            entity.Property(e => e.TrueName).HasMaxLength(100); // Nullable, as not all have True Names [4]

            // Enum Conversions: Store Ranks/Classes as Strings for readability in DB
            entity.Property(e => e.Rank).HasConversion<string>();
            entity.Property(e => e.Class).HasConversion<string>();

            // Relationships
            // An Awakened has one unique Aspect
            entity.HasOne(e => e.Aspect)
                  .WithOne()
                  .HasForeignKey<Awakened>(e => e.AspectId)
                  .OnDelete(DeleteBehavior.Cascade);

            // An Awakened has one unique Flaw
            entity.HasOne(e => e.Flaw)
                  .WithOne()
                  .HasForeignKey<Awakened>(e => e.FlawId)
                  .OnDelete(DeleteBehavior.Cascade);

            // Clan Relationship (Nullable)
            entity.HasOne(e => e.Clan)
                  .WithMany(c => c.Members)
                  .HasForeignKey(e => e.ClanId)
                  .OnDelete(DeleteBehavior.SetNull);
        });

        // --- Memory Configuration ---
        modelBuilder.Entity<Memory>(entity =>
        {
            entity.Property(e => e.Rank).HasConversion<string>();
            entity.Property(e => e.Type).HasConversion<string>();

            // Lore Rule: Memories are destroyed when the owner dies [1].
            entity.HasOne<Awakened>()
                  .WithMany(a => a.Memories)
                  .HasForeignKey(m => m.OwnerId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        // --- Enchantment Configuration ---
        modelBuilder.Entity<Enchantment>(entity =>
        {
            // Enchantments belong to a specific Memory
            entity.HasOne(e => e.Memory)
                  .WithMany(m => m.Enchantments)
                  .HasForeignKey(e => e.MemoryId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        // --- Echo Configuration ---
        modelBuilder.Entity<Echo>(entity =>
        {
            entity.Property(e => e.Rank).HasConversion<string>();
            entity.Property(e => e.Class).HasConversion<string>();

            // Echoes belong to an owner
            entity.HasOne<Awakened>()
                  .WithMany(a => a.Echoes)
                  .HasForeignKey(e => e.OwnerId)
                  .OnDelete(DeleteBehavior.Cascade);

            // Echoes have attributes (Many-to-Many relationship usually, or 1:Many)
            entity.HasMany(e => e.Attributes)
                  .WithOne()
                  .HasForeignKey("EchoId");
        });

        // --- Aspect Configuration ---
        modelBuilder.Entity<Aspect>(entity =>
        {
            entity.Property(e => e.AspectRank).HasConversion<string>();

            // Aspect has multiple abilities unlocking at different ranks
            entity.HasMany(a => a.Abilities)
                  .WithOne()
                  .HasForeignKey(b => b.AspectId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        // --- Aspect Ability Configuration ---
        modelBuilder.Entity<AspectAbility>(entity =>
        {
            entity.Property(e => e.UnlockRank).HasConversion<string>();
        });

        // --- Nightmare Creature Configuration ---
        modelBuilder.Entity<NightmareCreature>(entity =>
        {
            entity.Property(e => e.Rank).HasConversion<string>();
            entity.Property(e => e.Class).HasConversion<string>();
        });

        // --- Location Configuration ---
        modelBuilder.Entity<Location>(entity =>
        {
            entity.Property(e => e.Type).HasConversion<string>();
        });
    }
}