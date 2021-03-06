namespace LogicAndTrick.Oy
{
    /// <summary>
    /// Represents the volume of a message (how much importance should be placed on it)
    /// </summary>
    public enum Volume
    {
        /// <summary>Low volume messages are sent to all clients.</summary>
        Low = 1,

        /// <summary>Normal volume message are sent to all clients until consumed, and then converted into a low volume message.</summary>
        Normal = 2,
        
        /// <summary>High volume messages are sent to all clients and cannot be consumed.</summary>
        High = 3,
    }
}
