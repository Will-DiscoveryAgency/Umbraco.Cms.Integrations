﻿using Newtonsoft.Json;

namespace Umbraco.Cms.Integrations.Crm.Hubspot.Models.Dtos
{
    public class ErrorDto
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
