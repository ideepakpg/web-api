# ASP.NET Core Web API

This repository contains a sample ASP.NET Core Web API project that demonstrates how to build a RESTful API, interact with a SQL Server database using Entity Framework, and provide interactive API documentation with Swashbuckle.

## Features

- **Entity Framework SQL Server**: We use Entity Framework Core to interact with a SQL Server database, making it easy to perform GET, POST, PUT, and DELETE operations on the data.

- **Swagger Documentation**: ```Swashbuckle.AspNetCore``` is integrated to provide interactive and auto-generated API documentation. This means you can easily explore the API endpoints without any external documentation.

- **API CRUD Operations**: The project includes a `MembersController.cs`, which showcases GET, POST, PUT, and DELETE operations for a "Member" entity.

## Getting Started

Follow these steps to get started with the project:

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/ideepakpg/web-api.git

2. **Navigate to the project directory**:
   ```sh
   cd web-api
   
3. **Restore Dependencies**:
   ```sh
   dotnet restore
   
4. **Configure Database**:
   Update the connection string in ```appsettings.json``` to point to your SQL Server database.

6. **Apply Migrations**:
   
   **Create and apply database migrations**:
   ```sh
   dotnet ef migrations add Initial
   dotnet ef database update

8. **Run the API**:
   Start the API project:
   ```sh
    dotnet run

9. **Explore the API Documentation**:
   Access the Swagger API documentation at http://localhost:5000/swagger while the API is running. You can test the API endpoints directly from the Swagger interface.

## API Endpoints
- GET /api/members: Retrieve a list of all members.
- GET /api/members/{id}: Retrieve a specific member by ID.
- POST /api/members: Create a new member.
- PUT /api/members/{id}: Update an existing member.
- DELETE /api/members/{id}: Delete a member by ID.
