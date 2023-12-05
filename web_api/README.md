### Communication Flow

The web_api will be responsible for handling business logic, database interactions, and serving data to the React frontend.

1. HTTP Requests: The controllers receive HTTP requests related to different entities (companies, products, etc.).

2. Repository Usage: Controllers use repositories to perform CRUD operations. Repositories abstract the database operations.

3. Database Interaction: Repositories interact with the database through RegistrationDbContext, which uses Entity Framework to manage database operations.

4. Service Registration: In Program.cs, services (like repositories) and the database context are registered for dependency injection, allowing controllers to use them.

5. Configuration: The application's configuration (like database connection strings) is managed in appsettings.json and Program.cs.

### Tasks to be done 

1. Authenticate and Authorize:
   - configure services in 'Program.cs' using JWT for authentication
   - support Azure AD alongside JWT
   - to enforce authentication in the Controller use [Authorize]
   - Update appsettings.json with jwt settings: unique string as the issuer of the JWT token; audience (URL of application) of the JWT token; secure key to sign the JWT token
   - for production: use Azure Key Vault or environment variables
   - add authorization policies if required:
'''
   [Authorize(Roles = "Admin")]
public class AdminController : ControllerBase
{
    // Admin-only actions
}

[Authorize(Policy = "MustBeUser")]
public IActionResult UserAction()
{
    // Action available to users with the "MustBeUser" policy
}
'''
- 