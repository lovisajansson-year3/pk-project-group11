using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g11assignment1
{
    class Controller
    {
        public DataAccessLayer dal = new DataAccessLayer();

        //tar in värden från interface & skapar en ny member m.h.a. AddObjectToDatabase i dal
        public GymMember CreateMember(string memberId, string memberName, string memberPhoneNumber, string memberAddress, string memberEmail)
        {

            GymMember newMember = new GymMember();
            newMember.MemberID = memberId;
            newMember.Name = memberName;
            newMember.PhoneNumber = memberPhoneNumber;
            newMember.Address = memberAddress;
            newMember.Email = memberEmail;

            return dal.AddObjectToDatabase(newMember) as GymMember;
        }

        //tar in värden från interface & skapar en ny session m.h.a. AddObjectToDatabase i dal

        public TrainingSession CreateTrainingSession (string sessionId,string sessionInstructor, string sessionRoomNumber, string sessionType, 

            DateTime sessionStartTime, int sessionLength)
        {
            TrainingSession newSession = new TrainingSession();
            newSession.SessionId = sessionId;
            newSession.Instructor = sessionInstructor;
            newSession.RoomNumber = sessionRoomNumber;
            newSession.Type = sessionType;
            newSession.StartTime = sessionStartTime;
            newSession.Length = sessionLength;

            return dal.AddObjectToDatabase(newSession) as TrainingSession;

        }

        public int CreateMemberId()
        {
            int memberId = dal.CreateMemberId();
            return memberId;
        }
        public int CreateTrainingSessionId()
        {
            int sessionId = dal.CreateTrainingSessionId();
            return sessionId;
        }
        public int CreateBookingId()
        {
            int bookingId = dal.CreateBookingId();
            return bookingId;
        }

        public Boolean CreateBooking(TrainingSession session, GymMember member)
        {
            Booking booking = new Booking();
            booking.GymMember = member;
            booking.TrainingSession = session;
            booking.BookingId = CreateBookingId().ToString();
            if(dal.AddBookingToDatabase(booking.BookingId,session,member) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
                
            
            
            
        }
        public Object UpdateObject(object obj)
        {
            return dal.UpdateObject(obj) as Object;
        }

        public Boolean DeleteBooking(TrainingSession session, GymMember member)
        {
            if (dal.DeleteBookingToDatabase(session, member) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public Boolean DeleteObject(Object inObject)
        {
            if (dal.DeleteObjectFromDatabase(inObject) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public DataTable DisplayTable(Object obj)
        {
            DataTable dt = new DataTable();
            if (obj is String tableName)
            {
                tableName = obj as string;
                dt = dal.DisplayTable(tableName);

            } else if (obj is TrainingSession || obj is GymMember )
            {
                dt = dal.DisplayBookingForObject(obj);
            }
            return dt;
        }
        public DataTable FillComboBox(string column, string tableName)
        {
            DataTable dt = dal.FillComboBox(column, tableName);
            return dt;
        }
        public DataTable DisplayBookingForObject(Object obj)
        {
            DataTable dt = dal.DisplayBookingForObject(obj);
            return dt;
        }

        //////////////////////--PK2_DAL/////////////////////////////////
        PK2_DataAccessLayer dal2 = new PK2_DataAccessLayer();
        public DataTable DisplayTable()
        {
            DataTable dt = dal2.DisplayTable();
            return dt;
        }
        public DataTable DisplayMetadata(string table)
        {
            DataTable dt = dal2.DisplayMetadata(table);
            return dt;
        }
        public DataTable DisplayRows(string table)
        {
            DataTable dt = dal2.DisplayRows(table);
            return dt;
        }

        
    }
}
