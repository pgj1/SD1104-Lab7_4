using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Encodings.Web;

namespace Lab7_4_DatingSite
{
    class DatingProfile
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Bio { get; set; }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        private bool _lastNameSet { get; set; }
        private string _lastName { get; set; }
        private bool _messageRead { get; set; }
        private Messages _message { get; set; }
        public DatingProfile temp { get; set; }

        private List<Messages> myMessages;


        // constructor
        public DatingProfile(string firstName, string lastName, int age, string gender)
        {
            this.FirstName = firstName;
            this._lastName = lastName;
            this.Age = age;
            this.Gender = gender;
            this._lastNameSet = false;
            myMessages = new List<Messages>();
        }


        //Methods

        //Lets the user write a short bio 
        public void WriteBio(string text) 
        {
          Bio = text;
        }


        // Let's the user send a message 
        public void SendMessage(string messageTitle, string messageData, DatingProfile sentTo)
        {
            Messages message = new Messages(this, messageTitle, messageData);
            sentTo.AddToInbox(message);
        }


        // Add messages to a list
        public void AddToInbox(Messages message)
        {
            myMessages.Add(message);
            message.isRead = false;
        }



        // ReadMessage() - Let the user read their messages.
        public void ReadMessage()
        {
            foreach (Messages message in myMessages)
            {
                if (message.isRead == false)
                {
                    Console.Write(message.MessageTitle + ": ");
                    Console.WriteLine(message.MessageData + "\n");
                    message.isRead = true;
                }
            }
                
        }


        // UNABLE TO GET RECIPIENT (sentTo) TO WORK USING Console.Readline()

        // For user to send a message 
        /*   public void writeMessage(string messageTitle, string messageData, DatingProfile sentTo)
               {
                   Console.Write("Message title: ");
                   messageTitle = Console.ReadLine();

                   Console.Write("Message: ");
                   messageData = Console.ReadLine();

                   Console.Write("Recipient Profile: ");
                   temp = Console.ReadLine();
                   DatingProfile.sentTo = Console.ReadLine(sentTo);

                   _message = Messages.MessageTitle + ": " + this.MessageData;

                   Console.WriteLine("Message for " + sentTo + " " + _message + "\n");

                  this.myMessages.Add(_message);

               }

       */






        /// display profile to see variable values
        public void DisplayProfile()
        {
            Console.WriteLine(FirstName + " {0}", LastName + " " + Age + " " + Gender + " Bio text: " + Bio);
        }

        // clear the list during code test/debug
        public void ClearList()
        {
            this.myMessages.Clear();
        }


    }


 }


