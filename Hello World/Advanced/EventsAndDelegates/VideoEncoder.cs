using System;
using System.Threading;

namespace Advanced.EventsAndDelegates
{
    /*
     * Events:
     *      - A mechanism for communication between objects. When something happen inside an object, it can notify
     *       other objects about it.
     *      - They are used in building Loosely Coupled Applications
     *      - Help to extend applications
     *
     * Implement an event in the video encoder, such that when the encoding process is finish, it will notify all the
     * objects interested in that event. Three steps must be follow to achieve this:
     * 1. Define a delegate: A delegate is the contract/agreement between the publisher and the subscriber. It
     *    determines the signature of the event handler in the subscriber that will be called when the Publisher
     *    (Encode) publishes an event.
     * 2. Define an event based on the delegate
     * 3. Raise the event: Create a method responsible for raising the event
     *
     */
    public class VideoEncoder//?Subscriber
    {
        //? 1. Define the delegate
        /// <summary>
        /// Holds a reference to a function with a signature equal to:
        /// 
        /// VideoEncoderEventHandler(object source, EventArgs args);
        ///     source: Class that is publishing the event
        ///     args: additional data we want to send in the event (In this case we want to send a reference to the video we are encoded). The class we send must
        ///           inherit from EventArgs
        ///
        /// 
        /// </summary>
        
        public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);
        
        //? 2. Define an event based on that delegate
        /// <summary>
        /// Behind the scene, it is a list of pointers to methods.
        /// In .NET we have a delegate type called EventHandler and EventHandler<TEventArgs>.
        /// We can use this delegate to create the event instead of creating our own (public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);). 
        /// </summary>
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public event EventHandler VideoEncodedNoArgs;
        
        public void Encode(Video video)
        {
            
            Console.WriteLine("Encoding Video");
            //Simulates the encoding process
            Thread.Sleep(3000);
            
            OnVideoEncoded(video);
        }
        
        //? 3. Create a method to raise the event
        /// <summary>
        /// It is responsible to notify the subscribers about the occurrence of an event
        /// </summary>
        /// <param name="video"></param>
        protected virtual void OnVideoEncoded(Video video)
        {
            //* Looks at VideoEncoded and check the methods that are being pointed by VideoEncoded
            if (VideoEncoded != null)
            {
                //* Calls the pointers to the event handler methods in the subscribers of the Publisher
                VideoEncoded(this, new VideoEventArgs(){Video = video});
            }
        }
        
        public static void Launcher(string[] args)
        {
            var video = new Video();
            var videoEncoder = new VideoEncoder(); //?Publisher
            var mailService = new MailService(); //?Subscriber
            var messageService = new MessageService();//?Subscriber
            
            //? Register a handler (subscriber) to the VideoEncoded (Publisher) event.
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            
            videoEncoder.Encode(video);

        }
    }
    
    
}