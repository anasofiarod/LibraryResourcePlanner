\# Hi-Tech Order Management System



\## Project Overview



The Hi-Tech Order Management System is a multi-tier Windows Forms application designed to automate and centralize operations for a book distribution company. The system facilitates the management of employees, customers, inventory, and order processing through a secure, role-based interface.



This project demonstrates the implementation of enterprise-level software architecture, featuring a strict separation of concerns and utilizing multiple data access patterns, including ADO.NET (Connected and Disconnected modes) and Entity Framework 6.



\## Technical Architecture



The application is built upon a multi-tier architecture, dividing responsibilities into three distinct layers:

1\.  \*\*Presentation Layer (GUI):\*\* Manages user interaction and input validation.

2\.  \*\*Business Logic Layer (BLL):\*\* Enforces business rules and processes data.

3\.  \*\*Data Access Layer (DAL):\*\* Handles communication with the SQL Server database.



\### Key Technical Features



\* \*\*Role-Based Access Control:\*\* Security implementation restricting system functionality based on four distinct user roles: MIS Manager, Sales Manager, Inventory Controller, and Order Clerk.

\* \*\*ADO.NET Connected Mode:\*\* Utilized for real-time validation and management of Employee and User data.

\* \*\*ADO.NET Disconnected Mode:\*\* Implemented using DataSets and DataAdapters for efficient handling of Customer data and credit limit management.

\* \*\*Entity Framework 6:\*\* Employed for complex relational operations, specifically for Order processing and fulfillment.

\* \*\*Data Integrity:\*\* Comprehensive input validation to ensure data consistency and prevent redundancy.



\## Technologies Used



\* \*\*Language:\*\* C#

\* \*\*Framework:\*\* .NET Framework 4.8

\* \*\*User Interface:\*\* Windows Forms

\* \*\*Database:\*\* Microsoft SQL Server 2022

\* \*\*Data Access:\*\* Entity Framework 6, ADO.NET

\* \*\*Development Environment:\*\* Visual Studio 2022



\## System Modules



\### Human Resources \& Administration

\* \*\*User:\*\* MIS Manager

\* \*\*Functionality:\*\* Management of user credentials and employee profiles.

\* \*\*Implementation:\*\* ADO.NET Connected Architecture.



\### Sales \& Customer Management

\* \*\*User:\*\* Sales Manager

\* \*\*Functionality:\*\* Management of institutional customers (Universities and Colleges), including credit limit authorization.

\* \*\*Implementation:\*\* ADO.NET Disconnected Architecture.



\### Inventory Control

\* \*\*User:\*\* Inventory Controller

\* \*\*Functionality:\*\* Management of book inventory, including categorization, authors, and publishers.

\* \*\*Implementation:\*\* Object-oriented design handling many-to-many relationships between books and authors.



\### Order Processing

\* \*\*User:\*\* Order Clerks

\* \*\*Functionality:\*\* Creation, search, and cancellation of customer orders; generation of order confirmations.

\* \*\*Implementation:\*\* Entity Framework 6.



\## Setup and Configuration



\### Prerequisites

\* Visual Studio 2022

\* Microsoft SQL Server (Express or Developer Edition)



\### Installation Steps



1\.  \*\*Clone the Repository\*\*

&nbsp;   Clone the project source code to your local machine.



2\.  \*\*Database Configuration\*\*

&nbsp;   \* Open Microsoft SQL Server Management Studio (SSMS).

&nbsp;   \* Locate the `HiTechScripts.sql` file in the project root.

&nbsp;   \* Execute the script to create the `HiTechBooksDB` database and populate the required tables.



3\.  \*\*Connection String Configuration\*\*

&nbsp;   For security purposes, the database connection configuration is excluded from version control.

&nbsp;   \* Navigate to the `HiTechBooksManagement` directory.

&nbsp;   \* Locate the file named `App.config.template`.

&nbsp;   \* Rename this file to `App.config`.

&nbsp;   \* Open the file and update the `connectionStrings` section with your local SQL Server instance name and credentials.



4\.  \*\*Execution\*\*

&nbsp;   \* Open the `HiTechBooksManagement.sln` solution file in Visual Studio.

&nbsp;   \* Build the solution to restore NuGet packages.

&nbsp;   \* Run the application.



