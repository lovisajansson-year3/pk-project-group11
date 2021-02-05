using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g11assignment1
{
    public class TrainingSession
    {
        private String sessionId;
        private String instructor;
        private String roomNumber;
        private DateTime startTime;
        private int length = 1; 
        private String type;

        public TrainingSession()
        {

        }
        public TrainingSession(DateTime dateTime,string instructor,string type, string sessionId)
        {
            this.instructor = instructor;
            this.startTime = dateTime;
            this.type = type;
            this.sessionId = sessionId;
           
        }

        public TrainingSession(string instructor, DateTime dateTime, string type, string roomNumber)
        {
            this.instructor = instructor;
            this.startTime = dateTime;
            this.type = type;
            this.roomNumber = roomNumber;
        }
        

        
        public String Type
        {

            get { return type; }

            set { type = value; }
        }

        public String Instructor
        {
            get { return instructor; }
            set { instructor = value; }
        }

        public String RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        public DateTime StartTime
        { 
            get { return startTime; }
            set { startTime = value; }
        }



        public int Length { get => length; set => length = value; }
        public string SessionId { get => sessionId; set => sessionId = value; }

        public void AddTrainingSession() { }
        public void ReadTrainingSession() { }
        public void UpdateTrainingSession() { }
        public void DeleteTrainingSession() { }

        public static implicit operator TrainingSession(GymMember v)
        {
            throw new NotImplementedException();
        }
    }
}
