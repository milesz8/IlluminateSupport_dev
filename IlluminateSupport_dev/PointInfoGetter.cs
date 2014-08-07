using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace IlluminateSupport_dev
{
    class PointInfoGetter
    
    {
        SqlConnection connection = new SqlConnection("server=localhost;" + "trusted_connection=yes;" + "database=illuminatesupport_dev;");
        List<PointSummary> currentList = new List<PointSummary>();


        public PointInfo GetPointInfo(string pointID, string pointIDnum)
        {
            connection.Open();
            string pointCommand = @"getPoints";
            
            SqlCommand pointGetter = new SqlCommand(pointCommand, connection);
            
            pointGetter.CommandType = CommandType.StoredProcedure;
            
            pointGetter.Parameters.Add(new SqlParameter("@pointID", pointID));
            pointGetter.Parameters.Add(new SqlParameter("@pointIDnum", pointIDnum));
            PointInfo point = new PointInfo();
            using (SqlDataReader readPoint = pointGetter.ExecuteReader())
            {
                while (readPoint.Read())
                {
                    point.pointNumber = ReadCaller("PointNumber", readPoint);
                    point.type = ReadCaller("TypeName", readPoint);
                    point.updatedDate = ReadCaller("UpdateTime", readPoint);
                    point.state = ReadCaller("StateName", readPoint);
                    point.solution = ReadCaller("Solution", readPoint);
                    point.priority = ReadCaller("PriorityName", readPoint);
                    point.priorityID = ReadCaller("PointPriorityID", readPoint);
                    point.createdDate = ReadCaller("createdDate", readPoint);
                    point.pointDescription = ReadCaller("Description", readPoint);
                }
            }
            connection.Close();
            point.notes = setAllNotes(pointID);
            return point;
        }

        public List<PointSummary> GetPointList()
        {
            connection.Open();
            string pointCommand = @"getListOfPoints";
            SqlCommand pointGetter = new SqlCommand(pointCommand, connection);
            pointGetter.CommandType = CommandType.StoredProcedure;
            
            List<PointSummary> newPointSumList = new List<PointSummary>();
            using (SqlDataReader readPoint = pointGetter.ExecuteReader())
            {
                while (readPoint.Read())
                {
                    PointSummary newPoint_sum = new PointSummary();
                    
                    newPoint_sum.pointNumber = ReadCaller("PointNumber", readPoint);
                    newPoint_sum.summary = ReadCaller("Subject", readPoint);
                    newPointSumList.Add(newPoint_sum);
                }
            }
            connection.Close();
            currentList = newPointSumList;
            return newPointSumList;
        }

        public List<PointSummary> GetFilteredList(int typeSum, int stateSum, int prioritySum)
        {
            connection.Open();
            string filterCommand = @"getFilteredList";
            SqlCommand filteredGetter = new SqlCommand(filterCommand, connection);
            filteredGetter.CommandType = CommandType.StoredProcedure;

            filteredGetter.Parameters.Add(new SqlParameter("@pointType", typeSum));
            filteredGetter.Parameters.Add(new SqlParameter("@pointState", stateSum));
            filteredGetter.Parameters.Add(new SqlParameter("@pointPriority", prioritySum));

            List<PointSummary> filteredPoints = new List<PointSummary>();
            using (SqlDataReader readPoint = filteredGetter.ExecuteReader())
            {
                while (readPoint.Read())
                {
                    PointSummary newPoint_sum = new PointSummary();

                    newPoint_sum.pointNumber = ReadCaller("PointNumber", readPoint);
                    newPoint_sum.summary = ReadCaller("Subject", readPoint);

                    
                    filteredPoints.Add(newPoint_sum);
                }
            }
            connection.Close();
            currentList = filteredPoints;
            return filteredPoints;
        }



        private List<Note> setAllNotes(string pointID)
        {
            connection.Open();
            string noteCommand = @"getNotes";
            SqlCommand noteGetter = new SqlCommand(noteCommand, connection);
            noteGetter.CommandType = CommandType.StoredProcedure;
            List<Note> noteList = new List<Note>();
            noteGetter.Parameters.Add(new SqlParameter("@pointID", pointID));

                using (SqlDataReader readNote = noteGetter.ExecuteReader())
                {
                    while (readNote.Read())
                    {
                        Note newNote = new Note
                        {
                            IDNumber = ReadCaller("PointID", readNote),
                            noteDescription = ReadCaller("Description", readNote),
                            noteID = ReadCaller("PointNoteID", readNote),
                            dateNoteMade = ReadCaller("dateNoteMade", readNote),
                            notedBy = ReadCaller("FirstName", readNote) + " " + ReadCaller("LastName", readNote)
                        };
                        noteList.Add(newNote);
                    }
                }  
            connection.Close();
            return noteList;
        }

        
        
        public List<PointSummary> getCurrentList()
        {
            return currentList;
        }
        private static string ReadCaller(string column, SqlDataReader reader)
        {
            string retrn = reader[column].ToString();
            if (retrn == null)
                return "";
            return retrn;
        }
    }
}
