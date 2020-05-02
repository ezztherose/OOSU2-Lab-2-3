# Lab 2 & 3 OOSU2
This is a basic application where we are working with diffrent layers to build a complete app.

The app uses EntetyFramework (EF) and use the "Code First" approache, which means that all classes (models) are created first and then converted by EF to DB-tables.

---

EntetyFraework is an "Nuget" extension that you need to download from Visual Studio or your prefered IDE. There are some diffrences, if you are using VSCode, you will get the ".net entetyframework" core version, which means that you can't use Winforms and WPF. To use these GUI's you need to use Visual Studio and download ".net enetyframework". 

If you are using Visual Studio, make sure that ".net framework" are selected when you are creating your "class librarys".

## Build layout
- The layers are following:
    - DataLayer --> a layer that handles all communication with the database
    - BusinessLayer --> this layer handles all the requests from the GUI and sends them to the "DataLayer"
    - BusinessEnteties --> This are all the models that are beeing created inside the database
    - GUI --> This is basic WinForm's that are talking with the "BusinessLayer" to get access to the DB
    -  GUI-WPF --> this is just to show that you can add an outher GUI with the existing application.

---

There are some design patterns used as well.
- Design patterns:
    - UnitOfWork --> a collection class that creats all instances of the diffrent tables in the database.
    - Business Enteties --> this project are holding all models for the tables

- Improvements:
    - Build a "facade" pattern inside the "BusinessLayer"

Look inside the "Documantaion" folder for more info.

## Connect to the Database
When you download the project you need to add a few lines inside the "app.config" to be able to communicate with the database.

```
Data Source=SourcePath,port; Initial Catalog=SpecificDB;Persist Security Info=True;User ID=GivenID;Password=Password
```

To get a better description, check out: https://docs.microsoft.com/en-us/ef/ef6/fundamentals/configuring/config-file


## NOT COMPLETE
The code is not complete, there are som modifications thats are necessary to make WPF work.

You can follow the Alumn-Class in BusenissEntetise and make the same changes to the outher models.

## Free for all

This Code is free for everyone, enjoy it and hope it helps!

Good luck, Ezz