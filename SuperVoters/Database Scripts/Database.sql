/****** Object:  Database [SuperVoters]    Script Date: 3/26/2022 11:38:32 AM ******/
CREATE DATABASE [SuperVoters]  (EDITION = 'Basic', SERVICE_OBJECTIVE = 'Basic', MAXSIZE = 2 GB) WITH CATALOG_COLLATION = SQL_Latin1_General_CP1_CI_AS;
GO
ALTER DATABASE [SuperVoters] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SuperVoters] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SuperVoters] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SuperVoters] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SuperVoters] SET ARITHABORT OFF 
GO
ALTER DATABASE [SuperVoters] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SuperVoters] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SuperVoters] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SuperVoters] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SuperVoters] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SuperVoters] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SuperVoters] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SuperVoters] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SuperVoters] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [SuperVoters] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SuperVoters] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [SuperVoters] SET  MULTI_USER 
GO
ALTER DATABASE [SuperVoters] SET ENCRYPTION ON
GO
ALTER DATABASE [SuperVoters] SET QUERY_STORE = ON
GO
ALTER DATABASE [SuperVoters] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 7), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 10, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO)
GO
/*** The scripts of database scoped configurations in Azure should be executed inside the target database connection. ***/
GO
-- ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 8;
GO
/****** Object:  Table [dbo].[Candidate]    Script Date: 3/26/2022 11:38:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Candidate](
	[CandidateId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Party] [varchar](100) NOT NULL,
	[Description] [varchar](500) NOT NULL,
	[Address] [varchar](500) NOT NULL,
	[Phone] [varchar](100) NOT NULL,
	[MyImage] [image] NULL,
 CONSTRAINT [PK_Candidate] PRIMARY KEY CLUSTERED 
(
	[CandidateId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CastVote]    Script Date: 3/26/2022 11:38:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CastVote](
	[ElectionId] [int] NOT NULL,
	[VoterId] [int] NOT NULL,
	[CandidateId] [int] NOT NULL,
	[DateInserted] [varchar](25) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Election]    Script Date: 3/26/2022 11:38:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Election](
	[ElecId] [int] IDENTITY(1,1) NOT NULL,
	[ElecTopic] [char](200) NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[ElecCat] [char](100) NULL,
 CONSTRAINT [PK_Election] PRIMARY KEY CLUSTERED 
(
	[ElecId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ElectionCandidate]    Script Date: 3/26/2022 11:38:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ElectionCandidate](
	[ElecId] [int] NOT NULL,
	[CanId] [int] NOT NULL,
 CONSTRAINT [PK_ElectionCandidate] PRIMARY KEY CLUSTERED 
(
	[ElecId] ASC,
	[CanId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 3/26/2022 11:38:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logs]    Script Date: 3/26/2022 11:38:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[Level] [nvarchar](10) NULL,
	[Message] [nvarchar](max) NULL,
	[StackTrace] [nvarchar](max) NULL,
	[Exception] [nvarchar](max) NULL,
	[Logger] [nvarchar](255) NULL,
	[Url] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Register]    Script Date: 3/26/2022 11:38:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Register](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Role] [varchar](10) NOT NULL,
	[FirstName] [varchar](20) NOT NULL,
	[MiddleName] [varchar](20) NULL,
	[DateOfBirth] [varchar](25) NOT NULL,
	[Email] [varchar](20) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[LastName] [varchar](20) NOT NULL,
	[Party] [varchar](20) NULL,
	[DateInserted] [varchar](20) NULL,
 CONSTRAINT [PK_NewTable-1] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table]    Script Date: 3/26/2022 11:38:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table](
	[Id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TempCandidate]    Script Date: 3/26/2022 11:38:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TempCandidate](
	[CandidateId] [int] IDENTITY(1,1) NOT NULL,
	[CandidateName] [varchar](25) NOT NULL,
 CONSTRAINT [PK_TempCandidate] PRIMARY KEY CLUSTERED 
(
	[CandidateId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Voter]    Script Date: 3/26/2022 11:38:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Voter](
	[VoterId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](25) NOT NULL,
	[Email] [varchar](25) NOT NULL,
	[Phone] [varchar](25) NOT NULL,
	[Address] [varchar](25) NOT NULL,
	[MiddleName] [varchar](25) NOT NULL,
	[LastName] [varchar](25) NOT NULL,
	[DateInserted] [varchar](25) NOT NULL,
	[DateOfBirth] [varchar](25) NOT NULL,
	[UserName] [varchar](25) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Index_1]    Script Date: 3/26/2022 11:38:33 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [Index_1] ON [dbo].[Login]
(
	[username] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ElectionCandidate]  WITH CHECK ADD  CONSTRAINT [FK_1] FOREIGN KEY([ElecId])
REFERENCES [dbo].[Election] ([ElecId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ElectionCandidate] CHECK CONSTRAINT [FK_1]
GO
ALTER TABLE [dbo].[ElectionCandidate]  WITH CHECK ADD  CONSTRAINT [FK_2] FOREIGN KEY([CanId])
REFERENCES [dbo].[Candidate] ([CandidateId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ElectionCandidate] CHECK CONSTRAINT [FK_2]
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD  CONSTRAINT [CK_1] CHECK  (((1)=(1)))
GO
ALTER TABLE [dbo].[Login] CHECK CONSTRAINT [CK_1]
GO
/****** Object:  StoredProcedure [dbo].[GetElectionDates]    Script Date: 3/26/2022 11:38:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[GetElectionNames]    Script Date: 3/26/2022 11:38:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[GetVoteResults]    Script Date: 3/26/2022 11:38:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Test
/* 
exec dbo.GetVoteResults '03/04/22'
select * from dbo.CastVote
select * from dbo.Candidate
*/

