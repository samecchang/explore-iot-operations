/* Code generated by Azure.Iot.Operations.ProtocolCompiler; DO NOT EDIT. */

#nullable enable

namespace PTZ.dtmi_onvif_ptz__1
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using PTZ;

    public class Object_Onvif_Ptz_GetStatus__1
    {
        /// <summary>
        /// A reference to the MediaProfile where the PTZStatus should be requested.
        /// </summary>
        [JsonPropertyName("ProfileToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? ProfileToken { get; set; } = default;

    }
}
