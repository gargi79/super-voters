/*
INSERT INTO SuperVoters.[dbo].[CastVote] ([ElectionId], [VoterId], [CandidateId], [DateInserted]) VALUES (3, 1, 13, N'03/05/22 01:59:59.999')
INSERT INTO SuperVoters.[dbo].[CastVote] ([ElectionId], [VoterId], [CandidateId], [DateInserted]) VALUES (3, 1, 14, N'03/05/22 01:59:59.999')
INSERT INTO SuperVoters.[dbo].[CastVote] ([ElectionId], [VoterId], [CandidateId], [DateInserted]) VALUES (3, 1, 15, N'03/05/22 01:59:59.999')
INSERT INTO SuperVoters.[dbo].[CastVote] ([ElectionId], [VoterId], [CandidateId], [DateInserted]) VALUES (3, 1, 16, N'03/05/22 01:59:59.999')
INSERT INTO SuperVoters.[dbo].[CastVote] ([ElectionId], [VoterId], [CandidateId], [DateInserted]) VALUES (3, 1, 17, N'03/05/22 01:59:59.999')
INSERT INTO SuperVoters.[dbo].[CastVote] ([ElectionId], [VoterId], [CandidateId], [DateInserted]) VALUES (3, 1, 9, N'03/05/22 01:59:59.999')
INSERT INTO SuperVoters.[dbo].[CastVote] ([ElectionId], [VoterId], [CandidateId], [DateInserted]) VALUES (3, 1, 10, N'03/05/22 01:59:59.999')
INSERT INTO SuperVoters.[dbo].[CastVote] ([ElectionId], [VoterId], [CandidateId], [DateInserted]) VALUES (3, 1, 11, N'03/05/22 01:59:59.999')
INSERT INTO SuperVoters.[dbo].[CastVote] ([ElectionId], [VoterId], [CandidateId], [DateInserted]) VALUES (3, 1, 12, N'03/05/22 01:59:59.999')


select * from castvote
update castvote set candidateId = 9 where candidateId = 4

select * from candidate
select * from election
select * from voter


*/