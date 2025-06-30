USE [HelpDesk]
GO

/****** Object:  Table [dbo].[Severity]    Script Date: 6/21/2025 9:38:24 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Severity](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Severity] [varchar](50) NOT NULL
) ON [PRIMARY]
GO

