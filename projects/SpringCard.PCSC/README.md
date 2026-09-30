# SpringCard.PCSC

[![NuGet Version](https://img.shields.io/nuget/v/SpringCard.PCSC.svg)](https://www.nuget.org/packages/SpringCard.PCSC)
[![NuGet Downloads](https://img.shields.io/nuget/dt/SpringCard.PCSC.svg)](https://www.nuget.org/packages/SpringCard.PCSC)
[![License](https://img.shields.io/badge/license-SpringCard-blue.svg)](LICENSE.txt)

**SpringCard PCSC Library** - Core PCSC (Personal Computer/Smart Card) access library

---

## 📋 Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Supported Frameworks](#supported-frameworks)
- [Installation](#installation)
- [API Documentation](#api-documentation)
- [License](#license)
- [Support](#support)

---

## 📖 Overview

**SpringCard.PCSC** is the core .NET library developed by SpringCard for PCSC (Personal Computer/Smart Card) access. This library provides the fundamental functionality for communicating with smart card readers and smart cards in .NET applications.

As the foundation of the SpringCard PCSC suite, this library has been designed for reliability, performance, and ease of use. Originally developed for internal use at SpringCard, it is now available to facilitate PCSC integration across various .NET platforms.

---

## ✨ Features

### Core PCSC Functionality
- **Reader Detection**: Automatic detection of connected smart card readers
- **Card Communication**: Read and write operations with smart cards
- **APDU Commands**: Send and receive APDU (Application Protocol Data Unit) commands
- **Reader Monitoring**: Track reader connection/disconnection events

### Smart Card Operations
- **Card Insertion/Removal**: Automatic detection of card presence
- **ATR Analysis**: Parse and interpret Answer-To-Reset data
- **Protocol Selection**: Support for T=0, T=1, and other protocols
- **Extended APDU**: Support for extended length APDU commands

### API Design
- **Simple and Intuitive**: Easy-to-use API for common PCSC operations
- **Event-Driven**: Asynchronous notifications for card and reader events
- **Thread-Safe**: Safe for use in multi-threaded applications
- **Comprehensive**: Full access to PCSC functionality

---

## 🎯 Supported Frameworks

SpringCard.PCSC supports multiple target frameworks:

- **.NET 6.0**
- **.NET 10.0**
- **.NET Framework 4.8**

---

## 🚀 Installation

### Via NuGet Package Manager

```powershell
Install-Package SpringCard.PCSC
```

### Via .NET CLI

```bash
dotnet add package SpringCard.PCSC
```

### Via PackageReference in csproj

```xml
<PackageReference Include="SpringCard.PCSC" Version="[latest-version]" />
```

---

## 📚 API Documentation

For complete API documentation, please refer to the official SpringCard documentation:

- **[SpringCard PCSC Documentation](https://docs.springcard.com/apis/PCSC/index.html)**

---

## 📜 License

This library is licensed under SpringCard proprietary license. See LICENSE.txt for full license text.

```
Copyright (c) 2008-2026 SpringCard - www.springcard.com
All rights reserved
```

---

## 🆘 Support

For support and inquiries:

- **Website**: [https://www.springcard.com](https://www.springcard.com)
- **Email**: support@springcard.com

---

## 🏷️ Package Information

| Property | Value |
|----------|-------|
| **Package ID** | SpringCard.PCSC |
| **Author** | SpringCard |
| **Copyright** | Copyright © SpringCard SAS, France, 2008-2026 all rights reserved |

---

## 🔄 Version History

For complete version history, see the [NuGet Package Page](https://www.nuget.org/packages/SpringCard.PCSC).

---

## 📝 Notes

- This library is actively maintained by SpringCard
- Compatible with Windows, Linux, and macOS environments (depending on target framework)
- Designed for use with SpringCard hardware devices
- Requires PCSC-Lite on Linux/macOS or PCSC service on Windows
- Optimized for performance and reliability
- Extensively tested in production environments
- Foundation library for other SpringCard.PCSC packages

---

*Made with care by SpringCard SAS, France*
