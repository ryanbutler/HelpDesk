USE [HelpDesk]
GO
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([Id], [Department]) VALUES (1, N'Support')
INSERT [dbo].[Department] ([Id], [Department]) VALUES (2, N'Billing')
INSERT [dbo].[Department] ([Id], [Department]) VALUES (3, N'Sales')
SET IDENTITY_INSERT [dbo].[Department] OFF
GO
SET IDENTITY_INSERT [dbo].[Personnel] ON 

INSERT [dbo].[Personnel] ([Id], [Personnel]) VALUES (1, N'Student')
INSERT [dbo].[Personnel] ([Id], [Personnel]) VALUES (2, N'Faculty')
INSERT [dbo].[Personnel] ([Id], [Personnel]) VALUES (3, N'Staff')
SET IDENTITY_INSERT [dbo].[Personnel] OFF
GO
SET IDENTITY_INSERT [dbo].[Severity] ON 

INSERT [dbo].[Severity] ([Id], [Severity]) VALUES (1, N'High')
INSERT [dbo].[Severity] ([Id], [Severity]) VALUES (2, N'Medium')
INSERT [dbo].[Severity] ([Id], [Severity]) VALUES (3, N'Low')
SET IDENTITY_INSERT [dbo].[Severity] OFF
GO
