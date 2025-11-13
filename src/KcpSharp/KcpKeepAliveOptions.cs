using System;

namespace KcpSharp
{
    /// <summary>
    /// Options for customized keep-alive functionality.
    /// </summary>
    public readonly struct KcpKeepAliveOptions
    {
        /// <summary>
        /// Create an instance of option object for customized keep-alive functionality.
        /// </summary>
        /// <param name="sendInterval">The minimum interval in milliseconds between sending keep-alive messages.</param>
        /// <param name="gracePeriod">When no packets are received during this period (in milliseconds), the transport is considered to be closed.</param>
        public KcpKeepAliveOptions(uint sendInterval, uint gracePeriod)
        {
            if (sendInterval == 0)
                throw new ArgumentOutOfRangeException(nameof(sendInterval));
            if (gracePeriod == 0)
                throw new ArgumentOutOfRangeException(nameof(gracePeriod));

            SendInterval = sendInterval;
            GracePeriod = gracePeriod;
        }

        /// <summary>
        /// The minimum interval in milliseconds between sending keep-alive messages.
        /// </summary>
        public uint SendInterval { get; }

        /// <summary>
        /// When no packets are received during this period (in milliseconds), the transport is considered to be closed.
        /// </summary>
        public uint GracePeriod { get; }
    }
}
