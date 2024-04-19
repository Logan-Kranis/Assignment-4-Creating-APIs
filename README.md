# SmartCrop: Farm Management System

SmartCrop is a comprehensive Farm Management System designed to assist farmers in effectively managing their farms. It offers a variety of functionalities through a user-friendly web interface, empowering users with tools for updating farm details, deleting farm records, accessing geographic information, and receiving weather updates.

## Features

### Farm Management API
- **Update Farm Information**: Users can update details such as farm name, location, size, and type of produce. A form validation mechanism ensures data integrity.
- **Delete Farm**: This feature allows users to remove their farm from the system with a confirmation prompt for safeguarding against accidental deletions.

### Nearest City to Farm API
- **Display Nearest City**: Utilizing farm coordinates, the system calculates and displays the nearest city, including details like city name and distance, along with demographic or market information.

### Farm Weather Forecast API
- **Display Weather Forecast**: Fetches real-time weather data for the farm's location, presenting information on current conditions and forecasts. Users can toggle between hourly, daily, or weekly forecasts.
- **Weather Alert Notifications**: Provides notifications for severe weather conditions, with recommendations for mitigation actions. Options are available for receiving alerts via email or SMS.

### Homepage
- Features a welcome message, a navigation menu for accessing various sections of the website, and a weather dashboard with real-time information.

### User Profile
- Displays user-specific information and activities, offering profile customization options.

## Branches
- **Main Branch**: Contains the production-ready code.
- **Logan's Branch & Ahmed's Branch**: Include development and feature-specific code.

## Installation

To run the SmartCrop Farm Management System locally, follow these steps:
1. Clone the repository:
   ```bash
   git clone https://github.com/Logan-Kranis/Assignment-4-Creating-APIs
2. git clone https://github.com/Logan-Kranis/Mist-353-group-Project/blob/main/LoganKranisSP.sql
3. git clone https://github.com/Logan-Kranis/Assignment-4-Creating-APIs.git


## Resources

- **HttpContextFactory and its usage:** [Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.http.defaulthttpcontextfactory?view=aspnetcore-5.0)
- **Executing stored procedures in C#:** [StackOverflow](https://stackoverflow.com/questions/1260952/how-to-execute-a-stored-procedure-within-c-sharp-program)
- **Dependency injection in .NET:** [Microsoft Docs](https://learn.microsoft.com/en

## Prompts For ChatGPT (Ahmed Ismail)


## Overview

This document outlines various pieces of advice and step-by-step guides provided for integrating and utilizing `IHttpClientFactory` in an ASP.NET Core Razor Pages application, constructing and updating Razor Pages for farm management, resolving common issues, and correctly formatting Markdown for documentation.

### Integrating `IHttpClientFactory`

Advice on integrating `IHttpClientFactory` and setting up HTTP requests within a Razor Page model was provided, highlighting the necessity of registering `IHttpClientFactory` in `Startup.cs` for dependency injection and demonstrating how to modify the Page Model to make API calls. 

### Constructing a Razor Page for Updating Farm Details

Instructions were given on constructing a Razor Page for updating farm details. This included:
- Setting up the model and page model.
- Designing the HTML form.
- Handling database updates and form submissions within an ASP.NET Core Razor Pages application.

### Resolving `InvalidOperationException`

Clarification was provided on resolving an `InvalidOperationException` related to `IHttpClientFactory`. Key points emphasized included:
- The correct registration of `IHttpClientFactory` in `Startup.cs`.
- Ensuring that the ASP.NET Core version supports `IHttpClientFactory`.

### Addressing Method Errors within a Service

Guidance was offered on addressing a method error within a service in an ASP.NET Core application. The advice detailed potential issues such as incorrect data types, method definitions, and service instantiation, and highlighted best practices for method implementation and error handling.

### Building a Functional Website

A step-by-step guide was provided for building a functional website with ASP.NET Core Razor Pages that updates farm details. This guide covered:
- Creating the model.
- Setting up the database context.
- Defining the service layer.
- Configuring the Razor Page and Page Model for API interaction.

### Markdown Formatting for README Files

An explanation on how to correctly format Markdown content for a README file was given. This included demonstrating the structuring of features, installation steps, resources, and contributor acknowledgments for a project repository.

---

*Note: For specific implementation details, code snippets, and further instructions, refer to the actual project documentation and source code.*

## Contributors

- Logan Kranis
- Ahmed Ismail
