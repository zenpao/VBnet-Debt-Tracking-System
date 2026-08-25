# VBnet-Debt-Tracking-System (LCTS)

A Windows Forms desktop app (VB.NET) for tracking client debts/loans and daily collections, with role-based access for **Management** and **Collector** employees, backed by a local Microsoft Access database.

## Description

LCTS lets a business register employees (Management or Collector) and clients with an outstanding balance, due date, and an assigned collector. Collectors log daily payments against a client's balance; Management can monitor all collectors' daily collection totals. All monetary amounts are displayed in Philippine Peso (₱).

## Features

**Login & Registration**
- Login by Employee ID and password, routed to a different dashboard based on role (Management vs Collector)
- Register new Management or Collector employee accounts, or new Client accounts (with starting balance, start date, due-in-days, and assigned collector)
- Auto-generated numeric IDs for new employees/clients
- Database connectivity test button

**Collector dashboard**
- View today's collected payments and running total (per collector)
- View/search the list of clients (with an outstanding balance) assigned to that collector
- Select a client to view their profile and record a new payment: enter a payment amount, the app validates it against the current balance, deducts it, and logs the transaction with a timestamp
- View a client's payment history for the day and running total

**Management dashboard**
- View, per collector, today's client payments and total amount collected
- Switch between collectors to review their daily performance
- Database connectivity test button

## Tech Stack

- **VB.NET** (Visual Basic .NET)
- **Windows Forms** (WinForms)
- **.NET Framework**
- **Microsoft Access (`.mdb`)** database via `System.Data.OleDb` (Jet OLEDB 4.0 provider)

## Prerequisites

- Windows OS
- .NET Framework (matching the project's target version) — for running the built app
- Microsoft Access Database Engine / Jet OLEDB 4.0 provider (to connect to the `.mdb` database) — typically requires the 32-bit Access Database Engine redistributable, since Jet OLEDB 4.0 is 32-bit only
- Visual Studio (for building/editing the project)

## Installation

Clone the repository:

```bash
git clone https://github.com/paoradox/VBnet-Debt-Tracking-System.git
cd VBnet-Debt-Tracking-System
```

Open `LCTS.sln` in Visual Studio and build the solution.

## Usage

Build the solution in Visual Studio, then run the generated `LCTS.exe` (or run/debug directly from Visual Studio).

### Workflow

1. **Register an account:** from the login screen, register a Management or Collector employee, or (from the registration screen) a new Client with their balance, due date, and assigned collector.
2. **Log in:** enter your Employee ID and password. You'll be routed to the Management or Collector dashboard based on your account type.
3. **As a Collector:** view your assigned clients with outstanding balances, select one to see their profile, and record a payment — the balance updates and the transaction is logged with a timestamp.
4. **As Management:** select a collector from the list to see their day's collected payments and running total.

## Configuration

- The database connection string points to `dbAccounts.mdb` in the application's `|DataDirectory|` — this `.mdb` file must be present alongside the built executable, with `Employees`, `Clients`, and `Payments` tables.

## Troubleshooting

- **Database connection errors:** ensure the Microsoft Access Database Engine (Jet OLEDB 4.0, 32-bit) is installed, and that `dbAccounts.mdb` exists in the expected data directory. Use each dashboard's database-status test button to verify connectivity.
- **Invalid payment amount:** the app rejects payments greater than the client's current balance — enter an amount at or below the shown balance.

## Project Structure

```
VBnet-Debt-Tracking-System/
├── LCTS/
│   ├── Form1.vb / Form1.Designer.vb / Form1.resx     # Login form
│   ├── Form2.vb / Form2.Designer.vb / Form2.resx     # Registration form (employees & clients)
│   ├── Form3.vb / Form3.Designer.vb / Form3.resx     # Collector dashboard (home)
│   ├── Form4.vb / Form4.Designer.vb / Form4.resx     # Collector — today's collections monitor
│   ├── Form5.vb / Form5.Designer.vb / Form5.resx     # Collector — client list with balances
│   ├── Form6.vb / Form6.Designer.vb / Form6.resx     # Client profile & payment collection
│   ├── Form10.vb / Form10.Designer.vb / Form10.resx  # Management dashboard
│   ├── My Project/                                   # VB.NET project settings, assembly info
│   ├── App.config
│   ├── LCTS.vbproj                                   # Project file
│   ├── bin/                                          # Build output
│   ├── obj/                                          # Build intermediates
│   └── res/
├── LCTS.sln            # Visual Studio solution file
└── LCTS.exe.lnk         # Shortcut to the built executable
```

## License

Not specified.
