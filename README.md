# Student Management System API

A RESTful API for managing student records built with ASP.NET Core, implementing the CQRS (Command Query Responsibility Segregation) pattern with MediatR library.

## Overview

This project demonstrates a clean architecture approach to building web APIs using modern design patterns. The system allows for complete CRUD operations on student records while maintaining separation of concerns through CQRS implementation.

## Features

- Create new student records
- Retrieve all students
- Retrieve individual student by ID
- Update existing student information
- Delete student records
- In-memory data storage
- CQRS pattern implementation
- RESTful API design
- Interactive API documentation with Swagger

## Technical Implementation

### Design Patterns

**CQRS Pattern**  
The application separates read operations (queries) from write operations (commands). This separation allows for independent optimization and scaling of each operation type.

**Mediator Pattern**  
MediatR library is used to implement the mediator pattern, which reduces direct dependencies between components and centralizes request handling logic.

**Repository Pattern**  
Data access is abstracted through a repository interface, making the codebase more maintainable and testable.

