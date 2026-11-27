# DataSiswaDB — Student & Grade Management System

A desktop application built with **C# Windows Forms** and **SQLite** for managing student records and subject scores in a single, unified interface.

---

## Key Features

* **Automatic Database Setup:** Automatically generates a local SQLite database (`siswa.db`) with relational `Siswa` and `Nilai` tables on first launch.
* **Student Management (CRUD):** Add, view, update, and delete student records with a live total student counter.
* **Input Validation:**
  * Restricts Student ID (`NIS`) input to numeric digits only.
  * Prevents duplicate `NIS` entries before saving to the database.
  * Enforces valid score ranges (`0–100`).
* **Subject Score Management (CRUD):** Assign, edit, and delete subject grades linked to specific students, displayed using an SQL `JOIN` query.
* **Color-Coded Score Indicators:** Automatically highlights cells in the score table based on performance:
  * 🟩 **Light Green:** `80 – 100`
  * 🟨 **Yellow:** `70 – 79`
  * 🟥 **Light Coral (Red):** Below `70`

---

## Database Schema

The application uses a local SQLite file (`siswa.db`) containing two tables:

```sql
CREATE TABLE IF NOT EXISTS Siswa (
    Id        INTEGER PRIMARY KEY AUTOINCREMENT,
    NIS       TEXT NOT NULL,
    Nama      TEXT NOT NULL,
    Kelas     TEXT,
    TglDaftar TEXT
);

CREATE TABLE IF NOT EXISTS Nilai (
    SiswaId   INTEGER,
    MatPel    TEXT,
    Nilai     INTEGER
);
```

---

## Code Terminology (Indonesian – English)

Several variable, table, and UI control names are kept in Indonesian to match the Windows Forms Designer bindings:

| Term | Meaning | Description |
| :--- | :--- | :--- |
| **Siswa** | Student | Student table and entity |
| **NIS** | Student ID Number | *Nomor Induk Siswa* (unique identifier) |
| **Nama** | Name | Full name of the student |
| **Kelas** | Class | Student's assigned class/grade level |
| **TglDaftar** | Registration Date | Auto-generated date (`yyyy-MM-dd`) |
| **MatPel** | Subject | *Mata Pelajaran* (course/subject name) |
| **Nilai** | Score / Grade | Numeric grade (`0–100`) |

---

## How to Use

1. **Manage Students (Top Section):**
   * Fill in **NIS**, **Nama**, and **Kelas**, then click **Save** to add a new student.
   * Click any row in the top table to populate the form, then click **Update** or **Delete**.
2. **Manage Scores (Bottom Section):**
   * Select a student from the top table first.
   * Choose a **Subject (`MatPel`)**, enter a **Score (`Nilai`)** between `0` and `100`, and click **Save Score**.
   * Click any row in the bottom table to update or delete an existing score.

---

## Getting Started

### Prerequisites
* Windows OS
* Visual Studio (2019 or newer) with **.NET Desktop Development** workload
* `System.Data.SQLite` NuGet package

### Installation & Running
1. Clone this repository:
   ```bash
   git clone https://github.com/alvinadityaaa/DataSiswaDB.git
   ```
2. Open `DataSiswaDB.sln` in **Visual Studio**.
3. Restore NuGet packages (ensure `System.Data.SQLite` is installed).
4. Press `F5` or click **Start** to build and run the application.
