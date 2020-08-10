using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7_4_DatingSite
{
    class Messages
    {
        public DatingProfile Sender;
        public string MessageTitle;
        public string MessageData;
        public bool isRead;
 //       public bool NewMessage;



        // Message constructor
        public Messages(DatingProfile sender, string messageTitle, string messageData)
        {
            this.Sender = sender;
            this.MessageTitle = messageTitle;
            this.MessageData = messageData;
            isRead = false;
            
        }


        //Methods
        public void ChangeStatus()
        {
            this.isRead = true;

        }







    }


}

