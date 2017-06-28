# Lab 06 - Entity Framework Core

## Create a Model

1. Create a .NET Core console application
2. Create a model type, e.g. the class `Book`
3. Add properties to the model type, e.g. BookId, Title, and Publisher

## Create a Context

1. Create a BooksContext class that derives from DbContext
2. Add the necessary NuGet packages
3. Define a property to access the Book type using DbSet

## Add new objects

1. Instantiate the context in the `Main` method
2. Add new objects
3. Save changes

## Make a connection to the SQL Server database

1. Override the configuring method of the context
2. Configure to use SQL Server
3. Add the necessary NuGet package
4. Create a database on starting the application

## Migrations

1. Configure the *dotnet ef* tool in project.json
2. Enable migrations with the project
3. Change the model type by adding an additional property
4. Define code migrations for the update
5. Run migrations from code and using the dotnet tool

## Entity Framework with ASP.NET Core MVC 

1. Add the required NuGet packages for Entity Framework to the project you created with previous labs
2. Create an EF context for the entity type you created earlier
3. Define the constructor needed with EF using dependency injection
4. Configure the context in the dependency injection container
5. Create the database programmatically
5. Create a new controller to write a new record to the database