# 🚗 DVLD - Driving & Vehicle Licensing Department

**DVLD** is a full-featured desktop application designed to digitize and automate the daily operations of traffic departments and vehicle licensing authorities.  
It provides an integrated system to manage driver licenses, vehicle registrations, test appointments, user permissions, and financial records.

---

## 🧰 Built With

- **C# (.NET Framework 4.8)**
- **Windows Forms**
- **SQL Server**
- **ADO.NET**
- **3-Tier Architecture (Presentation, Business, Data Access)**
- **Stored Procedures & Views**

---

## ✨ Features

### 👤 People Management
- Add, update, delete, and search for individuals
- Input validation and clean, user-friendly interface

### 🧑‍💼 Users & Permissions
- Create and manage system users
- Assign granular permissions per user
- Secure login with username and password

### 🪪 License Management
- Issue new local and international driving licenses  
- Renew, replace, and issue replacements for lost or damaged licenses  
- Detain and release licenses  
- View complete license history for any person

### 📋 Applications Management
- New driving license applications  
- Schedule and manage test appointments (vision, written, practical)  
- Track application status and fees  
- Pass/Fail control per test

### 🧾 Financial Transactions
- Manage application and license fees  
- Print official receipts and license documents

### 🚙 Vehicle Management *(optional)*
- Register vehicles and link them to owners  
- Manage vehicle licenses and renewals

---

## 🧱 Architecture

The project follows a **clean 3-Tier Architecture**:

- **Presentation Layer (UI)** – Windows Forms  
- **Business Logic Layer (BLL)** – Implements business rules and logic  
- **Data Access Layer (DAL)** – Handles all database communication via ADO.NET  

All database operations are executed through **Stored Procedures** for performance and security.

---

## 🗄️ Database Schema

The database includes key tables such as:

- `People`
- `Users`
- `Licenses`
- `InternationalLicenses`
- `Applications`
- `TestTypes`
- `Tests`
- `Appointments`
- `DetainedLicenses`

Relationships are maintained with foreign keys and the schema is fully normalized.

---

## 🚀 Getting Started

### Prerequisites
- Visual Studio 2019 or newer  
- SQL Server 2016 or newer  
- .NET Framework 4.8  

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/youssef-darrag/DVLD.git
