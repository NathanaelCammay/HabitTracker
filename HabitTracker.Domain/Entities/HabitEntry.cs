using HabitTracker.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker.Domain.Entities
{
    public class HabitEntry
    {
        public int Id { get; private set; }
        public int HabitId { get; private set; }
        public DateTime DateLogged { get; private set; }

        public GymSession? GymSession { get; private set; }
        public CodingSession? CodingSession { get; private set; }
        public NutritionDetail? NutritionDetail { get; private set; }
        public CommunicationDetail? CommunicationDetail { get; private set; }

        private HabitEntry() { }

        public static HabitEntry CreateGymEntry(int habitId, GymSession gymSession)
        {
            return new HabitEntry
            {
                HabitId = habitId,
                DateLogged = DateTime.UtcNow,
                GymSession = gymSession
            };
        }

        public static HabitEntry CreateCodingEntry(int habitId, CodingSession codingSession)
        {
            return new HabitEntry
            {
                HabitId = habitId,
                DateLogged = DateTime.UtcNow,
                CodingSession = codingSession
            };
        }

        public static HabitEntry CreateNutritionEntry(int habitId, NutritionDetail nutritionDetail)
        {
            return new HabitEntry
            {
                HabitId = habitId,
                DateLogged = DateTime.UtcNow,
                NutritionDetail = nutritionDetail
            };
        }

        public static HabitEntry CreateCommunicationEntry(int habitId, CommunicationDetail communicationDetail)
        {
            return new HabitEntry
            {
                HabitId = habitId,
                DateLogged = DateTime.UtcNow,
                CommunicationDetail = communicationDetail
            };
        }
    }
}
