using System;
using System.Collections.Generic;
using System.Text;

namespace EvntsAndDelegates
{
    class MessageService
    {
        public void OnvideoEncoded(object src, VideoEventArgs e)
        {
            Console.WriteLine("MesseageService : Sending an text message..." + e.Video.Title);
        }
    }
}
