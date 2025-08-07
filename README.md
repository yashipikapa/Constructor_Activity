Julia Yashika A. Kong & Kyla Marie Caballero  
BSIT-2 

Problem: 
Your task is to build a Book class for a simple library management system. Not all the books in the library have complete information available, so you need to design your class to handle these different scenarios.

Requirements:
Define the Book Class: Create a new class named book with the following private fields  to store information about a book. 

string title
string author 
int yearPublished
string genre

Implement Multiple Constructor: 
Your Book class must have the following four constructors. C# will automatically choose the correct one based on the number and the type of arguments you provide when creating a  new Book object.

Constructor 1 (Default):
A parameterless constructor. It should initialize all string fields to 0. This is for books where no information is available yet. 

Constructor 2 (Basic):
A constructor that  accepts only the title and author. It should initialize these two  fields and use the default  values for the remaining fields (yearPublished and genre).

Constructor 3 (Detailed):
A constructor that accepts the title, author and yearPublished. It should initialize the three fields and  use the default value for the genre. 

Constructor 4 (Complete): 
A constructor that accept all four fields: title, author, yearPublished, and genre.

Create a DisplayBookInfo()
Method: Add a public method toi your Book class claed DisplayBookInfo(). This method should gently neatly print all the details of the book to the console, similar to the format below:

Title: The Hobbit 
Author: J.R.R. Tolkien 
Year Published: 1937
Genre: Fantasy
Test Your Implementation: In your Main method (Program.cs), create at least one Book object using each of the four constructors. After creating each object, call the DisplayBookInfo() method to prove that each constructor successfully initialized the object with the correct data.
