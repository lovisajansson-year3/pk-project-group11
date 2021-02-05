using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace g11assignment1
{
    public class DataAccessLayer
    {
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        string conString = "user id=lovisa;password=lovisa;server=localhost;Trusted_Connection=yes;database=T4Lab;connection timeout=30";


        public Object AddObjectToDatabase(Object inObject)
        {
            SqlCommand myCommand = new SqlCommand();
            if (inObject is GymMember member)
            {
                member = inObject as GymMember;
                Console.WriteLine(member.MemberID);
                string commandText = "insert into GymMember values(";
                commandText += $"'{member.MemberID}','{member.Address}','{member.Email}','{member.Name}','{member.PhoneNumber}');";

                using (sqlCon = new SqlConnection(conString))
                {
                    try
                    {
                        sqlCon.Open();
                        myCommand.CommandText = commandText;
                        myCommand.Connection = sqlCon;
                        int nbrOfRows = myCommand.ExecuteNonQuery();
                        if (nbrOfRows == 0)
                        {
                            Console.WriteLine("gymmember couldn't be added");
                            return null;
                        }
                        else
                        {
                            Console.WriteLine("gymmember added");
                            return member;
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.ToString());
                        Console.WriteLine("gymMember already exists with this id");
                        return null;

                    }
                }
            }
            if (inObject is TrainingSession session)
            {
                session = inObject as TrainingSession;
                string commandText = $"select * from TrainingSession where instructor ='{session.Instructor}' and startTime ='{session.StartTime}'";
                string commandText2 = "insert into TrainingSession (sessionId, instructor,startTime,roomNumber,length,type) values(";
                commandText2 += $"'{session.SessionId}','{session.Instructor}','{session.StartTime}','{session.RoomNumber}','{session.Length}','{session.Type}');";
                
                using (sqlCon = new SqlConnection(conString))
                {
                    try
                    {
                        sqlCon.Open();
                        SqlDataReader dr;
                        myCommand.CommandText = commandText;
                        myCommand.Connection = sqlCon;
                        dr = myCommand.ExecuteReader();
                        if (!dr.HasRows)
                        {
                            dr.Close();
                            myCommand.CommandText = commandText2;
                        
                            int nbrOfRows = myCommand.ExecuteNonQuery();
                            Console.WriteLine("session added");
                            return session;
                        }
                        else
                        {
                            Console.WriteLine("already exists");
                            return null;
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("couldnt add session");
                        return null;

                    }

                }

            }
            else { return null; }
        }
        public Boolean AddBookingToDatabase(String bookingId,TrainingSession session, GymMember member)
            {
            SqlCommand myCommand = new SqlCommand();
            long memberId = Convert.ToInt64(member.MemberID);
            long sessionId = Convert.ToInt64(session.SessionId);
            string commandText1 = $"select * from Booking b where b.tId='{sessionId}' and b.mId='{memberId}';";
           string commandText2 = $"insert into Booking (bookingId,tId,mId) values('{bookingId}','{session.SessionId}','{member.MemberID}');";
            using (sqlCon = new SqlConnection(conString))
            {
                try
                {
                    sqlCon.Open();
                    SqlDataReader dr;
                    myCommand.CommandText = commandText1;
                    myCommand.Connection = sqlCon;
                    dr = myCommand.ExecuteReader();
                    if (!dr.HasRows)
                    {
                        dr.Close();
                        myCommand.CommandText = commandText2;
                        myCommand.Connection = sqlCon;
                        int nbrOfRows = myCommand.ExecuteNonQuery();
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (SqlException ex)
                {
                    return false;
                }
            }
        }
        public Boolean DeleteBookingToDatabase(TrainingSession session, GymMember member)
        {
            SqlCommand myCommand = new SqlCommand();
            session.StartTime.AddMilliseconds(000);
            long memberId = Convert.ToInt64(member.MemberID);
            long sessionId = Convert.ToInt64(session.SessionId);
            string commandText = $"delete from Booking where mId= '{memberId}' and tId = '{sessionId}';";
            using (sqlCon = new SqlConnection(conString))
            {
                try
                {
                    sqlCon.Open();
                    myCommand.CommandText = commandText;
                    myCommand.Connection = sqlCon;
                    int nbrOfRows = myCommand.ExecuteNonQuery();
                    if (nbrOfRows == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    return false;
                }
            }
        }
        public Boolean DeleteObjectFromDatabase(Object inObject)
        {
            SqlCommand myCommand = new SqlCommand();
            if (inObject is GymMember member)
            {
                member = inObject as GymMember;
                long memberId = Convert.ToInt64(member.MemberID);
                string commandText = $"delete GymMember where memberId = '{memberId}';";
                using (sqlCon = new SqlConnection(conString))
                {
                    try
                    {
                        sqlCon.Open();
                        myCommand.CommandText = commandText;
                        myCommand.Connection = sqlCon;
                        int nbrOfRows = myCommand.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        return false;
                    }
                }
            }
            if (inObject is TrainingSession session)
            {
                session = inObject as TrainingSession;
                session.StartTime = session.StartTime.AddMilliseconds(000);
                long sessionId = Convert.ToInt64(session.SessionId);
                string commandText = $"delete TrainingSession where sessionId = '{sessionId}';";
                using (sqlCon = new SqlConnection(conString))
                {
                    try
                    {
                        sqlCon.Open();
                        myCommand.CommandText = commandText;
                        myCommand.Connection = sqlCon;
                        int nbrOfRows = myCommand.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        return false;
                    }
                }
            }
            return false;
        } 
        public Object UpdateObject(Object newObject)
        {
            SqlCommand myCommand = new SqlCommand();
            if(newObject is GymMember member)
            {
                member = newObject as GymMember;
                long memberId = Convert.ToInt64(member.MemberID);
                Console.WriteLine(member.Name);
                string commandText = $"update GymMember set name='{member.Name}',email='{member.Email}',phoneNumber='{member.PhoneNumber}',address='{member.Address}' where memberId='{memberId}';";
                using (sqlCon = new SqlConnection(conString)){
                    try
                    {
                        sqlCon.Open();
                        myCommand.CommandText = commandText;
                        myCommand.Connection = sqlCon;
                        int nbrOfRows = myCommand.ExecuteNonQuery();
                        return member;
                    }
                    catch (SqlException sqe) { Console.WriteLine(sqe.ToString());return null; }

                    catch (Exception e) { Console.WriteLine(e.ToString());return null; }
                }
            }
            if (newObject is TrainingSession session)
            {
                session = newObject as TrainingSession;
                long sessionId = Convert.ToInt64(session.SessionId);
                string commandText = $"select * from TrainingSession where instructor ='{session.Instructor}' and startTime ='{session.StartTime}'";

                string commandText2 = $"update TrainingSession set roomNumber='{session.RoomNumber}',length='{session.Length}', type='{session.Type}',instructor='{session.Instructor}',startTime='{session.StartTime}' where sessionId='{sessionId}';";
                using (sqlCon = new SqlConnection(conString))
                {
                    try
                    {
                        sqlCon.Open();
                        SqlDataReader dr;
                        myCommand.CommandText = commandText;
                        myCommand.Connection = sqlCon;
                        dr= myCommand.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Close();
                            return null;
                        }
                        else
                        {
                            dr.Close();
                            myCommand.CommandText = commandText2;
                            myCommand.ExecuteNonQuery();
                            Console.WriteLine("trainingsession updated");
                            return session;
                        }
                    }
                    catch (SqlException sqe) { Console.WriteLine(sqe.ToString());return null; }

                    catch (Exception e) { Console.WriteLine(e.ToString());return null; }
                }
            }
            else { return null; }
        }
        public DataTable DisplayTable(string tableName)
        {
            string sqlstr = "select * from ";
            sqlstr += tableName;

            
            SqlDataReader dR = null;
            DataTable dt = new DataTable();
            using (sqlCon = new SqlConnection(conString))
            {
                try
                {
                    sqlCon.Open();
                    sqlCmd = new SqlCommand(sqlstr, sqlCon);
                    using (dR = sqlCmd.ExecuteReader())

                        dt.Load(dR);
                        
                }
                catch (SqlException e) { Console.WriteLine(e.ToString()); }
            }
            return dt;

        }
        public int CreateMemberId ()
        {
            SqlCommand myCommand = new SqlCommand();
            String commandText = "select top 1 memberId from GymMember order by memberId desc";
            int result = 0;

            using(sqlCon = new SqlConnection(conString))
            {
                try {
                    sqlCon.Open();
                    myCommand.CommandText = commandText;
                    myCommand.Connection = sqlCon;

                   Object o = myCommand.ExecuteScalar();
                   result = Convert.ToInt32(o);
                    } catch (SqlException e) { 
                    Console.WriteLine(e.ToString());
                }
                ++result;
                
            return result;
        }

            }
        public int CreateTrainingSessionId()
        {
            SqlCommand myCommand = new SqlCommand();
            String commandText = "select top 1 sessionId from TrainingSession order by sessionId desc";
            int result = 0;

            using (sqlCon = new SqlConnection(conString))
            {
                try
                {
                    sqlCon.Open();
                    myCommand.CommandText = commandText;
                    myCommand.Connection = sqlCon;

                    Object o = myCommand.ExecuteScalar();
                    result = Convert.ToInt32(o);
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
                ++result;

                return result;
            }
        }
        public int CreateBookingId()
        {
            SqlCommand myCommand = new SqlCommand();
            String commandText = "select top 1 bookingId from Booking order by bookingId desc";
            int result = 0;

            using (sqlCon = new SqlConnection(conString))
            {
                try
                {
                    sqlCon.Open();
                    myCommand.CommandText = commandText;
                    myCommand.Connection = sqlCon;

                    Object o = myCommand.ExecuteScalar();
                    result = Convert.ToInt32(o);
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
                ++result;

                return result;
            }
        }
        
            public DataTable DisplayBookingForObject(Object obj)
        {
            string sqlString;
            SqlDataReader dR = null;
            DataTable dt = new DataTable();
            SqlCommand myCommand;
            if(obj is TrainingSession session)
            {
                session = obj as TrainingSession;
                sqlString = $"select mId, b.tId, s.type from Booking b join TrainingSession s on b.tId = '{session.SessionId}';";
                using (sqlCon = new SqlConnection(conString))
                {
                    try
                    {
                        sqlCon.Open();
                        myCommand = new SqlCommand(sqlString, sqlCon);
                        using (dR = myCommand.ExecuteReader())
                        {
                            dt.Load(dR);
                        }
                    }
                    catch (SqlException e) { Console.WriteLine(e.ToString()); }
                }
            }
            if (obj is GymMember member)
            {
                member = obj as GymMember;
                long mId = Convert.ToInt64(member.MemberID);
                sqlString = $"select mId, b.tId, s.type from Booking b join TrainingSession s on b.tId = s.sessionId where mId = '{mId}' ;";

                using (sqlCon = new SqlConnection(conString))
                {
                    try
                    {
                        sqlCon.Open();
                        myCommand = new SqlCommand(sqlString, sqlCon);
                        using (dR = myCommand.ExecuteReader())
                        {
                            dt.Load(dR);
                        }
                    }
                    catch (SqlException e) { Console.WriteLine(e.ToString()); }
                }
               
                    
      
            }
            return dt;
        }
        public DataTable FillComboBox(string column, string table)
        {
            DataTable dt = new DataTable();
            SqlDataReader dR = null;
            string sqlStr = $"select {column} from {table}";
            SqlCommand myCommand;

            using (sqlCon = new SqlConnection(conString))

            {
                try
                {
                    sqlCon.Open();
                    myCommand = new SqlCommand(sqlStr, sqlCon);
                    using (dR = myCommand.ExecuteReader())
                    {
                        dt.Load(dR);
                    }
                }
                catch (SqlException e) { Console.WriteLine(e.ToString()); }


            }
            return dt;
        }
            
        }

    }



