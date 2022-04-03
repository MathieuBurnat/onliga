# Onliga

## Description 

This is the new website to read manga online !

> This project has been created during my ASP courses. It also called the `Mangathèque`.

---
# Get Started

Be sure to have installed [database tools](https://docs.microsoft.com/en-us/ef/core/cli/dotnet) before starting.

After that you could build the project :
```
dotnet build
```

And update the databse :
```
dotnet ef database update
```

Run the following command : 

```
dotnet run
```

'nd Have fun !

## dotnet commands

### Generate a new migrations

```
dotnet ef migrations add [name]
```
### Update schema with new migrations

```
dotnet ef database update
```
### Delete schema

```
dotnet ef database drop
```

## Project featues
## Flash Message 
It's possible to use flash message.

Simply add these into an function's controller before returning an view :
```
@TempData["queryType"] = "true"; // True will display an success message, False an warning
@TempData["queryMessage"] = "My content :)";
```
---
# URL

The website is available [here](https://onligami.azurewebsites.net) ! :heart:

