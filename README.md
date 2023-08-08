# ASPNET-Blogs-Website
It is a website created by me for my portfolio with C# and in ASP.NET framework with bootstap for design. Webapp has CRUD, UserIdentity, User Verification and etc functionalities. 

Web app needs few action to work properly:
1. You need to input your own Google OAuth clientId and clientSecret in the "Program.cs" file, in order to google auhtentification to work correctly
2. You need to import a database from .backup file that I applied into your SQLserver and then insert your own connection string to "appsettings.json" file, so the user identity and blogs controller work properly