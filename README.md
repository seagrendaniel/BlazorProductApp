# BlazorTestApp

BlazorTestApp is a full-stack CRUD (Create, Read, Update, Delete) web application built with **Blazor WebAssembly** and **.NET 8**. It features a product list management interface, allowing users to add, update, and delete products.

## Features
- Create, Read, Update, Delete (CRUD) operations for products.
- Built with **Blazor WebAssembly** as the client-side application.
- **ASP.NET Core API** serving as the backend.
- Clean, modern UI with responsive design.

---

## Table of Contents
1. [Prerequisites](#prerequisites)
2. [Getting Started](#getting-started)
    - [Fork and Clone](#fork-and-clone)
    - [Project Setup](#project-setup)
3. [Running the Application](#running-the-application)
4. [Project Structure](#project-structure)
5. [Technologies Used](#technologies-used)
6. [License](#license)

---

## Prerequisites

To run this project, you'll need:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) installed on your machine.
- A code editor such as [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio](https://visualstudio.microsoft.com/vs/).
- [Git](https://git-scm.com/) for version control.
- (Optional) [SQLite](https://www.sqlite.org/download.html) or other databases (if configured).

---

## Getting Started

### Fork and Clone

To get started with **BlazorTestApp**, first fork the repository and then clone it to your local machine:

1. **Fork the Repository**: Click the "Fork" button at the top right of this repository.
2. **Clone the Repository**:

    ```bash
    git clone https://github.com/seagrendaniel/BlazorTestApp.git
    cd BlazorTestApp
    ```

### Project Setup

1. **Restore Packages**: Once cloned, navigate to the project directory and restore the required packages:

    ```bash
    dotnet restore
    ```

2. **Build the Solution**: Build the entire project to ensure that all dependencies and projects are correctly compiled:

    ```bash
    dotnet build
    ```

---

## Database Setup (Optional)

If you want to add persistent data storage, follow these instructions to set up the database. Currently, the app runs in-memory, but if needed, you can use **SQLite** or any other database by integrating **Entity Framework Core**.

### Using SQLite

1. **Install EF Core Tools** (if not already installed):

    ```bash
    dotnet tool install --global dotnet-ef
    ```

2. **Configure Connection String (Optional)**: By default, the project is configured to use SQLite, and the connection string is located in `Server/appsettings.json`. If you would like to update the connection string in the `appsettings.json`, modify the `Data Source` value:
    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Data Source=BlazorTestApp.db"
    }
    ```

3. **Add Migrations**: To set up the database schema, you need to create an initial migration. Navigate to the Server directory and run the following command:

    ```bash
    dotnet ef migrations add InitialCreate
    ```

    This will generate the initial migration files.

4. **Update the Database**: Once the migration has been added, apply the migration to create the database:

    ```bash
    dotnet ef database update
    ```

    This command will create a file called BlazorTestApp.db in your project directory, which is the SQLite database file.

5. **Verify the Database has been created**: After running the migration, the `BlazorTestApp.db` file should be created. You can use any SQLite tool (such as DB Browser for SQLite) to open this file and verify that the tables have been created.

6. **Additional Commands**: Here are some additional useful commands:

    **Remove Last Migration**: To rollback the most recent migration:

    ```bash
    dotnet ef migrations remove
    ```

    **Add New Migrations**: After modifying the model or making other changes to the DB, you can create new migrations by running:

    ```bash
    dotnet ef migrations add YourMigrationName
    ```

    **Apply New Migrations**: Once new migrations have been added, apply these migrations by running: 

    ```bash
    dotnet ef database update
    ```

---

## Running the Application

### Running the Backend and Frontend

1. **Run the Application**:
    To start both the server (backend) and the client (frontend), use the following command:
    ```bash
    dotnet run --project Server
    ```

2. **Open in Browser**: After the project starts, it will automatically open in your default browser at:
    ```
    https://localhost:5001
    ```

3. **Optional**: If needed, you can open the project in your preferred code editor:
    ```bash
    code .
    ```

---

## Project Structure

Here is a breakdown of the project structure:

```plaintext
BlazorTestApp/
│
├── Client/                # Blazor WebAssembly frontend
│   ├── Pages/             # Razor components (UI)
│   ├── Services/          # Service layer for API calls
│   └── wwwroot/           # Static assets (CSS, JS, images)
│
├── Server/                # ASP.NET Core backend (API)
│   ├── Controllers/       # API Controllers
│   ├── Services/          # API Services and Interfaces
│   └── Program.cs         # Server entry point
│
├── Shared/                # Shared code between Client and Server
│   └── Product.cs         # Product model
│
├── BlazorTestApp.sln       # Solution file
├── README.md              # Project documentation
└── ...                    # Other files

```
---

## Technologies Used

- **Blazor WebAssembly**: Client-side application framework for building interactive web UIs with C#.
- **ASP.NET Core**: Server-side framework for building APIs and handling HTTP requests.
- **Entity Framework Core**: (Optional) ORM for database handling (if extended).
- **.NET 8**: Latest version of the .NET runtime.
- **C#**: Language used throughout the project.

---

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.