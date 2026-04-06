using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker.Domain.Entities
{
    public class Habit
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public HabitCategory Category { get; set; }
    }

    public enum HabitCategory
    {
        Gym,
        Coding,
        Nutrition,
        Communication
    }
}
