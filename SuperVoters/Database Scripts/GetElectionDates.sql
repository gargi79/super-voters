IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'GetElectionDates')
BEGIN
    DROP PROCEDURE dbo.GetElectionDates
END

GO

--Run
--exec dbo.GetElectionDates

CREATE PROCEDURE [dbo].[GetElectionDates]  
AS   
    SET NOCOUNT ON;  
    SELECT Distinct convert(varchar, cast(DateInserted as date), 107) as ElectionDate
    FROM SuperVoters.dbo.CastVote  
    ORDER BY ElectionDate
GO

