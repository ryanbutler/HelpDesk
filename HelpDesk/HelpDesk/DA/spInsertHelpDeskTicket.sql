Use HelpDesk
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE spInsertHelpDeskTicket 
	-- Add the parameters for the stored procedure here
	@FName varchar(50),
	@LName varchar(50),
	@Email varchar(50),
	@Title varchar(50),
	@SeverityId int,
	@StatusId int,
	@DepartmentId int,
	@Summary varchar(250)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO HelpDesk (FName, LName, Title, Email, SeverityId, StatusId, DepartmentId, Summary)
	VALUES(@FName, @LName, @Email, @Title, @SeverityId, @StatusId, @DepartmentId, @Summary)
END
GO
