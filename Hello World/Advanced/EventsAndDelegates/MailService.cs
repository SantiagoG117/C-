using System;

namespace Advanced.EventsAndDelegates
{
    /// <summary>
    /// Responsible for sending an email once the vide is encoded
    /// </summary>
    public class MailService//? Subscriber
    {
        //? Define the event handler with the same signature defined by the delegate in the Subscriber (VideoEncoder)
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Mail Service: Sending an email..." + e.Video.Title);
        }
    }
}