Task: Implement 4 API Endpoints for creating, updating, getting and deleting an employee (CRUD)

1. Define the Employee Entity with the following properties:
	- Id
	- FirstName
	- LastName
	- Department

2. Register your Services for using DI in Startup.cs

3. Implement IEmployeeService that will do the logic of the according operations and return a EmployeeViewModel

4. Implement IEmployeeRepository that will talk to MyDbContext and adds/gets/deletes the Data from the DB

5. Define the Endpoints in EmployeeController by making use of the EmployeeDto for retrieving data and return the result as a json.


Important Notes:

- We are using an InMemoryDatabase (see Startup.cs) 

- Always make use of dependency injection

- Consider encapsulation of your code

- If you need to take adjustments on the provided wrapper in order to make your code functional, please go ahead

- Own extensions and ideas are always wanted ;)