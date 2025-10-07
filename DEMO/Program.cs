namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Video 01

            /*
            *************** Architectural Patterns ***************
            -Web architectural patterns are proven solutions to common design problems in building web applications 
            - Layered Pattern
            -يتم تقسيم التطبيق الي 3 طبقات رئيسية 
                - Presentation Layer
                - Business Layer
                - Data Access Layer
            - Advantages:
                - Separation of Concerns
                - Maintainability
                - Scalability
                - Testability
                - Reusability

            -Data Access Layer
                - Responsible for interacting with the database
                - Contains methods for CRUD operations (Create, Read, Update, Delete)
                - Example: UserRepository, ProductRepository

            -Business Layer
                - Contains the core business logic of the application
                - Processes data received from the Data Access Layer
                - Applies business rules and validations
                - Example: UserService, ProductService
            -Presentation Layer
                - Responsible for handling user interactions
                - Displays data to the user and captures user input
                - Example: Controllers in MVC, Razor Pages, Blazor Components
             */

            #endregion

            #region Video 02
            /*
             *************** Data Access Layer ***************
             - Class Library Project
             - Responsible for interacting with the database
             - Contains methods for CRUD operations (Create, Read, Update, Delete)
             - Example: UserRepository, ProductRepository
                - Common Technologies:
                    - Entity Framework Core
                    - Dapper
                    - ADO.NET
                - Best Practices:
                    - Use Repository Pattern
                    - Implement Unit of Work Pattern
                    - Handle Exceptions Gracefully
                    - Optimize Queries for Performance
                    - Use Asynchronous Programming for I/O Operations

             ***************  Business Logic Layer ***************
             - Class Library Project
             - Contains the core business logic of the application
             - Processes data received from the Data Access Layer
             - Applies business rules and validations

             ***************  Business Logic Layer ***************
             -The Presentation Layer is the entry point of the application
             - Responsible for handling user interactions
             - Displays data to the user and captures user input
             - Example: Controllers in MVC, Razor Pages, Blazor Components
             */


            #endregion

            #region Video 03

            /*
              *************** Dependency Injection  ***************
              - A design pattern used to implement IoC (Inversion of Control)
              - Allows the creation of dependent objects outside of a class and provides those objects to a class in different ways
              - Instead of the object creating its own dependencies, we pass them to it from the outside (CLR).
              -The purpose of DI
                    - To achieve loose coupling between classes and their dependencies
                    - To enhance testability and maintainability of the code
                - Common Types of Dependency Injection:
                    - Constructor Injection
                    - Property Injection
                    - Method Injection
                - Benefits of Dependency Injection:
                    - Improved Code Maintainability
                    - Enhanced Testability
                    - Reduced Boilerplate Code
                    - Better Separation of Concerns
                - Dependency Injection in ASP.NET Core:
                    - Built-in support for Dependency Injection
                    - Services are registered in the Startup.cs file using the IServiceCollection interface
                    - Services can be injected into controllers, middleware, and other services via constructor injection
                - Example of Registering Services in ASP.NET Core:
                        public void ConfigureServices(IServiceCollection services)
                        {
                            services.AddScoped<IUserRepository, UserRepository>();
                            services.AddScoped<IUserService, UserService>();
                            services.AddControllersWithViews();
                        }
             */

            #endregion
        }
    }
}
