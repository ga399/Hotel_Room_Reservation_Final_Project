INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'0344ec8f-a028-48f8-a42f-5935aa942cc0', N'hotel_admin', N'hotel_admin', N'f55e1bc9-b060-4661-9ecd-0a861964995a')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'34a61ec4-b0f7-4043-bdde-172a8087b7bd', N'client', N'client', N'3ea9bd58-73e1-4807-a860-38a2b5cc0411')
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'31a2137a-5472-4986-9ab4-e5b48617a0a4', N'david@gmail.com', N'DAVID@GMAIL.COM', N'david@gmail.com', N'DAVID@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEH5HrFHJHNDeyPMzjHosXWk6U1iGFN6aMqCi4ByfJlXPEO4LaP2OeuMPB2cftLY/Cg==', N'ROZSXURTP4BSSONN5SLRKHUFZ4HFCJE7', N'1fdddfd3-f01c-4b93-96df-a86e64f10606', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'4a94a1dd-8ba5-47fd-b702-a6a4288b5c6a', N'jim@gmail.com', N'JIM@GMAIL.COM', N'jim@gmail.com', N'JIM@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEGhJWu4TXbSk1bpyUOdSDASTXDGkZ0Q4dooLrmIRezgRIJAu/XvUjv0lnHDvlyxDkg==', N'6FPWVNQYFRDGYDQKCMFDIWVLYXVYL35J', N'd02f5a9e-7e4f-4285-b6ac-2e3c84522538', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'717e3713-5e91-4e74-8c08-2d82d8408340', N'admin@reserve.com', N'ADMIN@RESERVE.COM', N'admin@reserve.com', N'ADMIN@RESERVE.COM', 1, N'AQAAAAEAACcQAAAAEETqziDgzSW5xqFeVsWuvXf4XskBmVyLc/Y0Kg6VCi454EEv21blPZ0jgx2M1bRKUQ==', N'G7X4BF6GN3MFDAFQOSQKRLQUFOF5KGNA', N'df78f84b-dfc9-4acc-827d-73a6bff84cde', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'717e3713-5e91-4e74-8c08-2d82d8408340', N'0344ec8f-a028-48f8-a42f-5935aa942cc0')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'31a2137a-5472-4986-9ab4-e5b48617a0a4', N'34a61ec4-b0f7-4043-bdde-172a8087b7bd')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4a94a1dd-8ba5-47fd-b702-a6a4288b5c6a', N'34a61ec4-b0f7-4043-bdde-172a8087b7bd')
SET IDENTITY_INSERT [dbo].[Client] ON
INSERT INTO [dbo].[Client] ([Id], [FullName], [Email]) VALUES (1, N'David Wilkins', N'david@gmail.com')
INSERT INTO [dbo].[Client] ([Id], [FullName], [Email]) VALUES (2, N'James Davis', N'jim@gmail.com')
SET IDENTITY_INSERT [dbo].[Client] OFF
SET IDENTITY_INSERT [dbo].[Hotel] ON
INSERT INTO [dbo].[Hotel] ([Id], [HotelName], [TotalRooms], [BookedRooms], [RoomPrice], [Address]) VALUES (1, N'Golden Globe', 100, 1, CAST(90.00 AS Decimal(18, 2)), N'560 Green Street , Auckland')
INSERT INTO [dbo].[Hotel] ([Id], [HotelName], [TotalRooms], [BookedRooms], [RoomPrice], [Address]) VALUES (2, N'City Line', 50, 1, CAST(60.00 AS Decimal(18, 2)), N'230  Greath South Road  Mt Wellington')
INSERT INTO [dbo].[Hotel] ([Id], [HotelName], [TotalRooms], [BookedRooms], [RoomPrice], [Address]) VALUES (3, N' City Hotel', 200, 1, CAST(100.00 AS Decimal(18, 2)), N'270 High Street Auckland')
SET IDENTITY_INSERT [dbo].[Hotel] OFF
SET IDENTITY_INSERT [dbo].[RoomReservation] ON
INSERT INTO [dbo].[RoomReservation] ([Id], [ClientId], [HotelId]) VALUES (4, 1, 1)
INSERT INTO [dbo].[RoomReservation] ([Id], [ClientId], [HotelId]) VALUES (5, 1, 3)
INSERT INTO [dbo].[RoomReservation] ([Id], [ClientId], [HotelId]) VALUES (6, 2, 2)
SET IDENTITY_INSERT [dbo].[RoomReservation] OFF
