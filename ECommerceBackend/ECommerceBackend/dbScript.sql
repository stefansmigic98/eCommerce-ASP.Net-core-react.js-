USE [ECommerceAppDataBase]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([ID], [CategoryName]) VALUES (1, N'Patike')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ID], [Name], [CategoryID], [DateCreated], [Description], [Price]) VALUES (1, N'Proizvod1', 1, CAST(N'2020-04-04 00:00:00.0000000' AS DateTime2), N'opis proiyvoda', 9600)
INSERT [dbo].[Products] ([ID], [Name], [CategoryID], [DateCreated], [Description], [Price]) VALUES (2, N'Proizvod2', 1, CAST(N'2020-04-04 00:00:00.0000000' AS DateTime2), N'opis porizvoda', 10000)
INSERT [dbo].[Products] ([ID], [Name], [CategoryID], [DateCreated], [Description], [Price]) VALUES (3, N'proizvod3', 1, CAST(N'2019-05-01 00:00:00.0000000' AS DateTime2), N'opis proizvoda', 8000)
INSERT [dbo].[Products] ([ID], [Name], [CategoryID], [DateCreated], [Description], [Price]) VALUES (4, N'proizvod4', 1, CAST(N'2020-05-02 00:00:00.0000000' AS DateTime2), N'opis proizvoda', 7500)
SET IDENTITY_INSERT [dbo].[Products] OFF
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201001150501_first', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201003125434_secound', N'3.1.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201006194725_third', N'3.1.8')
