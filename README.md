# Onliga

## Description 

This is the new website to read manga online !

> This project has been created during my ASP courses. It also called the `Mangathèque`.

## Dev
### Get Started

Run the following command : 

```
dotnet run
```

'nd Have fun !

### dotnet commands

#### Generate a new migrations

```
dotnet ef migrations add [name]
```
#### Update schema with new migrations

```
dotnet ef database update
```
#### Delete schema

```
dotnet ef database drop
```

## URL

The website is available [here](https://onligami.azurewebsites.net) ! :heart:

## Flashmessage 
It's possible to use flash message.
Simply add these tags :
@ViewData["queryType"] = "true"; //true, success. False, warning
@ViewData["queryMessage"] = "My message"; //my content