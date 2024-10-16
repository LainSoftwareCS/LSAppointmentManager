
-- Insertar 10 registros de ejemplo en la tabla Workstation
INSERT INTO Workstation (Name, CreatedBy, CreatedDate) VALUES 
('Recepción', 'admin', GETDATE()), 
('Ventas', 'admin', GETDATE()), 
('Atención al Cliente', 'admin', GETDATE()), 
('Soporte Técnico', 'admin', GETDATE()), 
('Desarrollo', 'admin', GETDATE()), 
('Marketing', 'admin', GETDATE()), 
('Finanzas', 'admin', GETDATE()), 
('Recursos Humanos', 'admin', GETDATE()), 
('Logística', 'admin', GETDATE()), 
('Dirección', 'admin', GETDATE());

-- Insertar 10 registros de ejemplo en la tabla Worker
INSERT INTO Worker (Name, Lastname, Lastname2, Birthdate, Email, PhoneNumber, Gender, WorkstationId, CreatedBy, CreatedDate) VALUES 
('Carlos', 'García', 'López', '1980-02-15', 'carlos.garcia@example.com', '600123456', 1, 1, 'admin', GETDATE()),
('María', 'Martínez', 'Pérez', '1990-06-30', 'maria.martinez@example.com', '600234567', 2, 2, 'admin', GETDATE()),
('Luis', 'Fernández', NULL, '1985-10-10', 'luis.fernandez@example.com', '600345678', 1, 3, 'admin', GETDATE()),
('Laura', 'Sánchez', 'Gómez', '1995-03-25', 'laura.sanchez@example.com', '600456789', 2, 4, 'admin', GETDATE()),
('Ana', 'Díaz', NULL, '1982-07-12', 'ana.diaz@example.com', '600567890', 1, 5, 'admin', GETDATE()),
('Juan', 'Hernández', 'Rodríguez', '1993-09-21', 'juan.hernandez@example.com', '600678901', 1, 6, 'admin', GETDATE()),
('Eva', 'Ruiz', NULL, '1988-12-19', 'eva.ruiz@example.com', '600789012', 2, 7, 'admin', GETDATE()),
('Alberto', 'Jiménez', 'Morales', '1975-01-02', 'alberto.jimenez@example.com', '600890123', 1, 8, 'admin', GETDATE()),
('Sara', 'Ortiz', NULL, '1992-05-14', 'sara.ortiz@example.com', '600901234', 2, 9, 'admin', GETDATE()),
('Pedro', 'Castro', 'Núñez', '1987-11-07', 'pedro.castro@example.com', '600012345', 1, 10, 'admin', GETDATE());

-- Insertar 10 registros de ejemplo en la tabla ManagerUser
INSERT INTO ManagerUser (Username, Password, Name, Lastname, Lastname2, Email, PhoneNumber, CreatedBy, CreatedDate) VALUES 
('manager1', 'pass1234', 'Admin', 'User', NULL, 'admin1@example.com', '600111111', 'system', GETDATE()),
('manager2', 'pass1234', 'Super', 'User', NULL, 'admin2@example.com', '600222222', 'system', GETDATE()),
('manager3', 'pass1234', 'Root', 'User', NULL, 'admin3@example.com', '600333333', 'system', GETDATE()),
('manager4', 'pass1234', 'System', 'Admin', NULL, 'admin4@example.com', '600444444', 'system', GETDATE()),
('manager5', 'pass1234', 'Global', 'Admin', NULL, 'admin5@example.com', '600555555', 'system', GETDATE()),
('manager6', 'pass1234', 'Master', 'Admin', NULL, 'admin6@example.com', '600666666', 'system', GETDATE()),
('manager7', 'pass1234', 'Secure', 'Admin', NULL, 'admin7@example.com', '600777777', 'system', GETDATE()),
('manager8', 'pass1234', 'Chief', 'Admin', NULL, 'admin8@example.com', '600888888', 'system', GETDATE()),
('manager9', 'pass1234', 'Head', 'Admin', NULL, 'admin9@example.com', '600999999', 'system', GETDATE()),
('manager10', 'pass1234', 'Lead', 'Admin', NULL, 'admin10@example.com', '600000000', 'system', GETDATE());

