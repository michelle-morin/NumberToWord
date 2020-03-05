# _Number to Word Converter_

#### _C# Testing practice for Epicodus_, _Mar. 5, 2020_

#### By _**Michelle Morin**_

## Description

_This console application translates numbers in numeric form into written words. For example, it would translate 384 into "three hundred eighty four"._

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
| Application takes input of a integer, and returns error message for all other inputs | "hello" | "invalid input" |
| Application returns "zero" for input of a 0 | 0 | "zero" |
| For a number with a single digit, the application returns the written form of that number | 1 | "one" |
| For a number with two digits, and the first digit is a 1, the application returns a unique term for that number | 10, 11, 12, etc. | "ten", "eleven", "twelve", etc. |
| For a number with two digits (first digit 2-9, second digit 0), the application returns the word for that number | 20 | "twenty" |
| For a number with two digits (each digit is between 2 and 9), the application returns a combination of words for each digit | 22 | application breaks this into 20 at the ten's place and 2 at the one's place, then returns "twenty two" |
| For a number with three digits, the application returns a combination of words corresponding to the first digit, the word "hundred", followed by the written form of the last two digits (as determined above) | 120 | "one hundred twenty" |
| For a number with four digits, the application returns a combination of words corresponding to the first digit, the word "thousand", followed by the written form of the last three digits (as determined above) | 1050 | "one thousand fifty" |
| For a number with five digits, the application returns a combination of words corresponding to the first two digits, the word "thousand", followed by the written form of the last three digits (as determined above) | 10,50 | "ten thousand fifty" |
| For a number with six digits, the application returns a combination of words corresponding to the first three digits, the word "thousand", followed by the written form of the last three digits (as determined above) | 250003 | "two hundred fifty thousand three" |
| For a number with seven digits, the application returns a word corresponding to the first digit, the word "million", followed by a combination of words corresponding to the next three digits, the word "thousand", followed by the written form of the last three digits (as determined above) | 7,500,385 | "seven million five hundred thousand three hundred eighty five" |
| For a number with eight digits, the application returns a word corresponding to the first two digits, the word "million", followed by a combination of words corresponding to the next three digits, the word "thousand", followed by the written form of the last three digits (as determined above) | 17,500,385 | "seventeen million five hundred thousand three hundred eighty five" |
| For a number with nine digits, the application returns a word corresponding to the first three digits, the word "million", followed by a combination of words corresponding to the next three digits, the word "thousand", followed by the written form of the last three digits (as determined above) | 327,599,707 | "three hundred twenty seven million five hundred ninety nine thousand seven hundred seven" |
| For a number with ten digits, the application returns a word corresponding to the first digit followed by the word "trillion", a word corresponding to the next three digits, the word "million", a combination of words corresponding to the next three digits, the word "thousand", followed by the written form of the last three digits (as determined above) | 4,327,599,707 | "four trillion three hundred twenty seven million five hundred ninety nine thousand seven hundred seven" |

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone`` followed by the URL to this repository.
* ``cd`` followed by the repository name.

_Confirm that you have navigated to the correct directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Run this console application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``dotnet run``

_To view/edit the source code of this application, open the contents of this directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_
* _dotnet script_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Michelle Morin_**