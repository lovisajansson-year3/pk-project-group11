using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g11assignment1
{
    public class GymMember
    {
        private String name;
        private String memberId;
        private String emailAddress;
        private String phoneNumber;
        private String address;
        public GymMember() { }
        public GymMember(String memberId)
        {
            this.memberId = memberId;
        }
        public GymMember(string name, string email, string phone, string address)
        {
            this.name = name;
            this.emailAddress = email;
            this.phoneNumber = phone;
            this.address = address;
        }
        public GymMember(String memberId,string name, string email, string phone, string address)
        {
            this.memberId = memberId;
            this.name = name;
            this.emailAddress = email;
            this.phoneNumber = phone;
            this.address = address;
        }
        public String MemberID
        {
            get { return memberId; }
            set { memberId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Email
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }


        public void AddMember() { }
        public void ReadMember() { }
        public void UpdateMember() { }
        public void DeleteMember() { }

        
    }
}
