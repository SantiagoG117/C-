using System;

namespace Advanced.EventsAndDelegates
{
    /// <summary>
    /// Responsible for sending an SMS once the vide is encoded
    /// </summary>
    public class MessageService//? Subscriber
    {
        //?Define the event handler with the same signature defined by the delegate in the Subscriber
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Message Service: Sending an SMS" + e.Video.Title);
        }
    }
}