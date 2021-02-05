using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;


namespace g11assignment1
{
    public partial class Programkonstruktion : Form
    {
        string conString = "user id=lovisa;password=lovisa;server=localhost;Trusted_Connection=yes;database=T4Lab;connection timeout=30";
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        Controller controller = new Controller();
        DataAccessLayer Dal = new DataAccessLayer();
        public Programkonstruktion()
        {
            InitializeComponent();
           
            }
        private void Programkonstruktion_Load(object sender, EventArgs e)
        {
            SessionInstructorComboBox.Items.Add("Lovisa");
            SessionInstructorComboBox.Items.Add("Lena");
            SessionInstructorComboBox.Items.Add("Tove");
            SessionInstructorComboBox.Items.Add("Lisa");

            SessionRoomNbrComboBox.Items.Add("room 1");
            SessionRoomNbrComboBox.Items.Add("crossfit room");
            SessionRoomNbrComboBox.Items.Add("spinning room");

            SessionTypeComboBox.Items.Add("Spinning");
            SessionTypeComboBox.Items.Add("Zumba");
            SessionTypeComboBox.Items.Add("Crossfit");
            this.Populate();
            this.populatePk2();
            
        }
        private void Populate()
        {
            DataTable dtb = controller.DisplayTable("GymMember");
            GymMemberGridView.DataSource = dtb;
            MemberIDCombobox.DataSource = dtb;
            MemberIDCombobox.DisplayMember = dtb.Columns[0].ToString();
            MemberIDCombobox.SelectedItem = null;
            MemberIDCombobox.Text = "--new Member--";

            DataTable dt = controller.DisplayTable("TrainingSession");
            BookTrainingSessionCombobox.DataSource = dt;
            BookTrainingSessionCombobox.DisplayMember = dt.Columns[0].ToString();
            BookGymMemberComboBox.DataSource = dtb;
            BookGymMemberComboBox.DisplayMember = dtb.Columns["memberId"].ColumnName;
            BookGymMemberComboBox.ValueMember = dtb.Columns["memberId"].ToString();

            TrainingSessionComboBox.DataSource = dt;
            TrainingSessionGridView.DataSource = dt;
            TrainingSessionComboBox.DisplayMember = dt.Columns[0].ToString();
            TrainingSessionComboBox.SelectedItem = null;
            TrainingSessionComboBox.Text = "--new Trainingsession--";

            
            TrainingSessionGridView.Columns["startTime"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss.fff";


            dt = controller.FillComboBox("mId, t.type, b.tId", "Booking b join TrainingSession t on b.tId = t.sessionId;");
            BookTrainingGridView.DataSource =dt;
            //BookTrainingGridView.Columns["startTime"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss.fff";

            BookingMessageTextBox.Text = "";




        }
        private void populatePk2()
        {

           /* DataTable dt = controller.DisplayTable();
            assignment2ComboBox.DataSource = dt;
            assignment2ComboBox.DisplayMember = dt.Columns[0].ToString();
            assignment2ComboBox.ValueMember = dt.Columns[0].ToString();
            
    */
        }
        private void MemberIDCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MemberIDCombobox.SelectedItem != null)
            {
               
            }
            
        }

