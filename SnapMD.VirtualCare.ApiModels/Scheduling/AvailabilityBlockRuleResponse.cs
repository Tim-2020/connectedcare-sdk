﻿using System;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Availability block rule defines availability blocks repeating configuration.
    /// </summary>
    public class AvailabilityBlockRuleResponse : AvailabilityBlockRuleRequest
    {
        /// <summary>
        /// Availability block rule id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Created by user id.
        /// </summary>
        public int CreatedByUserId { get; set; }

        /// <summary>
        /// Modified by user id.
        /// </summary>
        public int? ModifiedByUserId { get; set; }

        /// <summary>
        /// Created date.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Last modified date.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }
    }
}
