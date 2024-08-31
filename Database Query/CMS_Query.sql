CREATE DATABASE CMS;

USE CMS;

CREATE TABLE Users (
    user_id INT PRIMARY KEY IDENTITY(1,1),
    email VARCHAR(50) NOT NULL UNIQUE,
    password NVARCHAR(512) NOT NULL,
    user_type VARCHAR(20) NOT NULL, -- E.g., 'admin', 'customer'
    status INT NOT NULL, -- E.g., '1 = Active', '0= Inactive'
);


CREATE TABLE User_Details (
    user_detail_id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT NOT NULL,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    age INT,
    gender VARCHAR(10),
    created_date DATE DEFAULT GETDATE(),
	phone_no VARCHAR(15) DEFAULT 'Not Provided' NULL,
    FOREIGN KEY (user_id) REFERENCES Users(user_id)
);


CREATE TABLE Orders (
    order_id INT PRIMARY KEY IDENTITY(1,1),
    customer_id INT NOT NULL,
    total_amount DECIMAL(10, 2) NOT NULL,
    status VARCHAR(20) NOT NULL, -- E.g., 'completed', 'canceled', 'pending'
    order_date DATETIME DEFAULT GETDATE(),
    payment_id INT,
    FOREIGN KEY (customer_id) REFERENCES Users(user_id),
);


ALTER TABLE Orders
ADD CONSTRAINT FK_Order_Details_Payment FOREIGN KEY (payment_id) REFERENCES Payments(payment_id);


CREATE TABLE Order_Details (
    order_detail_id INT PRIMARY KEY IDENTITY(1,1),
    order_id INT NOT NULL,
    product_id INT NOT NULL,
    category_id INT NOT NULL,
    quantity INT NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
	discount DECIMAL(10, 2),
    FOREIGN KEY (order_id) REFERENCES Orders(order_id),
    FOREIGN KEY (product_id) REFERENCES Products(product_id),
    FOREIGN KEY (category_id) REFERENCES Categories(category_id)
);


CREATE TABLE Products (
    product_id INT PRIMARY KEY IDENTITY(1,1),
    product_name VARCHAR(100) UNIQUE NOT NULL,
    description TEXT,
    price DECIMAL(10, 2) NOT NULL,
    image_url VARCHAR(255),
    category_id INT NOT NULL,
    status INT, -- '1 = available', '0 = no longer used'
    FOREIGN KEY (category_id) REFERENCES Categories(category_id)
);

CREATE TABLE Categories (
    category_id INT PRIMARY KEY IDENTITY(1,1),
    status INT, -- '1 = available', '0 = no longer used'
    category_name VARCHAR(50) NOT NULL
);

CREATE TABLE Menu (
    menu_id INT PRIMARY KEY IDENTITY(1,1),
    product_id INT NOT NULL,
    available_from TIME NOT NULL,
    available_to TIME NOT NULL,
    status INT, -- '1 = available', '0 = not available'
    FOREIGN KEY (product_id) REFERENCES Products(product_id)
);


CREATE TABLE Sales (
    sales_id INT PRIMARY KEY IDENTITY(1,1),
    order_id INT NOT NULL,
    order_date DATETIME NOT NULL,
    order_amount DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (order_id) REFERENCES Orders(order_id)
);

CREATE TABLE Payments (
    payment_id INT PRIMARY KEY IDENTITY(1,1),
    order_id INT NOT NULL,
    customer_id INT NOT NULL,
    amount DECIMAL(10, 2) NOT NULL,
    payment_mode VARCHAR(20) NOT NULL, -- E.g., 'credit_card', 'cash', 'online'
    status VARCHAR(20) NOT NULL, -- E.g., 'completed', 'pending'
    payment_date DATE DEFAULT GETDATE(),
    FOREIGN KEY (order_id) REFERENCES Orders(order_id),
    FOREIGN KEY (customer_id) REFERENCES Users(user_id)
);


CREATE TABLE Inventory (
    inventory_id INT PRIMARY KEY IDENTITY(1,1),
    product_id INT NOT NULL,
    quantity_in_stock INT NOT NULL,
    last_updated DATE DEFAULT GETDATE(),
    FOREIGN KEY (product_id) REFERENCES Products(product_id)
);


CREATE TABLE Suppliers (
    supplier_id INT PRIMARY KEY IDENTITY(1,1),
    supplier_name VARCHAR(100),
    contact_name VARCHAR(100),
    contact_phone VARCHAR(15),
    status INT, -- '1 = available', '0 = no longer dealt with'
    contact_email VARCHAR(100)
);

CREATE TABLE Inventory_Suppliers (
    inventory_supplier_id INT PRIMARY KEY IDENTITY(1,1),
    inventory_id INT,
    supplier_id INT,
    FOREIGN KEY (inventory_id) REFERENCES Inventory(inventory_id),
    FOREIGN KEY (supplier_id) REFERENCES Suppliers(supplier_id)
);


-- Inserting data into the Users table
INSERT INTO Users (username, password, user_type, status) VALUES
('farhanalam', 'password123', 'admin', 1);

-- Inserting data into the User_Details table for Farhan Alam
INSERT INTO User_Details (user_id, first_name, last_name, age, gender) VALUES
(1, 'Farhan', 'Alam', 30, 'Male');

