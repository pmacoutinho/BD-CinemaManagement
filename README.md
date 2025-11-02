# BD — Cinema Management

_Project for the **Bases de Dados (BD)** course._

---

## Overview
A small **cinema management** system with a C# desktop UI and a **Microsoft SQL Server** database (T‑SQL).

- UI code lives in `UI/CinemaManagment/`
- Database scripts live in `sql/`
- Extra materials: `Apresentação.pdf`, `Relatório.pdf`, `Demonstração.mp4`

### Features
- Manage core entities: **Movies, Rooms, Sessions/Showtimes, Tickets, Customers, Staff**
- Typical CRUD plus basic business rules implemented in SQL (constraints, views, procedures/triggers)

> This is an academic project, not production software.

---

## Tech Stack
- **C#** (desktop UI; Visual Studio solution)
- **T‑SQL** on **SQL Server**

---

## Getting Started

### Prerequisites
- **Windows** with **Visual Studio 2022+** (Community is fine) or JetBrains Rider
- **SQL Server** (Developer/Express/LocalDB). Optional: **SSMS** (SQL Server Management Studio)
- .NET runtime per the solution target (Framework or .NET). If unsure, just open the solution in Visual Studio and let it restore.

### 1) Set up the database
1. Create a new database (e.g. `CinemaDB`).
2. Run the scripts in `sql/` **in order**. If files are numbered, follow the numbers; otherwise run schema/objects first, then seed data.
3. Confirm objects were created (tables, views, procedures, triggers).

> Tip: You can spin up SQL Server in Docker instead of installing locally:
>
> ```bash
> docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=YourStrong!Passw0rd" >   -p 1433:1433 --name sql2022 -d mcr.microsoft.com/mssql/server:2022-latest
> ```

### 2) Configure the app connection string
Update the database **connection string** in the UI project:

- If the project uses **.NET Framework** (WinForms/WPF), edit `App.config` under `<connectionStrings>`.
- If it uses **.NET (Core/5/6/7)**, edit `appsettings.json`.

**Example (SQL Server Express / LocalDB):**
```xml
<connectionStrings>
  <add name="CinemaDb" 
       connectionString="Server=localhost;Database=CinemaDB;Trusted_Connection=True;MultipleActiveResultSets=true" 
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

**Example (SQL Server with username/password):**
```xml
<connectionStrings>
  <add name="CinemaDb" 
       connectionString="Server=localhost,1433;Database=CinemaDB;User Id=sa;Password=YourStrong!Passw0rd;TrustServerCertificate=True" 
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

### 3) Run the app
- Open the solution in `UI/CinemaManagment/` with Visual Studio and **Build > Start**.
- If your IDE prompts to restore packages or retarget the framework, accept the suggestions.

---

## Repository Structure
```
BD-CinemaManagement/
├─ UI/
│  └─ CinemaManagment/        # C# desktop application
├─ sql/                       # Database schema/objects/seed scripts
├─ Apresentação.pdf           # Slides
├─ Relatório.pdf              # Report
├─ Demonstração.mp4           # Short app demo
└─ README.md
```

---

## Demo & Docs
- 🎥 **Demo video:** `./Demonstração.mp4`
- 📝 **Report:** `./Relatório.pdf`
- 📽️ **Slides:** `./Apresentação.pdf`

---

## Notes & Limitations
- Built for a university course; **not** hardened for security or concurrency.
- Some features may be unfinished or have bugs.

---

## Contributing
Issues and small fixes are welcome. For bigger changes, open an issue first to discuss the approach.

## Authors
See the [GitHub contributors](../../contributors) page for the full list.
