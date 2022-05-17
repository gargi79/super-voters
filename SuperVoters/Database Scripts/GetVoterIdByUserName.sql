IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'GetVoterIdByUserName')
BEGIN
    DROP PROCEDURE dbo.GetVoterIdByUserName
END

GO

--Run
--exec dbo.GetVoterIdByUserName 'david'

CREATE PROCEDURE [dbo].GetVoterIdByUserName
(@UserName Varchar(25))

AS   
    SET NOCOUNT ON;  
   SELECT VoterId
    FROM SuperVoters.dbo.Voter
    Where @UserName = UserName
GO

