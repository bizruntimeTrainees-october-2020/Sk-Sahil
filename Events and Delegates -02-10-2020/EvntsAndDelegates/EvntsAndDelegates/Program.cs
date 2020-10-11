using System;
using System.Reflection;

namespace EvntsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "video 1" };
            var videoEncoder = new VideoEncoder();   //publisheer
          
            var mailservice = new MailService();   //subscriber
            var messageservice = new MessageService(); //subs
            videoEncoder.VideoEncoded += messageservice.OnvideoEncoded;
            videoEncoder.VideoEncoded += mailservice.OnvideoEncoded; //register a handler for the event 
            videoEncoder.Encode(video);

        }
    }
    
}
