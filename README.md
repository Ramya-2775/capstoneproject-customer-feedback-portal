# Customer Feedback Portal 📝

A lightweight web-based application where customers can submit their feedback—such as suggestions, opinions, or complaints—and admins can manage and review them via a dashboard.

🔧 Tech Stack

- Framework: ASP.NET Core MVC
- Language: C#
- Database: Entity Framework Core with SQL Server
- Frontend:HTML5, Bootstrap 5, Razor Pages
- IDE:Visual Studio / VS Code

🚀 Features

🧑 For Customers:
- Submit feedback (name, email, message)
- Get confirmation of successful submission

👩‍💼 For Admins:
- View all feedback entries in tabular format
- Edit / Delete / View Details of feedbacks
- Authorization-enabled Admin Dashboard
  
📁 Folder Structure

```
Customer-Feedback-Portal/
├── Controllers/
│   ├── AdminController.cs
│   ├── HomeController.cs
│   └── FeedbacksController.cs
│
├── Models/
│   ├── Admin.cs
│   ├── Feedback.cs
│   └── ErrorViewModel.cs
│
├── Views/
│   ├── Admin/
│   │   ├── Dashboard.cshtml
│   │   └── Login.cshtml
│   │
│   ├── Feedbacks/
│   │   ├── Create.cshtml
│   │   ├── Index.cshtml
│   │   ├── Edit.cshtml
│   │   ├── Delete.cshtml
│   │   └── Details.cshtml
│   │
│   ├── Home/
│   │   ├── About.cshtml
│   │   ├── Index.cshtml
│   │   └── Privacy.cshtml
│   │
│   └── Shared/
│       ├── _Layout.cshtml
│       └── _ValidationScriptsPartial.cshtml
│
├── Data/
│   └── Customer_Feedback_PortalContext.cs
│
├── wwwroot/
│   └── (CSS, JS, images, Bootstrap files)
│
├── appsettings.json
├── Program.cs
└── Startup.cs 
```
🌐 Website Preview
![Homepage Screenshot](./Images/website.png)
---

☁️ Azure Deployment Guide

Step 1: Create an Azure App Service
1. Log in to the Azure Portal → https://portal.azure.com  
2. Click **Create a resource** > **Web App**  
3. Fill in the required fields:  
   - Name: `CustomerFeedbackPortal`  
   - Publish: `Code`  
   - Runtime stack: `.NET 8`  
   - Region: Nearest to you  
4. Click **Next**, skip Monitoring  
5. Click **Review + Create** → then **Create**

---

Step 2: Create Azure SQL Database
1. Go to **Create a resource** > **SQL Database**  
2. Fill these:  
   - Database name: `CustomerFeedbackPortalDB`  
   - Server: Click **Create new** → set admin username/password  
3. Choose **Basic** pricing tier  
4. Click **Review + Create** → **Create**  
5. Go to the **SQL Server** > **Firewalls and virtual networks**  
   - Add your current IP  
   - Enable **Allow Azure services to connect**

---

Step 3: Get the SQL Connection String
1. Open your **SQL Database** in Azure  
2. Go to **Connection Strings** tab  
3. Copy the **ADO.NET** connection string
Example Azure SQL Connection String

```txt
Server=tcp:<your-server>.database.windows.net,1433;
Initial Catalog=CustomerFeedbackPortalDB;
Persist Security Info=False;
User ID=<your-user>;
Password=<your-password>;
MultipleActiveResultSets=False;
Encrypt=True;
TrustServerCertificate=False;
Connection Timeout=30;
```
---
Step 4: Update appsettings.json
Replace your local string with Azure string like this:
```txt
"ConnectionStrings": {
  "DefaultConnection": "Your Azure SQL Connection String"
}
```
Step 5: Publish from Visual Studio
1.Right-click your project → Publish

2.Select Azure App Service (Windows)

3.Choose your existing App Service

4.Click Publish

✅ Final Testing
1.Visit your app: https://customerfeedbackportal.azurewebsites.net

2.Test form submissions and dashboard

3.Check Azure SQL Database for data entries

