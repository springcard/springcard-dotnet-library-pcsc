# SpringCard PC/SC Library for .NET

[![NuGet](https://img.shields.io/nuget/v/SpringCard.PCSC.svg)](https://www.nuget.org/packages/SpringCard.PCSC)

**SpringCard.PCSC** provides reusable .NET classes for communicating with PC/SC readers, contact and contactless smart cards, and NFC/RFID tags. It handles reader discovery, reader and card monitoring, card connections and ISO 7816 APDU exchanges.

This repository contains the library source code and related components. **For integration into your own application, use the published NuGet packages whenever possible**.

## Installation

Install [**SpringCard.PCSC from NuGet**](https://www.nuget.org/packages/SpringCard.PCSC) using the .NET CLI:

```bash
dotnet add package SpringCard.PCSC
```

Alternatively, use the NuGet Package Manager in Visual Studio or its Package Manager Console:

```powershell
Install-Package SpringCard.PCSC
```

NuGet provides versioned releases and resolves package dependencies. Use this repository when you need to inspect the implementation or build from source. See the package page for available versions and framework compatibility.

## Library and examples

The core library provides the functional implementation reused by SpringCard applications. Sample applications and command-line and graphical tools are available in the [**SpringCard PC/SC SDK**](https://github.com/springcard/springcard.pcsc.sdk), the main reference for SDK examples and their ongoing development.

This repository also includes components for Windows Forms and Avalonia interfaces, alternative reader transports and bridge services. See the individual project READMEs under [projects](projects) for their scope and requirements.

## Platforms and source code

The core library includes native PC/SC bindings for Windows, Linux and macOS. Your system must provide a working PC/SC service and the appropriate reader drivers. Operating system and framework compatibility depend on the selected project and package.

To work with the source code, open [projects/SpringCard.PCSC.sln](projects/SpringCard.PCSC.sln) in a compatible development environment and restore its NuGet dependencies. Framework targets are defined in the project files and [projects/Directory.Build.props](projects/Directory.Build.props).

## Documentation

- [PC/SC API documentation](https://docs.springcard.com/apis/PCSC/index.html)
- [SDK examples and tools](https://github.com/springcard/springcard.pcsc.sdk)
- [SpringCard .NET packages](https://www.nuget.org/profiles/SpringCard)

## Licence

**Please read and comply with the SpringCard SDK licence before using, modifying or redistributing this software. Installation through NuGet does not change the licence conditions.**

The full terms are provided in [LICENSE.txt](LICENSE.txt) and the [licence distributed with the packages](projects/LICENSE.txt). In particular:

- Redistributed source or binary code may be used only in conjunction with hardware manufactured, distributed or developed by SpringCard.
- Source distributions must retain the copyright notices, licence conditions and disclaimer.
- Redistributed modifications must be clearly identified as "Code derived from original SPRINGCARD copyrighted source code", with a description of the changes and the author's name.
- Binary distributions must reproduce the copyright notices, licence conditions and disclaimer in their documentation or accompanying materials.
- The SpringCard name must not be used for endorsement or promotion without prior written permission.

The software is provided "AS IS", without warranty. Third-party components remain subject to their respective licences; preserve their applicable notices, including [the native PC/SC bindings licence](projects/SpringCard.PCSC/Native/COPYING).

This summary does not replace the full licence terms.