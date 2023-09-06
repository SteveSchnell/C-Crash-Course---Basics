﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace HelloWorld.Models
{
    public class Computer
    {
        [JsonPropertyName("computer_id")]
        public int ComputerId { get; set; }

        [JsonPropertyName("motherboard")]
        public string Motherboard { get; set; } = "";

        [JsonPropertyName("cpu_cores")]
        public int? CPUCores { get; set; } = 0;

        [JsonPropertyName("has_wifi")]
        public bool HasWiFi { get; set; }

        [JsonPropertyName("has_lte")]
        public bool HasLTE { get; set; }

        [JsonPropertyName("release_date")]
        public DateTime? ReleaseDate { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("video_card")]
        public string VideoCard { get; set; } = "";

        public Computer()
        {
        }

    }
}
