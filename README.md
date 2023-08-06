# Umblazor 
![Alt text](umblazor.png) 
This a POC of how to run Umbraco but having the front-end rendered by Blazor and Razor components instead of the traditional MVC views.

In the Index.razor component there is a wildcard route, a page content loader (for the current slug URL) and a very simple selection of wich "page component" the Model should be passed to.

## How to run

1. Clone the repo
2. start with ``` dotnet run ```
3. Go to https://localhost:44325 or  http://localhost:57950

Umbraco backoffice is available at https://localhost:44325/umbraco
Login with
```
username: admin@admin.example.com
password: 1234567890
```

