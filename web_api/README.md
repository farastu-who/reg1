### Communication Flow

The web_api will be responsible for handling business logic, database interactions, and serving data to the React frontend.

1. HTTP Requests: The controllers receive HTTP requests related to different entities (companies, products, etc.).

2. Repository Usage: Controllers use repositories to perform CRUD operations. Repositories abstract the database operations.

3. Database Interaction: Repositories interact with the database through RegistrationDbContext, which uses Entity Framework to manage database operations.

4. Service Registration: In Program.cs, services (like repositories) and the database context are registered for dependency injection, allowing controllers to use them.

5. Configuration: The application's configuration (like database connection strings) is managed in appsettings.json and Program.cs.
