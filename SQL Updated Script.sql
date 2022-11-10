--Adding PaymentID in tblPayment if not exists
IF NOT EXISTS (SELECT *  FROM   sys.columns WHERE  object_id = OBJECT_ID(N'[dbo].[tblPayment]') AND name = 'PaymentID')
BEGIN
    ALTER TABLE tblPayment
    ADD PaymentID INT IDENTITY(1,1)
END


IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('AddUpdateDeletePaymentType'))
   EXEC ('CREATE PROCEDURE AddUpdateDeletePaymentType AS BEGIN SET NOCOUNT ON; END')
GO

ALTER PROCEDURE [dbo].[AddUpdateDeletePaymentType](@TranType char(6), @PaymentTypeDesc nvarchar(50), @PaymentTypeID int)
AS
  BEGIN
     set nocount on;
	 IF (@TranType = 'add')
	    BEGIN
			INSERT INTO tblPaymentType(PaymentDesc) VALUES(@PaymentTypeDesc)
		END
	 IF (@TranType = 'update')
	    BEGIN
			UPDATE tblPaymentType SET PaymentDesc = @PaymentTypeDesc WHERE PaymentTypeID = @PaymentTypeID
		END
	IF (@TranType = 'delete')
	    BEGIN
			UPDATE tblPaymentType SET IsActive = 0 WHERE PaymentTypeID = @PaymentTypeID
		END
  END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('AddUpdateMember'))
   EXEC ('CREATE PROCEDURE AddUpdateMember AS BEGIN SET NOCOUNT ON; END')
GO

ALTER procedure [dbo].[AddUpdateMember](@MemberID int , @Lastname nvarchar(50), @Firstname nvarchar(50),@Middlename nvarchar(50),
   @Birthplace nvarchar(500),@Birthdate date = null,@Inductiondate date = null,@Telephone nvarchar(20),@EmailAddress nvarchar(100),@UserName nvarchar(50))
AS
BEGIN
   SET NOCOUNT ON;
   DECLARE @UserID uniqueidentifier,@ZeroGUID uniqueidentifier = '00000000-0000-0000-0000-000000000000' 
   SELECT @UserID = ISNULL(UserID,@ZeroGUID) FROM tblUsers WHERE Username = @UserName 
	
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
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('AddUpdatePayment'))
   EXEC ('CREATE PROCEDURE AddUpdatePayment AS BEGIN SET NOCOUNT ON; END')
GO

ALTER procedure [dbo].[AddUpdatePayment](@PaymentID int = 0, @MemberID int, @PaymentTypeID int,
   @PaymentAmount float,@PaymentMonth int,@PaymentYear int,@Paymentdate date,@UserName nvarchar(50))
AS
BEGIN
   SET NOCOUNT ON;
   DECLARE @UserID uniqueidentifier,@ZeroGUID uniqueidentifier = '00000000-0000-0000-0000-000000000000' 
   DECLARE @TranDate datetime2(2) = GETDATE()
   SELECT @UserID = ISNULL(UserID,@ZeroGUID) FROM tblUsers WHERE Username = @UserName 
	
	IF EXISTS(SELECT 1 FROM tblPayment WHERE PaymentID = @PaymentID AND MemberID = @MemberID)
		BEGIN
			UPDATE tblPayment SET PaymentAmount = @PaymentAmount,PaymentMonth=@PaymentMonth,PaymentYear=@PaymentYear,Paymentdate=@Paymentdate
			   ,TransactionDTM = @TranDate,UserID=@UserID,PaymentTypeID=@PaymentTypeID WHERE PaymentID=@PaymentID AND MemberID=@MemberID
		END
	ELSE
		BEGIN
		   INSERT INTO tblPayment(MemberID,PaymentTypeID,PaymentAmount,Paymentdate,PaymentMonth,PaymentYear,TransactionDTM,UserID)
		   SELECT @MemberID,@PaymentTypeID,@PaymentAmount,@Paymentdate,@PaymentMonth,@PaymentYear,@TranDate,@UserID						
	    END
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('AddUpdateUser'))
   EXEC ('CREATE PROCEDURE AddUpdateUser AS BEGIN SET NOCOUNT ON; END')
GO

