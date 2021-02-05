using System;

namespace g11assignment1
{
    partial class Programkonstruktion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Assignment1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TrainingSession = new System.Windows.Forms.TabControl();
            this.BookTrainingPage = new System.Windows.Forms.TabPage();
            this.BookingMessageTextBox = new System.Windows.Forms.RichTextBox();
            this.BookTrainingGridView = new System.Windows.Forms.DataGridView();
            this.BookGymMemberComboBox = new System.Windows.Forms.ComboBox();
            this.BookTrainingSessionCombobox = new System.Windows.Forms.ComboBox();
            this.BookTrainingBooking = new System.Windows.Forms.Button();
            this.DeleteBookTraining = new System.Windows.Forms.Button();
            this.SelectTrainingSession = new System.Windows.Forms.Label();
            this.SelectGymMember = new System.Windows.Forms.Label();
            this.BookTrainingLabel = new System.Windows.Forms.Label();
            this.GymMemberPage = new System.Windows.Forms.TabPage();
            this.reqFieldsLabel = new System.Windows.Forms.Label();
            this.GymMemberGridView = new System.Windows.Forms.DataGridView();
            this.MemberResponseTextBox = new System.Windows.Forms.RichTextBox();
            this.MemberAdress = new System.Windows.Forms.Label();
            this.MemberPhoneNumber = new System.Windows.Forms.Label();
            this.MemberEmail = new System.Windows.Forms.Label();
            this.MemeberName = new System.Windows.Forms.Label();
            this.DeleteMemberButton = new System.Windows.Forms.Button();
            this.UpdateMemberButton = new System.Windows.Forms.Button();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.MemberIDLabel = new System.Windows.Forms.Label();
            this.GymMemberDetails = new System.Windows.Forms.Label();
            this.MemberIDCombobox = new System.Windows.Forms.ComboBox();
            this.MemberAddressTextBox = new System.Windows.Forms.TextBox();
            this.MemberPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.MemberEmailTextBox = new System.Windows.Forms.TextBox();
            this.MemberNameTextBox = new System.Windows.Forms.TextBox();
            this.TrainingSessionPage = new System.Windows.Forms.TabPage();
            this.SessionDetailsLabel = new System.Windows.Forms.Label();
            this.RequiredFieldsLabel = new System.Windows.Forms.Label();
            this.SessionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SessionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SessionRoomNbrComboBox = new System.Windows.Forms.ComboBox();
            this.TrainingSessionComboBox = new System.Windows.Forms.ComboBox();
            this.SessionResponseTextBox = new System.Windows.Forms.RichTextBox();
            this.SessionRoomNbrLabel = new System.Windows.Forms.Label();
            this.SessionStartTimeLabel = new System.Windows.Forms.Label();
            this.SessionTypeLabel = new System.Windows.Forms.Label();
            this.SessionInstructorLabel = new System.Windows.Forms.Label();
            this.TrainingSessionGridView = new System.Windows.Forms.DataGridView();
            this.SessionInstructorComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteTrainingSessionButton = new System.Windows.Forms.Button();
            this.UpdateTrainingSessionButton = new System.Windows.Forms.Button();
            this.CreateTrainingSessionButton = new System.Windows.Forms.Button();
            this.Assignment2Page = new System.Windows.Forms.TabPage();
            this.assignment2DisplayRowsGridView = new System.Windows.Forms.DataGridView();
            this.assignment2GridView = new System.Windows.Forms.DataGridView();
            this.assignment2ComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.trainingSessionLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Assignment1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TrainingSession.SuspendLayout();
            this.BookTrainingPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookTrainingGridView)).BeginInit();
            this.GymMemberPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GymMemberGridView)).BeginInit();
            this.TrainingSessionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrainingSessionGridView)).BeginInit();
            this.Assignment2Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DisplayRowsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Assignment1
            // 
            this.Assignment1.Controls.Add(this.tabPage1);
            this.Assignment1.Controls.Add(this.tabPage2);
            this.Assignment1.Controls.Add(this.tabPage3);
            this.Assignment1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assignment1.Location = new System.Drawing.Point(-2, 0);
            this.Assignment1.Name = "Assignment1";
            this.Assignment1.SelectedIndex = 0;
            this.Assignment1.Size = new System.Drawing.Size(802, 450);
            this.Assignment1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TrainingSession);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Programkonstruktion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TrainingSession
            // 
            this.TrainingSession.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.TrainingSession.Controls.Add(this.BookTrainingPage);
            this.TrainingSession.Controls.Add(this.GymMemberPage);
            this.TrainingSession.Controls.Add(this.TrainingSessionPage);
            this.TrainingSession.Controls.Add(this.Assignment2Page);
            this.TrainingSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainingSession.Location = new System.Drawing.Point(0, 0);
            this.TrainingSession.Name = "TrainingSession";
            this.TrainingSession.SelectedIndex = 0;
            this.TrainingSession.Size = new System.Drawing.Size(798, 428);
            this.TrainingSession.TabIndex = 0;
            // 
            // BookTrainingPage
            // 
            this.BookTrainingPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BookTrainingPage.Controls.Add(this.BookingMessageTextBox);
            this.BookTrainingPage.Controls.Add(this.BookTrainingGridView);
            this.BookTrainingPage.Controls.Add(this.BookGymMemberComboBox);
            this.BookTrainingPage.Controls.Add(this.BookTrainingSessionCombobox);
            this.BookTrainingPage.Controls.Add(this.BookTrainingBooking);
            this.BookTrainingPage.Controls.Add(this.DeleteBookTraining);
            this.BookTrainingPage.Controls.Add(this.SelectTrainingSession);
            this.BookTrainingPage.Controls.Add(this.SelectGymMember);
            this.BookTrainingPage.Controls.Add(this.BookTrainingLabel);
            this.BookTrainingPage.Location = new System.Drawing.Point(4, 25);
            this.BookTrainingPage.Name = "BookTrainingPage";
            this.BookTrainingPage.Padding = new System.Windows.Forms.Padding(3);
            this.BookTrainingPage.Size = new System.Drawing.Size(790, 399);
            this.BookTrainingPage.TabIndex = 0;
            this.BookTrainingPage.Text = " Book Training";
            // 
            // BookingMessageTextBox
            // 
            this.BookingMessageTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BookingMessageTextBox.Location = new System.Drawing.Point(290, 322);
            this.BookingMessageTextBox.Name = "BookingMessageTextBox";
            this.BookingMessageTextBox.Size = new System.Drawing.Size(443, 68);
            this.BookingMessageTextBox.TabIndex = 8;
            this.BookingMessageTextBox.Text = "";
            // 
            // BookTrainingGridView
            // 
            this.BookTrainingGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.BookTrainingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookTrainingGridView.Location = new System.Drawing.Point(290, 103);
            this.BookTrainingGridView.Name = "BookTrainingGridView";
            this.BookTrainingGridView.Size = new System.Drawing.Size(443, 150);
            this.BookTrainingGridView.TabIndex = 9;
            // 
            // BookGymMemberComboBox
            // 
            this.BookGymMemberComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookGymMemberComboBox.FormattingEnabled = true;
            this.BookGymMemberComboBox.Location = new System.Drawing.Point(37, 135);
            this.BookGymMemberComboBox.Name = "BookGymMemberComboBox";
            this.BookGymMemberComboBox.Size = new System.Drawing.Size(121, 24);
            this.BookGymMemberComboBox.TabIndex = 0;
            this.BookGymMemberComboBox.SelectedIndexChanged += new System.EventHandler(this.GymMemberCombobox_SelectedIndexChanged);
            // 
            // BookTrainingSessionCombobox
            // 
            this.BookTrainingSessionCombobox.AccessibleName = "Book";
            this.BookTrainingSessionCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTrainingSessionCombobox.FormattingEnabled = true;
            this.BookTrainingSessionCombobox.Location = new System.Drawing.Point(37, 215);
            this.BookTrainingSessionCombobox.Name = "BookTrainingSessionCombobox";
            this.BookTrainingSessionCombobox.Size = new System.Drawing.Size(222, 24);
            this.BookTrainingSessionCombobox.TabIndex = 1;
            this.BookTrainingSessionCombobox.SelectedIndexChanged += new System.EventHandler(this.BookTrainingSessionCombobox_SelectedIndexChanged);
            // 
            // BookTrainingBooking
            // 
            this.BookTrainingBooking.Location = new System.Drawing.Point(37, 293);
            this.BookTrainingBooking.Name = "BookTrainingBooking";
            this.BookTrainingBooking.Size = new System.Drawing.Size(158, 23);
            this.BookTrainingBooking.TabIndex = 7;
            this.BookTrainingBooking.Text = "Book Training Session";
            this.BookTrainingBooking.UseVisualStyleBackColor = true;
            this.BookTrainingBooking.Click += new System.EventHandler(this.CreateBooking_Click);
            // 
            // DeleteBookTraining
            // 
            this.DeleteBookTraining.Location = new System.Drawing.Point(37, 331);
            this.DeleteBookTraining.Name = "DeleteBookTraining";
            this.DeleteBookTraining.Size = new System.Drawing.Size(175, 23);
            this.DeleteBookTraining.TabIndex = 6;
            this.DeleteBookTraining.Text = "Delete Traning Session";
            this.DeleteBookTraining.UseVisualStyleBackColor = true;
            this.DeleteBookTraining.Click += new System.EventHandler(this.DeleteBooking_Click);
            // 
            // SelectTrainingSession
            // 
            this.SelectTrainingSession.AccessibleName = "SelectTrainingSession";
            this.SelectTrainingSession.AutoSize = true;
            this.SelectTrainingSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTrainingSession.Location = new System.Drawing.Point(34, 195);
            this.SelectTrainingSession.Name = "SelectTrainingSession";
            this.SelectTrainingSession.Size = new System.Drawing.Size(157, 17);
            this.SelectTrainingSession.TabIndex = 5;
            this.SelectTrainingSession.Text = "Select Training Session";
            // 
            // SelectGymMember
            // 
            this.SelectGymMember.AutoSize = true;
            this.SelectGymMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectGymMember.Location = new System.Drawing.Point(34, 115);
            this.SelectGymMember.Name = "SelectGymMember";
            this.SelectGymMember.Size = new System.Drawing.Size(135, 17);
            this.SelectGymMember.TabIndex = 4;
            this.SelectGymMember.Text = "Select Gym Member";
            // 
            // BookTrainingLabel
            // 
            this.BookTrainingLabel.AutoSize = true;
            this.BookTrainingLabel.Font = new System.Drawing.Font("Cambria Math", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTrainingLabel.Location = new System.Drawing.Point(267, -22);
            this.BookTrainingLabel.Name = "BookTrainingLabel";
            this.BookTrainingLabel.Size = new System.Drawing.Size(211, 134);
            this.BookTrainingLabel.TabIndex = 2;
            this.BookTrainingLabel.Text = "Book training";
            // 
            // GymMemberPage
            // 
            this.GymMemberPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GymMemberPage.Controls.Add(this.reqFieldsLabel);
            this.GymMemberPage.Controls.Add(this.GymMemberGridView);
            this.GymMemberPage.Controls.Add(this.MemberResponseTextBox);
            this.GymMemberPage.Controls.Add(this.MemberAdress);
            this.GymMemberPage.Controls.Add(this.MemberPhoneNumber);
            this.GymMemberPage.Controls.Add(this.MemberEmail);
            this.GymMemberPage.Controls.Add(this.MemeberName);
            this.GymMemberPage.Controls.Add(this.DeleteMemberButton);
            this.GymMemberPage.Controls.Add(this.UpdateMemberButton);
            this.GymMemberPage.Controls.Add(this.CreateMemberButton);
            this.GymMemberPage.Controls.Add(this.MemberIDLabel);
            this.GymMemberPage.Controls.Add(this.GymMemberDetails);
            this.GymMemberPage.Controls.Add(this.MemberIDCombobox);
            this.GymMemberPage.Controls.Add(this.MemberAddressTextBox);
            this.GymMemberPage.Controls.Add(this.MemberPhoneNumberTextBox);
            this.GymMemberPage.Controls.Add(this.MemberEmailTextBox);
            this.GymMemberPage.Controls.Add(this.MemberNameTextBox);
            this.GymMemberPage.Location = new System.Drawing.Point(4, 25);
            this.GymMemberPage.Name = "GymMemberPage";
            this.GymMemberPage.Padding = new System.Windows.Forms.Padding(3);
            this.GymMemberPage.Size = new System.Drawing.Size(790, 399);
            this.GymMemberPage.TabIndex = 1;
            this.GymMemberPage.Text = "Gym Member";
            // 
            // reqFieldsLabel
            // 
            this.reqFieldsLabel.AutoSize = true;
            this.reqFieldsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqFieldsLabel.Location = new System.Drawing.Point(36, 57);
            this.reqFieldsLabel.Name = "reqFieldsLabel";
            this.reqFieldsLabel.Size = new System.Drawing.Size(119, 17);
            this.reqFieldsLabel.TabIndex = 19;
            this.reqFieldsLabel.Text = "* = required fields";
            // 
            // GymMemberGridView
            // 
            this.GymMemberGridView.AllowUserToOrderColumns = true;
            this.GymMemberGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.GymMemberGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GymMemberGridView.Location = new System.Drawing.Point(234, 87);
            this.GymMemberGridView.Name = "GymMemberGridView";
            this.GymMemberGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GymMemberGridView.Size = new System.Drawing.Size(545, 154);
            this.GymMemberGridView.TabIndex = 18;
            // 
            // MemberResponseTextBox
            // 
            this.MemberResponseTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.MemberResponseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberResponseTextBox.Location = new System.Drawing.Point(128, 344);
            this.MemberResponseTextBox.Name = "MemberResponseTextBox";
            this.MemberResponseTextBox.Size = new System.Drawing.Size(525, 50);
            this.MemberResponseTextBox.TabIndex = 17;
            this.MemberResponseTextBox.Text = "";
            // 
            // MemberAdress
            // 
            this.MemberAdress.AutoSize = true;
            this.MemberAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberAdress.Location = new System.Drawing.Point(57, 222);
            this.MemberAdress.Name = "MemberAdress";
            this.MemberAdress.Size = new System.Drawing.Size(73, 17);
            this.MemberAdress.TabIndex = 16;
            this.MemberAdress.Text = "* Address:";
            // 
            // MemberPhoneNumber
            // 
            this.MemberPhoneNumber.AutoSize = true;
            this.MemberPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberPhoneNumber.Location = new System.Drawing.Point(6, 194);
            this.MemberPhoneNumber.Name = "MemberPhoneNumber";
            this.MemberPhoneNumber.Size = new System.Drawing.Size(116, 17);
            this.MemberPhoneNumber.TabIndex = 15;
            this.MemberPhoneNumber.Text = "* Phone Number:";
            // 
            // MemberEmail
            // 
            this.MemberEmail.AutoSize = true;
            this.MemberEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberEmail.Location = new System.Drawing.Point(66, 163);
            this.MemberEmail.Name = "MemberEmail";
            this.MemberEmail.Size = new System.Drawing.Size(55, 17);
            this.MemberEmail.TabIndex = 14;
            this.MemberEmail.Text = "* Email:";
            // 
            // MemeberName
            // 
            this.MemeberName.AutoSize = true;
            this.MemeberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemeberName.Location = new System.Drawing.Point(63, 128);
            this.MemeberName.Name = "MemeberName";
            this.MemeberName.Size = new System.Drawing.Size(58, 17);
            this.MemeberName.TabIndex = 12;
            this.MemeberName.Text = "* Name:";
            // 
            // DeleteMemberButton
            // 
            this.DeleteMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteMemberButton.Location = new System.Drawing.Point(513, 303);
            this.DeleteMemberButton.Name = "DeleteMemberButton";
            this.DeleteMemberButton.Size = new System.Drawing.Size(140, 23);
            this.DeleteMemberButton.TabIndex = 11;
            this.DeleteMemberButton.Text = "Delete Member Button";
            this.DeleteMemberButton.UseVisualStyleBackColor = true;
            this.DeleteMemberButton.Click += new System.EventHandler(this.DeleteMemberButton_Click);
            // 
            // UpdateMemberButton
            // 
            this.UpdateMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateMemberButton.Location = new System.Drawing.Point(320, 303);
            this.UpdateMemberButton.Name = "UpdateMemberButton";
            this.UpdateMemberButton.Size = new System.Drawing.Size(140, 23);
            this.UpdateMemberButton.TabIndex = 10;
            this.UpdateMemberButton.Text = "Update Member Button";
            this.UpdateMemberButton.UseVisualStyleBackColor = true;
            this.UpdateMemberButton.Click += new System.EventHandler(this.UpdateMemberButton_Click);
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CreateMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMemberButton.Location = new System.Drawing.Point(128, 303);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(140, 23);
            this.CreateMemberButton.TabIndex = 9;
            this.CreateMemberButton.Text = "Create New";
            this.CreateMemberButton.UseVisualStyleBackColor = false;
            this.CreateMemberButton.Click += new System.EventHandler(this.CreateMemberButton_Click);
            // 
            // MemberIDLabel
            // 
            this.MemberIDLabel.AutoSize = true;
            this.MemberIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDLabel.Location = new System.Drawing.Point(36, 94);
            this.MemberIDLabel.Name = "MemberIDLabel";
            this.MemberIDLabel.Size = new System.Drawing.Size(85, 17);
            this.MemberIDLabel.TabIndex = 7;
            this.MemberIDLabel.Text = "* MemberID:";
            // 
            // GymMemberDetails
            // 
            this.GymMemberDetails.AutoSize = true;
            this.GymMemberDetails.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GymMemberDetails.Location = new System.Drawing.Point(269, 22);
            this.GymMemberDetails.Name = "GymMemberDetails";
            this.GymMemberDetails.Size = new System.Drawing.Size(242, 28);
            this.GymMemberDetails.TabIndex = 6;
            this.GymMemberDetails.Text = "Gym Member Details";
            this.GymMemberDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // MemberIDCombobox
            // 
            this.MemberIDCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDCombobox.FormattingEnabled = true;
            this.MemberIDCombobox.Location = new System.Drawing.Point(127, 91);
            this.MemberIDCombobox.Name = "MemberIDCombobox";
            this.MemberIDCombobox.Size = new System.Drawing.Size(100, 24);
            this.MemberIDCombobox.TabIndex = 5;
            this.MemberIDCombobox.SelectedIndexChanged += new System.EventHandler(this.MemberIDCombobox_SelectedIndexChanged);
            // 
            // MemberAddressTextBox
            // 
            this.MemberAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberAddressTextBox.Location = new System.Drawing.Point(127, 219);
            this.MemberAddressTextBox.Name = "MemberAddressTextBox";
            this.MemberAddressTextBox.Size = new System.Drawing.Size(100, 22);
            this.MemberAddressTextBox.TabIndex = 4;
            // 
            // MemberPhoneNumberTextBox
            // 
            this.MemberPhoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberPhoneNumberTextBox.Location = new System.Drawing.Point(128, 189);
            this.MemberPhoneNumberTextBox.Name = "MemberPhoneNumberTextBox";
            this.MemberPhoneNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.MemberPhoneNumberTextBox.TabIndex = 3;
            // 
            // MemberEmailTextBox
            // 
            this.MemberEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberEmailTextBox.Location = new System.Drawing.Point(127, 158);
            this.MemberEmailTextBox.Name = "MemberEmailTextBox";
            this.MemberEmailTextBox.Size = new System.Drawing.Size(100, 22);
            this.MemberEmailTextBox.TabIndex = 2;
            // 
            // MemberNameTextBox
            // 
            this.MemberNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNameTextBox.Location = new System.Drawing.Point(127, 125);
            this.MemberNameTextBox.Name = "MemberNameTextBox";
            this.MemberNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.MemberNameTextBox.TabIndex = 0;
            // 
            // TrainingSessionPage
            // 
            this.TrainingSessionPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TrainingSessionPage.Controls.Add(this.SessionDetailsLabel);
            this.TrainingSessionPage.Controls.Add(this.RequiredFieldsLabel);
            this.TrainingSessionPage.Controls.Add(this.SessionDateTimePicker);
            this.TrainingSessionPage.Controls.Add(this.SessionTypeComboBox);
            this.TrainingSessionPage.Controls.Add(this.SessionRoomNbrComboBox);
            this.TrainingSessionPage.Controls.Add(this.TrainingSessionComboBox);
            this.TrainingSessionPage.Controls.Add(this.SessionResponseTextBox);
            this.TrainingSessionPage.Controls.Add(this.SessionRoomNbrLabel);
            this.TrainingSessionPage.Controls.Add(this.SessionStartTimeLabel);
            this.TrainingSessionPage.Controls.Add(this.SessionTypeLabel);
            this.TrainingSessionPage.Controls.Add(this.SessionInstructorLabel);
            this.TrainingSessionPage.Controls.Add(this.TrainingSessionGridView);
            this.TrainingSessionPage.Controls.Add(this.SessionInstructorComboBox);
            this.TrainingSessionPage.Controls.Add(this.DeleteTrainingSessionButton);
            this.TrainingSessionPage.Controls.Add(this.UpdateTrainingSessionButton);
            this.TrainingSessionPage.Controls.Add(this.CreateTrainingSessionButton);
            this.TrainingSessionPage.Location = new System.Drawing.Point(4, 25);
            this.TrainingSessionPage.Name = "TrainingSessionPage";
            this.TrainingSessionPage.Padding = new System.Windows.Forms.Padding(3);
            this.TrainingSessionPage.Size = new System.Drawing.Size(790, 399);
            this.TrainingSessionPage.TabIndex = 2;
            this.TrainingSessionPage.Text = "Traning Session";
            // 
            // SessionDetailsLabel
            // 
            this.SessionDetailsLabel.AutoSize = true;
            this.SessionDetailsLabel.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionDetailsLabel.Location = new System.Drawing.Point(457, 14);
            this.SessionDetailsLabel.Name = "SessionDetailsLabel";
            this.SessionDetailsLabel.Size = new System.Drawing.Size(304, 42);
            this.SessionDetailsLabel.TabIndex = 25;
            this.SessionDetailsLabel.Text = "Training Session Details";
            // 
            // RequiredFieldsLabel
            // 
            this.RequiredFieldsLabel.AutoSize = true;
            this.RequiredFieldsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequiredFieldsLabel.Location = new System.Drawing.Point(26, 74);
            this.RequiredFieldsLabel.Name = "RequiredFieldsLabel";
            this.RequiredFieldsLabel.Size = new System.Drawing.Size(119, 17);
            this.RequiredFieldsLabel.TabIndex = 19;
            this.RequiredFieldsLabel.Text = "* = required fields";
            // 
            // SessionDateTimePicker
            // 
            this.SessionDateTimePicker.CustomFormat = "yyyy-MM-dd HH";
            this.SessionDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SessionDateTimePicker.Location = new System.Drawing.Point(29, 213);
            this.SessionDateTimePicker.Name = "SessionDateTimePicker";
            this.SessionDateTimePicker.Size = new System.Drawing.Size(155, 22);
            this.SessionDateTimePicker.TabIndex = 24;
            // 
            // SessionTypeComboBox
            // 
            this.SessionTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionTypeComboBox.FormattingEnabled = true;
            this.SessionTypeComboBox.Location = new System.Drawing.Point(29, 166);
            this.SessionTypeComboBox.Name = "SessionTypeComboBox";
            this.SessionTypeComboBox.Size = new System.Drawing.Size(155, 24);
            this.SessionTypeComboBox.TabIndex = 22;
            // 
            // SessionRoomNbrComboBox
            // 
            this.SessionRoomNbrComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionRoomNbrComboBox.FormattingEnabled = true;
            this.SessionRoomNbrComboBox.Location = new System.Drawing.Point(29, 258);
            this.SessionRoomNbrComboBox.Name = "SessionRoomNbrComboBox";
            this.SessionRoomNbrComboBox.Size = new System.Drawing.Size(155, 24);
            this.SessionRoomNbrComboBox.TabIndex = 21;
            // 
            // TrainingSessionComboBox
            // 
            this.TrainingSessionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainingSessionComboBox.FormattingEnabled = true;
            this.TrainingSessionComboBox.Location = new System.Drawing.Point(25, 47);
            this.TrainingSessionComboBox.Name = "TrainingSessionComboBox";
            this.TrainingSessionComboBox.Size = new System.Drawing.Size(238, 24);
            this.TrainingSessionComboBox.TabIndex = 20;
            this.TrainingSessionComboBox.Text = "Select Training Session";
            this.TrainingSessionComboBox.SelectedIndexChanged += new System.EventHandler(this.TrainingSessionComboBox_SelectedIndexChanged);
            // 
            // SessionResponseTextBox
            // 
            this.SessionResponseTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SessionResponseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionResponseTextBox.Location = new System.Drawing.Point(211, 329);
            this.SessionResponseTextBox.Name = "SessionResponseTextBox";
            this.SessionResponseTextBox.Size = new System.Drawing.Size(550, 50);
            this.SessionResponseTextBox.TabIndex = 18;
            this.SessionResponseTextBox.Text = "";
            // 
            // SessionRoomNbrLabel
            // 
            this.SessionRoomNbrLabel.AutoSize = true;
            this.SessionRoomNbrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionRoomNbrLabel.Location = new System.Drawing.Point(29, 238);
            this.SessionRoomNbrLabel.Name = "SessionRoomNbrLabel";
            this.SessionRoomNbrLabel.Size = new System.Drawing.Size(112, 17);
            this.SessionRoomNbrLabel.TabIndex = 15;
            this.SessionRoomNbrLabel.Text = "* Room Number:";
            // 
            // SessionStartTimeLabel
            // 
            this.SessionStartTimeLabel.AutoSize = true;
            this.SessionStartTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionStartTimeLabel.Location = new System.Drawing.Point(26, 193);
            this.SessionStartTimeLabel.Name = "SessionStartTimeLabel";
            this.SessionStartTimeLabel.Size = new System.Drawing.Size(86, 17);
            this.SessionStartTimeLabel.TabIndex = 13;
            this.SessionStartTimeLabel.Text = "* Start Time:";
            // 
            // SessionTypeLabel
            // 
            this.SessionTypeLabel.AutoSize = true;
            this.SessionTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionTypeLabel.Location = new System.Drawing.Point(29, 146);
            this.SessionTypeLabel.Name = "SessionTypeLabel";
            this.SessionTypeLabel.Size = new System.Drawing.Size(107, 17);
            this.SessionTypeLabel.TabIndex = 12;
            this.SessionTypeLabel.Text = "* Session Type:";
            // 
            // SessionInstructorLabel
            // 
            this.SessionInstructorLabel.AutoSize = true;
            this.SessionInstructorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionInstructorLabel.Location = new System.Drawing.Point(29, 99);
            this.SessionInstructorLabel.Name = "SessionInstructorLabel";
            this.SessionInstructorLabel.Size = new System.Drawing.Size(80, 17);
            this.SessionInstructorLabel.TabIndex = 11;
            this.SessionInstructorLabel.Text = "* Instructor:";
            // 
            // TrainingSessionGridView
            // 
            this.TrainingSessionGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.TrainingSessionGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TrainingSessionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrainingSessionGridView.Location = new System.Drawing.Point(211, 119);
            this.TrainingSessionGridView.Name = "TrainingSessionGridView";
            this.TrainingSessionGridView.Size = new System.Drawing.Size(550, 152);
            this.TrainingSessionGridView.TabIndex = 10;
            // 
            // SessionInstructorComboBox
            // 
            this.SessionInstructorComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.SessionInstructorComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.SessionInstructorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionInstructorComboBox.FormattingEnabled = true;
            this.SessionInstructorComboBox.Location = new System.Drawing.Point(29, 119);
            this.SessionInstructorComboBox.Name = "SessionInstructorComboBox";
            this.SessionInstructorComboBox.Size = new System.Drawing.Size(155, 24);
            this.SessionInstructorComboBox.TabIndex = 9;
            this.SessionInstructorComboBox.SelectedIndexChanged += new System.EventHandler(this.SessionInstructorComboBox_SelectedIndexChanged);
            // 
            // DeleteTrainingSessionButton
            // 
            this.DeleteTrainingSessionButton.Location = new System.Drawing.Point(399, 281);
            this.DeleteTrainingSessionButton.Name = "DeleteTrainingSessionButton";
            this.DeleteTrainingSessionButton.Size = new System.Drawing.Size(169, 33);
            this.DeleteTrainingSessionButton.TabIndex = 4;
            this.DeleteTrainingSessionButton.Text = "Delete Training Session";
            this.DeleteTrainingSessionButton.UseVisualStyleBackColor = true;
            this.DeleteTrainingSessionButton.Click += new System.EventHandler(this.DeleteTrainingSessionButton_Click);
            // 
            // UpdateTrainingSessionButton
            // 
            this.UpdateTrainingSessionButton.Location = new System.Drawing.Point(586, 281);
            this.UpdateTrainingSessionButton.Name = "UpdateTrainingSessionButton";
            this.UpdateTrainingSessionButton.Size = new System.Drawing.Size(175, 33);
            this.UpdateTrainingSessionButton.TabIndex = 3;
            this.UpdateTrainingSessionButton.Text = "Update Training Session";
            this.UpdateTrainingSessionButton.UseVisualStyleBackColor = true;
            this.UpdateTrainingSessionButton.Click += new System.EventHandler(this.UpdateTrainingSessionButton_Click_1);
            // 
            // CreateTrainingSessionButton
            // 
            this.CreateTrainingSessionButton.Location = new System.Drawing.Point(211, 281);
            this.CreateTrainingSessionButton.Name = "CreateTrainingSessionButton";
            this.CreateTrainingSessionButton.Size = new System.Drawing.Size(169, 33);
            this.CreateTrainingSessionButton.TabIndex = 2;
            this.CreateTrainingSessionButton.Text = "Create Training Session";
            this.CreateTrainingSessionButton.UseVisualStyleBackColor = true;
            this.CreateTrainingSessionButton.Click += new System.EventHandler(this.CreateTrainingSessionButton_Click);
            // 
            // Assignment2Page
            // 
            this.Assignment2Page.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Assignment2Page.Controls.Add(this.assignment2DisplayRowsGridView);
            this.Assignment2Page.Controls.Add(this.assignment2GridView);
            this.Assignment2Page.Controls.Add(this.assignment2ComboBox);
            this.Assignment2Page.Location = new System.Drawing.Point(4, 25);
            this.Assignment2Page.Name = "Assignment2Page";
            this.Assignment2Page.Padding = new System.Windows.Forms.Padding(3);
            this.Assignment2Page.Size = new System.Drawing.Size(790, 399);
            this.Assignment2Page.TabIndex = 3;
            this.Assignment2Page.Text = "Assignment 2";
            this.Assignment2Page.Click += new System.EventHandler(this.Assignment2Page_Click);
            // 
            // assignment2DisplayRowsGridView
            // 
            this.assignment2DisplayRowsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignment2DisplayRowsGridView.Location = new System.Drawing.Point(562, 100);
            this.assignment2DisplayRowsGridView.Name = "assignment2DisplayRowsGridView";
            this.assignment2DisplayRowsGridView.Size = new System.Drawing.Size(180, 150);
            this.assignment2DisplayRowsGridView.TabIndex = 2;
            // 
            // assignment2GridView
            // 
            this.assignment2GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignment2GridView.Location = new System.Drawing.Point(356, 100);
            this.assignment2GridView.Name = "assignment2GridView";
            this.assignment2GridView.Size = new System.Drawing.Size(181, 150);
            this.assignment2GridView.TabIndex = 1;
            // 
            // assignment2ComboBox
            // 
            this.assignment2ComboBox.FormattingEnabled = true;
            this.assignment2ComboBox.Location = new System.Drawing.Point(86, 100);
            this.assignment2ComboBox.Name = "assignment2ComboBox";
            this.assignment2ComboBox.Size = new System.Drawing.Size(161, 24);
            this.assignment2ComboBox.TabIndex = 0;
            this.assignment2ComboBox.SelectedIndexChanged += new System.EventHandler(this.assignment2ComboBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Webservice";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(794, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ERP";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // trainingSessionLabel
            // 
            this.trainingSessionLabel.AutoSize = true;
            this.trainingSessionLabel.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingSessionLabel.Location = new System.Drawing.Point(288, 19);
            this.trainingSessionLabel.Name = "trainingSessionLabel";
            this.trainingSessionLabel.Size = new System.Drawing.Size(194, 28);
            this.trainingSessionLabel.TabIndex = 0;
            this.trainingSessionLabel.Text = "Training Session";
            // 
            // Programkonstruktion
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.Assignment1);
            this.Name = "Programkonstruktion";
            this.Load += new System.EventHandler(this.Programkonstruktion_Load);
            this.Assignment1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.TrainingSession.ResumeLayout(false);
            this.BookTrainingPage.ResumeLayout(false);
            this.BookTrainingPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookTrainingGridView)).EndInit();
            this.GymMemberPage.ResumeLayout(false);
            this.GymMemberPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GymMemberGridView)).EndInit();
            this.TrainingSessionPage.ResumeLayout(false);
            this.TrainingSessionPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrainingSessionGridView)).EndInit();
            this.Assignment2Page.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assignment2DisplayRowsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment2GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Assignment1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;

        private System.Windows.Forms.TabControl TrainingSession;
        private System.Windows.Forms.TabPage BookTrainingPage;
        private System.Windows.Forms.TabPage GymMemberPage;
        private System.Windows.Forms.TabPage TrainingSessionPage;
        private System.Windows.Forms.ComboBox BookTrainingSessionCombobox;
        private System.Windows.Forms.Label BookTrainingLabel;
        private System.Windows.Forms.Label SelectTrainingSession;
        private System.Windows.Forms.Label SelectGymMember;
        private System.Windows.Forms.Button BookTrainingBooking;
        private System.Windows.Forms.Button DeleteBookTraining;
        private System.Windows.Forms.Label MemeberName;
        private System.Windows.Forms.Button DeleteMemberButton;
        private System.Windows.Forms.Button UpdateMemberButton;
        private System.Windows.Forms.Button CreateMemberButton;
        private System.Windows.Forms.Label MemberIDLabel;
        private System.Windows.Forms.Label GymMemberDetails;
        private System.Windows.Forms.ComboBox MemberIDCombobox;
        private System.Windows.Forms.TextBox MemberAddressTextBox;
        private System.Windows.Forms.TextBox MemberPhoneNumberTextBox;
        private System.Windows.Forms.TextBox MemberEmailTextBox;
        private System.Windows.Forms.TextBox MemberNameTextBox;
        private System.Windows.Forms.Label MemberAdress;
        private System.Windows.Forms.Label MemberPhoneNumber;
        private System.Windows.Forms.Label MemberEmail;
        private System.Windows.Forms.RichTextBox MemberResponseTextBox;
        private System.Windows.Forms.Label trainingSessionLabel;
        
        private System.Windows.Forms.ComboBox SessionInstructorComboBox;
        private System.Windows.Forms.Button DeleteTrainingSessionButton;
        private System.Windows.Forms.Button UpdateTrainingSessionButton;
        private System.Windows.Forms.Button CreateTrainingSessionButton;
        private System.Windows.Forms.DataGridView GymMemberGridView;

        private System.Windows.Forms.Label SessionInstructorLabel;
        private System.Windows.Forms.DataGridView TrainingSessionGridView;
        private System.Windows.Forms.Label SessionRoomNbrLabel;
        private System.Windows.Forms.Label SessionStartTimeLabel;
        private System.Windows.Forms.Label SessionTypeLabel;
        private System.Windows.Forms.RichTextBox SessionResponseTextBox;
        private System.Windows.Forms.Label RequiredFieldsLabel;
        private System.Windows.Forms.DataGridView BookTrainingGridView;
        private System.Windows.Forms.ComboBox BookGymMemberComboBox;

    


        private System.Windows.Forms.ComboBox TrainingSessionComboBox;
        private System.Windows.Forms.ComboBox SessionTypeComboBox;
        private System.Windows.Forms.ComboBox SessionRoomNbrComboBox;
        private System.Windows.Forms.DateTimePicker SessionDateTimePicker;
        private System.Windows.Forms.Label SessionDetailsLabel;
        private System.Windows.Forms.Label reqFieldsLabel;
        private System.Windows.Forms.RichTextBox BookingMessageTextBox;
        private System.Windows.Forms.TabPage Assignment2Page;
        private System.Windows.Forms.DataGridView assignment2GridView;
        private System.Windows.Forms.ComboBox assignment2ComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView assignment2DisplayRowsGridView;
    }
}

