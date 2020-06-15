using System.Collections.Generic;
using MarcusW.VncClient.Protocol.Encodings;
using MarcusW.VncClient.Protocol.Services;

namespace MarcusW.VncClient.Protocol
{
    /// <summary>
    /// Provides access to different elements of a RFB protocol implementation.
    /// </summary>
    public interface IRfbProtocolImplementation
    {
        /// <summary>
        /// Gets the supported encodings.
        /// </summary>
        IReadOnlyCollection<IEncoding> SupportedEncodings { get; }

        /// <summary>
        /// Creates a new <see cref="ITransportConnector"/>.
        /// </summary>
        /// <param name="context">Details about the associated connection.</param>
        /// <returns>A new instance of the transport connector.</returns>
        ITransportConnector CreateTransportConnector(RfbConnectionContext context);

        /// <summary>
        /// Creates a new <see cref="IRfbHandshaker"/>.
        /// </summary>
        /// <param name="context">Details about the associated connection.</param>
        /// <returns>A new instance of the RFB handshaker.</returns>
        IRfbHandshaker CreateRfbHandshaker(RfbConnectionContext context);

        /// <summary>
        /// Creates a new <see cref="IRfbMessageReceiver"/>.
        /// </summary>
        /// <param name="context">Details about the associated connection.</param>
        /// <returns>A new instance of the message receiver.</returns>
        IRfbMessageReceiver CreateMessageReceiver(RfbConnectionContext context);

        /// <summary>
        /// Creates a new <see cref="IRfbMessageSender"/>.
        /// </summary>
        /// <param name="context">Details about the associated connection.</param>
        /// <returns>A new instance of the message sender.</returns>
        IRfbMessageSender CreateMessageSender(RfbConnectionContext context);
    }
}
