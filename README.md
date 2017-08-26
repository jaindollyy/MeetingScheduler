************Problem: Meeting Scheduler ****************
The problem 
Your employer has an existing system for employees to submit booking requests for 
meetings in the boardroom. Your employer has now asked you to implement an application 
for processing batches of booking requests. 

Input 
Your processing application must process input as text. The first line of the input text 
represents the company office hours, in 24-hour format, and the remainder of the input 
represents individual booking requests. Each booking request is in the following format. 
[request submission time, in the format YYYY-MM-DD HH:MM:SS] [ARCH:employee id] 
[meeting start time, in the format YYYY-MM-DD HH:MM] [ARCH:meeting duration in hours] 
A sample text input follows, to be used in your solution:

0900 1730 
2011-03-17 10:17:06 
EMP001 
2011-03-21 09:00 2 
2011-03-16 12:34:56 
EMP002 
2011-03-21 09:00 2 
2011-03-16 09:28:23 
EMP003 
2011-03-22 14:00 2 
2011-03-17 11:23:45 
EMP004 
2011-03-22 16:00 1 
2011-03-15 17:29:12 
EMP005 
2011-03-21 16:00 3 

 Output 
Your application must provide a successful booking calendar as output, with bookings being 
grouped chronologically by day. For the sample input displayed above, your system must 
provide the following output. 

2011-03-21 
09:00 11:00 
EMP002 
2011-03-22 
14:00 16:00 
EMP003 
16:00 17:00 
EMP004 
Constraints 
•	No part of a meeting may fall outside office hours. 
•	Meetings may not overlap. 
•	The booking submission application only allows one submission at a time, so that submission times are guaranteed to be unique. 
•	Bookings must be processed in the chronological order in which they were submitted. 
•	The ordering of booking submissions in the supplied input is not guaranteed. 


************Solution************
MeetingScheduler is written in Visual Studio 2017( Community version) .It contains three projects:-
1) MeetingScheduler ( Console Application to read input text file and generate output text file.)
2) MeetingScheduler (Class library for batch processor business logic and entities)
3) MeetingScheduler.Tests (Although MSTests are more preferable for Visual Studio, In this project used parameterized Tests Using NUnit3TestAdapter and Nunit Framework)

************How to run this project************

1) Open "MeetingScheduler.sln" to load the project (it is main solution file in root folder )
2) Before running the project, place the Input.txt file containing inputs in special folder Documents
3) Run the console application , it will show the output file path in console window, press enter to close the console window
4) Output.txt file will be generated in same location.
