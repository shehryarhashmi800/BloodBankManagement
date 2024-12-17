﻿namespace Blood_Bnk_Management_System
{
    partial class Donor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donor));
            DPhone = new TextBox();
            DAgetb = new TextBox();
            DNametb = new TextBox();
            DSaveB = new Button();
            DAddressRtb = new RichTextBox();
            DBGroupCb = new ComboBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            DGenderCb = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            Donatelbl = new Label();
            label9 = new Label();
            BTransferLbl = new Label();
            patientlbl = new Label();
            vPatient = new Label();
            BStockLbl = new Label();
            Dashboardlbl = new Label();
            label1 = new Label();
            vDonorLbl = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // DPhone
            // 
            DPhone.Location = new Point(360, 223);
            DPhone.Name = "DPhone";
            DPhone.Size = new Size(152, 23);
            DPhone.TabIndex = 37;
            // 
            // DAgetb
            // 
            DAgetb.Location = new Point(523, 126);
            DAgetb.Name = "DAgetb";
            DAgetb.Size = new Size(152, 23);
            DAgetb.TabIndex = 36;
            // 
            // DNametb
            // 
            DNametb.Location = new Point(321, 128);
            DNametb.Name = "DNametb";
            DNametb.Size = new Size(152, 23);
            DNametb.TabIndex = 35;
            // 
            // DSaveB
            // 
            DSaveB.BackColor = Color.Red;
            DSaveB.FlatStyle = FlatStyle.Popup;
            DSaveB.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DSaveB.ForeColor = Color.WhiteSmoke;
            DSaveB.Location = new Point(505, 499);
            DSaveB.Name = "DSaveB";
            DSaveB.Size = new Size(203, 33);
            DSaveB.TabIndex = 34;
            DSaveB.Text = "Save";
            DSaveB.UseVisualStyleBackColor = false;
            DSaveB.Click += DSaveB_Click;
            // 
            // DAddressRtb
            // 
            DAddressRtb.Location = new Point(486, 325);
            DAddressRtb.Name = "DAddressRtb";
            DAddressRtb.Size = new Size(256, 96);
            DAddressRtb.TabIndex = 33;
            DAddressRtb.Text = "";
            // 
            // DBGroupCb
            // 
            DBGroupCb.FormattingEnabled = true;
            DBGroupCb.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            DBGroupCb.Location = new Point(653, 223);
            DBGroupCb.Name = "DBGroupCb";
            DBGroupCb.Size = new Size(121, 23);
            DBGroupCb.TabIndex = 32;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.WhiteSmoke;
            label16.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.DarkRed;
            label16.Location = new Point(360, 185);
            label16.Name = "label16";
            label16.Size = new Size(113, 23);
            label16.TabIndex = 31;
            label16.Text = "Phone Number";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.WhiteSmoke;
            label15.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DarkRed;
            label15.Location = new Point(653, 185);
            label15.Name = "label15";
            label15.Size = new Size(99, 23);
            label15.TabIndex = 30;
            label15.Text = "Blood Group";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.WhiteSmoke;
            label14.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.DarkRed;
            label14.Location = new Point(486, 285);
            label14.Name = "label14";
            label14.Size = new Size(70, 23);
            label14.TabIndex = 29;
            label14.Text = "Address";
            // 
            // DGenderCb
            // 
            DGenderCb.FormattingEnabled = true;
            DGenderCb.Items.AddRange(new object[] { "Male", "Female" });
            DGenderCb.Location = new Point(743, 126);
            DGenderCb.Name = "DGenderCb";
            DGenderCb.Size = new Size(121, 23);
            DGenderCb.TabIndex = 28;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.WhiteSmoke;
            label13.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DarkRed;
            label13.Location = new Point(733, 96);
            label13.Name = "label13";
            label13.Size = new Size(62, 23);
            label13.TabIndex = 27;
            label13.Text = "Gender";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.WhiteSmoke;
            label12.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DarkRed;
            label12.Location = new Point(523, 96);
            label12.Name = "label12";
            label12.Size = new Size(38, 23);
            label12.TabIndex = 26;
            label12.Text = "Age";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.WhiteSmoke;
            label11.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DarkRed;
            label11.Location = new Point(321, 97);
            label11.Name = "label11";
            label11.Size = new Size(50, 23);
            label11.TabIndex = 25;
            label11.Text = "Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkRed;
            label10.Location = new Point(596, 55);
            label10.Name = "label10";
            label10.Size = new Size(71, 30);
            label10.TabIndex = 24;
            label10.Text = "Donor";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Aqua;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(223, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(815, 47);
            panel2.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(240, 9);
            label2.Name = "label2";
            label2.Size = new Size(327, 29);
            label2.TabIndex = 3;
            label2.Text = "Blood Bank Management System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(pictureBox9);
            panel1.Controls.Add(pictureBox10);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(Donatelbl);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(BTransferLbl);
            panel1.Controls.Add(patientlbl);
            panel1.Controls.Add(vPatient);
            panel1.Controls.Add(BStockLbl);
            panel1.Controls.Add(Dashboardlbl);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(vDonorLbl);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 551);
            panel1.TabIndex = 38;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(12, 503);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(41, 29);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 26;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(12, 403);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(41, 29);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 25;
            pictureBox10.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(12, 205);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(41, 29);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 24;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(12, 253);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(41, 29);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 23;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(11, 301);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 29);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 22;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 352);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 29);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 161);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 62);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 110);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // Donatelbl
            // 
            Donatelbl.AutoSize = true;
            Donatelbl.BackColor = Color.Red;
            Donatelbl.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Donatelbl.ForeColor = Color.White;
            Donatelbl.Location = new Point(63, 62);
            Donatelbl.Name = "Donatelbl";
            Donatelbl.Size = new Size(82, 29);
            Donatelbl.TabIndex = 17;
            Donatelbl.Text = "Donate";
            Donatelbl.Click += Donatelbl_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Red;
            label9.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(64, 503);
            label9.Name = "label9";
            label9.Size = new Size(85, 29);
            label9.TabIndex = 5;
            label9.Text = "Log out";
            // 
            // BTransferLbl
            // 
            BTransferLbl.AutoSize = true;
            BTransferLbl.BackColor = Color.Red;
            BTransferLbl.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTransferLbl.ForeColor = Color.White;
            BTransferLbl.Location = new Point(63, 352);
            BTransferLbl.Name = "BTransferLbl";
            BTransferLbl.Size = new Size(161, 29);
            BTransferLbl.TabIndex = 14;
            BTransferLbl.Text = "Blood Transfer";
            BTransferLbl.Click += BTransferLbl_Click;
            // 
            // patientlbl
            // 
            patientlbl.AutoSize = true;
            patientlbl.BackColor = Color.Red;
            patientlbl.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientlbl.ForeColor = Color.White;
            patientlbl.Location = new Point(64, 205);
            patientlbl.Name = "patientlbl";
            patientlbl.Size = new Size(83, 29);
            patientlbl.TabIndex = 13;
            patientlbl.Text = "Patient";
            patientlbl.Click += patientlbl_Click;
            // 
            // vPatient
            // 
            vPatient.AutoSize = true;
            vPatient.BackColor = Color.Red;
            vPatient.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vPatient.ForeColor = Color.White;
            vPatient.Location = new Point(64, 253);
            vPatient.Name = "vPatient";
            vPatient.Size = new Size(134, 29);
            vPatient.TabIndex = 12;
            vPatient.Text = "View Patient";
            vPatient.Click += vPatient_Click;
            // 
            // BStockLbl
            // 
            BStockLbl.AutoSize = true;
            BStockLbl.BackColor = Color.Red;
            BStockLbl.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BStockLbl.ForeColor = Color.White;
            BStockLbl.Location = new Point(63, 301);
            BStockLbl.Name = "BStockLbl";
            BStockLbl.Size = new Size(132, 29);
            BStockLbl.TabIndex = 11;
            BStockLbl.Text = "Blood Stock";
            BStockLbl.Click += BStockLbl_Click;
            // 
            // Dashboardlbl
            // 
            Dashboardlbl.AutoSize = true;
            Dashboardlbl.BackColor = Color.Red;
            Dashboardlbl.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dashboardlbl.ForeColor = Color.White;
            Dashboardlbl.Location = new Point(63, 403);
            Dashboardlbl.Name = "Dashboardlbl";
            Dashboardlbl.Size = new Size(117, 29);
            Dashboardlbl.TabIndex = 10;
            Dashboardlbl.Text = "Dashboard";
            Dashboardlbl.Click += Dashboardlbl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(64, 110);
            label1.Name = "label1";
            label1.Size = new Size(71, 29);
            label1.TabIndex = 4;
            label1.Text = "Donor";
            // 
            // vDonorLbl
            // 
            vDonorLbl.AutoSize = true;
            vDonorLbl.BackColor = Color.Red;
            vDonorLbl.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vDonorLbl.ForeColor = Color.White;
            vDonorLbl.Location = new Point(63, 161);
            vDonorLbl.Name = "vDonorLbl";
            vDonorLbl.Size = new Size(122, 29);
            vDonorLbl.TabIndex = 5;
            vDonorLbl.Text = "View Donor";
            vDonorLbl.Click += vDonorLbl_Click;
            // 
            // Donor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 551);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(DPhone);
            Controls.Add(DAgetb);
            Controls.Add(DNametb);
            Controls.Add(DSaveB);
            Controls.Add(DAddressRtb);
            Controls.Add(DBGroupCb);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(DGenderCb);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Donor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Donor";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DPhone;
        private TextBox DAgetb;
        private TextBox DNametb;
        private Button DSaveB;
        private RichTextBox DAddressRtb;
        private ComboBox DBGroupCb;
        private Label label16;
        private Label label15;
        private Label label14;
        private ComboBox DGenderCb;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label Donatelbl;
        private Label label9;
        private Label BTransferLbl;
        private Label patientlbl;
        private Label vPatient;
        private Label BStockLbl;
        private Label Dashboardlbl;
        private Label label1;
        private Label vDonorLbl;
    }
}