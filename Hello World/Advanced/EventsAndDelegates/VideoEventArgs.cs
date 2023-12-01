using System;

namespace Advanced.EventsAndDelegates
{
    /// <summary>
    /// Class that contains data about the video that was encoded
    /// </summary>
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}