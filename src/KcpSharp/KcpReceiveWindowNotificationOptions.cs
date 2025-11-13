using System;
using System.Collections.Generic;
using System.Text;

namespace KcpSharp
{
    /// <summary>
    /// Options for sending receive window size notification.
    /// </summary>
    public readonly struct KcpReceiveWindowNotificationOptions
    {
        /// <summary>
        /// Create an instance of option object for receive window size notification functionality.
        /// </summary>
        /// <param name="initialInterval">The initial interval in milliseconds of sending window size notification.</param>
        /// <param name="maximumInterval">The maximum interval in milliseconds of sending window size notification.</param>
        public KcpReceiveWindowNotificationOptions(uint initialInterval, uint maximumInterval)
        {
            if (initialInterval == 0)
                throw new ArgumentOutOfRangeException(nameof(initialInterval));
            if (maximumInterval < initialInterval)
                throw new ArgumentOutOfRangeException(nameof(maximumInterval));

            InitialInterval = initialInterval;
            MaximumInterval = maximumInterval;
        }

        /// <summary>
        /// The initial interval in milliseconds of sending window size notification.
        /// </summary>
        public uint InitialInterval { get; }

        /// <summary>
        /// The maximum interval in milliseconds of sending window size notification.
        /// </summary>
        public uint MaximumInterval { get; }
    }
}
