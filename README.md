# FactoryOps

FactoryOps is a full-stack ASP.NET Core MVC application for managing and tracking manufacturing work orders.  
The project simulates modernization of legacy business systems by combining traditional MVC architecture with extensible API capabilities for future React integration.

---

## Overview

FactoryOps allows users to:

- Create, edit, delete, and view work orders
- Search and filter by Part Number and Status
- Track workflow status (Planned → In Progress → Completed)
- Enforce validation and business rules at the model level
- Secure sensitive operations using authentication

The application demonstrates enterprise-style layering, database migrations, and scalable search/query logic.

---

## Architecture

- **ASP.NET Core MVC** – Server-rendered UI
- **Entity Framework Core** – ORM and migrations
- **SQL Server** – Persistent storage
- **ASP.NET Identity** – Authentication
- Structured separation of:
  - Models (domain entities)
  - ViewModels (search/filter models)
  - Controllers (business logic)
  - Data layer (DbContext)

The system is structured to support incremental UI modernization via API controllers and React integration.

---

## Key Features

### Work Order Management
- Full CRUD operations with validation
- Status-based workflow transitions
- Due date tracking
- Quantity validation rules

### Search & Filtering
- Flexible filtering by Part Number and/or Status
- AND-based filtering when multiple fields are provided
- Safe handling of empty input

### Security
- Authentication required for Create/Edit/Delete
- Configurable read-only access

### Database
- Code-first migrations
- Managed via EF Core
- Migration history tracked in `__EFMigrationsHistory`

---

## Database Setup

Configure the connection string via:

- User Secrets
- `appsettings.Development.json`

Run migrations:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### Running the Application
dotnet run

### Future Modernization Path
FactoryOps is designed to support:

- API controllers for React integration
- Incremental UI modernization
- Role-based authorization
- Pagination and performance optimization

### Purpose
This project demonstrates:
- Enterprise-style ASP.NET MVC development
- Real-world SQL Server configuration and migration management
- Legacy-to-modern system evolution patterns
- Clean separation of concerns
