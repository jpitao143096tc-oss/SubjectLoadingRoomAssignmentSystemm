using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Managers
{
    public class SubjectManager
    {
        private string connectionString =
    "Server=localhost\\SQLEXPRESS;Database=SLRASDB;Trusted_Connection=True;";


        public bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        
        public void AddSubject(Subject subject)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Subjects 
                                (SubjectCode, Description, Units, Program) 
                                 VALUES (@Code, @Description, @Units, @Program)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Code", subject.Code);
                cmd.Parameters.AddWithValue("@Description", subject.Title);
                cmd.Parameters.AddWithValue("@Units", subject.Units);
                cmd.Parameters.AddWithValue("@Program", subject.Program);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

       
        public void UpdateSubject(Subject subject)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Subjects SET 
                                 SubjectCode = @Code,
                                 Description = @Description,
                                 Units = @Units,
                                 Program = @Program
                                 WHERE SubjectID = @SubjectID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Code", subject.Code);
                cmd.Parameters.AddWithValue("@Description", subject.Title);
                cmd.Parameters.AddWithValue("@Units", subject.Units);
                cmd.Parameters.AddWithValue("@Program", subject.Program);
                cmd.Parameters.AddWithValue("@SubjectID", subject.SubjectID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

       
        public void DeleteSubject(int subjectID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Subjects WHERE SubjectID = @SubjectID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SubjectID", subjectID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    
        public List<Subject> GetAllSubjects()
        {
            List<Subject> list = new List<Subject>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Subjects";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Subject subject = new Subject();

                    subject.SubjectID = Convert.ToInt32(reader["SubjectID"]);
                    subject.Code = reader["SubjectCode"].ToString();
                    subject.Title = reader["Description"].ToString();
                    subject.Units = Convert.ToInt32(reader["Units"]);
                    subject.Program = reader["Program"].ToString();

                    list.Add(subject);
                }
            }

            return list;
        }
    }
}
