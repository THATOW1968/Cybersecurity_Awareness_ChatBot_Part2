# Cybersecurity_Awareness_ChatBot_Part2
# Cybersecurity Awareness ChatBot Presentation

## Project Introduction

This project is a cybersecurity chatbot application designed to help users learn about online threats and digital safety.

The chatbot interacts with users through a graphical user interface and responds to cybersecurity-related questions.

The system also includes memory features where it remembers usernames and user interests.

The project demonstrates programming concepts such as file handling, object-oriented programming, event-driven programming, and GUI development.

## Project Objectives

The objectives of this project were:

* To create a chatbot that educates users about cybersecurity.
* To build an interactive and user-friendly interface.
* To store user information using text files.
* To implement chatbot memory and recall features.
* To improve interaction using intelligent chatbot responses.

## Technologies Used

The project was developed using:

* C# programming language
* Windows Presentation Foundation, also known as WPF
* XAML for graphical interface design
* Text file handling for data storage
* Object-Oriented Programming principles

These technologies helped create both the logic and the user interface of the chatbot.
## MainWindow.xaml

MainWindow.xaml is responsible for the graphical user interface.

This file contains:

* Buttons
* Textboxes
* Grids
* Chat areas
* Styling and colors

The interface uses gradient backgrounds and custom button styles to create a modern appearance.

Different grids are used for:

* Home screen
* Username screen
* Chat screen

This improves navigation and user experience.

## MainWindow.xaml.cs

This file contains the main chatbot logic.

Its responsibilities include:

* Processing user messages
* Detecting keywords
* Displaying chatbot responses
* Saving user interests
* Validating user input
* Handling chatbot memory

This class acts as the brain of the application.

## respond.cs Class

The respond.cs class stores chatbot answers and ignored words.

It uses ArrayLists to:

* Store chatbot responses
* Store ignored words

The chatbot contains multiple responses for each keyword to make conversations feel more natural.

I also improved the chatbot by preventing repeated responses.

## user_name.cs Class

The user_name.cs class manages usernames.

Its functions include:

* Checking if a user already exists
* Saving usernames into text files
* Welcoming returning users

The system uses file handling methods such as:

* File.Exists()
* File.AppendAllText()
* File.ReadAllLines()

This allows the chatbot to remember users even after the application closes.
## voice_greeting.cs Class

This class is responsible for voice greetings.

It uses the SoundPlayer class to play an audio greeting when the chatbot starts.

This feature improves:

* User interaction
* Accessibility
* User experience

The chatbot automatically plays the greeting sound during startup.

## Keyword Detection Logic

The chatbot uses keyword detection to understand user questions.

The process works as follows:

* The user enters a message.
* The message is converted to lowercase.
* The chatbot searches for matching keywords.
* The best matching keyword is selected.
* A response is chosen from stored answers.

The chatbot also uses longest-match logic to improve accuracy.

## Memory and Recall System

One of the advanced features of this project is memory and recall.

The chatbot can:

* Save user interests
* Store them in a text file
* Recall them later during conversations

For example:
If the user says:
“I like gaming and cybersecurity”

The chatbot saves these interests and later reminds the user about them.

A HashSet is used to prevent duplicate interests from being stored.

## Non-Repeating Response System

Initially, the chatbot repeated the same responses frequently.

To solve this problem:

* I created a usedResponses list.
* Previously used responses are temporarily stored.
* The chatbot avoids selecting the same response repeatedly.

When all responses are used, the list resets automatically.

This makes the chatbot feel more intelligent and realistic.

## Input Validation

The chatbot includes input validation to improve reliability.

The system:

* Checks for empty input
* Removes unnecessary special characters
* Prevents invalid messages

This improves stability and reduces errors during execution.

## Programming Techniques Used

Several programming techniques were used in this project, including:

* Object-Oriented Programming
* Lists and ArrayLists
* Randomized response generation
* File handling
* Event-driven programming
* String manipulation
* Input validation

These techniques helped improve both functionality and performance.
## Challenges and Solutions

During development, several challenges were encountered.

The first challenge was repeated chatbot responses.
This was solved using a tracking list.

The second challenge was duplicate interests.
This was solved using a HashSet.

Another challenge was keyword conflicts.
This was fixed using longest-match logic.

Finally, invalid input was handled using validation techniques.
## Conclusion

In conclusion, the Cybersecurity Awareness ChatBot successfully demonstrates practical software development skills.

The project combines:

* User interface design
* Chatbot logic
* Memory systems
* File handling
* Cybersecurity awareness

The chatbot helps users learn about online safety while providing an interactive experience.


