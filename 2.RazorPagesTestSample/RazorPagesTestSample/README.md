# ASP.NET Core Razor Pages unit tests sample

This sample illustrates unit tests of a [Razor Pages](https://docs.microsoft.com/aspnet/core/mvc/razor-pages) app. This sample demonstrates the features described in the [Razor Pages unit tests](https://docs.microsoft.com/aspnet/core/test/razor-pages-tests) topic.

The message app is a Razor Pages message system with the following characteristics:

- The Index page of the app (Pages/Index.cshtml and Pages/Index.cshtml.cs) provides a UI and page model methods to control the addition, deletion, and analysis of messages (find the average number of words per message).
- A message is described by the Message class (Data/Message.cs) with two properties: Id (key) and Text (message). The Text property is required and limited to 200 characters.
- Messages are stored using Entity Framework's in-memory database†.
- The app contains a DAL in its database context class, AppDbContext (Data/AppDbContext.cs). The DAL methods are marked virtual, which allows mocking the methods for use in the tests.
- If the database is empty on app startup, the message store is initialized with three messages. These seeded messages are also used in tests.