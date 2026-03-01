Order System - Project Guide
Project Overview

This is a C# WinForms application for managing orders.
It uses SQL Server as the database backend.

1. Prerequisites

Before running the project, make sure the following are installed:
- Visual Studio (2019 or later recommended)
- .NET Framework (as required by the project, .NET 8.0)
- SQL Server (Express or full edition)
- SQL Server Management Studio (SSMS)


2. Setting Up the Database

- Open SQL Server Management Studio (SSMS).
- Connect to your SQL Server instance.
- Open the SQL script file OrderDB.sql included in the project.
- Execute the script to:
- Drop the database if it exists
  + Create the database OrderDB
  + Create all tables and initial data
After executing, the OrderDB database should appear in your SQL Server instance.

	+ 
3. Configuring the Project

Open the project solution file OrderSystem.sln in Visual Studio.
Check the connection string in App.config (or wherever your project stores it):

<connectionStrings>
  <add name="OrderDB" connectionString="Server=YOUR_SERVER_NAME;Database=OrderDB;Trusted_Connection=True;" providerName="System.Data.SqlClient"/>
</connectionStrings>

Replace YOUR_SERVER_NAME with your SQL Server instance name (e.g., .\SQLEXPRESS).
If using SQL Authentication, update User ID and Password in the connection string.

4. Running the Application

Set MainForm (or Program.cs) as the startup form if needed.
Press F5 (Start Debugging) or Ctrl+F5 (Run without debugging) in Visual Studio.
The Login Form will appear:
Use the default credentials if provided in the SQL script
After logging in successfully, you can access the main features.


5. Logging Out & Exiting

Press Logout in the Main Form to return to the Login Form.
Press X (Close) in the Main Form to exit the application completely.


6. Notes

- Ensure SQL Server is running before launching the app.
- If there are connection issues, double-check the connection string and server instance.
- The project works on Windows OS with .NET Framework installed.

- 
7. Contact

For any issues or questions about the project, contact me on Telegram:
	+ Tel: 0969950805
	+ username: @kdeyxd05