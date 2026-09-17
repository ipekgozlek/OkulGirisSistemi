# 🎓 School Management System

A desktop **School Management System** developed using **C# Windows Forms** and **SQL Server**.

## 📌 About the Project

The **School Management System** is a desktop application designed to manage basic school operations digitally.

### 👨‍🏫 Teacher / Administrator Operations

- Student management
- Course management
- Club management
- Exam and grade management

### 👨‍🎓 Student Operations

- View courses
- View exam grades
- View project grades
- View average grade
- View pass / fail status

## ✨ Features

### 👨‍🎓 Student Management

- Add students
- Delete students
- Update student information
- Search students
- List students

### 📚 Course Management

- Add courses
- Delete courses
- Update courses
- List courses

### 🏫 Club Management

- Add clubs
- Delete clubs
- Update clubs
- List clubs

### 📝 Exam & Grade Management

The system allows teachers/administrators to manage student grades.

- 1st Exam
- 2nd Exam
- 3rd Exam
- Project Grade
- Average Grade
- Pass / Fail Status

## 🖥️ Screenshots

### 🏠 Main Screen

<img width="525" height="440" alt="Ekran görüntüsü 2026-09-17 235323" src="https://github.com/user-attachments/assets/188a63f8-0bda-4eae-a447-72f6d4620fd0" />


### 👨‍🏫 Teacher Panel

<img width="420" height="582" alt="Ekran görüntüsü 2026-09-17 235347" src="https://github.com/user-attachments/assets/9782f604-4778-4dcc-bd0c-9deacb81460c" />


### 👨‍🎓 Student Management

<img width="787" height="480" alt="Ekran görüntüsü 2026-09-18 000025" src="https://github.com/user-attachments/assets/6e9ae78d-59dd-48e1-8c17-79f09debf6cb" />


### 📚 Course Management

<img width="546" height="457" alt="Ekran görüntüsü 2026-09-17 235403" src="https://github.com/user-attachments/assets/a1f8bb0c-c936-4173-b67b-d4b25679c50b" />

### 🏫 Club Management

<img width="590" height="420" alt="Ekran görüntüsü 2026-09-17 235857" src="https://github.com/user-attachments/assets/6b5dc005-4352-4543-9f53-26b4fc609214" />


### 📝 Exam & Grade Management
<img width="792" height="446" alt="Ekran görüntüsü 2026-09-17 235932" src="https://github.com/user-attachments/assets/54a4da32-3f36-407b-a9b9-d9a4135cd212" />


### 📊 Student Grades

<img width="717" height="507" alt="Ekran görüntüsü 2026-09-18 000000" src="https://github.com/user-attachments/assets/adb84b83-7edf-40fc-a674-162f7ef212de" />


## 🛠️ Technologies

- **C#**
- **.NET 10**
- **Windows Forms**
- **SQL Server**
- **Microsoft.Data.SqlClient**
- **Typed DataSet**
- **TableAdapter**

## 🗄️ Database

The application uses **SQL Server** as its database management system.

### Main Tables

- `TBLOGRENCILER`
- `TBLDERSLER`
- `TBLKULUPLER`
- `TBLNOTLAR`

## 🔄 CRUD Operations

The application implements the basic CRUD operations:

- **Create** – Add new records
- **Read** – List and search records
- **Update** – Update existing records
- **Delete** – Delete records

## 🏗️ Project Structure

```text
BonusProje/
│
├── Form1.cs
├── FrmOgretmen.cs
├── FrmOgrenci.cs
├── FrmDersler.cs
├── FrmKulup.cs
├── FrmSinavNotlar.cs
├── FrmOgrenciNotlar.cs
│
├── DataSet1.xsd
├── DataSet1.Designer.cs
├── Program.cs
│
├── Properties/
│
└── BonusProje.csproj
