USE [HelpDesk]
GO

/****** Object:  Table [dbo].[Personnel]    Script Date: 6/21/2025 9:37:44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Personnel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Personnel] [varchar](50) NOT NULL
) ON [PRIMARY]
GO

