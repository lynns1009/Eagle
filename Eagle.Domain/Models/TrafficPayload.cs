﻿using System;
using System.Runtime.Serialization;

namespace Eagle.Domain.Models
{
    public class TrafficPayload
    {
        [DataMember(Name = "id")]
        public Guid EagleBotGuid { get; set; }

        [DataMember(Name = "latitude")]
        public double Latitude { get; set; }

        [DataMember(Name = "longitude")]
        public double Longitude { get; set; }

        [DataMember(Name = "date")]
        public DateTime Date { get; set; }

        [DataMember(Name = "roadName")]
        public String RoadName { get; set; }

        [DataMember(Name = "direct")]
        public String Direction { get; set; }

        [DataMember(Name = "rate")]
        public double Rate { get; set; }

        [DataMember(Name = "averageSpeed")]
        public double AverageSpeed { get; set; }

    }
}