-- Inserting data into the Categories table
INSERT INTO Categories (status, category_name) VALUES
(1, 'Beverages'),
(1, 'Snacks'),
(1, 'Main Course'),
(1, 'Desserts'),
(1, 'Sides');

-- Inserting data into the Products table
INSERT INTO Products (product_name, description, price, image_url, category_id, status) VALUES
('Momos', 'Traditional Nepali dumplings filled with vegetables or meat, served with dipping sauce.', 150.00, 'momos.jpg', 3, 1),
('Samosa', 'Fried pastry filled with spiced potatoes, peas, and sometimes ground meat.', 80.00, 'samosa.jpg', 2, 1),
('Chowmein', 'Stir-fried noodles with vegetables and sometimes meat, seasoned with soy sauce and spices.', 200.00, 'chowmein.jpg', 3, 1),
('Lassi', 'Traditional yogurt-based drink, sweet or salty, served chilled.', 100.00, 'lassi.jpg', 1, 1),
('Gulab Jamun', 'Deep-fried dumplings made of milk solids, soaked in sugar syrup.', 120.00, 'gulab_jamun.jpg', 4, 1);

-- Inserting data into the Orders table
INSERT INTO Orders (customer_id, total_amount, discount, status, order_date) VALUES
(1, 450.00, NULL, 'completed', GETDATE()),
(1, 280.00, NULL, 'completed', GETDATE());

-- Inserting data into the Payments table
INSERT INTO Payments (order_id, customer_id, amount, payment_mode, status, payment_date) VALUES
(1, 1, 450.00, 'cash', 'completed', GETDATE()),
(2, 1, 280.00, 'credit_card', 'completed', GETDATE());

-- Inserting data into the Inventory table
INSERT INTO Inventory (product_id, quantity_in_stock) VALUES
(1, 50),
(2, 80),
(3, 40),
(4, 60),
(5, 30);

-- Inserting data into the Suppliers table
INSERT INTO Suppliers (supplier_name, contact_name, contact_phone, status, contact_email) VALUES
('Nepal Spices Pvt. Ltd.', 'Rajesh Shrestha', '9841566566', 1, 'rajesh@nepalspices.com'),
('Himalayan Drinks Supplier', 'Santosh Gurung', '9813145236', 1, 'santosh@himalayandrinks.com');

-- Inserting data into the Inventory_Suppliers table
INSERT INTO Inventory_Suppliers (inventory_id, supplier_id) VALUES
(1, 1),
(2, 2),
(3, 1),
(4, 1),
(5, 2);

-- Inserting sample data into the Order_Details table
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(1, 1, 3, 3, 150.00),
(1, 2, 2, 2, 80.00),
(2, 3, 3, 1, 200.00),
(2, 4, 1, 2, 100.00),
(2, 5, 4, 4, 120.00);


-- Inserting data into the Users table for customers
INSERT INTO Users (username, password, user_type, status) VALUES
('sushma', 'password123', 'customer', 1),
('manoj', 'password123', 'customer', 1),
('sunita', 'password123', 'customer', 1),
('rajesh', 'password123', 'customer', 1),
('anita', 'password123', 'customer', 1);


-- Inserting data into the User_Details table for additional customers
INSERT INTO User_Details (user_id, first_name, last_name, age, gender) VALUES
(2, 'Sushma', 'Thapa', 28, 'Female'),
(3, 'Manoj', 'Shrestha', 35, 'Male'),
(4, 'Sunita', 'Rai', 40, 'Female'),
(5, 'Rajesh', 'Gurung', 32, 'Male'),
(6, 'Anita', 'Tamang', 25, 'Female');

-- Inserting data into the Menu table
INSERT INTO Menu (product_id, available_from, available_to, status) VALUES
(1, '10:00', '14:00', 1),  -- Momos available from 10 AM to 2 PM
(2 '08:00', '18:00', 1),   -- Samosa available from 8 AM to 6 PM
(3, '11:00', '15:00', 1),  -- Chowmein available from 11 AM to 3 PM
(4, '09:00', '16:00', 1),  -- Lassi available from 9 AM to 4 PM
(5, '07:00', '17:00', 1);  -- Gulab Jamun available from 7 AM to 5 PM

-- Inserting data into the Products table
INSERT INTO Products (product_name, description, price, image_url, category_id, status) VALUES
('Pizza', 'Italian pizza topped with cheese, vegetables, and meat.', 250.00, 'D:\Semester Final Project\4th Sem Final Project\Images\pizza.jpg', 2, 1),
('Sandwich', 'A snack made with two slices of bread with fillings like cheese, vegetables, or meat.', 100.00, 'D:\Semester Final Project\4th Sem Final Project\Images\sandwich.jpg', 2, 1),
('Coffee', 'Hot beverage made from roasted coffee beans.', 50.00, 'D:\Semester Final Project\4th Sem Final Project\Images\coffee.jpg', 5, 1);


-- Inserting data into the Menu table
INSERT INTO Menu (product_id, available_from, available_to, status) VALUES
(6, '12:00', '23:59', 1), 
(7, '10:30', '23:59', 1), 
(8, '09:00', '23:59', 1); 

INSERT INTO Inventory (product_id, quantity_in_stock) VALUES
(6, 5),
(7, 8),
(8, 15);

