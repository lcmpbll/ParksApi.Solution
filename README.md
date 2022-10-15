# _Parks Api Api_

#### By _Liam Campbell_



#### _A C# based API That lists animals found in Parks Api_

## Table of Contents

[Technologies Used](#technologies-used)  
[Description](#description)  
[Setup/Installation Requirements](#setup-and-installation-requirements)  
[Known Bugs](#known-bugs)  
[License](#License)

## Technologies Used

* _C#_
* _.NET_
* _Swagger_
* _XML_
* _SQL Workbench_
* _Entity Framework_
* _MVC_


---
## Description
_This API is made up of a list of parks found in Oregon. The returned list can be curated by:_
* _Name - name of the park_
* _Location - Which part of Oregon the park is in_
* _Dogs allowed - are dogs allowed in all areas of the park_
* _ParkMgmt - Is the park a national or state park_
*_Description - A short description of the park_

_Both v1 and v2 are supported at this time. Some end points that can be use are:_

* _/api/v1/Parks/all - returns all listed parks_
* _5001/api/v1/Parks/{id} - returns a park by id_
* _Put, Post, Delete updates may all be made by id number as well._
*_v2 supports filtered results._
*_After following the set up instructions below see swagger documentation for more information._



---
## Setup and Installation Requirements

<details>
<summary><strong>Initial Setup</strong></summary>
<ol>
<li>Copy the git repository url: https://github.com/lcmpbll/ParksApi.Solution
<li>Open a shell program and navigate to your desktop.
<li>Clone the repository for this project using the "git clone" command and including the copied URL.
<li>While still in the shell program, navigate to the root directory of the newly created file named "ParksApi.Solution".
<li>From the root directory, navigate to the "ParksApi" directory.
<li>Move onto "SQL Workbench" instructions below to re-create database necessary to run this project.
<br>
</details>

<details>
<summary><strong>SQL Workbench Configuration</strong></summary>
<ol>
<li>Create an appsetting.json file in the "ParksApi" directory of the project*  
   <pre>ParksApi.Solution
   └── ParksApi
    └── appsetting.json</pre>
<li> Insert the following code** : <br>

<pre>{
   "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=park_api;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}</pre>
<small>*note: you must include your password in the code block section labeled "YOUR-PASSWORD-HERE".</small>
<small>**note: if you plan to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore before doing so.</small>

<li>Once "appsettings.json" file has been created, navigate back to SQL Workbench.


</details>

<details>
<summary><strong>To Run</strong></summary>
Navigate to:  
   <pre>ParksApi.Solution
   └── <strong>ParksApi</strong></pre>

Run `$ dotnet restore` in the console.<br>
Run `$ dotnet database update` in the console.<br>
Run `$ dotnet run` in the console
* _To view more information view localhost:[yourlocalhost]/index.html_
* _Additional information in JSon can also be viewed at https://localhost:[yourlocalhost]/swagger/v1/swagger.json
</details>

<br>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

## Known Bugs

* _Data for the Valley of the Rogue River does not appear_
* _Searching descriptions can be tricky. Thoughts on future versions include uploading activities for each site as part of an array._

## License

_Feel free to reach out via [Github](github.com.lcmpbll) to provide feedback on this project or to view my other projects._

[Copyright](/LICENSE) (c) _08-21-2022_ _Liam Campbell_