-- Insertar 10 registros de ejemplo en la tabla Customer
INSERT INTO Customer (Name, Lastname, Lastname2, PhoneNumber, Gender, Birthdate, CreatedBy, CreatedDate) VALUES 
('David', 'Vega', NULL, '600001111', 1, '1992-01-01', 'admin', GETDATE()),
('Marta', 'Alonso', 'García', '600002222', 2, '1988-03-15', 'admin', GETDATE()),
('Lucas', 'Gil', 'López', '600003333', 1, '1990-07-22', 'admin', GETDATE()),
('Elena', 'Navarro', NULL, '600004444', 2, '1985-09-30', 'admin', GETDATE()),
('Sergio', 'Molina', NULL, '600005555', 1, '1993-11-05', 'admin', GETDATE()),
('Patricia', 'Romero', 'Hernández', '600006666', 2, '1991-02-14', 'admin', GETDATE()),
('Daniel', 'Santos', NULL, '600007777', 1, '1982-04-08', 'admin', GETDATE()),
('Raquel', 'Medina', 'Ortega', '600008888', 2, '1995-06-12', 'admin', GETDATE()),
('Miguel', 'Ramos', NULL, '600009999', 1, '1987-08-25', 'admin', GETDATE()),
('Silvia', 'Soler', 'Pérez', '600010101', 2, '1994-10-18', 'admin', GETDATE());

-- Insertar 10 registros de ejemplo en la tabla Sale
INSERT INTO Sale (CustomerId, Subtotal, Discount, Taxes, Total, CreatedBy, CreatedDate) VALUES 
(1, 100.00, 10.00, 18.00, 108.00, 'admin', GETDATE()),
(2, 200.00, 20.00, 36.00, 216.00, 'admin', GETDATE()),
(3, 150.00, 15.00, 27.00, 162.00, 'admin', GETDATE()),
(4, 180.00, 18.00, 32.40, 194.40, 'admin', GETDATE()),
(5, 220.00, 22.00, 39.60, 237.60, 'admin', GETDATE()),
(6, 130.00, 13.00, 23.40, 140.40, 'admin', GETDATE()),
(7, 170.00, 17.00, 30.60, 183.60, 'admin', GETDATE()),
(8, 190.00, 19.00, 34.20, 205.20, 'admin', GETDATE()),
(9, 210.00, 21.00, 37.80, 226.80, 'admin', GETDATE()),
(10, 160.00, 16.00, 28.80, 172.80, 'admin', GETDATE());

-- Insertar 10 registros de ejemplo en la tabla ProductService
INSERT INTO ProductService (Name, Sku, Description, Price, HasTaxes, HasTaxesIncluded, CreatedBy, CreatedDate) VALUES 
('Producto 1', 'SKU001', 'Descripción del producto 1', 50.00, 1, 0, 'admin', GETDATE()),
('Producto 2', 'SKU002', 'Descripción del producto 2', 100.00, 1, 0, 'admin', GETDATE()),
('Producto 3', 'SKU003', 'Descripción del producto 3', 75.00, 1, 1, 'admin', GETDATE()),
('Producto 4', 'SKU004', 'Descripción del producto 4', 200.00, 1, 0, 'admin', GETDATE()),
('Producto 5', 'SKU005', 'Descripción del producto 5', 150.00, 1, 1, 'admin', GETDATE()),
('Producto 6', 'SKU006', 'Descripción del producto 6', 120.00, 1, 0, 'admin', GETDATE()),
('Producto 7', 'SKU007', 'Descripción del producto 7', 180.00, 1, 1, 'admin', GETDATE()),
('Producto 8', 'SKU008', 'Descripción del producto 8', 110.00, 1, 0, 'admin', GETDATE()),
('Producto 9', 'SKU009', 'Descripción del producto 9', 90.00, 1, 1, 'admin', GETDATE()),
('Producto 10', 'SKU010', 'Descripción del producto 10', 140.00, 1, 0, 'admin', GETDATE());

