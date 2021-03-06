﻿using System;
using Covid19Radar.Common;
using Newtonsoft.Json;

namespace Covid19Radar.Models
{
    [JsonObject("userResultModel")]
    public class UserResultModel
    {
        /// <summary>
        /// Last notification date and time
        /// </summary>
        [JsonProperty("lastNotificationTime")]
        public DateTime LastNotificationTime { get; set; }
        /// <summary>
        /// Last Infection update date and time
        /// </summary>
        [JsonProperty("lastInfectionUpdateTime")]
        public DateTime LastInfectionUpdateTime { get; set; }
    }
}
