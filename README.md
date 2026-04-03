# mfsd_mod_7_project
Full stack integration project for coursera microsoft full stack developer module 7

**Implementation walkthrough for functionalities is in wiki page**

https://github.com/DanielKhongMunLoong/mfsd_mod_7_project/wiki 

**Reflection summary**

**[1] Explain how Copilot assisted in generating integration code, debugging issues, structuring JSON responses, and optimizing performance**

I described my intended API response and URL, copilot can instantly generate the C# Product and Category classes with correct property types, thereby reducing boiler plate code for the backend. Prompting it: "Create a typed HttpClient service for Blazor that fetches from this product endpoint with error handling," and it will generate the service registration and the GetFromJsonAsync calls correctly. Preparing integration code becomes easier.

Copilot explained the reason behind the .NET errors I faced during debugging phase. Error Correction provided from CS# codes occurred during compilation errors. It will identify the exact line and character mistake (e.g., changing .clear() to .Clear()). Copilot analyzes runtime logic, if products list is unexpectedly empty, I asked copilot the likely reasons, it will suggest adding StateHasChanged() or checking the JSON property naming (camelCase vs PascalCase). 

When working with Minimal APIs, Copilot helps me move from "anonymous types" to "structured responses." It helps me to refactor my code correctly and suggest good JSON formatting practices to ensure C# backend is consistent with Blazor front end implementation.

Regarding Optimizing Performance, Copilot can check Program.cs for efficiency. It provides helpful suggestions on caching implementation for my endpoints, Async/Await Efficiency to rewrite inefficient code with “blocking” to function efficiently and responsively. It even suggests how to properly structure HTTP client API calling code in the blazor front end pages. I managed to implement caching strategy for minimal API in my backend code with the help of copilot.

**[2] Highlight any challenges you encountered and how Copilot helped you overcome them**

Challenge 1: My backend uses PascalCase (e.g., ProductName), but JSON or Frontend expects camelCase (productName). This often leads to empty lists in the UI because the mapper can't find the properties. How Copilot helped: I paste C# class and ask for a JSON example, Copilot will show exactly how the data will look. It can also suggest the correct JsonSerializerOptions in Program.cs to ensure the two sides "speak the same language" automatically. 

Challenge 2: Many developers struggle with Bootstrap's deep nesting and specific class names (like d-flex justify-content-between).
How Copilot helped: I can describe the UI in plain English: "Make a responsive product card with the price on the right and a blue buy button." Copilot will generate the exact 
