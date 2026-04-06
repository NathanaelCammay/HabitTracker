using System;

namespace HabitTracker.Domain.ValueObjects
{
    public sealed record CommunicationDetail
    {
        public string SkillFocusedOn { get; }
        public int ConfidenceScore { get; }
        public string Reflection { get; }

        public CommunicationDetail(string skillFocusedOn, int confidenceScore, string reflection)
        {
            if (string.IsNullOrWhiteSpace(skillFocusedOn))
            {
                throw new ArgumentException("Skill focus is required.", nameof(skillFocusedOn));
            }

            if (confidenceScore < 1 || confidenceScore > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(confidenceScore), "Confidence score must be between 1 and 10.");
            }

            if (string.IsNullOrWhiteSpace(reflection))
            {
                throw new ArgumentException("Reflection is required.", nameof(reflection));
            }

            SkillFocusedOn = skillFocusedOn;
            ConfidenceScore = confidenceScore;
            Reflection = reflection;
        }
    }
}
