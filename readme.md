# Lab 2 & 3 OOSU2
This is a basic application where we are working with diffrent layers to build a complete app.

The app uses EntetyFrameworks (EF) and use the "Code First" approache, which means that all classes (models) are created first and then converted by EF to DB-tables.

---

## Build layout
- The layers are following:
    - DataLayer --> a layer that handles all communication with the database
    - BusinessLayer --> this layer handles all the requests from the GUI and sends them to the "DataLayer"
    - BusinessEnteties --> This are all the models that are beeing created inside the database
    - GUI --> This is basic WinForm's that are talking with the "BusinessLayer" to get access to the DB
    -  