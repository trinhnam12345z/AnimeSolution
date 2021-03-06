# ASP .NET Core 3.1 Project
_ASP .NET Core 3.1 Project, design a Anime Website for watching movie,..._

_Copyright ©2020 All rights reserved | This template is made by Colorlib._

_For education only._
### Tools/Required
- ASP .NET Core 3.1
- Entity Framework Core 3.1
- Visual Studio Community/Professional (2019)
- .NET Core 3.1 SDK
- SQL Server 2019
- Git client
-----
## Installed Packages
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.Extensions.Configuration.FileExtensions
- Microsoft.Extensions.Configuration.Json
-----
## Features
- Admin page for management.
- Frontend page for customer.
- Git source control.
- Database design (temporary).
![kxz54IX](https://user-images.githubusercontent.com/70925557/98659669-efba2900-2376-11eb-84a9-2e6ff5cf07f0.png)
-----
## How to Configure and Run
- Clone code from Github: git clone https://github.com/hntdahta/AnimeSolution
- Open solution AnimeSolution.sln in Visual Studio 2019
- Set startup project is AnimeSolution.Data
- Change connection string in appsettings.json in AnimeSolution.Data project
- Open Tools --> Nuget Package Manager --> Package Manager Console in Visual Studio
- Type <Update-Database> and Enter.
- After migrating database successfully, set Startup Project is AnimeSolution.WebApp
- Change database connection in appsettings.Development.json in AnimeSolution.WebApp project.
- Choose profile to run or press F5
-----
## Template
- Admin: https://startbootstrap.com/templates/sb-admin/
- Main: https://colorlib.com/wp/template/anime/
-----
## Internalization
References: https://medium.com/swlh/step-by-step-tutorial-to-build-multi-cultural-asp-net-core-web-app-3fac9a960c43
