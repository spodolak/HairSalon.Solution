# _Hair Salon_

#### _Epicodus C# Database Practice_, _Mar. 18, 2020_
#### A web application for a hair salon (an exersize utilizing one to many object relationships)

#### By _**Stephanie Podolak**_

## Description
A program designed to practice building databases with mySQL and estabish one-to-may relationships between database objects. The web application allows the user to add stylists and clients and display both in relation to eachother. Clients can be viewed by stylist, and client details will also include stylist details when selected.

## Specifications:

| Specification | Example Input | Example Output |
| :-------------:|:-------------:|:-------------:|
| User will be able to view all stylists in database | user navigates to stylists page | page displays all sylists in database |
| User selects a stylists and can see their details, including a list of all clients that belong to that stylist | user clicks stylist name | stylist details displayed |
| User is able to add new stylists to our database when they are hired | User inputs sylist detail to form | stylist details are stored and displayed |
| User is able to add new clients to a specific stylist's roster | User inputs client details including their unique stylist | client details are stored and displayed |
| Web page does not allow new client to be added if no stylists are added | User navigates to add client page | Site displays error message and client intake form is not displayed |

## Setup/Installation Requirements

To use this application, follow the following instructions. 

#### Installing .NET core

##### For macOS: 

* Dowload [this .NET Core SDK](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) which will prompt a .pkg file download from Microsoft.

* Open the file. This will launch and walk you through installation steps. Use default settings. 

* Confirm the installation is successful by opening the terminal and running the command ``$ dotnet --version``. You should see something like ``2.2.105`` in response.

##### For Windows: 
* Visit the [Microsoft .NET Installation Guide](https://docs.microsoft.com/en-us/dotnet/framework/install/).

#### Installing donet script

* After installing .NET Core, run the command `` dotnet tool install -g dotnet-script `` in Terminal. 

#### Application Setup:
_Clone this repository via Terminal using the following commands:_
* > ``$ cd desktop``
* >``$ git clone "https://github.com/spodolak/HairSalon.Solution.git" ``
* >``$ cd HairSalon.Solution``

_Set up a local project database to edit and view in MySQL Workbench use the following SQLcommands:_
* > CREATE DATABASE ` stephanie_podolak`;
* > USE `stephanie_podolak`;
* > CREATE TABLE `clients` (
  `ClientId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Number` int NOT NULL DEFAULT '0',
  `StylistId` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`ClientId`)
) ;
* > CREATE TABLE `stylists` (
  `StylistId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Specialty` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
) ;

 


_To Run this Console Application, enter the following commands in the Terminal:_

* >``$ dotnet restore``
* >``$ dotnet build``
* >``$ dotnet run``

_To view the source code of this application, open the folder in the Text Editor of your choice. (Example: to open via Visual Code enter the command ``code . `` in Terminal.)_

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_
* _MySQL Workbench 8.0_
* _dotnet script_
* _VS Code_

### License

*This application is licensed under the MIT license.*

Copyright (c) 2020 **_Stephanie Podolak_**
