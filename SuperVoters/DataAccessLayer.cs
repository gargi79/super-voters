
using SuperVoters.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SuperVoters
{
    public static class DataAccessLayer
    {
        private static string _connectionString;
        

        //Singleton for connection string
        private static string GetConnectionString()
        {
            if (string.IsNullOrWhiteSpace(_connectionString))
            {
                var settings = new Properties.Settings();
                _connectionString = settings.SuperVotersConnectionString;
            }

            return _connectionString;

        }

        public static List<string> GetElectionDates(ref string retValue)
        {
            List<string> dates = new List<string>();

            try
            {
                SqlDataReader rdr = null;

                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    SqlCommand cmd = new SqlCommand("dbo.GetElectionDates", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    rdr = cmd.ExecuteReader();

                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            dates.Add(rdr["ElectionDate"].ToString());
                        }

                        retValue = "Successfully retrieved election dates";
                    }
                    else
                        retValue = "No data returned for election dates";
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(retValue))
                    retValue = "Error occurred while getting election dates: " + ex.Message;

                LogFactory.WriteLog(LogFactory.Level.Error,retValue);
            }

            return dates;
        }

        public static int GetVoterIdByUserName(string userName, ref string retValue)
        {
            int voterId = -1;

            try
            {
                SqlDataReader rdr = null;

                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    SqlCommand cmd = new SqlCommand("dbo.GetVoterIdByUserName", connection);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    rdr = cmd.ExecuteReader();

                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            voterId = Convert.ToInt32(rdr["VoterId"]);
                        }

                        retValue = "Successfully retrieved voterId";
                    }
                    else
                        retValue = "No data returned for voterId dates";
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(retValue))
                    retValue = "Error occurred while getting voterId: " + ex.Message;

                LogFactory.WriteLog(LogFactory.Level.Error,retValue);
            }

            return voterId;
        }


        public static List<ElectionData> GetElectionNames(ref string retValue)
        {
            List<ElectionData> names = new List<ElectionData>();

            try
            {
                SqlDataReader rdr = null;

                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    SqlCommand cmd = new SqlCommand("dbo.GetElectionNames", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    rdr = cmd.ExecuteReader();
                    int i = 0;

                    ElectionData name = new ElectionData();
                    name.ElectionName = "Select an Election";
                    name.ElectionId = "-1";
                    names.Add(name);

                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            name = new ElectionData();
                            name.ElectionId = rdr["ElecId"].ToString();
                            name.ElectionName = rdr["ElectionData"].ToString();
                            names.Add(name);
                        }

                        retValue = "Successfully retrieved election names";
                    }
                    else
                        retValue = "No data returned for election names";
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(retValue))
                    retValue = "Error occurred while getting election names: " + ex.Message;

                LogFactory.WriteLog(LogFactory.Level.Error,retValue);
            }

            return names;
        }

        public static Tuple<string, int>[] GetVoteResults(string electionDate, string electionId, ref string retValue)
        {
            Tuple<string, int>[] voteResults = new Tuple<string, int>[20];

            try
            {
                SqlDataReader rdr = null;

                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    string query = "SELECT * INTO #temp FROM ";
                    query += "(SELECT cv.CandidateId, COUNT(*) as TotalVotes ";
                    query += "FROM SuperVoters.dbo.CastVote cv ";
                    query += "JOIN SuperVoters.dbo.Candidate c on cv.CandidateId = c.CandidateId ";

                    if (electionId != "-1")
                    {
                        query += "JOIN SuperVoters.dbo.Election e on cv.ElectionId = e.ElecId ";
                        query += "AND e.ElecId = " + electionId + " ";
                    }

                    if (!string.IsNullOrWhiteSpace(electionDate))
                    {
                        query += "AND CAST(cv.DateInserted as date) = CAST('" + electionDate + "' as date) ";
                    }

                    query += " Group By cv.CandidateId) as abc ";

                    query += " SELECT c.Name, t.TotalVotes from #Temp t ";
                    query += " JOIN dbo.Candidate c on c.CandidateId = t.CandidateId ";
                    query += " ORDER BY t.TotalVotes DESC";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.CommandType = CommandType.Text;

                    connection.Open();
                    rdr = cmd.ExecuteReader();
                    int i = 0;

                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            voteResults[i] = new Tuple<string, int>(rdr["Name"].ToString(), Convert.ToInt32(rdr["TotalVotes"]));
                            i++;
                        }

                        retValue = "Successfully retrieved Vote Results";
                    }
                    else
                        retValue = "No data returned for Vote Results";
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(retValue))
                    retValue = "Error occurred while getting Vote Results: " + ex.Message;

                LogFactory.WriteLog(LogFactory.Level.Error,retValue);
            }

            return voteResults;
        }

        public static string GetVoteResultsQuery(string electionDate, string electionId)
        {
            string query = "SELECT * INTO #temp FROM ";
            query += "(SELECT cv.CandidateId, COUNT(*) as TotalVotes ";
            query += "FROM SuperVoters.dbo.CastVote cv ";
            query += "JOIN SuperVoters.dbo.Candidate c on cv.CandidateId = c.CandidateId ";

            if (electionId != "-1")
            {
                query += "JOIN SuperVoters.dbo.Election e on cv.ElectionId = e.ElecId ";
                query += "AND e.ElecId = " + electionId + " ";
            }

            if (!string.IsNullOrWhiteSpace(electionDate))
            {
                query += "AND CAST(cv.DateInserted as date) = CAST('" + electionDate + "' as date) ";
            }

            query += " Group By cv.CandidateId) as abc ";

            query += " SELECT c.Name, t.TotalVotes from #Temp t ";
            query += " JOIN dbo.Candidate c on c.CandidateId = t.CandidateId ";
            query += " ORDER BY t.TotalVotes DESC";

            return query;
        }

        public static string SaveRegistration(string role, string firstName, string middleName, string lastName, string dateOfBirth, string email, string address, string party)
        {
            string retValue = "";

            try
            {
                object sqlParty = party == "" ? DBNull.Value : (object)party;
                string dateInserted = DateTime.Now.ToShortDateString();

                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    string query = "Insert into dbo.Register (Role, FirstName, MiddleName, LastName, DateOfBirth, Email, Address, Party, DateInserted )";
                    query += " VALUES (@Role, @FirstName, @MiddleName, @LastName, @DateOfBirth, @Email, @Address, @Party,  @DateInserted)";

                    //Note the using will close the connection when done.
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Role", role);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@MiddleName", middleName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Party", sqlParty);
                        command.Parameters.AddWithValue("@DateInserted", dateInserted);

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                            retValue = "Error inserting data into Register table!";
                        else
                            retValue = "Successful";
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(retValue))
                    retValue = "Error occurred while Saving to DB: " + ex.Message;

                LogFactory.WriteLog(LogFactory.Level.Error,retValue);
            }

            return retValue;
        }

        public static string SaveVoter(string userName,string firstName, string middleName, string lastName, string dateOfBirth, string email, string address, string phone, ref int voterId)
        {
            string retValue = "";

            try
            {
                string dateInserted = DateTime.Now.ToShortDateString();

                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    string query = "Insert into dbo.Voter (UserName, FirstName, MiddleName, LastName, DateOfBirth, Email, Address, Phone, DateInserted )";
                    query += " VALUES (@UserName, @FirstName, @MiddleName, @LastName, @DateOfBirth, @Email, @Address, @Phone,  @DateInserted)";

                    //Note the using will close the connection when done.
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", userName);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@MiddleName", middleName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@DateInserted", dateInserted);

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                            retValue = "Error inserting data into Voter table!";
                        else
                            retValue = "Successful";

                        //Get voterId
                        string idQuery = "Select @@IDENTITY";
                        command.CommandText = idQuery;
                        voterId = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(retValue))
                    retValue = "Error occurred while Saving to DB: " + ex.Message;

                LogFactory.WriteLog(LogFactory.Level.Error, retValue);
            }

            return retValue;
        }

        public static string SaveLogin(string userName, string password)
        {
            string retValue = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnectionString()))
                {
                    string query = "Insert into dbo.Login (UserName, Password)";
                    query += " VALUES (@UserName, @Password)";

                    //Note the using will close the connection when done.
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", userName);
                        command.Parameters.AddWithValue("@Password", password);

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                            retValue = "Error inserting data into Register table!";
                        else
                            retValue = "Successful";
                    }
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(retValue))
                    retValue = "Error occurred while Saving to DB: " + ex.Message;
                LogFactory.WriteLog(LogFactory.Level.Error,retValue);
            }

            return retValue;
        }
    }
}

