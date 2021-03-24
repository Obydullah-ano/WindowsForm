namespace StudentCrudOperation
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnterUserName = new System.Windows.Forms.TextBox();
            this.btnRegisterWindow = new System.Windows.Forms.Button();
            this.txtEnterPassword = new System.Windows.Forms.TextBox();
            this.btnCreateLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 452);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Password";
            // 
            // txtEnterUserName
            // 
            this.txtEnterUserName.AccessibleDescription = "";
            this.txtEnterUserName.AccessibleName = "";
            this.txtEnterUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterUserName.Location = new System.Drawing.Point(235, 380);
            this.txtEnterUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnterUserName.Name = "txtEnterUserName";
            this.txtEnterUserName.Size = new System.Drawing.Size(200, 30);
            this.txtEnterUserName.TabIndex = 2;
            // 
            // btnRegisterWindow
            // 
            this.btnRegisterWindow.BackColor = System.Drawing.Color.SpringGreen;
            this.btnRegisterWindow.FlatAppearance.BorderSize = 0;
            this.btnRegisterWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.btnRegisterWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterWindow.Location = new System.Drawing.Point(110, 600);
            this.btnRegisterWindow.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisterWindow.Name = "btnRegisterWindow";
            this.btnRegisterWindow.Size = new System.Drawing.Size(265, 50);
            this.btnRegisterWindow.TabIndex = 1;
            this.btnRegisterWindow.Text = "Register";
            this.btnRegisterWindow.UseVisualStyleBackColor = false;
            this.btnRegisterWindow.Click += new System.EventHandler(this.btnRegisterWindow_Click);
            // 
            // txtEnterPassword
            // 
            this.txtEnterPassword.AccessibleName = "";
            this.txtEnterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterPassword.Location = new System.Drawing.Point(235, 450);
            this.txtEnterPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnterPassword.Name = "txtEnterPassword";
            this.txtEnterPassword.PasswordChar = '*';
            this.txtEnterPassword.Size = new System.Drawing.Size(200, 30);
            this.txtEnterPassword.TabIndex = 2;
            // 
            // btnCreateLogin
            // 
            this.btnCreateLogin.BackColor = System.Drawing.Color.Blue;
            this.btnCreateLogin.FlatAppearance.BorderSize = 0;
            this.btnCreateLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCreateLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateLogin.Location = new System.Drawing.Point(110, 510);
            this.btnCreateLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateLogin.Name = "btnCreateLogin";
            this.btnCreateLogin.Size = new System.Drawing.Size(265, 50);
            this.btnCreateLogin.TabIndex = 1;
            this.btnCreateLogin.Text = "Login";
            this.btnCreateLogin.UseVisualStyleBackColor = false;
            this.btnCreateLogin.Click += new System.EventHandler(this.btnCreateLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GhostWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 383);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter User Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.BackgroundImage = global::StudentCrudOperation.Properties.Resources.loginBackground;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCreateLogin);
            this.groupBox1.Controls.Add(this.txtEnterPassword);
            this.groupBox1.Controls.Add(this.btnRegisterWindow);
            this.groupBox1.Controls.Add(this.txtEnterUserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-4, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 696);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 693);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnterUserName;
        private System.Windows.Forms.Button btnRegisterWindow;
        private System.Windows.Forms.TextBox txtEnterPassword;
        private System.Windows.Forms.Button btnCreateLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}