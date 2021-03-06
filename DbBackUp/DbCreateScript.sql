USE [ETicaret]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 18.02.2019 22:34:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[AdressID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerAddress]    Script Date: 18.02.2019 22:34:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerAddress](
	[Id] [int] NOT NULL,
	[Desc] [nvarchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItems]    Script Date: 18.02.2019 22:34:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[ProductPrice] [float] NOT NULL,
	[ProductDiscountPrice] [float] NOT NULL,
	[DiscountValue] [float] NOT NULL,
 CONSTRAINT [PK__ORDER_IT__3214EC07EE48F289] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 18.02.2019 22:34:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[TotalPrice] [float] NOT NULL,
	[DiscountPrice] [float] NOT NULL,
	[CustomerAddressDesc] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK__ORDER__3214EC07819CCE32] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 18.02.2019 22:34:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Desc] [nvarchar](50) NOT NULL,
	[Price] [float] NOT NULL,
	[DiscountPrice] [float] NOT NULL,
	[ProductTypeID] [int] NOT NULL,
 CONSTRAINT [PK__PRODUCT__3214EC0788F5854A] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductType]    Script Date: 18.02.2019 22:34:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductType](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[OrderItems] ON 

INSERT [dbo].[OrderItems] ([Id], [OrderID], [ProductID], [ProductPrice], [ProductDiscountPrice], [DiscountValue]) VALUES (1, 0, 1, 50, 26, 0)
INSERT [dbo].[OrderItems] ([Id], [OrderID], [ProductID], [ProductPrice], [ProductDiscountPrice], [DiscountValue]) VALUES (2, 0, 1, 50, 26, 0)
INSERT [dbo].[OrderItems] ([Id], [OrderID], [ProductID], [ProductPrice], [ProductDiscountPrice], [DiscountValue]) VALUES (3, 0, 1, 50, 26, 0)
INSERT [dbo].[OrderItems] ([Id], [OrderID], [ProductID], [ProductPrice], [ProductDiscountPrice], [DiscountValue]) VALUES (4, 0, 1, 50, 26, 0)
INSERT [dbo].[OrderItems] ([Id], [OrderID], [ProductID], [ProductPrice], [ProductDiscountPrice], [DiscountValue]) VALUES (5, 0, 1, 50, 26, 0)
SET IDENTITY_INSERT [dbo].[OrderItems] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [CustomerID], [TotalPrice], [DiscountPrice], [CustomerAddressDesc]) VALUES (1, 1, 250, 26, N'')
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Name], [Desc], [Price], [DiscountPrice], [ProductTypeID]) VALUES (1, N'Karışık Pizza1', N'Karışık Pizza1', 50, 26, 1)
INSERT [dbo].[Products] ([Id], [Name], [Desc], [Price], [DiscountPrice], [ProductTypeID]) VALUES (2, N'Bolmalzemos', N'Bolmalzemos', 45, 34, 1)
INSERT [dbo].[Products] ([Id], [Name], [Desc], [Price], [DiscountPrice], [ProductTypeID]) VALUES (3, N'Tavuk Parçaları', N'Tavuk Parçaları', 20, 18, 2)
INSERT [dbo].[Products] ([Id], [Name], [Desc], [Price], [DiscountPrice], [ProductTypeID]) VALUES (4, N'Sufle', N'Sufle', 15, 10, 2)
INSERT [dbo].[Products] ([Id], [Name], [Desc], [Price], [DiscountPrice], [ProductTypeID]) VALUES (5, N'Kola', N'Kola', 5, 5, 3)
INSERT [dbo].[Products] ([Id], [Name], [Desc], [Price], [DiscountPrice], [ProductTypeID]) VALUES (6, N'Ayran', N'Ayran', 5, 5, 3)
SET IDENTITY_INSERT [dbo].[Products] OFF
INSERT [dbo].[ProductType] ([Id], [Name]) VALUES (1, N'Pizza')
INSERT [dbo].[ProductType] ([Id], [Name]) VALUES (2, N'Side')
INSERT [dbo].[ProductType] ([Id], [Name]) VALUES (3, N'Drink')