ALTER PROCEDURE [dbo].[AddUpdateUser](@Username nvarchar(100),@Password nvarchar(100),@isActive bit = 1) 	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	DECLARE @UserID uniqueidentifier;
	DECLARE @PasswordHash varbinary(MAX)
	    
	IF NOT EXISTS(SELECT 1 FROM tblUsers WHERE UserName = @UserName)
	   BEGIN
	       SET @UserID = NEWID()
	       SET @PasswordHash = dbo.Hash(@Password,@UserID)
	       INSERT INTO tblUsers
		   SELECT @UserID,@Username,@PasswordHash,@isActive
	   END
	ELSE
	   BEGIN
	     SET @UserID = (SELECT UserID FROM tblUsers WHERE UserName = @UserName)
		 SET @PasswordHash = dbo.Hash(@Password,@UserID)
		 UPDATE tblUsers SET UserPassword = @PasswordHash, IsActive = @isActive WHERE Username = @Username
	   END
	
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('CheckUserExist'))
   EXEC ('CREATE PROCEDURE CheckUserExist AS BEGIN SET NOCOUNT ON; END')
GO

ALTER PROCEDURE [dbo].[CheckUserExist](@Username nvarchar(100),@Password nvarchar(100)) 	
AS
BEGIN
	
	SET NOCOUNT ON;
	DECLARE @UserID uniqueidentifier
	DECLARE @PasswordHash varbinary(max)
	
	IF EXISTS(SELECT 1 FROM tblUsers WHERE Username = @Username)
	   BEGIN
	       SELECT @UserID = UserID FROM tblUsers WHERE Username = @Username 
		   SET @PasswordHash = dbo.Hash(@Password,@UserID)
		   SELECT * FROM tblUsers WHERE UserName = @UserName and UserPassword = @PasswordHash AND IsActive=1
	   END		
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('DeleteMember'))
   EXEC ('CREATE PROCEDURE DeleteMember AS BEGIN SET NOCOUNT ON; END')
GO

ALTER PROCEDURE [dbo].[DeleteMember](@MemberID int)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    UPDATE tblMembers SET IsActive = 0 WHERE MemberID = @MemberID
	
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('GetMember'))
   EXEC ('CREATE PROCEDURE GetMember AS BEGIN SET NOCOUNT ON; END')
GO

ALTER PROCEDURE [dbo].[GetMember] (@MemberID int)	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    
	SELECT MemberID,Lastname,Firstname,Middlename FROM tblMembers WHERE IsActive = 1 AND MemberID = @MemberID
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('GetMembers'))
   EXEC ('CREATE PROCEDURE GetMembers AS BEGIN SET NOCOUNT ON; END')
GO

ALTER PROCEDURE [dbo].[GetMembers] 	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    
	SELECT MemberID,Lastname,Firstname,Middlename,Format(Birthdate,'MM/dd/yyyy') Birthdate,Birthplace
	,Telephone,Format(Inductiondate,'MM/dd/yyyy') Inductiondate,EmailAddress FROM tblMembers WHERE IsActive = 1
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('GetPayment'))
   EXEC ('CREATE PROCEDURE GetPayment AS BEGIN SET NOCOUNT ON; END')
GO

ALTER PROCEDURE [dbo].[GetPayment](@PaymentID int) 	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    
	SELECT a.PaymentID,a.MemberID,b.Lastname,b.Firstname,a.PaymentYear
		,PaymentMonth=DATENAME(MONTH, DATEADD(MONTH, ISNULL(a.PaymentMonth,1), '2020-12-01'))
		,a.PaymentAmount,a.Paymentdate,c.PaymentDesc
	FROM tblPayment a INNER JOIN tblMembers b ON a.MemberID = b.MemberID 
		LEFT JOIN tblPaymentType c ON a.PaymentTypeID = c.PaymentTypeID
    WHERE PaymentID = @PaymentID
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('GetPayments'))
   EXEC ('CREATE PROCEDURE GetPayments AS BEGIN SET NOCOUNT ON; END')
GO

ALTER PROCEDURE [dbo].[GetPayments] 	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    
	SELECT a.PaymentID,a.MemberID,b.Lastname,b.Firstname,a.PaymentYear
		,PaymentMonth=DATENAME(MONTH, DATEADD(MONTH, ISNULL(a.PaymentMonth,1), '2020-12-01'))
		,a.PaymentAmount,a.Paymentdate,c.PaymentDesc
	FROM tblPayment a INNER JOIN tblMembers b ON a.MemberID = b.MemberID 
		LEFT JOIN tblPaymentType c ON a.PaymentTypeID = c.PaymentTypeID
	ORDER BY a.Paymentdate DESC,b.Lastname

END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('GetPaymentType'))
   EXEC ('CREATE PROCEDURE GetPaymentType AS BEGIN SET NOCOUNT ON; END')
GO