CREATE PROCEDURE [dbo].[GetVoteResults]  
    @ElectionDate varchar(20)

AS   
    SET NOCOUNT ON; 

    SELECT * INTO #temp from 
    (SELECT cv.CandidateId,  COUNT(*) as TotalVotes
    FROM SuperVoters.dbo.CastVote cv 
    JOIN SuperVoters.dbo.Candidate c on cv.CandidateId = c.CandidateId
     WHERE CAST(cv.DateInserted as date) = CAST(@ElectionDate as date)
    Group By cv.CandidateId) as abc

    SELECT c.Name, t.TotalVotes from #Temp t
    JOIN dbo.Candidate c on c.CandidateId = t.CandidateId
    ORDER BY t.TotalVotes DESC
 
GO
/****** Object:  StoredProcedure [dbo].[GetVoteResultsByDate]    Script Date: 3/26/2022 11:38:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Test
/* 
exec dbo.[GetVoteResultsByDate] '03/04/22'
select * from dbo.CastVote
select * from dbo.Candidate
*/

CREATE PROCEDURE [dbo].[GetVoteResultsByDate]  
    @ElectionDate varchar(20)

AS   
    SET NOCOUNT ON; 

    SELECT * INTO #temp from 
    (SELECT cv.CandidateId,  COUNT(*) as TotalVotes
    FROM SuperVoters.dbo.CastVote cv 
    JOIN SuperVoters.dbo.Candidate c on cv.CandidateId = c.CandidateId
     WHERE CAST(cv.DateInserted as date) = CAST(@ElectionDate as date)
    Group By cv.CandidateId) as abc

    SELECT c.Name, t.TotalVotes from #Temp t
    JOIN dbo.Candidate c on c.CandidateId = t.CandidateId
    ORDER BY t.TotalVotes DESC
 
GO
/****** Object:  StoredProcedure [dbo].[GetVoteResultsByElectionDate]    Script Date: 3/26/2022 11:38:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Test
/* 
exec dbo.[GetVoteResultsByElectionDate] '03/04/22'
select * from dbo.CastVote
select * from dbo.Candidate
*/

CREATE PROCEDURE [dbo].[GetVoteResultsByElectionDate]  
    @ElectionDate varchar(20)

AS   
    SET NOCOUNT ON; 

    SELECT * INTO #temp from 
    (SELECT cv.CandidateId,  COUNT(*) as TotalVotes
    FROM SuperVoters.dbo.CastVote cv 
    JOIN SuperVoters.dbo.Candidate c on cv.CandidateId = c.CandidateId
     and CAST(cv.DateInserted as date) = CAST(@ElectionDate as date)
    Group By cv.CandidateId) as abc

    SELECT c.Name, t.TotalVotes from #Temp t
    JOIN dbo.Candidate c on c.CandidateId = t.CandidateId
    ORDER BY t.TotalVotes DESC
 
GO
/****** Object:  StoredProcedure [dbo].[GetVoteResultsByElectionName]    Script Date: 3/26/2022 11:38:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Test
/* 
exec dbo.[GetVoteResultsByElectionName] '03/04/22'
select * from dbo.CastVote
select * from dbo.Candidate
select * from dbo.election
*/

CREATE PROCEDURE [dbo].[GetVoteResultsByElectionName]  
    @ElectionName varchar(50)

AS   
    SET NOCOUNT ON; 

    SELECT * INTO #temp from 
    (SELECT cv.CandidateId,  COUNT(*) as TotalVotes
    FROM SuperVoters.dbo.CastVote cv 
    JOIN SuperVoters.dbo.Candidate c on cv.CandidateId = c.CandidateId
    JOIN SuperVoters.dbo.Election e on cv.ElectionId = e.ElecId
     --WHERE CAST(cv.DateInserted as date) = CAST(@ElectionDate as date)
    Group By cv.CandidateId) as abc

    SELECT c.Name, t.TotalVotes from #Temp t
    JOIN dbo.Candidate c on c.CandidateId = t.CandidateId
    ORDER BY t.TotalVotes DESC
 
GO
/****** Object:  StoredProcedure [dbo].[GetVoterIdByUserName]    Script Date: 3/26/2022 11:38:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Run
--exec dbo.GetElectionDates

CREATE PROCEDURE [dbo].[GetVoterIdByUserName]
(@UserName Varchar(25))

AS   
    SET NOCOUNT ON;  
   SELECT VoterId
    FROM SuperVoters.dbo.Voter
    Where @UserName = UserName
GO
ALTER DATABASE [SuperVoters] SET  READ_WRITE 
GO
