# C# _Hotel_Management
Project on Hotel Management System using C# windows form. 

There are 4 modules
1. Login Module
2. Manage Clients
3. Manage Rooms
4. Manage Reservations

1.Login Module
  Owner should login to this system by entering Username and Password.
  
2. Manage Clients
   Owner/ Admin can add a client(id,first name,last name, phoneno, country)
   Admin can edit the details of client
   Admin can delete a client
   
   
3. Manage Rooms
  Admin can add a room(room number, room type(single,double,family,suite),phone number, and its availability(Yes/no)
  Admin can edit the details of room
  Admin can delete the details of room
  
  
 4. Manage Reservation
  Admin can add the reservation of client(Client id,reservation id,room type(single,double,family,suite),room number date in & date out
  Admin can edit the reservation details
  Admin can delete the reservations.
  
  Techonologies used:
  - C# Programming Language.
 - Visual Studio Editor.
 - MySQL Database.
 - XAMPP Server.

C# CONTROLS WE WILL USE IN THIS PROJECT:
- Windows Form 
- Panel.
- DataGridView.
- TextBox.
- Button.
- Label.
- ComboBox.
- PictureBox.
- MenuStrip.
- RadioButton.
- DateTimePicker.


the mysql database schema:
or database will contains 4 tables:
1 - the rooms categories table where all the rooms type are stored with the price of each category
2 - the rooms table where all rooms are stored with their numbers (the key) this table contains the foreign key from the table rooms_categories
3 - the clients table where we store all the clients information, 
4 - the reservations table where we store all clients reservations, this table contains two foreign keys,1 from the table rooms to know which room the client has reserved,2 from the table clients to know who reserved,
+ a date in and a date out to know when this reservation will start and when it will end
