using System.Data.SqlClient;
using System.Configuration;
using System;

namespace Homework6.Job3
{
    public static class MyDB
    {
        public static void UpdateCharacter()
        {
            var queryString =
                @"CREATE TABLE [dbo].[Story2]([id] [int] NULL,[story] [varchar](50) NULL) ON [PRIMARY]";


            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MyFirstDB"].ConnectionString;
            SqlCommand command = new SqlCommand(queryString, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();

                queryString = @"insert into Story2 ([story]) values ('Story1')";
                command.CommandText = queryString;
                command.ExecuteNonQuery();
                queryString = @"insert into Story2 ([story]) values ('Story2')";
                command.CommandText = queryString;
                command.ExecuteNonQuery();
                queryString = @"insert into Story2 ([story]) values ('Story3')";
                command.CommandText = queryString;
                command.ExecuteNonQuery();
                    // читаем из БД
                    queryString = @"select * from Story2";
                    command.CommandText = queryString;
                    SqlDataReader sqlReader = command.ExecuteReader();

                    try
                    {
                        while (sqlReader.Read())
                        {
                            Console.WriteLine(sqlReader["story"].ToString());
                        }
                    }
                    finally
                    {
                        sqlReader.Close();
                    }

            }
            finally
            {
                connection.Close();
            }



        }
    }
}
