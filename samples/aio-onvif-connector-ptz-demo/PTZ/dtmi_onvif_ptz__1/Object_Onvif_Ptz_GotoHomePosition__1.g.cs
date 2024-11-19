/* Code generated by Azure.Iot.Operations.ProtocolCompiler; DO NOT EDIT. */

#nullable enable

namespace PTZ.dtmi_onvif_ptz__1
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using PTZ;

    public class Object_Onvif_Ptz_GotoHomePosition__1
    {
        /// <summary>
        /// A reference to the MediaProfile where the operation should take place.
        /// </summary>
        [JsonPropertyName("ProfileToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? ProfileToken { get; set; } = default;

        /// <summary>
        /// A requested speed.The speed parameter can only be specified when Speed Spaces are available for the PTZ Node.
        /// </summary>
        [JsonPropertyName("Speed")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Object_Onvif_Ptz_PTZSpeed__1? Speed { get; set; } = default;

    }
}
