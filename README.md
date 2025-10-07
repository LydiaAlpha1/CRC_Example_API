Visual studio 2022 IDE



.NET version 9.09



Entity Framework SQL/TOOLS/DESIGN/CORE



ASP.NET Core NewtonsoftJson/OpenAPI



Microsoft SQL server/manager







### **ASSUMPTIONS:**



Used the Postman App for an API interface for visuals.

Established mock SQL database with DBMS Microsoft Server Manager.

Scripts for GET/PUT/POST/DELETE/ 





### **SQL SCRIPTS:**



//Not need as the migration class will handle the table implementation.



CREATE TABLE Products (

Id INT PRIMARY KEY,

Name NVARCHAR(100),

Price DECIMAL(10,2),



);



//Use this to populate database.



INSERT INTO Products (Name, Price) VALUES

('Wireless Mouse', 19.99),

('Bluetooth Speaker', 49.50),

('USB-C Cable', 8.75),

('Smartphone Stand', 12.99),

('Smart Watch', 199.99),

('Power Bank', 34.00),

('Webcam', 45.60),

('Laptop Sleeve', 25.30),

('Office Chair', 139.99),

('Standing Desk', 299.00),

('Bookshelf', 89.99),

('Filing Cabinet', 119.50),

('Bedside Table', 49.99),

('Non-stick Pan', 24.00),

('Electric Kettle', 29.99),

('Blender', 64.95),

('Stainless Steel Knife Set', 59.90),

('Coffee Grinder', 39.75),

('Wall Clock', 22.50),

('Canvas Art', 45.00),

('Table Lamp', 34.20),

('Ceramic Vase', 28.75),

('Throw Pillow', 18.99),

('Yoga Mat', 29.99),

('Dumbbells (Set)', 64.00),

('Resistance Bands', 14.99),

('Jump Rope', 12.00),

('Treadmill', 599.99),

('Notebook', 6.99),

('Gel Pen Set', 9.99),

('Desk Organizer', 19.50),

('Stapler', 7.25),

('Highlighter Pack', 5.99),

('Backpack', 49.99),

('Sunglasses', 59.00),

('Wrist Watch', 89.00),

('Leather Wallet', 39.99),

('Keychain Set', 14.99),

('Air Purifier', 129.99),

('Vacuum Cleaner', 199.50),

('Table Fan', 34.99),

('Toaster', 29.95),

('Microwave Oven', 149.99),

('Running Shoes', 79.95),

('Sandals', 29.50),

('Slippers', 22.00),

('Boots', 109.99),

('Loafers', 59.95),

('Building Blocks', 24.99),

('Remote Control Car', 39.99),

('Puzzle Set', 18.75),

('Action Figure', 14.99),

('Board Game', 34.00),

('Gaming Mouse', 29.99),

('Noise Cancelling Headphones', 129.99),

('Portable SSD', 79.95),

('4K Monitor', 249.99),

('Smartphone Gimbal', 109.00),

('Desk Chair Mat', 34.99),

('Bean Bag Chair', 89.95),

('Shoe Rack', 42.00),

('Dining Chair', 59.99),

('Footrest', 24.00),

('Mixing Bowl Set', 22.99),

('Air Fryer', 99.95),

('Food Processor', 79.00),

('Rice Cooker', 54.99),

('Ice Cube Tray Set', 10.99),

('Mirror Wall Art', 38.50),

('LED Strip Lights', 26.99),

('Curtain Set', 49.00),

('Floor Rug', 85.00),

('Picture Frame Set', 19.95),

('Kettlebell (20lb)', 44.00),

('Foam Roller', 25.99),

('Pull-Up Bar', 32.00),

('Fitness Tracker', 69.00),

('Adjustable Bench', 129.99),

('Planner', 14.95),

('Whiteboard Set', 29.99),

('Binder Clips Pack', 4.50),

('Paper Cutter', 23.00),

('Drawing Pad', 12.99),

('Travel Backpack', 59.99),

('Beanie Hat', 18.00),

('Travel Organizer Set', 29.99),

('Laptop Bag', 49.99),

('Smart Ring', 74.00),

('Clothes Steamer', 44.00),

('Electric Heater', 89.99),

('Mini Fridge', 139.95),

('Humidifier', 45.00),

('Induction Cooktop', 129.00),

('Hiking Boots', 129.99),

('Sneakers', 89.99),

('Flip Flops', 19.95),

('Heels', 74.00),

('Crocs', 39.50),

('Plush Toy', 19.99),

('Toy Drone', 69.99);



### **Setup:**



**Both the API and the MVC should be set to run in parallel. If not simply go to configure startup project and mark multiply project start and select both the MVC and Example\_1 for the API.** 



**Replace the placeholder connect string with the proper connection to a SQL database.**



 **"ConnectionStrings": {**

   **"DefaultConnection": "Server=ServerName;Database=DatabaseName;Trusted\_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true"**



**To add the table to the SQL Database open the solution and navigate to the Tools drop down menu. Find and Select the NuGet package manager and click package manager console. In the console within visual studios enter in "Update-Database". This will construct the table within the Database. To populate I have set aside the INSERT script for a small amount of items. This script needs to be entered into the DBMS as it is not set to populate on creation.**



**Once the SQL script has populated the database. Running the program from Visual studio two terminals will launch one for the MVC and the other with the API. The API will with the tag /api/Products will pull all products. Appending a number will pull using the product ID. A browser will launch with the a small MVC with a Products Tab that will call the products table as well.** 















































































