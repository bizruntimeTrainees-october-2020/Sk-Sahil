using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace EvntsAndDelegates
{
    class VideoEventArgs : EventArgs
    {
        

        public Video Video { get ; set; }
    }
    class VideoEncoder
    {
        //define delegate
        public delegate void VideoEncodedEventHandler(object src, VideoEventArgs args);
        //define event 
        public event VideoEncodedEventHandler VideoEncoded;


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video.....");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() {Video= video});
            }
        }

    }
}
