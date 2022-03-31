# MovieStore

Welcome to the MovieStore project! This project is being used as my final project for the Code Louisville Software Development C# course. Currently, the application allows you to create new customers, search/edit customers, view current inventory, and start the check out process. This is still a work in progress that I intend to continue working on even once the cohort has finished. The intent of the finished project is to be able to check out/check in movies that are assigned to different customers, view the due dates of any items depending on the customer you have selected, and add/remove new items to the store's inventory. Below is a list of the different features I have implemented:

- A "master loop" console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program
- Creating a list that is populated with several values, retrieved, and used in the program
- Reading data from an external JSON file and using that data to edit customer information, and view inventory information
- Using a LINQ query to retrive information from a list
- Calculating and displaying data based on an external factor (using the date that the movie is checked out, entering the number of days to have it checked out, and then displaying the due date based on the entered number of days)
