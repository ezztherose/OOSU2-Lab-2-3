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
    - DB-context --> to talk to the DB
    - UnitOfWork --> a collection class that creats all instances of the diffrent tables in the database.
    - Business Enteties --> this project are holding all models for the tables

- Improvements:
    - Build a "facade" pattern inside the "BusinessLayer"

Look inside the "Documantaion" folder for more info.

## COnnect to the Database
When you download the 