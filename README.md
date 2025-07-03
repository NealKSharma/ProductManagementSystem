# Product Management System - Windows Forms Application

This is a simple Product Management System developed during my training at **Tata Consultancy Services (TCS)** as part of my internship onboarding. The project helped me get started with **C#**, **Windows Forms**, **.NET Framework**, and **SQL Server**.

---

## Demonstration Video

[Click here to watch the demo video](https://NealKSharma.github.io/ProductManagementSystem/)

---

## Features

- Add new products to the database
- Update product details (name, design, color, and date)
- Delete products by `ProductID`
- Search for specific products
- View full product list in a dynamic `DataGridView`

---

## Technologies Used

- C# (.NET Framework)
- Windows Forms (WinForms)
- SQL Server (MSSQL)
- SQL Server Management Studio (SSMS)
- ADO.NET for database connectivity
- Visual Studio (Windows Forms Designer)

---

## Database Schema

The application uses a SQL Server table called `ProductInfo_Tab` with the following structure:

| Column Name | Data Type | Description            |
|-------------|------------|------------------------|
| ProductID   | INT        | Primary Key            |
| ItemName    | NVARCHAR   | Name of the item       |
| Design      | NVARCHAR   | Product design name    |
| Color       | NVARCHAR   | Product color          |
| InsertDate  | DATETIME   | Timestamp of insertion |
| UpdateDate  | DATETIME   | Timestamp of update    |

---

## Getting Started

### Prerequisites

- Visual Studio (with Windows Forms support)
- SQL Server (Express or Standard)
- SQL Server Management Studio (SSMS)
- .NET Framework 4.7 or higher

### Setup Steps

1. **Clone the repository**:

   ```bash
   git clone https://github.com/NealKSharma/ProductManagementSystem.git
   ```

2. **Open the project** in Visual Studio by launching `WindowsFormsApp1.sln`.

3. **Launch SQL Server Management Studio (SSMS)** and connect to your local database instance.

4. **Create the table** using the following SQL script:

   ```sql
   CREATE TABLE ProductInfo_Tab (
     ProductID INT PRIMARY KEY,
     ItemName NVARCHAR(50),
     Design NVARCHAR(50),
     Color NVARCHAR(30),
     InsertDate DATETIME,
     UpdateDate DATETIME
   );
   ```

5. **Update the connection string** in `Form1.cs` if your SQL Server instance is different:

   ```csharp
   SqlConnection connection = new SqlConnection("Your_Connection_String_Here");
   ```

---

## My Contributions

- Developed the full UI in Windows Forms
- Wrote and tested all CRUD operations using ADO.NET
- Designed the SQL table schema and connected via SSMS
- Demonstrated the working application via video
- Documented the full setup and code structure

---

## Learning Outcomes

This project helped me:

- Understand form design and event handling in Windows Forms
- Learn how to connect C# applications to SQL Server
- Practice CRUD operations in a real-world desktop app
- Get familiar with tools like **SSMS**, **Visual Studio**, and **ADO.NET**

---

## Author

**Neal Kaushik Sharma**  
TCS Intern | Computer Science Student at Iowa State University
[GitHub Profile →](https://github.com/NealKSharma)
