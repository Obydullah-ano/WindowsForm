namespace StudentCrudOperation
{
    partial class StudentCrudFrm
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
            this.dateTimeDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbInstituteName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCourseName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCourseFee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.btnInsertCourse = new System.Windows.Forms.Button();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReportView = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvStudentCrud = new System.Windows.Forms.DataGridView();
            this.btnBrows = new System.Windows.Forms.Button();
            this.pictureBoxStudentPhoto = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentCrud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudentPhoto)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeDateOfBirth
            // 
            this.dateTimeDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDateOfBirth.Location = new System.Drawing.Point(164, 171);
            this.dateTimeDateOfBirth.Name = "dateTimeDateOfBirth";
            this.dateTimeDateOfBirth.Size = new System.Drawing.Size(268, 28);
            this.dateTimeDateOfBirth.TabIndex = 6;
            this.dateTimeDateOfBirth.ValueChanged += new System.EventHandler(this.dateTimeDateOfBirth_ValueChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(310, 353);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 40);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(164, 353);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 40);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update\r\n\r\n";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(28, 353);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbInstituteName
            // 
            this.cmbInstituteName.BackColor = System.Drawing.SystemColors.Info;
            this.cmbInstituteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInstituteName.FormattingEnabled = true;
            this.cmbInstituteName.Location = new System.Drawing.Point(164, 219);
            this.cmbInstituteName.Name = "cmbInstituteName";
            this.cmbInstituteName.Size = new System.Drawing.Size(269, 30);
            this.cmbInstituteName.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Student Name";
            // 
            // cmbCourseName
            // 
            this.cmbCourseName.BackColor = System.Drawing.SystemColors.Info;
            this.cmbCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourseName.FormattingEnabled = true;
            this.cmbCourseName.Location = new System.Drawing.Point(164, 265);
            this.cmbCourseName.Name = "cmbCourseName";
            this.cmbCourseName.Size = new System.Drawing.Size(269, 30);
            this.cmbCourseName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Date of Birth";
            // 
            // txtCourseFee
            // 
            this.txtCourseFee.BackColor = System.Drawing.SystemColors.Info;
            this.txtCourseFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseFee.Location = new System.Drawing.Point(164, 312);
            this.txtCourseFee.Name = "txtCourseFee";
            this.txtCourseFee.Size = new System.Drawing.Size(269, 28);
            this.txtCourseFee.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Course Fee";
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.SystemColors.Info;
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(164, 82);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(269, 28);
            this.txtStudentName.TabIndex = 1;
            // 
            // txtFatherName
            // 
            this.txtFatherName.BackColor = System.Drawing.SystemColors.Info;
            this.txtFatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFatherName.Location = new System.Drawing.Point(164, 127);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(269, 28);
            this.txtFatherName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Course Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Father\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Institute Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(354, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "STUDENT MANAGEMENT CRUD OPERATION";
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteCourse.FlatAppearance.BorderSize = 0;
            this.btnDeleteCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCourse.Location = new System.Drawing.Point(299, 149);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(130, 40);
            this.btnDeleteCourse.TabIndex = 4;
            this.btnDeleteCourse.Text = "Delete";
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdateCourse.FlatAppearance.BorderSize = 0;
            this.btnUpdateCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCourse.Location = new System.Drawing.Point(157, 149);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(130, 40);
            this.btnUpdateCourse.TabIndex = 4;
            this.btnUpdateCourse.Text = "Update";
            this.btnUpdateCourse.UseVisualStyleBackColor = false;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // btnInsertCourse
            // 
            this.btnInsertCourse.BackColor = System.Drawing.Color.Green;
            this.btnInsertCourse.FlatAppearance.BorderSize = 0;
            this.btnInsertCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertCourse.Location = new System.Drawing.Point(16, 149);
            this.btnInsertCourse.Name = "btnInsertCourse";
            this.btnInsertCourse.Size = new System.Drawing.Size(130, 40);
            this.btnInsertCourse.TabIndex = 4;
            this.btnInsertCourse.Text = "Insert";
            this.btnInsertCourse.UseVisualStyleBackColor = false;
            this.btnInsertCourse.Click += new System.EventHandler(this.btnInsertCourse_Click);
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(154, 99);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(279, 30);
            this.txtCourseName.TabIndex = 3;
            // 
            // txtCourseId
            // 
            this.txtCourseId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCourseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseId.Location = new System.Drawing.Point(154, 45);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.ReadOnly = true;
            this.txtCourseId.Size = new System.Drawing.Size(279, 30);
            this.txtCourseId.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Course Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Course ID";
            // 
            // btnReportView
            // 
            this.btnReportView.BackColor = System.Drawing.Color.Yellow;
            this.btnReportView.FlatAppearance.BorderSize = 0;
            this.btnReportView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnReportView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportView.Location = new System.Drawing.Point(0, 566);
            this.btnReportView.Name = "btnReportView";
            this.btnReportView.Size = new System.Drawing.Size(225, 51);
            this.btnReportView.TabIndex = 11;
            this.btnReportView.Text = "View Report";
            this.btnReportView.UseVisualStyleBackColor = false;
            this.btnReportView.Click += new System.EventHandler(this.btnReportView_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1538, 70);
            this.panel1.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(178, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Course Information";
            // 
            // dgvStudentCrud
            // 
            this.dgvStudentCrud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentCrud.Location = new System.Drawing.Point(0, 1);
            this.dgvStudentCrud.Name = "dgvStudentCrud";
            this.dgvStudentCrud.RowHeadersWidth = 51;
            this.dgvStudentCrud.RowTemplate.Height = 24;
            this.dgvStudentCrud.Size = new System.Drawing.Size(1081, 530);
            this.dgvStudentCrud.TabIndex = 7;
            this.dgvStudentCrud.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpdateDelete_CellClick);
            this.dgvStudentCrud.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpdateDelete_CellContentClick);
            // 
            // btnBrows
            // 
            this.btnBrows.BackgroundImage = global::StudentCrudOperation.Properties.Resources.upload1;
            this.btnBrows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrows.Location = new System.Drawing.Point(107, 33);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(64, 31);
            this.btnBrows.TabIndex = 11;
            this.btnBrows.UseVisualStyleBackColor = true;
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // pictureBoxStudentPhoto
            // 
            this.pictureBoxStudentPhoto.BackColor = System.Drawing.Color.SpringGreen;
            this.pictureBoxStudentPhoto.Location = new System.Drawing.Point(12, 4);
            this.pictureBoxStudentPhoto.Name = "pictureBoxStudentPhoto";
            this.pictureBoxStudentPhoto.Size = new System.Drawing.Size(89, 73);
            this.pictureBoxStudentPhoto.TabIndex = 10;
            this.pictureBoxStudentPhoto.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 696);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1538, 37);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 626);
            this.panel3.TabIndex = 16;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.txtFatherName);
            this.panel7.Controls.Add(this.cmbInstituteName);
            this.panel7.Controls.Add(this.cmbCourseName);
            this.panel7.Controls.Add(this.btnDelete);
            this.panel7.Controls.Add(this.btnSave);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.btnBrows);
            this.panel7.Controls.Add(this.dateTimeDateOfBirth);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.pictureBoxStudentPhoto);
            this.panel7.Controls.Add(this.txtCourseFee);
            this.panel7.Controls.Add(this.btnUpdate);
            this.panel7.Controls.Add(this.txtStudentName);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 220);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(456, 403);
            this.panel7.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(178, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "Student Information";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 210);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(456, 10);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.txtCourseId);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.btnInsertCourse);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtCourseName);
            this.panel4.Controls.Add(this.btnUpdateCourse);
            this.panel4.Controls.Add(this.btnDeleteCourse);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(456, 210);
            this.panel4.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::StudentCrudOperation.Properties.Resources.contentImage;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.btnReportView);
            this.panel6.Controls.Add(this.dgvStudentCrud);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(456, 70);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1082, 626);
            this.panel6.TabIndex = 17;
            // 
            // StudentCrudFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 733);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentCrudFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student CRUD";
            this.Load += new System.EventHandler(this.UpdateAndDeleteFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentCrud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudentPhoto)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrows;
        private System.Windows.Forms.DateTimePicker dateTimeDateOfBirth;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbInstituteName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCourseName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCourseFee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxStudentPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.Button btnInsertCourse;
        private System.Windows.Forms.Button btnReportView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvStudentCrud;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label11;
    }
}