        private void BookTrainingSessionCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void GymMemberCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView rowView = BookGymMemberComboBox.SelectedItem as DataRowView;
            GymMember temp = new GymMember();
            temp.MemberID = (rowView[0]) as string;
            BookTrainingGridView.DataSource = controller.DisplayBookingForObject(temp);
            //BookTrainingGridView.Columns["startTime"].DefaultCellStyle.Format = "yyyy-MM-dd hh:mm";


        }
        private void UpdateMemberButton_Click(object sender, EventArgs e)
        {

            if (MemberIDCombobox.SelectedItem != null)
            {
                DataRowView rowView = MemberIDCombobox.SelectedItem as DataRowView;
                String memberId = (rowView[0]).ToString();
                string name = MemberNameTextBox.Text;
                string phoneNumber = MemberPhoneNumberTextBox.Text;
                string address = MemberAddressTextBox.Text;
                string email = MemberEmailTextBox.Text;
                GymMember newMember = new GymMember(memberId, name, email, phoneNumber, address);
                Console.WriteLine(newMember.Address+newMember.Name+newMember.Email+newMember.PhoneNumber);
                controller.UpdateObject(newMember);
                Console.WriteLine($"member {memberId} updated!");
                this.Populate();
            }
            else
            {
                MemberResponseTextBox.Text = "select member to update";
            }

        }
        private void DeleteMemberButton_Click(object sender, EventArgs e)
        {
            if (MemberIDCombobox.SelectedItem != null)
            {
                DataRowView rowView = MemberIDCombobox.SelectedItem as DataRowView;
                GymMember newMember = new GymMember();
                newMember.MemberID = (rowView[0]).ToString();

                if (controller.DeleteObject(newMember) == true)
                {
                   MemberResponseTextBox.Text=$"member {newMember.MemberID} deleted!";
                    this.Populate();
                } else
                {
                    MemberResponseTextBox.Text = "cannot delete member that has made bookings on trainingsessions";
                }
            }
            else
            {
                MemberResponseTextBox.Text = "select member to delete";
            }


        }
        private void DeleteTrainingSessionButton_Click(object sender, EventArgs e)
        {

            DataRowView rowView = TrainingSessionComboBox.SelectedItem as DataRowView;
            TrainingSession newSession = new TrainingSession();
            if (rowView != null)
            {
                newSession.SessionId = (rowView[0].ToString());
                if (controller.DeleteObject(newSession) == true)
                {
                    SessionResponseTextBox.Text = "booking deleted";
                }
                else
                {
                    SessionResponseTextBox.Text = "cannot delete trainingsession that has bookings";

                }


                this.Populate();
            }
            else
            {
                SessionResponseTextBox.Text = "select session to delete";

            }
        }
        private void DeleteBooking_Click(object sender, EventArgs e)
        {
            DataRowView memberRow = BookGymMemberComboBox.SelectedItem as DataRowView;
            DataRowView sessionRow = BookTrainingSessionCombobox.SelectedItem as DataRowView;
            GymMember member = new GymMember();
            member.MemberID = (memberRow[0].ToString());
            TrainingSession session = new TrainingSession();
           
            session.SessionId = sessionRow[0].ToString();
            if( controller.DeleteBooking(session, member) == true)
            {
                BookingMessageTextBox.Text = $"booking for member = {member.MemberID} deleted for Trainingsession = {session.SessionId}";
                BookTrainingGridView.DataSource = controller.DisplayBookingForObject(member);

            }
            else
            {
                BookingMessageTextBox.Text = "booking doesnt exist";

            }

            
        }
        private void CreateBooking_Click(object sender, EventArgs e)
        {

            DataRowView memberRow = BookGymMemberComboBox.SelectedItem as DataRowView;
            DataRowView sessionRow = BookTrainingSessionCombobox.SelectedItem as DataRowView;
            GymMember member = new GymMember( memberRow[0].ToString());
            TrainingSession session = new TrainingSession();
            session.SessionId = sessionRow[0].ToString();
            if (controller.CreateBooking(session, member) == true)
            {
                long memberId = Convert.ToInt64(member.MemberID);
                long sessionId = Convert.ToInt64(session.SessionId);
                BookingMessageTextBox.Text = $"booking for member = {memberId} added for Trainingsession = {sessionId}";
                BookTrainingGridView.DataSource = controller.DisplayBookingForObject(member);

            }
            else
            {
                BookingMessageTextBox.Text = "booking already exists";

            }
            
                  
            
        }
        
        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            if (MemberIDCombobox.SelectedItem is null)
            {
                string memberName = MemberNameTextBox.Text;
                string memberPhoneNumber = MemberPhoneNumberTextBox.Text;
                string memberAddress = MemberAddressTextBox.Text;
                string memberEmail = MemberEmailTextBox.Text;
   		        if (memberName.Length != 0 && memberPhoneNumber.Length != 0 && memberAddress.Length != 0 && memberEmail.Length != 0)
                    {
                    int memberId = controller.CreateMemberId();
                    MemberResponseTextBox.Text = "session added";
                    controller.CreateMember(memberId.ToString(), memberName, memberPhoneNumber, memberAddress, memberEmail);
                    this.Populate();
                }else
                    {

                    MemberResponseTextBox.Text = "Please make sure all fields have been filled in.";
                    }
            } else
            {
                MemberResponseTextBox.Text = "you must select 'new member' ";
            }
	


            }
        private void UpdateTrainingSessionButton_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("hej");
            DataRowView rowView = TrainingSessionComboBox.SelectedItem as DataRowView;

            if (TrainingSessionComboBox.SelectedItem is null)
            {
                SessionResponseTextBox.Text = "pick session to update";
            }
            else
            {

                if (SessionInstructorComboBox.SelectedItem != null && SessionRoomNbrComboBox.SelectedItem != null && SessionTypeComboBox.SelectedItem != null && SessionRoomNbrComboBox.SelectedItem != null)
                {
                    TrainingSession session = new TrainingSession();
                    session.Instructor = SessionInstructorComboBox.SelectedItem.ToString();
                    session.Type = SessionTypeComboBox.SelectedItem.ToString();
                    session.StartTime = SessionDateTimePicker.Value;
                    session.Length = 1;
                    session.RoomNumber = SessionRoomNbrComboBox.SelectedItem.ToString();
                    session.SessionId = rowView[0].ToString();
                    session = controller.UpdateObject(session) as TrainingSession;
                    if (session == null)
                    {
                        SessionResponseTextBox.Text = "session already exists for this instructor at this time";
                    }
                    else
                    {
                        SessionResponseTextBox.Text = "session added";
                        this.Populate();
                    }
                }
                else
                {
                    SessionResponseTextBox.Text = "Please make sure all fields have been filled in.";
                }

            }
        


        

    }
        private void CreateTrainingSessionButton_Click(object sender, EventArgs e)
        {
            if (TrainingSessionComboBox.SelectedItem is null)
            {
                if (SessionInstructorComboBox.SelectedItem != null && SessionRoomNbrComboBox.SelectedItem != null && SessionTypeComboBox.SelectedItem != null && SessionRoomNbrComboBox.SelectedItem != null)
                {
                    String sessionInstructor = SessionInstructorComboBox.SelectedItem.ToString();
                    String sessionType = SessionTypeComboBox.SelectedItem.ToString();
                    DateTime sessionStartTime = SessionDateTimePicker.Value;
                    Console.WriteLine(sessionStartTime);
                    string date = sessionStartTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                    sessionStartTime = DateTime.ParseExact(date, "yyyy-MM-dd HH:mm:ss.fff",null);
                    int sessionLength = 1;
                    String sessionRoomNumber = SessionRoomNbrComboBox.SelectedItem.ToString();
                    int sessionId = controller.CreateTrainingSessionId();
                    TrainingSession session = controller.CreateTrainingSession(sessionId.ToString(), sessionInstructor, sessionRoomNumber, sessionType, sessionStartTime, sessionLength);
                    if (session == null)
                    {
                        SessionResponseTextBox.Text = "session already exists for this instructor at this time";
                    }
                    else
                    {
                        SessionResponseTextBox.Text = "session added";
                        this.Populate();
                    }
                }
                else
                {
                    SessionResponseTextBox.Text = "Please make sure all fields have been filled in.";
                }
            }
            else
            {
                SessionResponseTextBox.Text = "please select --new trainingsession--";
                this.Populate();
            }


            
        }

        

        private void TrainingSessionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TrainingSessionComboBox.SelectedItem != null)
            {
                DataRowView rowView = TrainingSessionComboBox.SelectedItem as DataRowView;
                SessionInstructorComboBox.SelectedItem = rowView["instructor"].ToString();
                string dateTime = rowView["startTime"].ToString();
                SessionDateTimePicker.Value = DateTime.Parse(dateTime);
                SessionRoomNbrComboBox.SelectedItem = rowView["roomNumber"] as string;
                SessionTypeComboBox.SelectedItem = rowView["type"] as string;
            }
        }
        private void SessionInstructorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void assignment2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (assignment2ComboBox.SelectedItem!=null)
            {
                DataRowView rowView1 = assignment2ComboBox.SelectedItem as DataRowView;
                string name = rowView1[0] as string;
                DataTable dt = controller.DisplayMetadata(name);
                DataTable dt2 = controller.DisplayRows(name);
                assignment2GridView.DataSource = dt;
                assignment2DisplayRowsGridView.DataSource = dt2;
            }
               
                }

 

        private void Assignment2Page_Click(object sender, EventArgs e)
        {
            this.populatePk2();
        }

        
    }



}