INSERT INTO Products (product_name, description, price, image_url, category_id, status) VALUES
('Burger', 'Juicy beef burger with lettuce, tomato, and cheese.', 200.00, 'D:\Semester Final Project\4th Sem Final Project\Images\burger.jpg', 2, 1),
('Pasta', 'Italian pasta served with a rich tomato sauce.', 150.00, 'D:\Semester Final Project\4th Sem Final Project\Images\pasta.jpg', 2, 1),
('Tea', 'Classic black tea served hot.', 30.00, 'D:\Semester Final Project\4th Sem Final Project\Images\tea.jpg', 5, 1),
('Cake', 'Delicious chocolate cake with creamy frosting.', 300.00, 'D:\Semester Final Project\4th Sem Final Project\Images\cake.jpg', 2, 1),
('Juice', 'Freshly squeezed orange juice.', 60.00, 'D:\Semester Final Project\4th Sem Final Project\Images\juice.jpg', 5, 1);


INSERT INTO Menu (product_id, available_from, available_to, status) VALUES
(13, '11:00', '22:00', 1), 
(14, '12:00', '22:00', 1), 
(15, '08:00', '22:00', 1),
(16, '09:00', '22:00', 1),
(17, '10:00', '22:00', 1);


INSERT INTO Inventory (product_id, quantity_in_stock) VALUES
(13, 10),
(14, 6),
(15, 20),
(16, 12),
(17, 25);


-- Insert sample orders
INSERT INTO Orders (customer_id, total_amount,status, order_date) VALUES
(1, 520.00,'completed', GETDATE()),  -- Order 1
(2, 320.00,'completed', GETDATE()),  -- Order 2
(3, 150.00, 'completed', GETDATE()),  -- Order 3
(4, 400.00, 'completed', GETDATE());  -- Order 4

-- Insert sample order details for Order 1
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(1, 1, 3, 4, 150.00),  -- 4 Momos
(1, 2, 2, 3, 80.00);   -- 3 Samosas

-- Insert sample order details for Order 2
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(2, 3, 3, 2, 200.00),  -- 2 Chowmeins
(2, 4, 1, 1, 100.00),  -- 1 Lassi
(2, 5, 4, 2, 120.00);  -- 2 Gulab Jamuns

-- Insert sample order details for Order 3
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(3, 6, 2, 1, 250.00);  -- 1 Pizza

-- Insert sample order details for Order 4
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(4, 7, 2, 2, 100.00),  -- 2 Sandwiches
(4, 8, 5, 1, 50.00);   -- 1 Coffee


-- Insert sample orders from the past 8 days
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(1, 450.00, 'completed', DATEADD(DAY, -1, GETDATE())),  -- Order 1 (yesterday)
(2, 350.00, 'completed', DATEADD(DAY, -2, GETDATE())),  -- Order 2 (2 days ago)
(3, 200.00, 'completed', DATEADD(DAY, -3, GETDATE())),  -- Order 3 (3 days ago)
(4, 600.00, 'completed', DATEADD(DAY, -4, GETDATE())),  -- Order 4 (4 days ago)
(5, 280.00, 'completed', DATEADD(DAY, -5, GETDATE())),  -- Order 5 (5 days ago)
(6, 320.00, 'completed', DATEADD(DAY, -6, GETDATE())),  -- Order 6 (6 days ago)
(7, 170.00, 'completed', DATEADD(DAY, -7, GETDATE())),  -- Order 7 (7 days ago)
(8, 450.00, 'completed', DATEADD(DAY, -8, GETDATE()));  -- Order 8 (8 days ago)

-- Insert sample order details for Order 1
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(1, 1, 3, 5, 100.00),  -- 5 Momos
(1, 2, 2, 4, 60.00);   -- 4 Samosas

-- Insert sample order details for Order 2
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(2, 3, 3, 3, 180.00),  -- 3 Chowmeins
(2, 4, 1, 2, 120.00),  -- 2 Lassis
(2, 5, 4, 1, 50.00);   -- 1 Gulab Jamun

-- Insert sample order details for Order 3
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(3, 6, 2, 2, 200.00);  -- 2 Pizzas

-- Insert sample order details for Order 4
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(4, 7, 2, 3, 150.00),  -- 3 Sandwiches
(4, 8, 5, 2, 100.00);  -- 2 Coffees

-- Insert sample order details for Order 5
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(5, 1, 3, 2, 75.00),   -- 2 Momos
(5, 2, 2, 1, 40.00),   -- 1 Samosa
(5, 3, 3, 1, 100.00);  -- 1 Chowmein

-- Insert sample order details for Order 6
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(6, 4, 1, 3, 180.00),  -- 3 Lassis
(6, 5, 4, 3, 90.00);   -- 3 Gulab Jamuns

-- Insert sample order details for Order 7
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(7, 6, 2, 1, 250.00),  -- 1 Pizza
(7, 7, 2, 1, 50.00);   -- 1 Sandwich

-- Insert sample order details for Order 8
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(8, 8, 5, 2, 100.00),  -- 2 Coffees
(8, 1, 3, 3, 90.00);   -- 3 Momos

use CMS

-- Inserting additional sample data into the Payments table for today
INSERT INTO Payments (order_id, customer_id, amount, payment_mode, status, payment_date) VALUES
(1, 1, 450.00, 'cash', 'completed', GETDATE()),      -- Payment for Order 1
(2, 2, 350.00, 'credit_card', 'completed', GETDATE()),-- Payment for Order 2
(3, 3, 200.00, 'online', 'completed', GETDATE()),     -- Payment for Order 3
(4, 4, 600.00, 'cash', 'completed', GETDATE()),       -- Payment for Order 4
(5, 5, 280.00, 'credit_card', 'pending', GETDATE()),  -- Payment for Order 5 (pending)
(6, 6, 320.00, 'online', 'completed', GETDATE()),      -- Payment for Order 6
(7, 7, 170.00, 'cash', 'completed', GETDATE()),       -- Payment for Order 7
(8, 8, 450.00, 'credit_card', 'completed', GETDATE()); -- Payment for Order 8


