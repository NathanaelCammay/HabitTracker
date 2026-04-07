using HabitTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HabitTracker.Infrastructure.Persistence.Configurations;

public class HabitEntryConfiguration : IEntityTypeConfiguration<HabitEntry>
{
    public void Configure(EntityTypeBuilder<HabitEntry> builder)
    {
        builder.ToTable("HabitEntries");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.HabitId)
            .IsRequired();

        builder.Property(x => x.DateLogged)
            .IsRequired();

        builder.HasIndex(x => new { x.HabitId, x.DateLogged });

        builder.OwnsOne(x => x.GymSession, gym =>
        {
            gym.Property(p => p.WorkoutType)
                .HasMaxLength(100);

            gym.Property(p => p.DurationMinutes);

            gym.Property(p => p.WeightKg)
                .HasColumnType("decimal(18,2)");
        });

        builder.OwnsOne(x => x.CodingSession, code =>
        {
            code.Property(p => p.Language)
                .HasMaxLength(50);

            code.Property(p => p.DurationMinutes);

            code.Property(p => p.Notes)
                .HasMaxLength(1000);
        });

        builder.OwnsOne(x => x.NutritionDetail, nut =>
        {
            nut.Property(p => p.Calories);

            nut.Property(p => p.ProteinGrams)
                .HasColumnType("decimal(18,2)");

            nut.Property(p => p.FatGrams);

            nut.Property(p => p.CarbohydratesGrams);
        });

        builder.OwnsOne(x => x.CommunicationDetail, communication =>
        {
            communication.Property(p => p.SkillFocusedOn)
                .HasMaxLength(100);

            communication.Property(p => p.ConfidenceScore);

            communication.Property(p => p.Reflection)
                .HasMaxLength(1000);
        });

        builder.HasOne<Habit>()
               .WithMany()
               .HasForeignKey(x => x.HabitId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}