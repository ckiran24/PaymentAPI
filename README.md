# Payment Processing System (.NET + OOPS)

This project is a simple ASP.NET Core Web API built to demonstrate
Object-Oriented Programming (OOPS) concepts using C# and .NET.

## Tech Stack
- ASP.NET Core Web API
- C#
- Swagger (Swashbuckle)

## OOPS Concepts Demonstrated

### 1. Abstraction
An interface `IPaymentService` defines the contract for payment processing
without exposing implementation details.

### 2. Polymorphism
Multiple implementations (`CardPaymentService`, `UpiPaymentService`)
provide different behaviors using the same interface.

### 3. Composition
A `PaymentServiceResolver` composes the appropriate payment service
based on runtime input.

### 4. Dependency Injection
Services are registered using ASP.NET Core's built-in DI container
with scoped lifetime.

## Project Structure
PaymentAPI
├── Controllers
├── Services
│ ├── Interfaces
│ └── Implementations
├── Models
└── Program.cs


## How to Run
1. Navigate to backend/PaymentAPI
2. Run `dotnet run`
3. Open Swagger at `http://localhost:<port>/swagger`

## Example API Usage
- Endpoint: POST /api/payment
- Parameters:
  - type: card | upi
  - amount: decimal

## Purpose
This project was created to demonstrate clean backend design,
OOPS principles, and dependency injection in .NET.
