# _Animal Shelter API_

#### By _**Jacob Wilson**_

#### An animal shelter api that hosts a database with user generated animals.

## Technologies Used

* _.Net5.0_
* _GitBash_
* _Dotnet Script_
* _VS Code_
* _C#_
* _Markdown_
* _MySQL_
* _EntityFrameworkCore_
* _Swagger_
* _Api Versioning_

## Description

An api database designed for use at an animal shelter. The api contains endpoints that allow users to create, edit, view, and delete animals. The api supports version control through Microsoft.AspNetCore.Mvc.Versioning and supports viewing of the api with swagger.

## Setup/Installation Requirements

Step1: Clone the project.
* _Navigate to the github repository [here](https://github.com/JLEWilson/AnimalShelter.Solution.git)_
* _Click code and copy the https link_
* _In your in git bash or your preferred git terminal navigate to the directory you would like to store the project_
* _Enter: `git clone` followed by the https link_
* _Now that the repository is cloned to your computer, right click on the folder and click open with vs code_
Step2: Install Dependencies.
* _Once in the project navigate to the AnimalShelter directory_
* _In your terminal type `dotnet restore` to install dependencies_

Step3: Database Initialization.
* _In order to initialize a database you will need to create an appsettings.json file that looks like this_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=jacob-wilson;uid={YOUR USER ID HERE};pwd={YOUR PASSWORD HERE};"
  }
}
```
* _Once you have the appsettings.json fie, to create a database run: `dotnet ef migrations add Initial`_
* _To update the database in MySQL run: `dotnet ef database update`_

Step4: Run the project.
* _At this point you will now be able to view the project by typing `dotnet run` in the terminal_



## API Endpoints

| Rout      | Description |
| :-----------: | :-----------: |
| http://localhost:5000/Swagger      | Use swagger to navigate the api|
|Version 1   |  Routs prefix with /api/v1 |
| http://localhost:5000/api/v1/animals   | Full list of animals        |
| http://localhost:5000/api/v1/animals/1   | Finds animal by ID (replace 1 with desired id)|        
| Version 2  |  Routs prefix with /api/v2|
| http://localhost:5000/api/v2/animals  |  Animals now supports search functionality <br> Animals sorted by name to differentiate<br> Versions while no search is present|
| http://localhost:5000/api/v2/animals?age=1  |  Animals with age of 1 (replace 1 with desired age)|
| http://localhost:5000/api/v2/animals?gender=female  |  Animals that are female(male also available)|
| http://localhost:5000/api/v2/animals?species=cat  |  Animals that are cats(dog also available)|
| http://localhost:5000/api/v2/animals?name=milo  |  Animals that are named milo|

## Further Exploration Objectives
### Versioning
  Versioning is used to allow different releases of the api without breaking client applications that rely on functionality. 
  
  First I added versioning support in ConfigureServices and specified a default version if one is not selected:
  ```
  services.AddApiVersioning(options => 
            {
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.ReportApiVersions = true;
            });
  ```

  In this API I set the rout to be version dependant with this route decorator above the AnimalsController class:
  ```
  [Route("api/v{version:apiVersion}/[controller]")]
  ```
  In order to make the AnimalsController available to both version 1.0 and 2.0 you will also use the ApiVersion attribute in the same location:
  ```
  [ApiVersion("1.0")]
  [ApiVersion("2.0")]
  ```
  Now all that is left to do is specify which which methods belong to which version using MapToApiVersion:
  ```
  [MapToApiVersion("1.0")]
  ```
  ### Swagger
  With this api I use swagger to allow for clear documentation of the api's crud functionality. While `dotnet new webapi --framework net5.0` does come with some swagger implementation by default the problem is that it will throw an error if you are using version control, as it cannot differentiate versions the routs from each other without some added functionality. To get around this I had to use custom configurations for swagger options. Since we shouldn't do this in Startup.cs's configure method I created a ConfigureSwaggerOptions that will assist in creating new json files for each version. 

  With the ConfigureSwaggerOptions class made we just reference it in Startup.cs Configure  and tell it to use SwaggerGen:
  ```
  services.AddSwaggerGen();
  services.ConfigureOptions<ConfigureSwaggerOptions>();
  ```
  All that's left is to insert the middleware, and generate endpoints for each available version:
  ```
  app.UseSwagger();

  app.UseSwaggerUI(c =>
  {
      foreach(var description in provider.ApiVersionDescriptions)
      {
          c.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", 
      description.GroupName.ToUpperInvariant());
      }
  });
  ```


## Known Bugs

* _No known bugs_

## License - [MIT](https://opensource.org/licenses/MIT)

_If you run into any problems or find a bug, would like to reach me for a separate reason, feel free to send me an email @jacobleeeugenewilson@gmail.com with details of your issue._

Copyright (c) _01/21/2022_ _Jacob Wilson_