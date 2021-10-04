# GoRestApi
 ## Task
Create a C# solution for managing Employees details. User must use a desktop application in (Win-Forms or WPF) to add, edit, remove, view and search and export (CSV or Tab separated) Employee details. Employed details have been exposed through RESTful service. 
Note: Please implement at least 2 functionalities (add, edit, remove, view and search and export)
 RESTful service:
- Use https://gorest.co.in/public-api/  to perform CRUD operation 
 - API Token: fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56
- CRUD APIs:
GET /public-api/users: list all users.
GET /public-api/users?first_name=john: list all users with first_name contains john.
POST /public-api/users: create a new user.
GET /public-api/users/123: return the details of the user 123.
PATCH /public-api/users/123 or PUT /public-api/users/123: update the user 123.
DELETE /public-api/users/123: delete the user 123.
For paged result set parameter "page" should be passed in url ex: GET /public-api/users?page=5 will get 5th page results. If non existing page number is passed, then last page results will be returned.
Windows application:
- Use Win.Forms or WPF
Language:
C#

General 
- Push your code to Github or send this back as source files (no binaries)
- Solution must compile
- If any additional dependency must be installed or configured to compile or run solution, these dependencies must be specified in additional document.
 
Restrictions:
- You have one week to complete this task.  
- Code should be clean, modular, scalable and reusable.
 
Bonus points for:
- Use best practices and design patterns
- Solution should utilize resources wise
- Thinking of data concurrency
- Automation tests (Unit tests, Moq etc.)
- Anything else you think worth adding