ALTER PROCEDURE [dbo].[GetPaymentType]	
	
AS
BEGIN	

	SET NOCOUNT ON;

	SELECT PaymentDesc,PaymentTypeID FROM tblPaymentType WHERE IsActive = 1
    
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('DeletePayment'))
   EXEC ('CREATE PROCEDURE DeletePayment AS BEGIN SET NOCOUNT ON; END')
GO

ALTER PROCEDURE [dbo].[DeletePayment](@PaymentID int)
AS
BEGIN
	
	SET NOCOUNT ON;
	DELETE FROM tblPayment WHERE PaymentID = @PaymentID
    	
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('GetUsers'))
   EXEC ('CREATE PROCEDURE GetUsers AS BEGIN SET NOCOUNT ON; END')
GO


ALTER PROCEDURE [dbo].[GetUsers] 	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    
	SELECT Username,UserID FROM tblUsers WHERE IsActive = 1
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('DeleteUser'))
   EXEC ('CREATE PROCEDURE DeleteUser AS BEGIN SET NOCOUNT ON; END')
GO

ALTER PROCEDURE [dbo].[DeleteUser]	
	(@UserName nvarchar(50))
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    IF EXISTS(SELECT 1 FROM tblUsers  WHERE Username = @UserName)
	   UPDATE tblUsers SET IsActive = 0 WHERE Username = @UserName
END

IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('SearchPayments'))
   EXEC ('CREATE PROCEDURE SearchPayments AS BEGIN SET NOCOUNT ON; END')
GO

ALTER PROCEDURE [dbo].[SearchPayments](@StringSearch nvarchar(50),@SearchType char(3)) 	
AS
BEGIN
	
	SET NOCOUNT ON;
	
	DECLARE @tblSearch TABLE(strSearch nvarchar(50), Ident smallint)
	DECLARE @tempSearchResults TABLE(PaymentID char(10),MemberID char(10),Lastname nvarchar(50),FirstName nvarchar(50),PaymentYear char(5),
				PaymentMonth nvarchar(10),PaymentAmount nvarchar(20),Paymentdate nvarchar(20),PaymentDesc nvarchar(100))
	DECLARE @sqlQuery nvarchar(max),@refSearch nvarchar(50)
	DECLARE @refL smallint = 1
	SET @SearchType = IIF(ISNULL(@SearchType,'')='','OR',@SearchType)
	INSERT INTO @tblSearch
	SELECT LTRIM(RTRIM((VALUE))),ROW_NUMBER() OVER(ORDER BY value) FROM string_split(@StringSearch,'+')

	WHILE EXISTS(SELECT 1 FROM @tblSearch)
		BEGIN
			 SET @refSearch =  (SELECT '%' + strSearch + '%' FROM @tblSearch WHERE Ident=@refL)	
			 
			 IF (@SearchType = 'OR' OR @refL=1 )			    
			    BEGIN				
					INSERT INTO @tempSearchResults
					SELECT a.PaymentID,a.MemberID,b.Lastname,b.Firstname,a.PaymentYear
						,PaymentMonth=DATENAME(MONTH, DATEADD(MONTH, ISNULL(a.PaymentMonth,1), '2020-12-01'))
						,a.PaymentAmount,a.Paymentdate,c.PaymentDesc
					FROM tblPayment a INNER JOIN tblMembers b ON a.MemberID = b.MemberID 
						LEFT JOIN tblPaymentType c ON a.PaymentTypeID = c.PaymentTypeID
					WHERE CAST(a.MemberID as nvarchar(20))+b.Lastname+b.Firstname+c.PaymentDesc+CAST(a.PaymentYear as char(4)) LIKE @refSearch
						OR DATENAME(MONTH, DATEADD(MONTH, ISNULL(a.PaymentMonth,1), '2020-12-01')) LIKE @refSearch
			            OR LOWER(@refSearch) = '%all%'			
				END	
			ELSE IF (@SearchType = 'AND' AND @refL>1 )
			    BEGIN
					DELETE FROM @tempSearchResults
					WHERE MemberID+Lastname+FirstName+PaymentDesc+PaymentYear+PaymentMonth NOT LIKE @refSearch
				END
			DELETE FROM @tblSearch WHERE Ident = @refL
			SET @refL += 1
		END
	SELECT DISTINCT a.PaymentID,a.MemberID,a.Lastname,a.Firstname,a.PaymentYear
 		  ,a.PaymentMonth,a.PaymentAmount,a.Paymentdate,a.PaymentDesc
	FROM @tempSearchResults a
	
END

