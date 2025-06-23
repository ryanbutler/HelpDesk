USE [HelpDesk]
GO

/****** Object:  Table [dbo].[Severity]    Script Date: 6/16/2025 2:00:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Severity](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Severity] [varchar](50) NOT NULL
) ON [PRIMARY]
GO


