# ECommerce Microservices Project
**Microservices architecture** which includes microservices over .NET Core, using **ASP.NET Web API, Docker, RabbitMQ, MassTransit, MediatR, FluentValidations, Grpc, Yarp API Gateway, PostgreSQL, Marten, Redis, SQLite, SqlServer, Entity Framework Core, CQRS, DDD, Vertical and Clean Architecture** implementation with using latest features of **.NET 8** and **C# 12**.

![image](https://github.com/venellinus1/ECommerceMicroservices/assets/34251748/23a59ac5-431f-4e61-b4e1-86a76fd21d4b)

## Internal Architecture:

### Catalog microservice:
![image](https://github.com/venellinus1/ECommerceMicroservices/assets/34251748/0d2676dc-b7d0-4acb-9dfc-787f9d9fc64d)

- Using **ASP.NET Core Minimal APIs** and latest features of .NET8 and C# 12 (eg primary constructors, collection expressions, inline arrays..)
- **Vertical Slice Architecture** implementation with Feature folders and single .cs file includes different classes in one file
- **CQRS** implementation using **MediatR** library
- **CQRS** Validation Pipeline Behaviors with **MediatR** and **FluentValidation**
- Use **Marten** library for .NET Transactional **Document DB** on **PostgreSQL**, so Product microservices database will be **PostgreSQL** but acting as a **Document DB** using **Marten** library
- Use **Carter** for **Minimal API** endpoint definition
- **Cross-cutting concerns:** Logging, Global Exception Handling and Health Checks
- Implemented **Dockerfile** and **docker-compose** file for running Product microservice and PostgreSQL database in **Docker environment**



### Basket microservice:
![image](https://github.com/venellinus1/ECommerceMicroservices/assets/34251748/9068c257-878d-4019-bbe5-a250ef511362)

- **ASP.NET 8** Web API application, **REST API**, **CRUD**
- Using **Redis** as a Distributed Cache over basketdb
- Implements **Proxy**, **Decorator** and **Cache-aside** patterns
- Consume **Discount Grpc** Service for inter-service sync communication to calculate product final price
- Publish BasketCheckout Queue with using **MassTransit** and **RabbitMQ**


### Discount microservice:
![image](https://github.com/venellinus1/ECommerceMicroservices/assets/34251748/01c9e080-db96-4fd9-9dd7-512e788c4a78)

- **ASP.NET gRPC** Service application
- Build a Highly Performant inter-service **gRPC** Communication with Discount and Basket Microservice
- gRPC Communications, Proto files CRUD operations
- Exposing Grpc Services with creating **Protobuf** messages
- **SQLite** database connection and containerization
- **Entity Framework Core ORM** — **SQLite** Data Provider and **Migrations** to simplify data access and ensure high performance
- **N-Layer Architecture** implementation
- Containerize Discount Microservices with SQLite database using Docker Compose

### Ordering microservice:
![image](https://github.com/venellinus1/ECommerceMicroservices/assets/34251748/406a4978-bbd1-45ce-931a-f5ea56235a72)

- **ASP.NET Core** Web **Minimal APIs** for building fast HTTP APIs-fully functioning REST endpoints for CRUD operations
- Implementing **DDD**, **CQRS**, and **Clean Architecture** with using Best Practices
- Apply **SOLID Principles**, **Dependency Injection**
- Raise and handle **Domain Events** & **Integration Events**
- **Entity Framework Core Code-First Approach, Migrations, DDD Entity Configurations**
- **Clean Architecture** implementation (Domain, Application, Infrastructure, API layers) on **Entity Framework** and **SQL Server**
- Consuming **RabbitMQ** BasketCheckout event queue with using **MassTransit-RabbitMQ** Configuration
- Containerize Ordering Microservices with SQL Server database

## Final Application
![image](https://github.com/venellinus1/ECommerceMicroservices/assets/34251748/4886e265-7eaa-4fab-b9b5-763dc0343adf)

Note: this project is developed following the Udemy course:
https://www.udemy.com/course/microservices-architecture-and-implementation-on-dotnet/?couponCode=JUNE24
