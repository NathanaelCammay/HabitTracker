using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker.Domain.ValueObjects
{
    public sealed record NutritionDetail(
        int Calories,
        decimal ProteinGrams,
        int FatGrams,
        int CarbohydratesGrams);
}
