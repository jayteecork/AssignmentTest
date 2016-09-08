using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace AssignmentTest.ViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }
        public int? ID { get; set; }

        public int StudentCount { get; set; }
        public int ACount ()
        {
            string stmt = "SELECT COUNT(*) FROM Student";
            int count = 0;

            using (SqlConnection thisConnection = new SqlConnection("Data Source=DATASOURCE"))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
            }
            return count;
        }


    }
}