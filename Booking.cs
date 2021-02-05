using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g11assignment1
{
    public class Booking
    {
        private String bookingId;
        private GymMember gymMember;
        private TrainingSession trainingSession;

        public String BookingId
        {
            get { return bookingId; }
            set { bookingId = value; }
        }
        public GymMember GymMember
        {
            get { return gymMember; }
            set { gymMember = value; }
        }

        public TrainingSession TrainingSession
        {
            get { return trainingSession; }
            set { trainingSession = value; }
        }

    }

}
