# BARAKA TOOL V1.0 - Complete Device Management System

**Professional Windows Desktop Application for Mobile Device Management**

---

## 🎯 Overview

BARAKA TOOL is a comprehensive device management solution designed for managing mobile devices from various manufacturers. It provides powerful tools for device maintenance, FRP removal, factory resets, backups, and more.

**Developer:** Baraka Tanzania  
**Version:** 1.0.0  
**Platform:** Windows 10/11 (.NET 8)  
**Support:** WhatsApp: 0782700859  

---

## ✨ Key Features

### 🔐 Authentication
- Secure login system
- Username: `0782700859`
- Password: `782700859b`
- Change password anytime from Settings

### 📱 Device Support
- ✅ Samsung
- ✅ Xiaomi
- ✅ Tecno
- ✅ Infinix
- ✅ Oppo
- ✅ Vivo

### 🔧 Device Tools

#### 1. **Remove FRP Lock** 🔓
- Factory Reset Protection removal
- All supported brands
- Safe and secure process
- Device-specific instructions

#### 2. **Hard Reset** 🔄
- Complete device data wipe
- All user data removed permanently
- Reset to factory settings
- Irreversible operation (double confirmation)

#### 3. **Factory Reset** 🔁
- Reset device to original state
- Brand-specific instructions
- Safe and guided process
- All data cleared

#### 4. **Device Management** 📱
- View device information
- Screenshot capability
- File manager access
- Backup and restore

### 📊 Dashboard
- Device statistics
- Quick access to tools
- System information
- Event logging

### ⚙️ Settings
- Change password
- Database configuration
- Backup location settings
- Theme settings

### 📞 Support Center
- 24/7 WhatsApp support
- FAQ section
- Help & resources
- Company information

---

## 🏗️ Project Structure

```
BarakaTool/
├── App.xaml
├── App.xaml.cs
├── LoginWindow.xaml
├── LoginWindow.xaml.cs
├── MainWindow.xaml
├── MainWindow.xaml.cs
├── BarakaTool.csproj
├── Data/
│   └── DatabaseManager.cs
└── Pages/
    ├── DashboardPage.xaml
    ├── DashboardPage.xaml.cs
    ├── SamsungPage.xaml
    ├── SamsungPage.xaml.cs
    ├── XiaomiPage.xaml
    ├── XiaomiPage.xaml.cs
    ├── TecnoPage.xaml
    ├── TecnoPage.xaml.cs
    ├── InfinixPage.xaml
    ├── InfinixPage.xaml.cs
    ├── OppoPage.xaml
    ├── OppoPage.xaml.cs
    ├── VivoPage.xaml
    ├── VivoPage.xaml.cs
    ├── SettingsPage.xaml
    ├── SettingsPage.xaml.cs
    ├── RemoveFRPPage.xaml
    ├── RemoveFRPPage.xaml.cs
    ├── HardResetPage.xaml
    ├── HardResetPage.xaml.cs
    ├── FactoryResetPage.xaml
    ├── FactoryResetPage.xaml.cs
    ├── SupportPage.xaml
    ├── SupportPage.xaml.cs
    ├── AboutPage.xaml
    └── AboutPage.xaml.cs
```

---

## 🚀 Getting Started

### Installation

1. **Clone Repository**
   ```bash
   git clone https://github.com/barakaturuka529-boop/baraka.git
   cd BarakaTool
   ```

2. **Open in Visual Studio 2022**
   - Open `BarakaTool.csproj`

3. **Restore NuGet Packages**
   ```bash
   dotnet restore
   ```

4. **Build Project**
   ```bash
   dotnet build
   ```

5. **Run Application**
   ```bash
   dotnet run
   ```

### Login Credentials

**Default Admin Account:**
- **Username:** 0782700859
- **Password:** 782700859b

---

## 📋 Usage Guide

### 1. Login
- Start the application
- Enter credentials
- Click "LOGIN"

### 2. Navigate Dashboard
- View connected devices count
- Access quick actions
- Check supported brands

### 3. Select Device Brand
- Choose from 6 supported brands
- View brand-specific options

### 4. Use Device Tools
- **Remove FRP:** Select brand → Follow instructions → Start process
- **Hard Reset:** Select brand → Confirm twice → Execute (irreversible)
- **Factory Reset:** Select brand → Confirm → Execute

### 5. Access Settings
- Change password
- Configure backup location
- Adjust application settings

### 6. Get Support
- Access Support Center
- Chat on WhatsApp (0782700859)
- View FAQs
- Browse help resources

---

## 🎨 User Interface

### Dark Theme
- Easy on the eyes
- Professional appearance
- Material Design components
- Green/Blue accent colors

### Navigation
- **Left Sidebar:** Brand selection
- **Top Bar:** Page title
- **Content Area:** Main content
- **Console Area:** Real-time logs

---

## 🔒 Security Features

- Secure login authentication
- Password change capability
- Confirmation dialogs for dangerous operations
- Session logging
- Database encryption support

---

## 💾 Database

### Tables

#### Devices
- Id, Brand, Model, SerialNumber, IMEI, AndroidVersion, Status, LastConnected, CreatedAt

#### Backups
- Id, DeviceId, BackupName, BackupSize, BackupPath, BackupDate, Status, CreatedAt

#### Logs
- Id, EventType, Message, DeviceId, Timestamp

---

## 🛠️ Technologies Used

- **Language:** C#
- **Framework:** WPF (.NET 8)
- **UI Library:** Material Design in XAML
- **Database:** SQLite
- **Architecture:** MVVM Pattern
- **Package Manager:** NuGet

---

## ⚠️ Important Warnings

### FRP Removal
- Use only on authorized devices
- May void device warranty
- Requires proper authorization

### Hard Reset
- **ALL DATA WILL BE PERMANENTLY DELETED**
- **THIS CANNOT BE UNDONE**
- Backup data before proceeding
- Requires double confirmation

### Factory Reset
- Removes all user data
- Resets to factory settings
- Takes 10-30 minutes
- Keep device connected during process

---

## 📞 Support & Contact

**WhatsApp Business:** 0782700859  
**Company:** BARAKA TANZANIA  
**Location:** Tanzania  🇹🇿  
**Available:** 24/7  

---

## 🎓 Learning Resources

- Video tutorials available
- Step-by-step user guide
- FAQ section in app
- In-app help documentation

---

## 📄 License

**Professional Edition** - All Rights Reserved  
© 2026 BARAKA TANZANIA

---

## 🤝 Support the Project

For bugs, feature requests, or suggestions:
- Contact WhatsApp: 0782700859
- Email support available

---

## 🎉 Version History

### v1.0.0 (Current)
- ✅ Initial release
- ✅ 6 device brands supported
- ✅ FRP removal tool
- ✅ Hard reset & factory reset
- ✅ Settings & profile management
- ✅ Support center
- ✅ Professional UI

---

**Making Device Management Easy & Accessible** 🚀
