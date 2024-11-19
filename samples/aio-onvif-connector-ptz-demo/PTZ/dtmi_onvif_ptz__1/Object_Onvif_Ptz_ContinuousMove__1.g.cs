/* Code generated by Azure.Iot.Operations.ProtocolCompiler; DO NOT EDIT. */

#nullable enable

namespace PTZ.dtmi_onvif_ptz__1
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using PTZ;

    public class Object_Onvif_Ptz_ContinuousMove__1
    {
        /// <summary>
        /// A reference to the MediaProfile.
        /// </summary>
        [JsonPropertyName("ProfileToken")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string? ProfileToken { get; set; } = default;

        /// <summary>
        /// An optional Timeout parameter.
        /// </summary>
        [JsonPropertyName("Timeout")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public TimeSpan? Timeout { get; set; } = default;

        /// <summary>
        /// A Velocity vector specifying the velocity of pan, tilt and zoom.
        /// </summary>
        [JsonPropertyName("Velocity")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public Object_Onvif_Ptz_PTZSpeed__1? Velocity { get; set; } = default;

    }
}
