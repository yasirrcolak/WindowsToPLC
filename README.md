# WindowsToPLC

Connect Windows Form App to Siemens TIA Portal S7-1200 series PLC 

## Summary

This project is basically a Windows Forms application. 
It communicates with a Siemens S7-1200 series PLC running on the "TIA Portal" application via TCP/IP protocol.
All these actions are recorded in the MySQL database to be reported later.

## Client Side

Client Side is C# Windows Form Application.
All control and reporting is done through this application.

## CPU Side

CPU Side is Siemens S7-1200 Series PLC project on TIA Portal Application.
The PLC computer in this project performs the commands it receives from the Windows Form application over the TCP/IP protocol.

## Database Side

It is a MySQL database that records every action done through the Windows Form application for reporting.

## Other Dependencies

A 'Net to PLC' application is needed to create the necessary TCP/IP protocol connection so that the actions performed on the Windows Form application programmed with C# language on the Visual Studio IDE can reach the S7-1200 series PLC running on the PLC simulation module embedded in the TIA Portal. heard and downloaded and installed.

I downloaded and installed the 'XAMPP' program to create the server required for database access.
