using System;
using System.Collections.Generic;
using System.Text;

namespace EvntsAndDelegates
{
    class MailService
    {
        
        
            public void OnvideoEncoded(object src, VideoEventArgs e)
            {
                Console.WriteLine("MailService : Sending an email..." + e.Video.Title);
            }
        
    }
}
