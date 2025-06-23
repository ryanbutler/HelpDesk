USE [HelpDesk]
GO

/****** Object:  Table [dbo].[Status]    Script Date: 6/16/2025 1:55:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Status](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Status] [varchar](50) NOT NULL
) ON [PRIMARY]
GO


