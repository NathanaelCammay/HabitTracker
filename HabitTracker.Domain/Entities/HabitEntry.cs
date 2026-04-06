using HabitTracker.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker.Domain.Entities
{
    public class HabitEntry
    {
        public int Id { get; set; }
        public int HabitId { get; set; }
        public DateTime DateLogged { get; set; } = DateTime.UtcNow;

        public GymSession? GymSession { get; set; }
        public CodingSession? CodingSession { get; set; }
        public NutritionDetail? NutritionDetail { get; set; }
        public CommunicationDetail? CommunicationDetail { get; set; }
    }
}
