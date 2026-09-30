# SpringCard.PCSC.ZeroDriver

[![NuGet Version](https://img.shields.io/nuget/v/SpringCard.PCSC.ZeroDriver.svg)](https://www.nuget.org/packages/SpringCard.PCSC.ZeroDriver)
[![NuGet Downloads](https://img.shields.io/nuget/dt/SpringCard.PCSC.ZeroDriver.svg)](https://www.nuget.org/packages/SpringCard.PCSC.ZeroDriver)
[![License](https://img.shields.io/badge/license-SpringCard-blue.svg)](LICENSE.txt)

**SpringCard PCSC Zero Driver Library** - Advanced PCSC driver implementation

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

**SpringCard.PCSC.ZeroDriver** is a .NET library developed by SpringCard, providing an advanced implementation of PCSC (Personal Computer/Smart Card) driver functionality. This library enables direct communication with smart card readers using various transport protocols.

Originally developed for internal use at SpringCard, this library has been made available to facilitate advanced PCSC operations in .NET applications.

---

## ✨ Features

### Transport Protocols
- **CCID Over USB**: Direct USB communication with CCID-compliant readers
- **CCID Over Bluetooth**: Bluetooth transport for mobile readers
- **CCID Over Network**: Network-based communication with remote readers
- **CCID Over Serial**: Serial port communication
- **CCID Over Secure**: Secure communication channels

### Reader Support
- **Multiple Reader Types**: Support for various SpringCard reader models
- **Automatic Detection**: Detect and identify connected readers
- **Hot Plugging**: Support for dynamic reader connection/disconnection

### Advanced Features
- **APDU Level Access**: Direct APDU command/response handling
- **Extended APDU**: Support for extended length APDUs
- **Secure Messaging**: Encrypted communication with readers

---

## 🎯 Supported Frameworks

SpringCard.PCSC.ZeroDriver supports:

- **.NET 6.0**
- **.NET 10.0**
- **.NET Framework 4.8**

---

## 🚀 Installation

### Via NuGet Package Manager

```powershell
Install-Package SpringCard.PCSC.ZeroDriver
```

### Via .NET CLI

```bash
dotnet add package SpringCard.PCSC.ZeroDriver
```

### Via PackageReference in csproj

```xml
<PackageReference Include="SpringCard.PCSC.ZeroDriver" Version="[latest-version]" />
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
| **Package ID** | SpringCard.PCSC.ZeroDriver |
| **Author** | SpringCard |
| **Copyright** | Copyright © SpringCard SAS, France, 2008-2026 all rights reserved |

---

## 🔄 Version History

For complete version history, see the [NuGet Package Page](https://www.nuget.org/packages/SpringCard.PCSC.ZeroDriver).

---

## 📝 Notes

- This library is actively maintained by SpringCard
- Compatible with Windows, Linux, and macOS environments (depending on target framework)
- Requires SpringCard.PCSC library as dependency
- Designed for use with SpringCard hardware devices
- Supports various transport protocols
- Optimized for performance and reliability
- Extensively tested in production environments

---

*Made with care by SpringCard SAS, France*
