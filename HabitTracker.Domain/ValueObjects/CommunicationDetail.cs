using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker.Domain.ValueObjects
{
    public class CommunicationDetail
    {
        public string SkillFocusedOn { get; set; } = string.Empty;
        public int ConfidenceScore { get; set; }
        public string Reflection { get; set; } = string.Empty;
    }
}
