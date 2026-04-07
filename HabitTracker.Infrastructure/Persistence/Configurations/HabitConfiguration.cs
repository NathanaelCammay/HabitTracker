using HabitTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HabitTracker.Infrastructure.Persistence.Configurations;

public class HabitConfiguration : IEntityTypeConfiguration<Habit>
{
    public void Configure(EntityTypeBuilder<Habit> builder)
    {
        builder.ToTable("Habits");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Description)
            .IsRequired()
            .HasMaxLength(500);

        builder.Property(x => x.CreatedAt)
            .IsRequired();

        builder.Property(x => x.Category)
            .IsRequired();

        builder.HasData(
            new Habit
            {
                Id = 1,
                Name = "Coding",
                Description = "Track coding practice and development upskilling.",
                CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                Category = HabitCategory.Coding
            },
            new Habit
            {
                Id = 2,
                Name = "Gym",
                Description = "Track gym training sessions and physical progress.",
                CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                Category = HabitCategory.Gym
            },
            new Habit
            {
                Id = 3,
                Name = "Nutrition",
                Description = "Track nutrition habits and dietary consistency.",
                CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                Category = HabitCategory.Nutrition
            },
            new Habit
            {
                Id = 4,
                Name = "Communication",
                Description = "Track communication practice and confidence in skills/traits.",
                CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                Category = HabitCategory.Communication
            });
    }
}
