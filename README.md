# Patika-Week-9-MVC-Library-Management-System
![image](https://github.com/user-attachments/assets/bdb973da-5d7c-4753-be04-cf0e9e7c3b96)

Library Management System 
Project Summary
The Library Management System is an ASP.NET Core MVC application that performs management operations on books, authors, and members. The project includes functionalities for adding, editing, and deleting books, managing authors, and handling member registration/login operations. Additionally, the project utilizes the basic MVC structure to manage and present data.


Technologies Used
.NET 8.0: The main framework for the project.
ASP.NET Core MVC: Used to create model, view, and controller layers within the MVC architecture.
Entity Framework Core (Optional): Can be used for database operations. In this project, static test data has been used instead of a database.

Features
Book Management:
Add, edit, delete, and view book details.
Author Management:
Add, edit, delete, and view author details.
Member Management:
User registration and login operations.
Home & About Pages:
Informative general pages.
Footer:
A static copyright message is displayed at the bottom of the page.

Project Structure
Controllers/: Contains controllers for managing books, authors, and users.

BookController.cs: Manages book operations.
AuthorController.cs: Manages author operations.
AuthController.cs: Handles member registration and login operations.
Models/: Contains data models and ViewModels.

Book.cs: Model for books.
Author.cs: Model for authors.
User.cs: Model for members.
SignUpViewModel.cs: ViewModel for the registration form.
LoginViewModel.cs: ViewModel for the login form.
Views/: Contains Razor View files used in the project.

Book/: Pages related to book operations.
Author/: Pages related to author operations.
Auth/: Pages for user login and registration.
Shared/: Layout and partial view files.
wwwroot/: CSS, JS, resimler ve diğer statik dosyalar.
Proje Dokümantasyonu - Kütüphane Yönetim Sistemi
Proje Adı:
Kütüphane Yönetim Sistemi

Project Documentation - Library Management System
Project Name: Library Management System

Project Description:
The Library Management System is an ASP.NET Core MVC project designed for managing books, authors, and members. The system performs fundamental library management functions, such as adding, editing, and deleting books, managing authors, and handling membership operations. Additionally, it provides login and registration pages for users.

Project Configuration
Project Architecture:
The project is structured using the Model-View-Controller (MVC) architecture. The following directories form the core building blocks of the project:

Models: Contains database objects and ViewModels.
Views: Contains user interfaces for each controller.
Controllers: Contains the logic and data transport management code.
wwwroot: Contains static files like CSS, JS, and images.
Database:
Instead of a database, test data has been manually added to the project. For a real project, database integration can be implemented using Entity Framework Core.

ViewModels:
Separate ViewModel classes have been created for registration and login operations:

SignUpViewModel: Validates the data submitted in the registration form.
LoginViewModel: Handles data validation for login operations.
Routing and Configuration:
The MVC services are added and routing is configured in the Program.cs file as follows:

csharp
Kodu kopyala
app.UseRouting();
app.UseEndpoints(endpoints => {
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});
Static Files (wwwroot):
The CSS and JavaScript files used in the project are stored in the wwwroot directory. These files enhance the appearance and interactivity of the pages.

Project Functions
Book Management:
Book List: Lists all books. Editing and deleting operations can be performed here.
Book Details: Displays detailed information about a specific book.
Add Book: Allows the addition of new books.
Edit Book: Enables the modification of existing book details.
Delete Book: Confirms and deletes a book.
Author Management:
Author List: Lists all authors in the system. Authors can be deleted from here.
Author Details: Displays detailed information about a specific author.
Add/Edit Author: Allows adding new authors or updating existing author information.
Member Management:
Sign Up: Users can register through this page.
Login: Allows users to log in using their username and password.
Home and About:
The project provides home and about pages through a HomeController.
Footer:
A static "All rights reserved" message is displayed at the bottom of the page.
Testing
Manual Testing Process:

Book Operations:
Verified that new books can be added and appear in the list.
Checked that editing and deleting existing books work correctly.
Author Operations:
Tested adding, listing, editing, and deleting authors.
User Operations:
Tested registration and login pages for form validation.
Ensured that error messages display correctly when incorrect credentials are entered.
Functional Tests:

Model Binding Test: Checked if data submitted from forms correctly binds to models.
Validation Test: Ensured that validation rules work as expected on the registration and login forms.
