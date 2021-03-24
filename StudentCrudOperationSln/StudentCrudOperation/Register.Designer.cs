namespace StudentCrudOperation
{
    partial class Register
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoginWindo = new System.Windows.Forms.Button();
            this.txtCreatePassword = new System.Windows.Forms.TextBox();
            this.btnCreateRegister = new System.Windows.Forms.Button();
            this.txtCreateUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.BackgroundImage = global::StudentCrudOperation.Properties.Resources.loginBackground;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLoginWindo);
            this.groupBox1.Controls.Add(this.txtCreatePassword);
            this.groupBox1.Controls.Add(this.btnCreateRegister);
            this.groupBox1.Controls.Add(this.txtCreateUserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(-2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 696);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.SpringGreen;
            this.btnHome.BackgroundImage = global::StudentCrudOperation.Properties.Resources.labelBack;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(132, 172);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(186, 47);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 382);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create User Name";
            // 
            // btnLoginWindo
            // 
            this.btnLoginWindo.BackColor = System.Drawing.Color.Blue;
            this.btnLoginWindo.FlatAppearance.BorderSize = 0;
            this.btnLoginWindo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLoginWindo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginWindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginWindo.Location = new System.Drawing.Point(110, 600);
            this.btnLoginWindo.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoginWindo.Name = "btnLoginWindo";
            this.btnLoginWindo.Size = new System.Drawing.Size(265, 50);
            this.btnLoginWindo.TabIndex = 1;
            this.btnLoginWindo.Text = "Login";
            this.btnLoginWindo.UseVisualStyleBackColor = false;
            this.btnLoginWindo.Click += new System.EventHandler(this.btnLoginWindo_Click);
            // 
            // txtCreatePassword
            // 
            this.txtCreatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatePassword.Location = new System.Drawing.Point(235, 450);
            this.txtCreatePassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreatePassword.Name = "txtCreatePassword";
            this.txtCreatePassword.Size = new System.Drawing.Size(200, 30);
            this.txtCreatePassword.TabIndex = 2;
            // 
            // btnCreateRegister
            // 
            this.btnCreateRegister.BackColor = System.Drawing.Color.Lime;
            this.btnCreateRegister.FlatAppearance.BorderSize = 0;
            this.btnCreateRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCreateRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRegister.Location = new System.Drawing.Point(110, 510);
            this.btnCreateRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateRegister.Name = "btnCreateRegister";
            this.btnCreateRegister.Size = new System.Drawing.Size(265, 50);
            this.btnCreateRegister.TabIndex = 1;
            this.btnCreateRegister.Text = "Register";
            this.btnCreateRegister.UseVisualStyleBackColor = false;
            this.btnCreateRegister.Click += new System.EventHandler(this.btnCreateRegister_Click);
            // 
            // txtCreateUserName
            // 
            this.txtCreateUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateUserName.Location = new System.Drawing.Point(235, 380);
            this.txtCreateUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreateUserName.Name = "txtCreateUserName";
            this.txtCreateUserName.Size = new System.Drawing.Size(200, 30);
            this.txtCreateUserName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 449);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Create Password";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 693);
            this.Controls.Add(this.groupBox1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoginWindo;
        private System.Windows.Forms.TextBox txtCreatePassword;
        private System.Windows.Forms.Button btnCreateRegister;
        private System.Windows.Forms.TextBox txtCreateUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHome;
    }
}