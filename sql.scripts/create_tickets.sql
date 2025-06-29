USE [HelpDesk]
GO

/****** Object:  Table [dbo].[Tickets]    Script Date: 6/16/2025 1:57:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tickets](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL
) ON [PRIMARY]
GO


