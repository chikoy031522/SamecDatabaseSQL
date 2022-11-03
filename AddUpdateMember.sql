USE [SamecDatabase]
GO
/****** Object:  StoredProcedure [dbo].[AddUpdateMember]    Script Date: 11/3/2022 7:49:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[AddUpdateMember](@MemberID int , @Lastname nvarchar(50), @Firstname nvarchar(50),@Middlename nvarchar(50),
   @Birthplace nvarchar(500),@Birthdate date = null,@Inductiondate date = null,@Telephone nvarchar(20),@EmailAddress nvarchar(100),@UserName nvarchar(50))
AS
BEGIN
   SET NOCOUNT ON;
   DECLARE @UserID uniqueidentifier,@ZeroGUID uniqueidentifier = '00000000-0000-0000-0000-000000000000' 
   SELECT @UserID = ISNULL(UserID,@ZeroGUID) FROM tblUsers WHERE Username = @UserName
 --  IF (@MemberID <> 0)
	--	BEGIN
	--		IF EXISTS(SELECT 1 FROM tblMembers WHERE MemberID = @MemberID)
	--			BEGIN
	--				UPDATE tblMembers SET Lastname=@Lastname,Firstname = @Firstname,Middlename = @Middlename,Birthplace = @Birthplace,
	--					Birthdate=@Birthdate,Inductiondate=@Inductiondate,Telephone=@Telephone,EmailAddress=@EmailAddress WHERE MemberID = @MemberID
	--			END
	--	END
	--ELSE
	--	BEGIN
	--	    IF NOT EXISTS(SELECT 1 FROM tblMembers WHERE Lastname = @Lastname AND Firstname = @Firstname)
	--			BEGIN
	--				INSERT INTO tblMembers(Firstname,Lastname,Middlename,Birthplace,Birthdate,Inductiondate,Telephone,EmailAddress,TransactionDTM,UserID)
	--				SELECT @Firstname,@Lastname,@Middlename,@Birthplace,@Birthdate,@Inductiondate,@Telephone,@EmailAddress,GETDATE(),@UserID
	--			END
	--	END
	IF EXISTS(SELECT 1 FROM tblMembers WHERE MemberID = @MemberID)
		BEGIN
			UPDATE tblMembers SET Lastname=@Lastname,Firstname = @Firstname,Middlename = @Middlename,Birthplace = @Birthplace,
						Birthdate=@Birthdate,Inductiondate=@Inductiondate,Telephone=@Telephone,EmailAddress=@EmailAddress WHERE MemberID = @MemberID
		END
	ELSE
		BEGIN
		   INSERT INTO tblMembers(MemberID,Firstname,Lastname,Middlename,Birthplace,Birthdate,Inductiondate,Telephone,EmailAddress,TransactionDTM,UserID)
						SELECT @MemberID,@Firstname,@Lastname,@Middlename,@Birthplace,@Birthdate,@Inductiondate,@Telephone,@EmailAddress,GETDATE(),@UserID
	    END
END