-- Inserting 50 separate records into the Payments table for the past 2 months
INSERT INTO Payments (order_id, customer_id, amount, payment_mode, status, payment_date) VALUES
(1, 1, 250.00, 'credit_card', 'completed', DATEADD(DAY, -10, GETDATE())),
(2, 2, 320.00, 'cash', 'completed', DATEADD(DAY, -15, GETDATE())),
(3, 3, 150.00, 'online', 'pending', DATEADD(DAY, -20, GETDATE())),
(4, 4, 470.00, 'credit_card', 'completed', DATEADD(DAY, -25, GETDATE())),
(5, 5, 380.00, 'cash', 'completed', DATEADD(DAY, -30, GETDATE())),
(6, 6, 210.00, 'online', 'pending', DATEADD(DAY, -35, GETDATE())),
(7, 7, 540.00, 'credit_card', 'completed', DATEADD(DAY, -40, GETDATE())),
(8, 8, 290.00, 'cash', 'pending', DATEADD(DAY, -45, GETDATE())),
(1, 1, 400.00, 'online', 'completed', DATEADD(DAY, -50, GETDATE())),
(2, 2, 250.00, 'cash', 'completed', DATEADD(DAY, -55, GETDATE())),
(3, 3, 300.00, 'credit_card', 'pending', DATEADD(DAY, -60, GETDATE())),
(4, 4, 150.00, 'online', 'completed', DATEADD(DAY, -12, GETDATE())),
(5, 5, 350.00, 'cash', 'completed', DATEADD(DAY, -22, GETDATE())),
(6, 6, 420.00, 'credit_card', 'completed', DATEADD(DAY, -32, GETDATE())),
(7, 7, 500.00, 'online', 'pending', DATEADD(DAY, -42, GETDATE())),
(8, 8, 270.00, 'cash', 'completed', DATEADD(DAY, -52, GETDATE())),
(1, 1, 330.00, 'credit_card', 'pending', DATEADD(DAY, -62, GETDATE())),
(2, 2, 200.00, 'online', 'completed', DATEADD(DAY, -72, GETDATE())),
(3, 3, 400.00, 'cash', 'completed', DATEADD(DAY, -82, GETDATE())),
(4, 4, 270.00, 'credit_card', 'pending', DATEADD(DAY, -92, GETDATE())),
(5, 5, 500.00, 'online', 'completed', DATEADD(DAY, -102, GETDATE())),
(6, 6, 220.00, 'cash', 'completed', DATEADD(DAY, -112, GETDATE())),
(7, 7, 460.00, 'credit_card', 'pending', DATEADD(DAY, -122, GETDATE())),
(8, 8, 290.00, 'online', 'completed', DATEADD(DAY, -132, GETDATE())),
(1, 1, 310.00, 'cash', 'completed', DATEADD(DAY, -142, GETDATE())),
(2, 2, 350.00, 'credit_card', 'pending', DATEADD(DAY, -152, GETDATE())),
(3, 3, 220.00, 'online', 'completed', DATEADD(DAY, -162, GETDATE())),
(4, 4, 460.00, 'cash', 'completed', DATEADD(DAY, -172, GETDATE())),
(5, 5, 330.00, 'credit_card', 'pending', DATEADD(DAY, -182, GETDATE())),
(6, 6, 500.00, 'online', 'completed', DATEADD(DAY, -192, GETDATE())),
(7, 7, 280.00, 'cash', 'completed', DATEADD(DAY, -202, GETDATE())),
(8, 8, 420.00, 'credit_card', 'pending', DATEADD(DAY, -212, GETDATE())),
(1, 1, 150.00, 'online', 'completed', DATEADD(DAY, -222, GETDATE())),
(2, 2, 290.00, 'cash', 'completed', DATEADD(DAY, -232, GETDATE())),
(3, 3, 370.00, 'credit_card', 'pending', DATEADD(DAY, -242, GETDATE())),
(4, 4, 220.00, 'online', 'completed', DATEADD(DAY, -252, GETDATE())),
(5, 5, 340.00, 'cash', 'completed', DATEADD(DAY, -262, GETDATE())),
(6, 6, 480.00, 'credit_card', 'pending', DATEADD(DAY, -272, GETDATE())),
(7, 7, 310.00, 'online', 'completed', DATEADD(DAY, -282, GETDATE())),
(8, 8, 270.00, 'cash', 'pending', DATEADD(DAY, -292, GETDATE())),
(1, 1, 320.00, 'credit_card', 'completed', DATEADD(DAY, -302, GETDATE())),
(2, 2, 410.00, 'online', 'pending', DATEADD(DAY, -312, GETDATE())),
(3, 3, 200.00, 'cash', 'completed', DATEADD(DAY, -322, GETDATE())),
(4, 4, 360.00, 'credit_card', 'pending', DATEADD(DAY, -332, GETDATE())),
(5, 5, 450.00, 'online', 'completed', DATEADD(DAY, -342, GETDATE())),
(6, 6, 290.00, 'cash', 'pending', DATEADD(DAY, -352, GETDATE())),
(7, 7, 430.00, 'credit_card', 'completed', DATEADD(DAY, -362, GETDATE())),
(8, 8, 280.00, 'online', 'completed', DATEADD(DAY, -372, GETDATE()));


