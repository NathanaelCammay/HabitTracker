using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker.Domain.ValueObjects
{
    public sealed record CommunicationDetail(
        string SkillFocusedOn,
        int ConfidenceScore,
        string Reflection);
}
