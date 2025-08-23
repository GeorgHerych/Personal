using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace Personal_
{
    /// <summary>
    /// Provides access to service member data stored in the Access database
    /// located on the network share.
    /// </summary>
    public class AccessServiceMemberRepository
    {
        private readonly string _connectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\as-1\personal\PersonalServer.accdb;Persist Security Info=False;";

        /// <summary>
        /// Retrieves all service members from the Access database.
        /// </summary>
        public IList<ServiceMember> GetAll()
        {
            var members = new List<ServiceMember>();

            using (var connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT Rank, FullName, MovementType FROM ServiceMembers";
                using (var command = new OleDbCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        members.Add(new ServiceMember
                        {
                            Rank = reader["Rank"].ToString(),
                            FullName = reader["FullName"].ToString(),
                            MovementType = reader["MovementType"].ToString()
                        });
                    }
                }
            }

            return members;
        }
    }
}
