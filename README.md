# Inventory Management System

## 📝 Project Overview
A web-based **Inventory Management System** built with **Clean Architecture**.  
It helps small to medium businesses manage products, suppliers, stock levels, sales, invoices, and returns.

**Key Features:**
- Real-time inventory tracking
- Product and supplier management
- Low-stock alerts
- POS interface for sales and invoice generation
- Sales returns processing
- Reporting and analytics

---

## 🏛️ Project Structure (Clean Architecture)

- **InventorySystem.Domain**  
  Entities, Value Objects, Domain Logic  

- **InventorySystem.Application**  
  Application services, Use Cases, Interfaces, Handellar

- **InventorySystem.Infrastructure**  
  DbContext, Migrations, Seed Data  

- **InventorySystem.Api**  
  Entry point (Controllers, Dependency Injection, Startup configuration)

> Note: Images are stored as file paths (`ImagePath`). No binary image data in DB.

---

## 🗂️ Database Schema Overview

**Products:** ID, Name, Description, SKU, CategoryID, Price, Cost, ReorderLevel, CurrentStock, Barcode, UnitOfMeasurement, MinimumStockLevel, MaximumStockLevel, ImagePath  
**Categories:** ID, Name, Description  
**Suppliers:** ID, Name, ContactPerson, Email, Phone, Address  
**ProductSupplier:** ID, ProductID, SupplierID, Cost  
**StockHistory:** ID, ProductID, Quantity, Type, Notes, Date  
**SalesInvoice:** ID, InvoiceNumber, Date, TotalAmount, CreatedByUserId  
**SalesInvoiceItems:** ID, InvoiceId, ProductID, Quantity, UnitPrice, SubTotal  
**SalesReturns:** ID, InvoiceId, ReturnDate, TotalReturnedAmount, CreatedByUserId  
**SalesReturnItems:** ID, SalesReturnId, ProductID, Quantity, UnitPrice, SubTotal  
**Notifications:** ID, Title, Message, Type, Priority, IsRead, ReadAt, CreatedAt, ProductID  
**Users:** ASP.NET Identity schema with custom roles (Admin/Staff)  

--
### 1. Clone the repository
```bash

git clone https:git@github.com:osamateama/-inventory-system.git

```
