# Dr. Sillystringz's Factory

#### An ASP.NET Core MVC factory admin panel application to create maintenance orders between engineers and machines.

#### The factory management is be able to add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines.

#### By [Onur Kaymak](https://onurkaymak.com)

## Technologies Used

- C#
- .NET 6
- Razor
- EF Core
- MySQL
- MySQL Workbench
- VS Code

## Description

An independent C# / ASP .NET project assignment for [Epicodus](https://www.epicodus.com/), project is about "Many-To-Many Relationships in MySQL".

## Important - This project requires

- [.NET 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

- [MySQL](https://dev.mysql.com/downloads/mysql)

- [MySQL WorkBench](https://dev.mysql.com/downloads/workbench)

## Setup/Installation Requirements

- Clone this project from the provided GitHub repository: [Repository Link](https://github.com/onurkaymak/factory).

- Navigate into the project's folder in your terminal.

- Navigate into Factory directory in your terminal.

- Create a file called `appsettings.json`.

- Add the following code below in `appsettings.json` file.

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE];uid=[USERNAME];pwd=[PASSWORD];"
  }
}

```

- Replace the `USERNAME`,`PASSWORD` and `DATABASE` values with your own username and password for MySQL and your choice of database name.

### Creating the Database from Migrations

- After configuring your `appsettings.json`, you can create your database with migrations.

- Type `$ dotnet tool install --global dotnet-ef --version 6.0.0` to install a tool for Entity Framework Core, this tool allows us to create migrations and update our database. (This will install the EF Core migration tool globally in your machine.)

- To create your database by migrations navigate into `Factory` directory from root directory, type `dotnet ef database update` to create a database in your MySQL with your MySQL credentials that you provided in `appsettings.json` file.

### Run the Application

- Type `$ dotnet run` in the terminal command line to compile and execute this application while in Factory directory (Not the root directory Factory.Solution).

- IMPORTANT: `$ dotnet run` compiles the project folders for you without needing `$ dotnet build` command, however you can still use `$ dotnet build` if you need to compile the folders without executing the application.

- You will have a new browser tab open to view the application, you can also navigate `https://localhost:5000` manually to view it.

## Known Bugs

There is no known bugs.

## License

MIT License

Copyright (c) [2023] [Onur Kaymak]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
