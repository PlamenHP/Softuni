USE [LocalStore]
GO

ALTER TABLE Products
ALTER COLUMN quantity FLOAT NULL 

ALTER TABLE Products
ALTER COLUMN weight FLOAT NULL 

SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Name], [DistributorName], [Description], [Price]) VALUES (1, N'Cup', N'Fairtrade', N'Tea Cup', CAST(4.50 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([Id], [Name], [DistributorName], [Description], [Price]) VALUES (2, N'Plate', N'Fairtrade', N'Dinner Plate', CAST(7.80 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([Id], [Name], [DistributorName], [Description], [Price]) VALUES (3, N'Vase', N'Homebase', N'Porcelan Vase', CAST(9.90 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Products] OFF
