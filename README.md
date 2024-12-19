# 📚 Library Management Console App

Welcome to the **Library Management Console App**, a beginner-friendly C# project built during **Phase 1: Mastering C# and .NET Basics for GUI Development**. This app allows users to add books and list them using a simple console application.

---

## 🚀 About the Project
This project is part of a learning module designed to teach the basics of C# and .NET. It covers:
- 🛠️ Setting up Visual Studio for development.
- 🐙 Setting up GitHub for version control.
- 🧱 Structuring a basic console application.
- 📂 Organizing project folders and files.
- ✍️ Writing clean, reusable C# code.
- 🔄 Committing and pushing changes to GitHub.

---

## 📝 Features
- Add books to the library.
- List all books stored in the library.
- Simple and intuitive console interface.

---

## 📂 Project Folder Structure

```
LibraryManagementConsoleApp
├── Program.cs           // Main entry point
├── Library.cs           // Logic to manage books
├── Book.cs              // Represents a book object
├── HelperFunctions.cs   // Reusable methods (future-proofing)
└── README.md            // Project description
```

---

## 🛠️ Prerequisites
Before running the project, ensure you have the following installed:

- [Visual Studio](https://visualstudio.microsoft.com/downloads/) (Community Edition recommended).
- .NET SDK (version 6 or higher).

---

## ⚙️ How to Set Up and Use the App

### **Step 1: Clone the Repository**
1. Open a terminal or Git Bash.
2. Run the following command:
   ```bash
   git clone https://github.com/your-username/LibraryManagementConsoleApp.git
   ```

### **Step 2: Open the Project in Visual Studio**
1. Launch Visual Studio.
2. Click on **File** > **Open** > **Project/Solution**.
3. Navigate to the cloned repository folder and select the `.csproj` file.

### **Step 3: Build and Run the Project**
1. Press `Ctrl + F5` to build and run the application.
2. Follow the on-screen instructions in the console.

---

## 💻 How to Use the App

1. **Add a Book**
   - When prompted, enter the book's title and author.

2. **List Books**
   - View all books currently stored in the library.

Example Output:
```
Adding a book:
Enter book title: C# for Beginners
Enter book author: John Doe

Listing books:
Title: C# for Beginners, Author: John Doe
```

---

## 📘 Learning Objectives
- **Understand C# syntax**: Learn how to create classes, objects, and methods.
- **Project organization**: Gain experience structuring small-scale projects.
- **Version control**: Get comfortable with Git and GitHub for collaboration and backups.

---

## 🐙 GitHub Workflow
1. **Initialize Git**: Run `git init` in the project folder (done via Visual Studio).
2. **Add Files**: Stage changes using:
   ```bash
   git add .
   ```
3. **Commit Changes**: Commit your progress:
   ```bash
   git commit -m "Initial commit: Add basic library functionality."
   ```
4. **Push to GitHub**:
   ```bash
   git push origin main
   ```

---

## ✨ Future Improvements
- Implement search functionality for books.
- Add file storage to save the library persistently.
- Build a GUI version using Windows Forms or WPF in **Phase 2**.

---

## 📜 License
This project is part of a personal learning initiative and is free to use for educational purposes.

---

Happy coding! 😊
