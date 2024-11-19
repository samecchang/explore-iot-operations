/* Code generated by Azure.Iot.Operations.ProtocolCompiler; DO NOT EDIT. */

#nullable enable

namespace PTZ.dtmi_onvif_ptz__1
{
    using System;
    using System.Collections.Generic;
    using Azure.Iot.Operations.Protocol;
    using Azure.Iot.Operations.Protocol.RPC;
    using Azure.Iot.Operations.Protocol.Models;
    using PTZ;

    public static partial class Ptz
    {
        /// <summary>
        /// Specializes the <c>CommandInvoker</c> class for Command 'GetConfigurations'.
        /// </summary>
        public class GetConfigurationsCommandInvoker : CommandInvoker<EmptyJson, GetConfigurationsResponsePayload>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="GetConfigurationsCommandInvoker"/> class.
            /// </summary>
            internal GetConfigurationsCommandInvoker(IMqttPubSubClient mqttClient)
                : base(mqttClient, "GetConfigurations", new Utf8JsonSerializer())
            {
            }
        }
    }
}
