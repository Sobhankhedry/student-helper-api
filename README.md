# 🎓 Student Helper API

A RESTful backend API for a university student assistant application, built with **ASP.NET Core 8** and **Entity Framework Core**.

The API provides backend services for user authentication, university course schedules, weekly schedules, and examination schedules. It is designed to be consumed by the Student Helper Flutter application.

## 🚀 Overview

**Student Helper API** is the backend component of a university-oriented student management application.

The application allows students and professors to access academic information based on their university, major, role, and registered courses.

The backend exposes RESTful endpoints for:

* User registration
* User login
* University and major course schedules
* Student weekly schedules
* Examination schedules
* Professor-specific course information

## ✨ Features

* 🔐 User registration and login
* 👨‍🎓 Student and professor roles
* 🎓 University and major-based course filtering
* 📅 Weekly course schedule
* 📝 Examination schedule
* 📚 Term/course schedule
* 👨‍🏫 Professor-specific course filtering
* 🗄️ SQL Server database integration
* 🔄 Entity Framework Core migrations
* 📖 Swagger / OpenAPI support
* 🌐 CORS configuration for client applications

## 🛠️ Tech Stack

| Technology                  | Purpose                       |
| --------------------------- | ----------------------------- |
| **C#**                      | Programming language          |
| **ASP.NET Core 8**          | Web API framework             |
| **Entity Framework Core 9** | ORM                           |
| **SQL Server**              | Database                      |
| **Swagger / OpenAPI**       | API documentation and testing |
| **CORS**                    | Frontend API access           |

## 🏗️ Project Structure

```text
student-helper-api/
│
├── SoftWare_Engineering/
│   │
│   ├── Controllers/
│   │   └── UsersController.cs
│   │
│   ├── Data/
│   │   └── DBContext.cs
│   │
│   ├── Migrations/
│   │
│   ├── Models/
│   │   ├── Requests/
│   │   ├── Course.cs
│   │   ├── GetCourse.cs
│   │   ├── StudentHelperDbContext.cs
│   │   └── User.cs
│   │
│   ├── Properties/
│   │
│   ├── Program.cs
│   ├── appsettings.json
│   ├── appsettings.Development.json
│   └── SoftWare_Engineering.csproj
│
└── SoftWare_Engineering.sln
```

## 🔌 API Endpoints

Base route:

```text
/api/Users
```

### Authentication

#### Register

```http
POST /api/Users/SignUp
```

Creates a new user account.

#### Login

```http
POST /api/Users/Login
```

Authenticates an existing user.

---

### 📚 Courses

#### Get Term Courses

```http
POST /api/Users/TermCourse
```

Returns courses based on:

* University
* Major

---

### 📝 Examination Schedule

```http
POST /api/Users/Exam
```

Returns examination/course information based on:

* University
* Major
* Username

The response differs depending on whether the user is a student or professor.

---

### 📅 Weekly Schedule

```http
POST /api/Users/Weekly
```

Returns the user's weekly course schedule based on:

* University
* Major
* Username
* Role

Students receive courses associated with their selected courses, while professors receive courses assigned to them.

---

### 🎓 Course Schedule

```http
POST /api/Users/Course
```

Returns available courses for a specific:

* University
* Major

## 🗄️ Database

The project uses **SQL Server** with **Entity Framework Core**.

Database access is configured through the standard ASP.NET Core connection string:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "YOUR_CONNECTION_STRING"
  }
}
```

> ⚠️ Do not commit real database credentials or passwords to the repository.

## 🔄 Entity Framework Core Migrations

The project includes an EF Core `Migrations` directory.

To create a new migration:

```bash
dotnet ef migrations add MigrationName
```

To apply migrations:

```bash
dotnet ef database update
```

## ⚙️ Getting Started

### Prerequisites

Make sure you have:

* .NET 8 SDK
* SQL Server
* Git
* Entity Framework Core CLI (recommended)

### Clone

```bash
git clone https://github.com/Sobhankhedry/student-helper-api.git
cd student-helper-api
```

### Configure the database

Update the connection string in:

```text
SoftWare_Engineering/appsettings.json
```

### Restore dependencies

```bash
dotnet restore
```

### Build

```bash
dotnet build
```

### Run

```bash
dotnet run --project SoftWare_Engineering
```

The API is configured to listen on:

```text
HTTPS: 7006
HTTP: 7007
```

## 📖 Swagger

When running in the Development environment, Swagger is enabled.

Open:

```text
https://localhost:7006/swagger
```

or

```text
http://localhost:7007/swagger
```

Swagger can be used to explore and test the available endpoints.

## 🌐 CORS

The API currently enables CORS for client applications so that the Flutter frontend can communicate with the backend.

The API is configured to accept cross-origin requests.

## 🔗 Related Frontend

This API is designed to work with the Student Helper Flutter application:

**Student Helper UI**

https://github.com/Sobhankhedry/Student-Helper-UI

The Flutter application communicates with this API through HTTP requests.

## 🧩 Application Flow

```text
Flutter Application
        │
        │ HTTP / JSON
        ▼
ASP.NET Core Web API
        │
        ▼
Entity Framework Core
        │
        ▼
SQL Server
```

## 🚧 Current Limitations

This project is currently an academic/personal project and can be further improved for production use.

Potential improvements include:

* [ ] ASP.NET Core Identity
* [ ] JWT authentication
* [ ] Password hashing
* [ ] DTOs instead of exposing database entities
* [ ] Service layer
* [ ] Repository / Unit of Work where appropriate
* [ ] Global exception handling
* [ ] FluentValidation
* [ ] Proper HTTP response models
* [ ] Authorization policies
* [ ] Unit tests
* [ ] Integration tests
* [ ] API versioning
* [ ] Docker support
* [ ] CI/CD pipeline
* [ ] Production database configuration

## 🎯 Learning Goals

This project was developed to practice:

* REST API development
* ASP.NET Core
* Entity Framework Core
* SQL Server
* HTTP communication
* Backend/frontend integration
* Database migrations
* API design
* Role-based application logic

## 📄 License

This project is licensed under the MIT License.

## 👨‍💻 Author

**Sobhan Khedry**

GitHub:
https://github.com/Sobhankhedry
