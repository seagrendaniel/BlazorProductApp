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

---

## Contribution Guidelines

If you'd like to contribute to this project:

1. Fork the repository.
2. Create a new feature branch (`git checkout -b feature-branch`).
3. Commit your changes (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature-branch`).
5. Create a new Pull Request.
