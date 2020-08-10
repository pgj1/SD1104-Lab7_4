LAB: The Dating Game
Lesson Time: 3 Hours

It’s time to practice OOP hands on. In this lab, we are going to put to work what’ve we’ve learned by 
creating classes for a dating website. This is a big lab, so feel free to work with partners or with 
your instructor as a group to complete it.

The Scenario:
You work for a company that operates a dating website. You’ve been asked to create 
C# classes that the web site will use to help online daters find their match! You work 
on a team, so another developer will be taking the code you create and output it to 
the web--your only job is to write the class code. Let’s get started!

PART 1 - Create the Dating Profile.
1. Create a new class called DatingProfile.

2. Dating Profile will have the following properties
	● Public string First Name
	● Private string Last Name
	● Public int Age
	● Public string Gender
	● Public string Bio

3. DatingProfile needs a constructor that lets us fill out firstname, lastname, age, and gender of the profile.

4. Dating Profile will have the following methods
	● WriteBio(string text) - This will let the user write their bio text to their profile.
	● ReadMessage() - This will let the user read their messages.
	● SendMessage(string MessageTitle, string MessageData, DatingProfile toProfile)
	The send message method takes another Dating Profile as input and some text of the message.


Part 2 - Create the Message Class
Next, create a Message Class that will represent the messages.

1. Create a new class called Messages

2. Messages will have the following properties
	● Public DatingProfile sender
	● Public string MessageTitle
	● Public string MessageData
	● Private bool isRead

3. Create a constructor that sets the value for sender, title, and message data. The isRead should default to false.


Part 3 - Add Message List of the Dating Profile
Next, back in our Dating Profile, add a new public property called MyMessages. 
This property will be a LIST of messages. Remember to add using System.Generic.Collections to get access to a list.

In the Dating Profile, create the SendMessages method. It will create a new message and then Add the message 
to the other Dating Profiles List of Messages.

Finally, in Dating profile, add another method called ReadMessages. It should print all unread 
messages to the console and mark the message as isRead true.

Testing the classes.
To test everything, in the Program Main Method, create two Dating Profiles.
Have one dating profile send a message to the other dating profile
Have the second dating profile read their messages.
To view the solution, download the 7_4 dating game project