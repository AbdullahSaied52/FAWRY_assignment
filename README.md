\# FAWRY Internship - Technical Assessment Solution



\## Overview

This repository contains the implementation of the technical assignment required for the FAWRY Internship Program. The project is built using C# and adheres to layered architecture principles to ensure code maintainability, clear separation of concerns, and scalability.



\---



\## Project Structure



```text

FAWRY\_assignment/

├── CarDTO/             # Data Transfer Objects (DTOs)

├── process\_layer/      # Business logic layer to process requests

├── Program.cs          # Application entry point

├── App.config          # Application configurations

└── FAWRY\_assignment.sln # Visual Studio Solution



Architecture and Design Principles

Separation of Concerns: Clear boundary between data representations (CarDTO) and core logic (process\_layer).



Data Transfer Object Pattern: Encapsulates data and facilitates safe transfer between layers.



Business Processing Layer: Centralizes domain rules and logic handling.

