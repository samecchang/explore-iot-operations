/* Code generated by Azure.Iot.Operations.ProtocolCompiler; DO NOT EDIT. */

#nullable enable

namespace PTZ.dtmi_onvif_ptz__1
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using PTZ;

    public class SendAuxiliaryCommandResponsePayload : IJsonOnDeserialized, IJsonOnSerializing
    {
        /// <summary>
        /// The Command response argument.
        /// </summary>
        [JsonPropertyName("SendAuxiliaryCommandResponse")]
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        [JsonRequired]
        public Object_Onvif_Ptz_SendAuxiliaryCommandResponse__1 SendAuxiliaryCommandResponse { get; set; } = default!;

        void IJsonOnDeserialized.OnDeserialized()
        {
            if (SendAuxiliaryCommandResponse is null)
            {
                throw new ArgumentNullException("SendAuxiliaryCommandResponse field cannot be null");
            }
        }

        void IJsonOnSerializing.OnSerializing()
        {
            if (SendAuxiliaryCommandResponse is null)
            {
                throw new ArgumentNullException("SendAuxiliaryCommandResponse field cannot be null");
            }
        }
    }
}
