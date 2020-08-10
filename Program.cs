
using System;
using System.Collections.Generic;
using System.Text;


namespace Lab7_4_DatingSite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 7.4 Dating Game \n \n");

            //Create 2 profiles
            DatingProfile mary = new DatingProfile("Mary", "Smith", 34, "Female");
            DatingProfile john = new DatingProfile("John Q", "Public", 38, "Male");

            //print profiles
            Console.WriteLine("Profile has been created: " + mary.FirstName + " " + mary.LastName + " " + mary.Age + " " + mary.Gender);
            Console.WriteLine("Profile has been created: " + john.FirstName + " {0}", john.LastName + " " + john.Age + " " + john.Gender);

            // Call method to input bios
            Console.Write(mary.FirstName + " Please provide a short bio about yourself: ");
            mary.WriteBio(Console.ReadLine());
            Console.WriteLine("Thank you " + mary.FirstName +". Your profile will be updated with your bio information \n");

            Console.Write(john.FirstName + " Please provide a short bio about yourself: ");
            john.WriteBio(Console.ReadLine());
            Console.WriteLine("Thank you " + john.FirstName + ". Your profile will be updated with your bio information \n");


            //display bio
            Console.WriteLine("Here is your bio profile " + mary.FirstName +": " + mary.Bio);
            Console.WriteLine("Here is your bio profile " + john.FirstName + ": " + john.Bio + "\n");


            // call method to send message to John 
            mary.SendMessage("Message 1","Hi there John",john);
            mary.SendMessage("Message 2", "I like your picture. Where was it taken?", john);
           
            //read John's messages
            john.ReadMessage();

            // look at John's profile
 //           Console.WriteLine("John's profile: ");
 //           john.DisplayProfile();

        }

    }
}
