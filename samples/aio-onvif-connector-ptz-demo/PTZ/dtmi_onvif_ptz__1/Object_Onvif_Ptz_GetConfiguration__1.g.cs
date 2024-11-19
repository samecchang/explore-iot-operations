/* Code generated by Azure.Iot.Operations.ProtocolCompiler; DO NOT EDIT. */

#nullable enable

namespace PTZ.dtmi_onvif_ptz__1
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using PTZ;

    public class Object_Onvif_Ptz_GetConfiguration__1
    {
        /// <summary>
        /// Token of the requested PTZConfiguration.
        /// </summary>
        [JsonPropertyName("PTZConfigurationToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? PTZConfigurationToken { get; set; } = default;

    }
}
