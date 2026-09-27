# Cinema Management System

A Windows desktop application for running a cinema: managing films, scheduling
showings and booking seats. I built this in 2021 as a university project while
learning C#, and it is here as a record of that work rather than as an example of
how I write code today.

## What it does

- Manage films and their details
- Schedule showings
- Book and cancel seats for a showing
- Keep everything in a SQL Server database

## Built with

C# and .NET Framework, Windows Forms for the interface, and a typed DataSet over
SQL Server for data access.

## Running it

Open `CMS/CMS.sln` in Visual Studio, point the connection string in `App.config`
at your own SQL Server instance, and run.

## What I would change today

The forms still carry their default names from the designer, the data access sits
directly in the UI layer, and there are no tests. If I rebuilt it now I would
separate the database code from the forms, give the classes names that say what
they do, and write tests for the booking logic.
