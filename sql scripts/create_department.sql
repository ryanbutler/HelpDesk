USE [HelpDesk]
GO

/****** Object:  Table [dbo].[Departments]    Script Date: 6/16/2025 1:50:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Departments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Department] [varchar](50) NOT NULL
) ON [PRIMARY]
GO


