using System;

namespace HabitTracker.Domain.ValueObjects
{
    public sealed record NutritionDetail
    {
        public int Calories { get; }
        public decimal ProteinGrams { get; }
        public int FatGrams { get; }
        public int CarbohydratesGrams { get; }

        public NutritionDetail(int calories, decimal proteinGrams, int fatGrams, int carbohydratesGrams)
        {
            if (calories < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(calories), "Calories cannot be negative.");
            }

            if (proteinGrams < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(proteinGrams), "Protein grams cannot be negative.");
            }

            if (fatGrams < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(fatGrams), "Fat grams cannot be negative.");
            }

            if (carbohydratesGrams < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(carbohydratesGrams), "Carbohydrates grams cannot be negative.");
            }

            Calories = calories;
            ProteinGrams = proteinGrams;
            FatGrams = fatGrams;
            CarbohydratesGrams = carbohydratesGrams;
        }
    }
}
