
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace SuperVoters.Services
{
    public class VoteService
    {
        /// <summary>
        /// This method inserts a vote record into the database.
        /// </summary>
        /// <param name="electionId">Election primary key.</param>
        /// <param name="candidateId">Candidate primary key.</param>
        /// <param name="voterId">Voter primary key.</param>
        /// <returns>0 if insertion was successful or -1 if failed.</returns>

        

        public static int CastNewVote(int electionId, int candidateId, int voterId)
        {
            var conn = new SqlConnection(new Properties.Settings().SuperVotersConnectionStringModelTest);
            int returnValue = 0;

            try
            {
                const string query = "INSERT INTO CastVote (ElectionId, VoterId, CandidateId, DateInserted)" +
                                     " VALUES(@ElectionId, @VoterId, @CandidateId, @DateInserted)";

                using (var command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ElectionId", electionId);
                    command.Parameters.AddWithValue("@VoterId", voterId);

                    command.Parameters.AddWithValue("@CandidateId", candidateId);
                    command.Parameters.AddWithValue("@DateInserted", DateTime.Now.ToString(CultureInfo.InvariantCulture));


                    conn.Open();
                    int rows = command.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        conn.Close();
                        returnValue = 0;
                    }
                    else
                    {
                        conn.Close();
                        throw new Exception("Could not insert vote into CastVote table.");
                    }
                }
            }
            catch (Exception ex)
            {
                LogFactory.WriteLog(LogFactory.Level.Error,"An error occurred: " + ex.Message);
                Utilities.SendEmailToAdmin("Hello Admin, we have a problem with SuperVoters: Casting votes is failing.");
                MessageBox.Show("Sorry, there is an error with voting.  Please contact the administrator");
                returnValue = -1;
            }
            finally
            {
                conn.Close();
            }

            return returnValue;
        }

        public static bool CheckIsCapableOfVoting(int electionId, int voterId, VotingCapability votingCapability = VotingCapability.SingleVotePerElection)
        {
            switch (votingCapability)
            {
                case VotingCapability.SingleVotePerElection:
                    var conn = new SqlConnection(new Properties.Settings().SuperVotersConnectionStringModelTest);
                    var query = $"SELECT * FROM CastVote WHERE VoterId='{voterId}' AND ElectionId = '{electionId}'";

                    using (var command = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        SqlDataReader rows = command.ExecuteReader();
                        if (rows.HasRows)
                        {
                            conn.Close();
                            return false;
                        }
                        conn.Close();
                        return true;
                    }

                default:
                    throw new ArgumentOutOfRangeException(nameof(votingCapability), votingCapability, null);
            }
        }
        public static int DeleteVote(int electionId, int candidateId, int voterId)
        {
            var conn = new SqlConnection(new Properties.Settings().SuperVotersConnectionStringModelTest);
            try
            {
                const string query = "DELETE FROM CastVote " +
                                     "WHERE " +
                                     "ElectionId = @ElectionId " +
                                     "AND VoterId = @VoterId " +
                                     "AND CandidateId = @CandidateId";

                using (var command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ElectionId", electionId);
                    command.Parameters.AddWithValue("@VoterId", voterId);

                    command.Parameters.AddWithValue("@CandidateId", candidateId);
                    conn.Open();
                    int rows = command.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        conn.Close();
                        return 0;
                    }
                    else
                    {
                        conn.Close();
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                LogFactory.WriteLog(LogFactory.Level.Error,"An error occurred: " + ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return 0;
        }
    }


    public enum VotingCapability
    {
        SingleVotePerElection = 1
    }
}
