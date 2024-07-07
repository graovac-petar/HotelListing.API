# Hotel Listing API

## Overview
Hotel Listing API is a RESTful web service designed for managing a comprehensive database of hotels. This API provides endpoints for CRUD operations on hotels, allowing users to add, update, retrieve, and delete hotel data as well as Country these hotels are from. 
In this application thay are two types of users admin and basic user. Admin can administrate hotels and user can book them. 

## Technologies
- **ASP.NET Core**: Used for building the API.
- **Entity Framework Core**: For database operations.

## Features
CRUD Hotels
CRUD Countries
LogIn and SignIn using Identity

## Installation
To set up the project locally, follow these steps:
1. Clone the repository:
2. Navigate to the project directory:
3. Restore the necessary packages:
4. Update the database:
5. Start the application:

Example:
- **GET /api/hotels**: Returns a list of all hotels.
- **POST /api/hotels**: Creates a new hotel entry.
- **PUT /api/hotels/{id}**: Updates an existing hotel.
- **DELETE /api/hotels/{id}**: Deletes a specific hotel.
