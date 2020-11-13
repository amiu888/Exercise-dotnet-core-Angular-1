


#Requirement

## 1. Install VSCode from https://code.visualstudio.com/download
## 2. Install Node from https://nodejs.org/en/download/
## 3. Clone socure code from https://github.com/amiu888/Exercise-dotnet-core-Angular-1.git
## 4. Use Git command to create a branch for you.
## 5. Open the projects in vscode
## 6. Start debugging by press F5.















Install ef tool

## 1. _>dotnet add package Microsoft.EntityFrameworkCore.SqlServer
## 2. _>dotnet add package Microsoft.EntityFrameworkCore.Design
## 3. _>dotnet tool install --global dotnet-ef 

## 4. _>dotnet ef dbcontext scaffold "Server=OTSWITF86VHR2XL\SQLEXPRESS;Database=Movies;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models

## 3. >

#SQLITE

1. download sqlte odbc drive
    http://www.ch-werner.de/sqliteodbc/


# Get into the Workspace or Angular project you are working with, open command prompt and run the below command:

npm install --save @angular/material @angular/cdk

If the error is still not gone, try clearing the cache by the given command :
 
npm cache clear --force
 
Another approach to clean the cache is by manually deleting it from the file system at

C:\Users\%USER_PROFILE_NAME%\AppData\Roaming\npm-cache

Try deleting everything from the above location then rerun

npm install --save @angular/material @angular/cdk

Hopefully this should solve your issue and ngServe would show the message about successful compilation of project.     message about successful compilation of project.    