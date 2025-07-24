---
# Aether Engine


[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Version](https://img.shields.io/badge/version-0.1.0--alpha-blue)](https://github.com/your-username/aether-engine)

A powerful, cross-platform 2D RPG creation platform for Windows and Android, designed to bring your stories to life with minimal coding. Inspired by classics like RPG Maker, Aether Engine provides a modern, integrated environment for indie developers and hobbyists.

## About The Project

Aether Engine is a comprehensive suite of tools that enables developers to create, collaborate on, and export 2D role-playing games. It features a visual, drag-and-drop interface for building worlds and defining complex game logic, supported by a robust backend and a rich asset library. Our goal is to streamline the development process, making game creation more accessible and collaborative.

---

### ✨ Key Features

- **🖥️ Cross-Platform Editor:** Built with .NET MAUI to run natively on Windows and Android.
- **🗺️ Visual Game Logic Editor:** Design maps, create characters, and build complex events with a powerful drag-and-drop interface—no coding required.
- **🎨 Asset & Template Library:** Jumpstart your project with a library of pre-built assets (sprites, tilesets, audio) and system templates (battle, inventory, quests).
- **🧩 Extensible Plugin System:** Extend the engine's functionality by writing and managing custom JavaScript plugins.
- **🤝 Real-Time Collaboration:** Invite team members to your project, assign roles (Owner, Editor, Viewer), and use a project-locking system to prevent edit conflicts.
- **🤖 AI-Assisted Development:** Get contextual code suggestions for complex event logic to accelerate your workflow.
- **📦 Multi-Platform Export:** Export your finished game to Windows (.EXE), Android (.APK), and HTML5 with a single click.
- **🔗 Dependency Tracking:** Automatically tracks asset dependencies to ensure your exported game includes all necessary files.
- **💰 In-App Purchase Ready:** Configure monetization options directly in the editor for easy integration with the Application Store.

---

### 📸 Screenshots

---

### 💻 Tech Stack

This project is built with a modern, robust, and scalable technology stack.

| Component                   | Technology                                                                             |
| :-------------------------- | :------------------------------------------------------------------------------------- |
| **Client (Desktop/Mobile)** | **.NET 8**, **.NET MAUI**, **SkiaSharp** (for rendering)                               |
| **Backend API**             | **ASP.NET Core 8**, **Entity Framework Core 8**                                        |
| **Database**                | **Microsoft SQL Server** (backend), **SQLite** (client-side caching & offline storage) |
| **Game Preview & Runtime**  | **PixiJS** (for the HTML5 game player)                                                 |
| **DevOps & Cloud**          | **Azure App Service**, **Azure SQL Database**, **Azure DevOps** (for CI/CD)            |
| **Authentication**          | **ASP.NET Core Identity**, **OAuth 2.0** (GitHub Provider)                             |

---

## 🚀 Getting Started

To get a local copy up and running, follow these steps.

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) with the .NET MAUI workload installed
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Express, Developer, or full edition)

### Installation

1.  **Clone the repository:**

    ```sh
    git clone https://github.com/your-username/aether-engine.git
    cd aether-engine
    ```

2.  **Configure Backend Secrets:**

    - Navigate to the backend API project directory.
    - Create a file named `appsettings.Development.json`.
    - Add your database connection string and GitHub OAuth credentials:
      ```json
      {
        "ConnectionStrings": {
          "DefaultConnection": "Server=your_server;Database=AetherEngineDB;Trusted_Connection=True;TrustServerCertificate=True;"
        },
        "GitHub": {
          "ClientId": "your_github_client_id",
          "ClientSecret": "your_github_client_secret"
        }
      }
      ```

3.  **Apply Database Migrations:**

    - Navigate to the backend API project directory in your terminal.
    - Run the Entity Framework migration command to create the database schema:
      ```sh
      dotnet ef database update
      ```

4.  **Run the Backend API:**

    - Open a terminal in the backend API project directory and run:
      ```sh
      dotnet run
      ```
    - The API will be available at `https://localhost:7xxx` and `http://localhost:5xxx`.

5.  **Run the MAUI Client:**
    - Open the solution (`.sln`) file in Visual Studio.
    - Set the MAUI project as the startup project.
    - Press the "Run" button (or F5), selecting either a Windows or Android target.

---

## 🚧 Project Status

**In Active Development.** This project is under construction. Core features are being added incrementally. It is not yet ready for production use.

### Roadmap

- [ ] **Module 1:** Foundation & Core Services
- [ ] **Module 2:** User Identity & Secure Access
- [ ] **Module 3:** The Asset Pipeline & Library
- [ ] **Module 4:** The Visual Scene Editor
- [ ] **Module 5:** Game Logic & The Event System
- [ ] ...and more!

---

## 🤝 Contributing

Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

---

## 📜 License

Distributed under the MIT License.

---

## 📧 Contact
