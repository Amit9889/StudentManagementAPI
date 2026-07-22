# Student Management API

A RESTful Student Management System built using **ASP.NET Core 8**, **ASP.NET Core Identity**, **JWT Authentication**, **Role-Based Authorization**, **Entity Framework Core**, and **MySQL**.

## Features

- User Registration
- User Login
- JWT Authentication
- ASP.NET Core Identity
- Role-Based Authorization
- Course Management
- MySQL Database
- Swagger API Documentation

---

## Tech Stack

- ASP.NET Core 8 Web API
- ASP.NET Core Identity
- Entity Framework Core
- MySQL
- JWT Bearer Authentication
- Swagger (OpenAPI)

---

## Roles

### Admin
- Register users
- Login
- Create courses
- Update courses
- Delete courses
- View all courses

### Faculty
- Login
- Create courses
- Update courses
- View courses

### Student
- Login
- View available courses

---

## Project Structure

```
StudentManagementAPI
│
├── Controllers
│   ├── AuthController.cs
│   └── CourseController.cs
│
├── Data
│   ├── AppDbContext.cs
│   └── DataSeeder.cs
│
├── DTOs
│   ├── LoginDto.cs
│   └── RegisterDto.cs
│
├── Models
│   ├── ApplicationUser.cs
│   ├── Course.cs
│   └── Enrollment.cs
│
├── Services
│   └── JwtService.cs
│
├── Migrations
├── Program.cs
└── appsettings.json
```

---

## Authentication Flow

1. Register a new user.
2. Login using email and password.
3. Receive a JWT token.
4. Click **Authorize** in Swagger.
5. Enter:

```
Bearer YOUR_JWT_TOKEN
```

6. Access protected APIs.

---

## API Endpoints

### Authentication

| Method | Endpoint | Description |
|---------|----------|-------------|
| POST | `/api/Auth/register` | Register a new user |
| POST | `/api/Auth/login` | Login and receive JWT |

---

### Course

| Method | Endpoint | Access |
|---------|----------|--------|
| GET | `/api/Course` | All authenticated users |
| POST | `/api/Course` | Admin, Faculty |
| PUT | `/api/Course/{id}` | Admin, Faculty |
| DELETE | `/api/Course/{id}` | Admin |

---

## Database

Database: **MySQL**

Identity Tables

- AspNetUsers
- AspNetRoles
- AspNetUserRoles
- AspNetUserClaims
- AspNetRoleClaims
- AspNetUserLogins
- AspNetUserTokens

Application Tables

- Courses
- Enrollments

---

## Setup

### Clone Repository

```bash
git clone <repository-url>
cd StudentManagementAPI
```

### Restore Packages

```bash
dotnet restore
```

### Update Database

```bash
dotnet ef database update
```

### Run Application

```bash
dotnet run
```

Open Swagger

```
http://localhost:5085/swagger
```

---

## Sample Register Request

```json
{
  "email": "admin@gmail.com",
  "password": "Admin@123",
  "role": "Admin"
}
```

---

## Sample Login Request

```json
{
  "email": "admin@gmail.com",
  "password": "Admin@123"
}
```

---

## Sample Course Request

```json
{
  "name": "Database Management System",
  "description": "Introduction to DBMS",
  "credits": 4
}
```

---

## Security

- Password hashing using ASP.NET Core Identity
- JWT Bearer Authentication
- Role-Based Authorization
- Protected API endpoints
- Secure password storage


---

## Author

**Amit Sahu**

Tech Stack:
- ASP.NET Core
- C#
- Entity Framework Core
- MySQL
- JWT Authentication
- ASP.NET Core Identity


<img width="1844" height="989" alt="Screenshot From 2026-07-23 00-05-01" src="https://github.com/user-attachments/assets/2562d39e-c34d-43fc-a7e9-85d6305bddf0" />

