using HabitTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HabitTracker.Infrastructure.Persistence.Configurations;

public class HabitEntryConfiguration : IEntityTypeConfiguration<HabitEntry>
{
    public void Configure(EntityTypeBuilder<HabitEntry> builder)
    {
        // 1. Table Name
        builder.ToTable("HabitEntries");

        // 2. Primary Key
        builder.HasKey(x => x.Id);

        // 3. Mapping the Record types as "Owned Entities"
        // This is key for Composition. It keeps everything in one table.
        builder.OwnsOne(x => x.GymSession, gym =>
        {
            gym.Property(p => p.WorkoutType).HasMaxLength(100);
            gym.Property(p => p.WeightKg).HasColumnType("decimal(18,2)");
        });

        builder.OwnsOne(x => x.CodingSession, code =>
        {
            code.Property(p => p.Language).HasMaxLength(50);
        });

        builder.OwnsOne(x => x.NutritionDetail, nut =>
        {
            nut.Property(p => p.ProteinGrams).HasColumnType("decimal(18,2)");
        });

        builder.OwnsOne(x => x.CommunicationDetail);

        // 4. Relationships
        builder.HasOne<Habit>()
               .WithMany()
               .HasForeignKey(x => x.HabitId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}