-- Insert values for this week
INSERT INTO Payments (order_id, customer_id, amount, payment_mode, status, payment_date) VALUES
(1, 1, 450.00, 'cash', 'completed', DATEADD(DAY, -3, GETDATE())), -- 3 days ago
(2, 2, 350.00, 'credit_card', 'completed', DATEADD(DAY, -2, GETDATE())), -- 2 days ago
(3, 3, 200.00, 'online', 'completed', DATEADD(DAY, -1, GETDATE())), -- 1 day ago
(4, 4, 600.00, 'cash', 'completed', GETDATE()), -- Today
(5, 5, 280.00, 'credit_card', 'pending', DATEADD(DAY, 1, GETDATE())), -- 1 day from now
(6, 6, 320.00, 'online', 'completed', DATEADD(DAY, 2, GETDATE())), -- 2 days from now
(7, 7, 170.00, 'cash', 'completed', DATEADD(DAY, 3, GETDATE())), -- 3 days from now
(8, 8, 450.00, 'credit_card', 'completed', DATEADD(DAY, 4, GETDATE())), -- 4 days from now
(7, 1, 100.00, 'cash', 'completed', DATEADD(DAY, 5, GETDATE())), -- 5 days from now
(2, 2, 250.00, 'online', 'pending', DATEADD(DAY, 6, GETDATE())); -- 6 days from now

use CMS

-- Orders for Q1 2022
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(1, 200.00, 'completed', '2022-01-15'),
(2, 150.00, 'completed', '2022-02-10'),
(3, 100.00, 'completed', '2022-03-05');

-- Order Details for Q1 2022
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(1, 1, 3, 2, 150.00),  -- 2 Momos
(2, 2, 2, 3, 80.00),   -- 3 Samosas
(3, 3, 3, 1, 100.00);  -- 1 Chowmein

-- Orders for Q2 2022
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(4, 270.00, 'completed', '2022-04-08'),
(5, 200.00, 'completed', '2022-05-15'),
(6, 150.00, 'completed', '2022-06-20');

-- Order Details for Q2 2022
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(4, 4, 1, 2, 100.00),  -- 2 Lassis
(5, 5, 4, 2, 80.00),   -- 2 Gulab Jamuns
(6, 6, 2, 1, 150.00);  -- 1 Pizza

-- Orders for Q3 2022
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(7, 300.00, 'completed', '2022-07-19'),
(8, 170.00, 'completed', '2022-08-25'),
(1, 250.00, 'completed', '2022-09-30');

-- Order Details for Q3 2022
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(7, 7, 2, 2, 100.00),  -- 2 Sandwiches
(8, 8, 5, 1, 50.00),   -- 1 Coffee
(1, 2, 2, 3, 80.00);   -- 3 Samosas

-- Orders for Q4 2022
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(2, 320.00, 'completed', '2022-10-10'),
(3, 250.00, 'completed', '2022-11-15'),
(4, 400.00, 'completed', '2022-12-20');


-- Orders for Q1 2023
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(1, 250.00, 'completed', '2023-01-20'),
(2, 180.00, 'completed', '2023-02-12'),
(3, 120.00, 'completed', '2023-03-10');

-- Order Details for Q1 2023
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(1, 1, 3, 3, 150.00),  -- 3 Momos
(2, 2, 2, 2, 80.00),   -- 2 Samosas
(3, 3, 3, 1, 120.00);  -- 1 Chowmein

-- Orders for Q2 2023
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(4, 350.00, 'completed', '2023-04-15'),
(5, 280.00, 'completed', '2023-05-22'),
(6, 180.00, 'completed', '2023-06-28');

-- Order Details for Q2 2023
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(4, 4, 1, 2, 100.00),  -- 2 Lassis
(5, 5, 4, 2, 80.00),   -- 2 Gulab Jamuns
(6, 6, 2, 1, 150.00);  -- 1 Pizza

-- Orders for Q3 2023
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(7, 280.00, 'completed', '2023-07-10'),
(8, 200.00, 'completed', '2023-08-20'),
(1, 300.00, 'completed', '2023-09-25');

-- Order Details for Q3 2023
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(7, 7, 2, 2, 100.00),  -- 2 Sandwiches
(8, 8, 5, 2, 100.00),  -- 2 Coffees
(1, 2, 2, 4, 160.00);  -- 4 Samosas

-- Orders for Q4 2023
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(2, 400.00, 'completed', '2023-10-15'),
(3, 270.00, 'completed', '2023-11-10'),
(4, 500.00, 'completed', '2023-12-20');

-- Order Details for Q4 2023
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(2, 3, 3, 2, 200.00),  -- 2 Chowmeins
(3, 6, 2, 1, 250.00),  -- 1 Pizza
(4, 1, 3, 5, 150.00);  -- 5 Momos

-- Orders for Q1 2024
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(1, 300.00, 'completed', '2024-01-10'),
(2, 200.00, 'completed', '2024-02-15'),
(3, 130.00, 'completed', '2024-03-20');

