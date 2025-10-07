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
        }
    }
}
