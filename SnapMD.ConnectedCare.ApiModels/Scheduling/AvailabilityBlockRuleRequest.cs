﻿using System;

namespace SnapMD.ConnectedCare.ApiModels.Scheduling
{
    public class AvailabilityBlockRuleRequest
    {
        public byte EndTimeHour { get; set; }

        public byte EndTimeMinute { get; set; }

        public DateTime FromDate { get; set; }

        public int Id { get; set; }

        public int RepeatInterval { get; set; }

        public int[] RepeatOn { get; set; }

        public int RepeatPeriod { get; set; }

        public byte StartTimeHour { get; set; }

        public byte StartTimeMinute { get; set; }

        public DateTime? ToDate { get; set; }
    }
}