-- Order Details for Q1 2024
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(1, 1, 3, 4, 150.00),  -- 4 Momos
(2, 2, 2, 3, 80.00),   -- 3 Samosas
(3, 3, 3, 1, 130.00);  -- 1 Chowmein

-- Orders for Q2 2024
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(4, 380.00, 'completed', '2024-04-12'),
(5, 290.00, 'completed', '2024-05-18'),
(6, 210.00, 'completed', '2024-06-25');

-- Order Details for Q2 2024
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(4, 4, 1, 3, 150.00),  -- 3 Lassis
(5, 5, 4, 2, 80.00),   -- 2 Gulab Jamuns
(6, 6, 2, 1, 210.00);  -- 1 Pizza

-- Orders for Q3 2024
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(7, 320.00, 'completed', '2024-07-10'),
(8, 240.00, 'completed', '2024-08-22'),
(1, 350.00, 'completed', '2024-09-15');

-- Order Details for Q3 2024
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(7, 7, 2, 2, 100.00),  -- 2 Sandwiches
(8, 8, 5, 2, 120.00),  -- 2 Coffees
(1, 2, 2, 5, 200.00);  -- 5 Samosas

-- Orders for Q4 2024
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(2, 420.00, 'completed', '2024-10-05'),
(3, 300.00, 'completed', '2024-11-15'),
(4, 550.00, 'completed', '2024-12-22');

-- Order Details for Q4 2024
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(2, 3, 3, 3, 200.00),  -- 3 Chowmeins
(3, 6, 2, 2, 300.00),  -- 2 Pizzas
(4, 1, 3, 6, 180.00);  -- 6 Momos

-- Orders for January 2024
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(1, 150.00, 'completed', '2024-01-05'),
(2, 200.00, 'pending', '2024-01-10'),
(3, 180.00, 'completed', '2024-01-15'),
(4, 250.00, 'cancelled', '2024-01-20'),
(5, 130.00, 'completed', '2024-01-25');

-- Orders for February 2024
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(6, 270.00, 'pending', '2024-02-02'),
(7, 320.00, 'completed', '2024-02-08'),
(8, 240.00, 'completed', '2024-02-14'),
(1, 150.00, 'cancelled', '2024-02-18'),
(2, 190.00, 'completed', '2024-02-25');

-- Orders for March 2024
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(3, 300.00, 'completed', '2024-03-01'),
(4, 350.00, 'pending', '2024-03-07'),
(5, 220.00, 'completed', '2024-03-12'),
(6, 180.00, 'cancelled', '2024-03-19'),
(7, 250.00, 'completed', '2024-03-26');

-- Orders for April 2024
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(8, 200.00, 'completed', '2024-04-03'),
(1, 170.00, 'pending', '2024-04-10'),
(2, 290.00, 'completed', '2024-04-15'),
(3, 240.00, 'cancelled', '2024-04-22'),
(4, 310.00, 'completed', '2024-04-28');

-- Orders for May 2024
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(5, 200.00, 'completed', '2024-05-02'),
(6, 220.00, 'pending', '2024-05-09'),
(7, 150.00, 'completed', '2024-05-16'),
(8, 180.00, 'cancelled', '2024-05-21'),
(1, 250.00, 'completed', '2024-05-29');

-- Orders for June 2024
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(2, 190.00, 'completed', '2024-06-01'),
(3, 220.00, 'pending', '2024-06-07'),
(4, 250.00, 'completed', '2024-06-14'),
(5, 270.00, 'cancelled', '2024-06-19'),
(6, 320.00, 'completed', '2024-06-25');

-- Orders for July 2024
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(7, 350.00, 'completed', '2024-07-04'),
(8, 230.00, 'pending', '2024-07-12'),
(1, 160.00, 'completed', '2024-07-18'),
(2, 210.00, 'cancelled', '2024-07-22'),
(3, 280.00, 'completed', '2024-07-30');

-- Orders for August 2024
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(4, 300.00, 'completed', '2024-08-02'),
(5, 170.00, 'pending', '2024-08-09'),
(6, 220.00, 'completed', '2024-08-15'),
(7, 250.00, 'cancelled', '2024-08-20'),
(8, 300.00, 'completed', '2024-08-27');

-- Order Details for January 2024
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(1, 1, 1, 3, 50.00),   -- 3 Burgers
(2, 2, 2, 2, 100.00),  -- 2 Sandwiches
(3, 3, 3, 4, 45.00),   -- 4 Pizzas
(4, 4, 4, 2, 60.00),   -- 2 Salads
(5, 5, 5, 5, 26.00);   -- 5 Coffees

-- Order Details for February 2024
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(6, 6, 1, 2, 70.00),   -- 2 Sandwiches
(7, 7, 2, 3, 100.00),  -- 3 Burgers
(8, 8, 3, 4, 80.00),   -- 4 Pizzas
(1, 1, 4, 2, 40.00),   -- 2 Salads
(2, 2, 5, 5, 25.00);   -- 5 Coffees

-- Order Details for March 2024
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(3, 3, 1, 3, 90.00),   -- 3 Burgers
(4, 4, 2, 2, 70.00),   -- 2 Sandwiches
(5, 5, 3, 4, 120.00),  -- 4 Pizzas
(6, 6, 4, 2, 50.00),   -- 2 Salads
(7, 7, 5, 3, 18.00);   -- 3 Coffees

