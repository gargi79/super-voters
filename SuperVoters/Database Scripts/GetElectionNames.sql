IF EXISTS(SELECT 1 FROM sys.procedures 
          WHERE Name = 'GetElectionNames')
BEGIN
    DROP PROCEDURE dbo.[GetElectionNames]
END

GO

--Run
--exec dbo.[GetElectionNames]
--select * from election

CREATE PROCEDURE [dbo].[GetElectionNames]  
AS    
    SET NOCOUNT ON;  
    SELECT ElecId, (TRIM(ElecTopic) + ' - ' +  TRIM(ElecCat) + ' - ' + convert(varchar, cast(StartDate as date), 107) + ' to ' + convert(varchar, cast(EndDate as date), 107)) as ElectionData
    FROM SuperVoters.dbo.Election  
    ORDER BY ElecTopic
GO

