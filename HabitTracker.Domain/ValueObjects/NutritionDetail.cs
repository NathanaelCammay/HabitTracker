using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker.Domain.ValueObjects
{
    public class NutritionDetail
    {
        public int Calories { get; set; }
        public decimal ProteinGrams { get; set; }
        public int FatGrams { get; set; }
        public int CarbohydratesGrams { get; set; }
    }
}
