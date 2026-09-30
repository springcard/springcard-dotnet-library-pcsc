# SpringCard.PCSC.Bridges

[![NuGet Version](https://img.shields.io/nuget/v/SpringCard.PCSC.Bridges.svg)](https://www.nuget.org/packages/SpringCard.PCSC.Bridges)
[![NuGet Downloads](https://img.shields.io/nuget/dt/SpringCard.PCSC.Bridges.svg)](https://www.nuget.org/packages/SpringCard.PCSC.Bridges)
[![License](https://img.shields.io/badge/license-SpringCard-blue.svg)](LICENSE.txt)

**SpringCard PCSC Bridges Library** - Bridge components for PCSC compatibility

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

**SpringCard.PCSC.Bridges** is a .NET library developed by SpringCard, providing bridge components to ensure compatibility between different PCSC implementations and versions. This library enables seamless integration with various smart card reader drivers and PCSC stacks.

Originally developed for internal use at SpringCard, this library has been made available to facilitate interoperability in complex PCSC environments.

---

## ✨ Features

### Compatibility Bridges
- **Driver Compatibility**: Work with various smart card reader drivers
- **PCSC Version Bridges**: Support for different PCSC versions and implementations
- **Platform Abstraction**: Unified API across different platforms
- **Legacy Support**: Compatibility with older PCSC implementations

### Integration Features
- **ZeroDriver Integration**: Bridge to SpringCard.PCSC.ZeroDriver for advanced features
- **Seamless Integration**: Transparent integration with existing PCSC code
- **Fallback Mechanisms**: Automatic fallback to alternative implementations when needed

### Advanced Capabilities
- **Protocol Translation**: Translate between different PCSC protocol implementations
- **Error Handling**: Robust error handling and recovery mechanisms
- **Performance Optimization**: Optimized data transfer between components

---

## 🎯 Supported Frameworks

SpringCard.PCSC.Bridges supports multiple target frameworks:

- **.NET 6.0**
- **.NET 10.0**
- **.NET Framework 4.8**

---

## 🚀 Installation

### Via NuGet Package Manager

```powershell
Install-Package SpringCard.PCSC.Bridges
```

### Via .NET CLI

```bash
dotnet add package SpringCard.PCSC.Bridges
```

### Via PackageReference in csproj

```xml
<PackageReference Include="SpringCard.PCSC.Bridges" Version="[latest-version]" />
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
| **Package ID** | SpringCard.PCSC.Bridges |
| **Author** | SpringCard |
| **Copyright** | Copyright © SpringCard SAS, France, 2008-2026 all rights reserved |

---

## 🔄 Version History

For complete version history, see the [NuGet Package Page](https://www.nuget.org/packages/SpringCard.PCSC.Bridges).

---

## 📝 Notes

- This library is actively maintained by SpringCard
- Compatible with Windows, Linux, and macOS environments (depending on target framework)
- Designed for use with SpringCard hardware devices
- Requires SpringCard.PCSC.ZeroDriver as dependency
- Enables compatibility with various PCSC implementations
- Optimized for performance and reliability
- Extensively tested in production environments

---

*Made with care by SpringCard SAS, France*
