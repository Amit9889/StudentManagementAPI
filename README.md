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
<img width="1844" height="989" alt="Screenshot From 2026-07-23 00-05-08" src="https://github.com/user-attachments/assets/6aba82d2-1886-47b2-8e3a-c737efe4ea09" />
<img width="1844" height="989" alt="Screenshot From 2026-07-23 00-05-26" src="https://github.com/user-attachments/assets/f5291dac-2cb2-4b93-9c96-c6e9cfb5543e" />
<img width="1844" height="989" alt="Screenshot From 2026-07-23 00-05-45" src="https://github.com/user-attachments/assets/2c6eab40-dcc4-45f5-b69e-fdac7a093a2b" />
<img width="1836" height="996" alt="Screenshot From 2026-07-23 00-13-44" src="https://github.com/user-attachments/assets/33a7b742-3168-4491-8f9d-246157f993c1" />
<img width="1836" height="996" alt="Screenshot From 2026-07-23 00-14-10" src="https://github.com/user-attachments/assets/01e6c32d-f585-4cee-890b-4d0cbd36e735" />
<img width="1836" height="996" alt="Screenshot From 2026-07-23 00-16-21" src="https://github.com/user-attachments/assets/252b2fc5-73c5-49b6-a9de-036b3f150d6b" />
<img width="1920" height="1080" alt="Screenshot From 2026-07-23 00-18-02" src="https://github.com/user-attachments/assets/21009012-7999-4f6f-b59d-6bb13cfb4f1a" />