-- Insertar 10 registros de ejemplo en la tabla ProductServiceDetail
INSERT INTO ProductServiceDetail (ProductServiceId, Name, Sku, Description, Price, HasTaxes, HasTaxesIncluded, CreatedBy, CreatedDate) VALUES 
(1, 'Detalle 1.1', 'SKU001-1', 'Descripción detalle 1.1', 25.00, 1, 0, 'admin', GETDATE()),
(2, 'Detalle 2.1', 'SKU002-1', 'Descripción detalle 2.1', 50.00, 1, 1, 'admin', GETDATE()),
(3, 'Detalle 3.1', 'SKU003-1', 'Descripción detalle 3.1', 37.50, 1, 0, 'admin', GETDATE()),
(4, 'Detalle 4.1', 'SKU004-1', 'Descripción detalle 4.1', 100.00, 1, 0, 'admin', GETDATE()),
(5, 'Detalle 5.1', 'SKU005-1', 'Descripción detalle 5.1', 75.00, 1, 1, 'admin', GETDATE()),
(6, 'Detalle 6.1', 'SKU006-1', 'Descripción detalle 6.1', 60.00, 1, 0, 'admin', GETDATE()),
(7, 'Detalle 7.1', 'SKU007-1', 'Descripción detalle 7.1', 90.00, 1, 1, 'admin', GETDATE()),
(8, 'Detalle 8.1', 'SKU008-1', 'Descripción detalle 8.1', 55.00, 1, 0, 'admin', GETDATE()),
(9, 'Detalle 9.1', 'SKU009-1', 'Descripción detalle 9.1', 45.00, 1, 1, 'admin', GETDATE()),
(10, 'Detalle 10.1', 'SKU010-1', 'Descripción detalle 10.1', 70.00, 1, 0, 'admin', GETDATE());

-- Insertar 10 registros de ejemplo en la tabla SaleDetail
INSERT INTO SaleDetail (SaleId, Quantity, Price, Discount, Taxes, Subtotal, Total, CreatedBy, CreatedDate) VALUES 
(1, 1.00, 50.00, 5.00, 9.00, 45.00, 54.00, 'admin', GETDATE()),
(2, 2.00, 100.00, 10.00, 18.00, 90.00, 108.00, 'admin', GETDATE()),
(3, 1.50, 75.00, 7.50, 13.50, 67.50, 81.00, 'admin', GETDATE()),
(4, 1.80, 200.00, 20.00, 36.00, 180.00, 216.00, 'admin', GETDATE()),
(5, 2.20, 150.00, 15.00, 27.00, 135.00, 162.00, 'admin', GETDATE()),
(6, 1.30, 120.00, 12.00, 21.60, 108.00, 129.60, 'admin', GETDATE()),
(7, 1.70, 180.00, 18.00, 32.40, 162.00, 194.40, 'admin', GETDATE()),
(8, 1.90, 110.00, 11.00, 19.80, 99.00, 118.80, 'admin', GETDATE()),
(9, 2.10, 140.00, 14.00, 25.20, 126.00, 151.20, 'admin', GETDATE()),
(10, 1.60, 90.00, 9.00, 16.20, 81.00, 97.20, 'admin', GETDATE());

-- Insertar 10 registros de ejemplo en la tabla Appointment
INSERT INTO Appointment (Guid, CustomerId, WorkerId, AppointmentDate, IsCompleted, IsConfirmed, IsCancelled, CreatedBy, CreatedDate) VALUES 
(NEWID(), 1, 1, '2024-10-16 09:00:00', 0, 1, 0, 'admin', GETDATE()),
(NEWID(), 2, 2, '2024-10-17 10:00:00', 1, 1, 0, 'admin', GETDATE()),
(NEWID(), 3, 3, '2024-10-18 11:00:00', 0, 0, 0, 'admin', GETDATE()),
(NEWID(), 4, 4, '2024-10-19 12:00:00', 0, 1, 0, 'admin', GETDATE()),
(NEWID(), 5, 5, '2024-10-20 13:00:00', 1, 1, 0, 'admin', GETDATE()),
(NEWID(), 6, 6, '2024-10-21 14:00:00', 0, 0, 1, 'admin', GETDATE()),
(NEWID(), 7, 7, '2024-10-22 15:00:00', 0, 1, 0, 'admin', GETDATE()),
(NEWID(), 8, 8, '2024-10-23 16:00:00', 0, 1, 0, 'admin', GETDATE()),
(NEWID(), 9, 9, '2024-10-24 17:00:00', 1, 1, 0, 'admin', GETDATE()),
(NEWID(), 10, 10, '2024-10-25 18:00:00', 0, 0, 0, 'admin', GETDATE());