-- Order Details for April 2024
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(8, 8, 1, 2, 60.00),   -- 2 Sandwiches
(1, 1, 2, 3, 90.00),   -- 3 Burgers
(2, 2, 3, 4, 160.00),  -- 4 Pizzas
(3, 3, 4, 1, 20.00),   -- 1 Salad
(4, 4, 5, 5, 30.00);   -- 5 Coffees

-- Order Details for May 2024
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(5, 5, 1, 4, 80.00),   -- 4 Burgers
(6, 6, 2, 2, 70.00),   -- 2 Sandwiches
(7, 7, 3, 3, 90.00),   -- 3 Pizzas
(8, 8, 4, 5, 100.00),  -- 5 Salads
(1, 1, 5, 5, 30.00);   -- 5 Coffees

-- Order Details for June 2024
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(2, 2, 1, 3, 75.00),   -- 3 Burgers
(3, 3, 2, 2, 80.00),   -- 2 Sandwiches
(4, 4, 3, 4, 100.00),  -- 4 Pizzas
(5, 5, 4, 3, 60.00),   -- 3 Salads
(6, 6, 5, 2, 20.00);   -- 2 Coffees

-- Order Details for July 2024
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(7, 7, 1, 3, 90.00),   -- 3 Burgers
(8, 8, 2, 4, 100.00),  -- 4 Sandwiches
(1, 1, 3, 5, 150.00),  -- 5 Pizzas
(2, 2, 4, 2, 30.00),   -- 2 Salads
(3, 3, 5, 4, 40.00);   -- 4 Coffees

-- Order Details for August 2024
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(4, 4, 1, 4, 80.00),   -- 4 Burgers
(5, 5, 2, 3, 90.00),   -- 3 Sandwiches
(6, 6, 3, 4, 120.00),  -- 4 Pizzas
(7, 7, 4, 3, 60.00),   -- 3 Salads
(8, 8, 5, 5, 50.00);   -- 5 Coffees


-- Canceled Orders for January 2024
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(1, 150.00, 'canceled', '2024-01-05'),
(2, 200.00, 'canceled', '2024-01-12'),
(3, 120.00, 'canceled', '2024-01-20'),
(4, 180.00, 'canceled', '2024-01-25'),
(5, 220.00, 'canceled', '2024-01-28');

-- Canceled Orders for February 2024
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(6, 130.00, 'canceled', '2024-02-03'),
(7, 210.00, 'canceled', '2024-02-07'),
(8, 160.00, 'canceled', '2024-02-14'),
(1, 190.00, 'canceled', '2024-02-18'),
(2, 250.00, 'canceled', '2024-02-22');

-- Canceled Orders for March 2024
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(3, 175.00, 'canceled', '2024-03-01'),
(4, 140.00, 'canceled', '2024-03-08'),
(5, 225.00, 'canceled', '2024-03-12'),
(6, 185.00, 'canceled', '2024-03-19'),
(7, 200.00, 'canceled', '2024-03-27');

-- Canceled Orders for April 2024
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(8, 120.00, 'canceled', '2024-04-02'),
(1, 175.00, 'canceled', '2024-04-10'),
(2, 240.00, 'canceled', '2024-04-15'),
(3, 190.00, 'canceled', '2024-04-22'),
(4, 210.00, 'canceled', '2024-04-29');

-- Canceled Orders for May 2024
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(5, 220.00, 'canceled', '2024-05-05'),
(6, 150.00, 'canceled', '2024-05-08'),
(7, 190.00, 'canceled', '2024-05-14'),
(8, 170.00, 'canceled', '2024-05-18'),
(1, 200.00, 'canceled', '2024-05-25');

-- Canceled Orders for June 2024
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(2, 180.00, 'canceled', '2024-06-01'),
(3, 160.00, 'canceled', '2024-06-09'),
(4, 200.00, 'canceled', '2024-06-13'),
(5, 220.00, 'canceled', '2024-06-19'),
(6, 250.00, 'canceled', '2024-06-27');

-- Canceled Orders for July 2024
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(7, 230.00, 'canceled', '2024-07-04'),
(8, 180.00, 'canceled', '2024-07-12'),
(1, 210.00, 'canceled', '2024-07-16'),
(2, 190.00, 'canceled', '2024-07-22'),
(3, 250.00, 'canceled', '2024-07-30');

-- Canceled Orders for August 2024
INSERT INTO Orders (customer_id, total_amount, status, order_date) VALUES
(4, 170.00, 'canceled', '2024-08-02'),
(5, 200.00, 'canceled', '2024-08-08'),
(6, 180.00, 'canceled', '2024-08-15'),
(7, 190.00, 'canceled', '2024-08-20'),
(8, 220.00, 'canceled', '2024-08-28');

-- Canceled Orders for January 2024
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(1, 1, 2, 2, 75.00),   -- 2 Items
(2, 2, 3, 1, 200.00),  -- 1 Item
(3, 3, 1, 3, 40.00),   -- 3 Items
(4, 4, 2, 1, 180.00),  -- 1 Item
(5, 5, 3, 4, 55.00);   -- 4 Items

-- Canceled Orders for February 2024
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(6, 6, 1, 2, 65.00),   -- 2 Items
(7, 7, 2, 3, 70.00),   -- 3 Items
(8, 8, 3, 1, 210.00),  -- 1 Item
(1, 9, 1, 2, 95.00),   -- 2 Items
(2, 10, 2, 2, 125.00); -- 2 Items

