# LoanManagement
CQRS, Command Query Responsibility Segregation is a design pattern that separates the read and write operations of a data source. Here Command refers to a Database Command, which can be either an Insert / Update or Delete Operation, whereas Query stands for Querying data from a source. It essentially separates the concerns in terms of reading and writing, which makes quite a lot of sense. This pattern was originated from the Command and Query Separation Principle devised by Bertrand Meyer. 
hello

https://www.c-sharpcorner.com/article/entity-framework-database-first-in-asp-net-core2/#:~:text=Entity%20Framework's%20Database%20First%20approach,you%20with%20very%20little%20code.

https://www.c-sharpcorner.com/article/implementing-cqrs-with-mediatr-in-asp-net-core-application/

====== database connection configurations  =================

.net api documentation

install all dependecy and frameworks

Install-package Microsoft.EntityFrameworkCore
Install-package Microsoft.EntityFrameworkCore.SqlServer
Install-package Microsoft.EntityFrameworkCore.Tools

//this will generate the db context relevents to sql server and generates the modals
Scaffold-DbContext "Data Source=DESKTOP-PQQMJ6D;Initial Catalog=SalaryManagerDB;Integrated Security=True"Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models/DB



===== Apply cqrs patterns =============
Install-package MediatR 

---------------------------------------







