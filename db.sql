USE [master]
GO
/****** Object:  Database [Dam2_HaranElola]    Script Date: 27/10/2025 8:46:20 ******/
CREATE DATABASE [Dam2_HaranElola]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Dam2_HaranElola', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SEGUNDO\MSSQL\DATA\Dam2_HaranElola.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'Dam2_HaranElola_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SEGUNDO\MSSQL\DATA\Dam2_HaranElola_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Dam2_HaranElola] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Dam2_HaranElola].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Dam2_HaranElola] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Dam2_HaranElola] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Dam2_HaranElola] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Dam2_HaranElola] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Dam2_HaranElola] SET ARITHABORT OFF 
GO
ALTER DATABASE [Dam2_HaranElola] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Dam2_HaranElola] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Dam2_HaranElola] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Dam2_HaranElola] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Dam2_HaranElola] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Dam2_HaranElola] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Dam2_HaranElola] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Dam2_HaranElola] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Dam2_HaranElola] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Dam2_HaranElola] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Dam2_HaranElola] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Dam2_HaranElola] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Dam2_HaranElola] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Dam2_HaranElola] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Dam2_HaranElola] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Dam2_HaranElola] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Dam2_HaranElola] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Dam2_HaranElola] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Dam2_HaranElola] SET  MULTI_USER 
GO
ALTER DATABASE [Dam2_HaranElola] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Dam2_HaranElola] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Dam2_HaranElola] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Dam2_HaranElola] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Dam2_HaranElola] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Dam2_HaranElola] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Dam2_HaranElola', N'ON'
GO
ALTER DATABASE [Dam2_HaranElola] SET QUERY_STORE = ON
GO
ALTER DATABASE [Dam2_HaranElola] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Dam2_HaranElola]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 27/10/2025 8:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](15) NOT NULL,
	[Description] [ntext] NULL,
	[Picture] [image] NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 27/10/2025 8:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [nchar](5) NOT NULL,
	[CompanyName] [nvarchar](40) NOT NULL,
	[ContactName] [nvarchar](30) NULL,
	[ContactTitle] [nvarchar](30) NULL,
	[Address] [nvarchar](60) NULL,
	[City] [nvarchar](15) NULL,
	[Region] [nvarchar](15) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[Country] [nvarchar](15) NULL,
	[Phone] [nvarchar](24) NULL,
	[Fax] [nvarchar](24) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeliveryNote]    Script Date: 27/10/2025 8:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeliveryNote](
	[DeliveryNoteID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NULL,
	[SupplierID] [int] NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_DeliveryNote] PRIMARY KEY CLUSTERED 
(
	[DeliveryNoteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeliveryNoteDetails]    Script Date: 27/10/2025 8:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeliveryNoteDetails](
	[DeliveryNoteID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_DeliveryNoteDetails] PRIMARY KEY CLUSTERED 
(
	[DeliveryNoteID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 27/10/2025 8:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[id] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[puesto] [varchar](50) NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 27/10/2025 8:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](20) NOT NULL,
	[FirstName] [nvarchar](10) NOT NULL,
	[Title] [nvarchar](30) NULL,
	[TitleOfCourtesy] [nvarchar](25) NULL,
	[BirthDate] [datetime] NULL,
	[HireDate] [datetime] NULL,
	[Address] [nvarchar](60) NULL,
	[City] [nvarchar](15) NULL,
	[Region] [nvarchar](15) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[Country] [nvarchar](15) NULL,
	[HomePhone] [nvarchar](24) NULL,
	[Extension] [nvarchar](4) NULL,
	[Photo] [image] NULL,
	[Notes] [ntext] NULL,
	[ReportsTo] [int] NULL,
	[PhotoPath] [nvarchar](255) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 27/10/2025 8:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[InvoiceID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[Factured] [bit] NOT NULL,
	[ShippingMode] [int] NOT NULL,
	[PaymentMethod] [int] NOT NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoiceDetails]    Script Date: 27/10/2025 8:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceDetails](
	[InvoiceID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[SalesPrice] [smallmoney] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [decimal](3, 2) NOT NULL,
	[Fee] [decimal](3, 2) NOT NULL,
 CONSTRAINT [PK_InvoiceDetails] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 27/10/2025 8:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[SalesPrice] [smallmoney] NOT NULL,
	[Units] [int] NOT NULL,
	[Discount] [decimal](3, 2) NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 27/10/2025 8:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [smalldatetime] NOT NULL,
	[SupplierID] [int] NOT NULL,
	[Total] [smallmoney] NOT NULL,
	[ShippingMode] [int] NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentMethods]    Script Date: 27/10/2025 8:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentMethods](
	[PaymentMethod] [int] NOT NULL,
	[Description] [nchar](10) NOT NULL,
 CONSTRAINT [PK_PaymentMethods] PRIMARY KEY CLUSTERED 
(
	[PaymentMethod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 27/10/2025 8:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](40) NOT NULL,
	[SupplierID] [int] NULL,
	[CategoryID] [int] NULL,
	[QuantityPerUnit] [nvarchar](20) NULL,
	[UnitPrice] [money] NULL,
	[UnitsInStock] [smallint] NULL,
	[UnitsOnOrder] [smallint] NULL,
	[ReorderLevel] [smallint] NULL,
	[Discontinued] [bit] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShippingMethods]    Script Date: 27/10/2025 8:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShippingMethods](
	[ShippingMode] [int] NOT NULL,
	[Description] [varchar](20) NOT NULL,
 CONSTRAINT [PK_ShippingMethods] PRIMARY KEY CLUSTERED 
(
	[ShippingMode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 27/10/2025 8:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[Status] [int] NOT NULL,
	[Description] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[Status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 27/10/2025 8:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](40) NOT NULL,
	[ContactName] [nvarchar](30) NULL,
	[ContactTitle] [nvarchar](30) NULL,
	[Address] [nvarchar](60) NULL,
	[City] [nvarchar](15) NULL,
	[Region] [nvarchar](15) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[Country] [nvarchar](15) NULL,
	[Phone] [nvarchar](24) NULL,
	[Fax] [nvarchar](24) NULL,
	[HomePage] [ntext] NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[DeliveryNote] ADD  CONSTRAINT [DF_DeliveryNote_Status]  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[Invoice] ADD  CONSTRAINT [DF_Invoice_ShippingMode]  DEFAULT ((0)) FOR [ShippingMode]
GO
ALTER TABLE [dbo].[Invoice] ADD  CONSTRAINT [DF_Invoice_PaymentMethod]  DEFAULT ((0)) FOR [PaymentMethod]
GO
ALTER TABLE [dbo].[InvoiceDetails] ADD  CONSTRAINT [DF_InvoiceDetails_Fee]  DEFAULT ((0.21)) FOR [Fee]
GO
ALTER TABLE [dbo].[OrderDetails] ADD  CONSTRAINT [DF_OrderDetails_Discount]  DEFAULT ((0)) FOR [Discount]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_OrderDate]  DEFAULT (getdate()) FOR [OrderDate]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_ShippingMode]  DEFAULT ((0)) FOR [ShippingMode]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_Status]  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[DeliveryNote]  WITH CHECK ADD  CONSTRAINT [FK_DeliveryNote_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[DeliveryNote] CHECK CONSTRAINT [FK_DeliveryNote_Orders]
GO
ALTER TABLE [dbo].[DeliveryNote]  WITH CHECK ADD  CONSTRAINT [FK_DeliveryNote_Status] FOREIGN KEY([Status])
REFERENCES [dbo].[Status] ([Status])
GO
ALTER TABLE [dbo].[DeliveryNote] CHECK CONSTRAINT [FK_DeliveryNote_Status]
GO
ALTER TABLE [dbo].[DeliveryNote]  WITH CHECK ADD  CONSTRAINT [FK_DeliveryNote_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[DeliveryNote] CHECK CONSTRAINT [FK_DeliveryNote_Suppliers]
GO
ALTER TABLE [dbo].[DeliveryNoteDetails]  WITH CHECK ADD  CONSTRAINT [FK_DeliveryNoteDetails_DeliveryNote] FOREIGN KEY([DeliveryNoteID])
REFERENCES [dbo].[DeliveryNote] ([DeliveryNoteID])
GO
ALTER TABLE [dbo].[DeliveryNoteDetails] CHECK CONSTRAINT [FK_DeliveryNoteDetails_DeliveryNote]
GO
ALTER TABLE [dbo].[DeliveryNoteDetails]  WITH CHECK ADD  CONSTRAINT [FK_DeliveryNoteDetails_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[DeliveryNoteDetails] CHECK CONSTRAINT [FK_DeliveryNoteDetails_Products]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Orders]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_PaymentMethods] FOREIGN KEY([PaymentMethod])
REFERENCES [dbo].[PaymentMethods] ([PaymentMethod])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_PaymentMethods]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_ShippingMethods] FOREIGN KEY([ShippingMode])
REFERENCES [dbo].[ShippingMethods] ([ShippingMode])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_ShippingMethods]
GO
ALTER TABLE [dbo].[InvoiceDetails]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceDetails_Invoice] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[Invoice] ([InvoiceID])
GO
ALTER TABLE [dbo].[InvoiceDetails] CHECK CONSTRAINT [FK_InvoiceDetails_Invoice]
GO
ALTER TABLE [dbo].[InvoiceDetails]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceDetails_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[InvoiceDetails] CHECK CONSTRAINT [FK_InvoiceDetails_Products]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_ShippingMethods] FOREIGN KEY([ShippingMode])
REFERENCES [dbo].[ShippingMethods] ([ShippingMode])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_ShippingMethods]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Status] FOREIGN KEY([Status])
REFERENCES [dbo].[Status] ([Status])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Status]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Suppliers]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
/****** Object:  StoredProcedure [dbo].[InsertarProducto]    Script Date: 27/10/2025 8:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- cerar un procedimiento almacenado
-- productId, ProductName, UnitPrice, UnitsInStock,
-- discontinued=0
-- insertar una fila

CREATE PROCEDURE [dbo].[InsertarProducto]
@pr_name NVARCHAR(40),
@unit_pvp MONEY,
@units_stock SMALLINT,

@out int out
AS
BEGIN
	BEGIN TRY
		INSERT INTO Dam2_HaranElola.dbo.Products (ProductName, UnitPrice, UnitsInStock, Discontinued)
		VALUES(@pr_name, @unit_pvp, @units_stock, 0)
		set @out = 1
	END TRY
	BEGIN CATCH
		set @out = @@ERROR
	END CATCH
END;
--EXEC InsertarProducto @pr_name = "sas", @unit_pvp = 13.2, @units_stock = 34

GO
/****** Object:  StoredProcedure [dbo].[PR_Eliminar_Producto]    Script Date: 27/10/2025 8:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- crear un procedimiento almacenado
-- productId, ProductName, UnitPrice, UnitsInStock,
-- discontinued=0
-- insertar una fila

--ALTER PROCEDURE InsertarProducto
--@pr_name NVARCHAR(40),
--@unit_pvp MONEY,
--@units_stock SMALLINT,

--@out int out
--AS
--BEGIN
--	BEGIN TRY
--		INSERT INTO Dam2_HaranElola.dbo.Products (ProductName, UnitPrice, UnitsInStock, Discontinued)
--		VALUES(@pr_name, @unit_pvp, @units_stock, 0)
--		set @out = 1
--	END TRY
--	BEGIN CATCH
--		set @out = @@ERROR
--	END CATCH
--END;
--EXEC InsertarProducto @pr_name = "sas", @unit_pvp = 13.2, @units_stock = 34

/***************************/
-- eliminar producto
-- params: 
--		entrada: @id
--		salida: @out
--			{
--				exito: 1,
--				no-existe: -1,
--				error: @@error
--			}
/**************************/