-- Canceled Orders for March 2024
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(3, 11, 2, 4, 50.00),  -- 4 Items
(4, 12, 3, 3, 140.00), -- 3 Items
(5, 13, 1, 2, 70.00),  -- 2 Items
(6, 14, 2, 2, 85.00),  -- 2 Items
(7, 15, 3, 5, 60.00);  -- 5 Items

-- Canceled Orders for April 2024
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(8, 16, 1, 1, 120.00), -- 1 Item
(1, 17, 2, 2, 85.00),  -- 2 Items
(2, 18, 3, 3, 160.00), -- 3 Items
(3, 19, 1, 1, 150.00), -- 1 Item
(4, 20, 2, 4, 210.00); -- 4 Items

-- Canceled Orders for May 2024
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(5, 21, 1, 3, 80.00),  -- 3 Items
(6, 22, 2, 1, 90.00),  -- 1 Item
(7, 23, 3, 2, 150.00), -- 2 Items
(8, 24, 1, 2, 85.00),  -- 2 Items
(1, 25, 2, 5, 200.00); -- 5 Items

-- Canceled Orders for June 2024
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(2, 26, 3, 4, 110.00), -- 4 Items
(3, 27, 1, 3, 90.00),  -- 3 Items
(4, 28, 2, 2, 130.00), -- 2 Items
(5, 29, 1, 5, 70.00),  -- 5 Items
(6, 30, 3, 3, 100.00); -- 3 Items

-- Canceled Orders for July 2024
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(7, 31, 1, 2, 115.00), -- 2 Items
(8, 32, 2, 3, 150.00), -- 3 Items
(1, 33, 3, 1, 230.00), -- 1 Item
(2, 34, 1, 4, 200.00), -- 4 Items
(3, 35, 2, 2, 190.00); -- 2 Items

-- Canceled Orders for August 2024
INSERT INTO Order_Details (order_id, product_id, category_id, quantity, price) VALUES
(4, 36, 1, 2, 70.00),  -- 2 Items
(5, 37, 2, 1, 130.00), -- 1 Item
(6, 38, 3, 2, 120.00), -- 2 Items
(7, 39, 1, 5, 140.00), -- 5 Items
(8, 40, 2, 4, 220.00); -- 4 Items

-- Insert sample cancelled payment records (excluding the identity column)
INSERT INTO Payments (customer_id, order_id, amount, payment_mode, status, payment_date)
VALUES
    (1, 1, 450.00, 'cash', 'Cancelled', '2024-09-01'),
    (2, 2, 350.00, 'credit_card', 'Cancelled', '2024-08-15'),
    (3, 3, 200.00, 'online', 'Cancelled', '2024-07-10'),
    (4, 4, 600.00, 'cash', 'Cancelled', '2024-06-25'),
    (5, 5, 280.00, 'credit_card', 'Cancelled', '2024-05-20'),
    (6, 6, 320.00, 'online', 'Cancelled', '2024-04-05'),
    (7, 7, 170.00, 'cash', 'Cancelled', '2024-03-15'),
    (8, 8, 450.00, 'credit_card', 'Cancelled', '2024-02-25'),
    (9, 1, 250.00, 'cash', 'Cancelled', '2023-12-10'),
    (10, 2, 320.00, 'online', 'Cancelled', '2023-11-05');



INSERT INTO Suppliers (supplier_name, contact_name, contact_phone, status, contact_email)
VALUES
('Evergreen Fruits Co.', 'Mina Rai', '9801234567', 1, 'mina@evergreenfruits.com'),
('Green Valley Vegetables', 'Sanjay Thapa', '9823456789', 1, 'sanjay@greenvalleyvege.com'),
('Fresh Bakery Delight', 'Sita Sharma', '9834567890', 1, 'sita@freshbakerydelight.com'),
('Organic Dairy Products', 'Raj Kumar', '9845678901', 1, 'raj@organicdairy.com'),
('Seafood Central', 'Anita Giri', '9856789012', 1, 'anita@seafoodcentral.com');


INSERT INTO Inventory (product_id, quantity_in_stock, last_updated)
VALUES
(1, 50, '2024-06-12'),
(2, 80, '2024-06-12'),
(3, 40, '2024-06-12'),
(4, 60, '2024-06-12'),
(5, 30, '2024-06-12'),
(6, 3, '2024-09-06'),
(7, 4, '2024-09-06'),
(8, 1, '2024-09-06'),
(13, 25, '2024-09-06'),
(14, 10, '2024-09-15');

INSERT INTO Inventory_Suppliers (inventory_id, supplier_id)
VALUES
(6, 2),  -- Himalayan Drinks Supplier supplies Pizza
(7, 2),  -- Himalayan Drinks Supplier supplies Sandwich
(8, 2),  -- Himalayan Drinks Supplier supplies Coffee
(9, 2),  -- Himalayan Drinks Supplier supplies Juice
(10, 2), -- Himalayan Drinks Supplier supplies Fried Chicken Leg Piece
(11, 3), -- Evergreen Fruits Co. supplies Cake
(12, 4), -- Green Valley Vegetables supplies Tea
(13, 5), -- Fresh Bakery Delight supplies Juice
(14, 6), -- Organic Dairy Products supplies Tea
(25, 7); -- Seafood Central supplies Juice

-- To reset counter for testing purposes
--DBCC CHECKIDENT ('Menu', RESEED, 5);



