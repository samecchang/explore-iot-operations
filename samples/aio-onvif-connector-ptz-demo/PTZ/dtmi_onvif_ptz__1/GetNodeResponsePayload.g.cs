/* Code generated by Azure.Iot.Operations.ProtocolCompiler; DO NOT EDIT. */

#nullable enable

namespace PTZ.dtmi_onvif_ptz__1
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using PTZ;

    public class GetNodeResponsePayload : IJsonOnDeserialized, IJsonOnSerializing
    {
        /// <summary>
        /// The Command response argument.
        /// </summary>
        [JsonPropertyName("GetNodeResponse")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        [JsonRequired]
        public Object_Onvif_Ptz_PTZNode__1 GetNodeResponse { get; set; } = default!;

        void IJsonOnDeserialized.OnDeserialized()
        {
            if (GetNodeResponse is null)
            {
                throw new ArgumentNullException("GetNodeResponse field cannot be null");
            }
        }

        void IJsonOnSerializing.OnSerializing()
        {
            if (GetNodeResponse is null)
            {
                throw new ArgumentNullException("GetNodeResponse field cannot be null");
            }
        }
    }
}
