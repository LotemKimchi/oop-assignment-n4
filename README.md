# 📋 Hierarchical Console Menu System – C#

A reusable console-based hierarchical menu framework implemented in C#, 
demonstrating Object-Oriented Programming, polymorphism, interfaces, delegates, and event-driven design.

Developed as part of an advanced OOP course in .NET.

---

## 🚀 Project Overview

This project implements a dynamic hierarchical menu system for Console applications.

The solution includes two independent implementations of the same infrastructure:

1. Interface-based implementation  
2. Delegate-based implementation (using `Action`)

A third project demonstrates usage of both approaches.

---

## 🏗 Solution Structure

Menus04.Ex.Interfaces  
→ Class Library implementing the menu system using Interfaces

Menus04.Ex.Events  
→ Class Library implementing the menu system using Delegates (`Action`)

Menus04.Ex.Test  
→ Console Application demonstrating usage of both implementations

---

## 🎯 Core Features

### 🔹 Hierarchical Menu Structure
- Multi-level nested menus
- Dynamic navigation between levels
- Back / Exit functionality
- Input validation and error handling
- Screen clearing on navigation

Each menu level displays:
- A title
- Numbered menu items
- "Back" (or "Exit" for main menu)
- Input request from user

Example:

```
** Version and Lowercase **
--------------------------
1. Show Version
2. Count Lowercase
0. Back
Please enter your choice (1-2 or 0 to go back):
```

---

## 🧠 Technical Highlights

### 1️⃣ Interface-Based Implementation

- Custom interface used for notifying the system when a menu item is selected
- Demonstrates:
  - Polymorphism
  - Abstraction
  - Loose coupling
  - Clear separation between infrastructure and business logic

### 2️⃣ Delegate-Based Implementation

- Uses `Action` delegates to invoke menu actions
- Demonstrates:
  - First-class function references
  - Callback-based execution
  - Event-driven style programming
  - Clean and flexible behavior injection

---

## 🖥 Demonstration (Test Project)

Two different main menus are created and displayed sequentially:

### 🔸 Version and Lowercase
- Show Version → Displays application version
- Count Lowercase → Counts lowercase letters in user input

### 🔸 Show Current Date/Time
- Show Current Time
- Show Current Date

Example output:

```
App Version: 26.1.4.5940
There are 27 lowercase letters in your text
Current Time is 18:45:32
```

---

## 🎨 UI Details

- Menu titles displayed in purple using `Console.ForegroundColor`
- Consistent formatting across all levels
- Automatic return to previous menu after action execution

---

## 🛠 Technologies Used

- C#
- .NET Framework
- Console Applications
- Interfaces
- Delegates (`Action`)
- Collections
- Polymorphism

---

## 💡 Design Principles Demonstrated

- Encapsulation
- Separation of concerns
- Callback pattern
- Event notification mechanism
- Component-based architecture
- Reusable infrastructure design

---

## 📚 Academic Context

Developed for an Object-Oriented Programming course in .NET, focusing on:

- Interfaces
- Delegates
- Events
- Clean code practices
- Multi-project solution architecture

---

## 👩‍💻 Author

Lotem Kimchi