CREATE PROCEDURE [dbo].[PR_Eliminar_Producto]
	@id int,
	@out int out
AS
BEGIN
	BEGIN TRY
		IF NOT EXISTS(SELECT * FROM Products WHERE ProductID = @id)
		BEGIN
			SET @out = -1
			RETURN
		END
			DELETE FROM dbo.Products WHERE ProductID = @id
			SET @out = 1
	END TRY
	BEGIN CATCH
		SET @out = @@ERROR
	END CATCH
END;

DECLARE @outp INT;

--EXEC PR_Eliminar_Producto
--	@id = 3343,
--	@out = @outp OUTPUT;

--SELECT @outp as error
GO
/****** Object:  StoredProcedure [dbo].[PR_EliminarCat]    Script Date: 27/10/2025 8:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PR_EliminarCat]
	@id int,
	@out int out
AS
BEGIN
SET NOCOUNT ON;
SET @out = 0;

	BEGIN TRY
		IF NOT EXISTS(SELECT * FROM Categories WHERE CategoryID = @id)
		BEGIN
			SET @out = -1
			RETURN
		END
			DELETE FROM dbo.Categories WHERE CategoryID = @id
			SET @out = 1
	END TRY
	BEGIN CATCH
		SET @out = @@ERROR
	END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[PR_InsertarCat]    Script Date: 27/10/2025 8:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PR_InsertarCat]
@cat_name NVARCHAR(15),
@cat_desc ntext,

@out int out
AS
BEGIN
	BEGIN TRY
		INSERT INTO dbo.Categories(CategoryName, Description)
		VALUES(@cat_name,@cat_desc)
		set @out = 1
	END TRY
	BEGIN CATCH
		set @out = @@ERROR
	END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[pr_modificarProducto]    Script Date: 27/10/2025 8:46:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_modificarProducto]
    @id     INT,
    @stock  SMALLINT,
    @pvp    MONEY,
    @out    INT OUTPUT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Products WHERE ProductID = @id)
    BEGIN
        SET @out = -1;
        RETURN;
    END;

    BEGIN TRY
        IF @stock IS NOT NULL AND @stock <> ''
        BEGIN
            UPDATE Products
            SET UnitsInStock = @stock
            WHERE ProductID = @id;
        END;

        IF @pvp IS NOT NULL AND @pvp <> ''
        BEGIN
            UPDATE Products
            SET UnitPrice = @pvp
            WHERE ProductID = @id;
        END;
    END TRY
    BEGIN CATCH
        SET @out = @@ERROR;
    END CATCH;
END;
GO
USE [master]
GO
ALTER DATABASE [Dam2_HaranElola] SET  READ_WRITE 
GO
