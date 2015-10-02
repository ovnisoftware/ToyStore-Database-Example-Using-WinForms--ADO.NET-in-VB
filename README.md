# ToyStore-Database-Example-Using-WinForms--ADO.NET-in-VB
Winforms app accesses SQL database using ADO.NET written in VB.NET

This is a 3 layer application with Winforms as the presentation layer, VB.NET code in the logic layer and ADO.NET to SQL Server on the database layer.  I used object data sources to access the data. 

Here's what the frontend looks like:
http://ovnisoftware.com/images/ToyStoreApp.jpg

How to get it to work

1. Create a database called ToyStore in Sql Server (App was tested on SQL Server 2014)

2. Execute the Create.txt script to create the schema

3. Execute the Populate.txt script to populate the schema with data

4. Change the connection string in ToyStoreDataDB.vb to link to your database

The create.txt and populate.txt database scripts come from Sam's Teach Yourself SQL in 10 Minutes.  I made a couple minor changes to them.

http://www.amazon.com/SQL-Minutes-Sams-Teach-Yourself/dp/0672336073/
