# 🔐 CipherLab

<p align="center">
  <img src="https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET 8" />
  <img src="https://img.shields.io/badge/C%23-12.0-239120?style=for-the-badge&logo=csharp&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/Platform-Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white" alt="Windows" />
  <img src="https://img.shields.io/badge/Security-AES--256%20%7C%20SHA--256-red?style=for-the-badge" alt="Security" />
</p>

> **CipherLab** is a secure, layered desktop application built with modern .NET 8 and Windows Forms technologies, designed for text encryption, decryption, and operation history tracking.

---

## 📌 About & Educational Purpose

> **Note:** This project was developed as a personal portfolio and educational exercise with the primary goal of practically mastering software architecture, cryptographic standards (**AES & **SHA-256**), and **Clean Code** principles.

It explores secure dynamic key handling for user data, modular UI component management (`UserControl`), and local JSON-based data persistence.

---

## 🚀 Key Features At a Glance

| Feature | Description | Technology Used |
| :--- | :--- | :--- |
| **Robust Encryption** | Secures text content with randomized initialization vectors. | `AES-256 (CBC)` |
| **Dynamic Key Derivation**| Turns user passwords into cryptographic keys safely. | `SHA-256 Hashing` |
| **Operation Logging** | Automatically tracks and persists activities locally. | `System.Text.Json` |
| **Clipboard Support** | Copy encrypted/decrypted results with a single click. | `Clipboard API` |
| **Modular Navigation** | Clean split of views using reusable UI elements. | `UserControl` |

---

## 🛠️ Technological Architecture & Structure

The project follows a clean, maintainable, and separation-of-concerns layered design pattern:

```text
CipherLab/
├── 📂 Models/
│   └── 📄 CryptoLogModel.cs       # Log data model (POCO)
├── 📂 Services/
│   ├── 📄 EncryptionService.cs    # AES & SHA-256 cryptography logic
│   └── 📄 JsonLogService.cs       # JSON read/write file service operations
├── 📂 Views/
│   └── 📂 Controls/
│       ├── 📄 UcHome.cs           # Welcome screen panel
│       ├── 📄 UcTextCrypto.cs     # Encryption/Decryption panel
│       └── 📄 UcHistory.cs        # History logs DataGridView panel
├── 📄 MainForm.cs                 # Main container & navigation window
└── 📄 Program.cs                  # Application entry point (.NET 8)
```

---

## 🔒 Security Best Practices

1. **No Hardcoded Keys:** The application contains zero hardcoded secrets or passwords. All keys are dynamically generated based on user input.
2. **CBC Mode & Random IV:** A unique IV is generated during every encryption operation and securely prepended to the Base64 output text.
3. **Resource Management:** `using` blocks are strictly implemented across cryptographic streams to ensure proper memory cleanup and resource disposal (`IDisposable`).

---

## ⚙️ Installation & Running

To run this application locally on your machine, follow these steps:

### Prerequisites
* [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later installed.
* Visual Studio 2022 (with .NET Desktop Development workload) or any compatible C# IDE.

### Steps
1. **Clone the repository:**
    ```bash
    git clone https://github.com/quantum-root/CipherLab.git
    ```

2. **Navigate to the project directory:**
    ```bash
    cd CipherLab
    ```

3. **Run the application:**
    ```bash
    dotnet run
    ```
    *(Alternatively, you can open the `CipherLab.sln` solution file in Visual Studio 2022 and press `F5`)*

---

## 📝 License

This project is open-source and available under the [MIT License](LICENSE). Created strictly for educational and self-improvement purposes.

---
