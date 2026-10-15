# 🏥 CareHub — Hospital Management System

**A modern ASP.NET Core MVC application for managing hospital operations, medical staff, patients, and treatments.**

CareHub is a hospital management system designed to simplify everyday hospital operations through an organized, responsive, and user-friendly interface. It provides CRUD functionality for managing departments, doctors, patients, and treatments, with SQL Server integration powered by Entity Framework Core.

---

## 📌 Table of Contents

- [Overview](#-overview)
- [Features](#-features)
- [Technology Stack](#-technology-stack)
- [Project Structure](#-project-structure)
- [Prerequisites](#-prerequisites)
- [Getting Started](#-getting-started)
- [Database Configuration](#-database-configuration)
- [Application Routes](#-application-routes)
- [Docker Deployment](#-docker-deployment)
- [Development Notes](#-development-notes)
- [Security Considerations](#-security-considerations)
- [License](#-license)

---

## ✨ Overview

CareHub provides a centralized interface for managing essential hospital information. Built with ASP.NET Core MVC and Razor Views, the application follows the Model-View-Controller architecture and uses Entity Framework Core for database operations.

The project focuses on structured data management, maintainable application architecture, and a responsive user experience.

<img width="1613" height="1001" alt="image" src="https://github.com/user-attachments/assets/113fac30-bc9b-4ef3-8c57-1973d7f60e4f" />


## 🚀 Features

- **Hospital Dashboard** — A central entry point for hospital management.
- **Department Management** — Create, view, update, and delete hospital departments.
- **Doctor Management** — Organize and manage doctor records.
- **Patient Management** — Maintain patient information.
- **Treatment Management** — Manage treatment records associated with doctors and patients.
- **CRUD Operations** — Dedicated workflows for creating, viewing, editing, and deleting records.
- **Responsive UI** — Bootstrap-based interface for different screen sizes.
- **About Page** — Displays information about the hospital.
- **Database Integration** — SQL Server persistence using Entity Framework Core.
- **MVC Architecture** — Separation of controllers, models, views, and data access logic.

## 🛠️ Technology Stack

| Technology | Purpose |
|---|---|
| C# | Application programming language |
| .NET 10 | Application platform |
| ASP.NET Core MVC | Web application framework |
| Razor Views | Dynamic server-rendered pages |
| Entity Framework Core 10 | Object-relational mapping (ORM) |
| SQL Server / LocalDB | Relational database |
| Bootstrap | Responsive UI styling |
| JavaScript | Client-side interactions |
| CSS | Custom styling |
| Docker | Containerization support |

## 📂 Project Structure

```text
hospital/
├── Controllers/                  # MVC controllers and actions
├── Data/                         # Database context and data access
├── Models/                       # Domain models
├── Views/                        # Razor views
├── wwwroot/                      # CSS, JavaScript, and static assets
├── Program.cs                    # Application entry point and routing
├── appsettings.json              # Application configuration
├── Dockerfile                    # Docker build configuration
└── hospital.csproj               # Project and package configuration
```

## 📋 Prerequisites

Before running CareHub, make sure you have the following installed:

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- [Visual Studio](https://visualstudio.microsoft.com/) with the ASP.NET and web development workload, or a compatible code editor
- SQL Server LocalDB or a compatible SQL Server instance
- [Docker Desktop](https://www.docker.com/products/docker-desktop/) (optional, for containerized execution)

> **Note:** Visual Studio is optional if you prefer using the .NET CLI and another compatible editor.

## ⚙️ Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/ghiadamohammedlap2482026-boop/hospital_management-system.git
cd hospital_management-system
```

### 2. Restore Dependencies

```bash
dotnet restore
```

### 3. Configure the Database

Verify the SQL Server connection string and ensure the database is available before starting the application.

See [Database Configuration](#-database-configuration) for details.

### 4. Build the Application

```bash
dotnet build
```

### 5. Run the Application

```bash
dotnet run
```

Open the local HTTP or HTTPS URL displayed in the terminal.

The default application route is:

```text
/Home/Index
```

## 🗄️ Database Configuration

CareHub uses Entity Framework Core to communicate with SQL Server.

The current database context is located at:

```text
Data/Hospital_db_context.cs
```

The application uses a LocalDB connection similar to the following:

```text
Server=(localdb)\MSSQLLocalDB;Database=Hospital_db;Trusted_Connection=True;TrustServerCertificate=True;
```

### Database Setup

1. Ensure SQL Server LocalDB or your chosen SQL Server instance is installed and available.
2. Configure the connection string for your environment.
3. Create the `Hospital_db` database.
4. Apply the required Entity Framework Core migrations, if available, or create the required tables using your existing database setup.
5. Run the application and verify that database operations work correctly.

**Important:** The database schema must match the application's entity models and relationships. Creating an empty database alone does not create the required tables.

For a different SQL Server instance, update the connection configuration accordingly.

## 🧭 Application Routes

| Section | Route |
|---|---|
| Dashboard | `/Home/Index` |
| About Hospital | `/Home/About` |
| Departments | `/Department/Departments` |
| Doctors | `/Doctor/Index` |
| Patients | `/Patient/Patient` |
| Treatments | `/Treatment/Treatments` |

These routes represent the application's configured MVC endpoints and may depend on controller actions and routing configuration.

## 🐳 Docker Deployment

CareHub includes a `Dockerfile` for containerized execution.

### Build the Docker Image

```bash
docker build -t carehub-hospital .
```

### Run the Container

```bash
docker run --rm -p 8080:8080 carehub-hospital
```

If the Docker configuration and database connection are set up correctly, the application should be accessible at:

```text
http://localhost:8080
```

**Database note:** A container does not automatically have access to your host machine's LocalDB instance. Configure a reachable SQL Server instance and supply the appropriate connection string when running in Docker.

## 🧑‍💻 Development Notes

- Follow the MVC structure when adding new features.
- Keep database access logic organized within the data layer.
- Validate incoming data and handle database errors appropriately.
- Run `dotnet build` after making changes to verify that the project compiles.
- If Visual Studio Hot Reload reports an Edit and Continue (`ENC`) error after changing Razor views, stop debugging and restart the application.
- Confirm that the database schema and entity relationships remain consistent when modifying models.

## 🔐 Security Considerations

- Never commit passwords, API keys, or production database credentials.
- Store environment-specific settings in configuration files that do not contain secrets.
- Use .NET User Secrets during local development when appropriate.
- Use environment variables or a dedicated secrets manager in production.
- Enable appropriate authentication, authorization, and input validation before exposing sensitive hospital data.
- Use HTTPS and secure database connections in production.

> **Production readiness:** This repository's documented functionality does not, by itself, establish that the application includes authentication, authorization, or healthcare compliance controls. Review and implement the protections required by your deployment environment before using real patient information.

## 📄 License

No license has currently been specified for this project. Unless a license is added, reuse and redistribution are not automatically permitted.

---

**Built with ASP.NET Core MVC, Entity Framework Core, and SQL Server.**

⭐ If you find this project useful, consider giving the repository a star on GitHub.
