
namespace StudentCrudOperation
{
    partial class InstituteFrm
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
            this.txtInstituteId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInsertInstitute = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInstituteName = new System.Windows.Forms.TextBox();
            this.btnUpdateInstitute = new System.Windows.Forms.Button();
            this.btnDeleteInstitute = new System.Windows.Forms.Button();
            this.dgvInstituteInfo = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstituteInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInstituteId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnInsertInstitute);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtInstituteName);
            this.groupBox1.Controls.Add(this.btnUpdateInstitute);
            this.groupBox1.Controls.Add(this.btnDeleteInstitute);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Institute Info";
            // 
            // txtInstituteId
            // 
            this.txtInstituteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstituteId.Location = new System.Drawing.Point(161, 72);
            this.txtInstituteId.Name = "txtInstituteId";
            this.txtInstituteId.ReadOnly = true;
            this.txtInstituteId.Size = new System.Drawing.Size(288, 30);
            this.txtInstituteId.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Institute ID";
            // 
            // btnInsertInstitute
            // 
            this.btnInsertInstitute.BackColor = System.Drawing.Color.Green;
            this.btnInsertInstitute.FlatAppearance.BorderSize = 0;
            this.btnInsertInstitute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertInstitute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertInstitute.Location = new System.Drawing.Point(5, 257);
            this.btnInsertInstitute.Name = "btnInsertInstitute";
            this.btnInsertInstitute.Size = new System.Drawing.Size(130, 40);
            this.btnInsertInstitute.TabIndex = 10;
            this.btnInsertInstitute.Text = "Insert";
            this.btnInsertInstitute.UseVisualStyleBackColor = false;
            this.btnInsertInstitute.Click += new System.EventHandler(this.btnInsertInstitute_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Institute Name";
            // 
            // txtInstituteName
            // 
            this.txtInstituteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstituteName.Location = new System.Drawing.Point(161, 153);
            this.txtInstituteName.Name = "txtInstituteName";
            this.txtInstituteName.Size = new System.Drawing.Size(288, 30);
            this.txtInstituteName.TabIndex = 9;
            // 
            // btnUpdateInstitute
            // 
            this.btnUpdateInstitute.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdateInstitute.FlatAppearance.BorderSize = 0;
            this.btnUpdateInstitute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInstitute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInstitute.Location = new System.Drawing.Point(161, 257);
            this.btnUpdateInstitute.Name = "btnUpdateInstitute";
            this.btnUpdateInstitute.Size = new System.Drawing.Size(130, 40);
            this.btnUpdateInstitute.TabIndex = 11;
            this.btnUpdateInstitute.Text = "Update";
            this.btnUpdateInstitute.UseVisualStyleBackColor = false;
            this.btnUpdateInstitute.Click += new System.EventHandler(this.btnUpdateInstitute_Click);
            // 
            // btnDeleteInstitute
            // 
            this.btnDeleteInstitute.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteInstitute.FlatAppearance.BorderSize = 0;
            this.btnDeleteInstitute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteInstitute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInstitute.Location = new System.Drawing.Point(310, 257);
            this.btnDeleteInstitute.Name = "btnDeleteInstitute";
            this.btnDeleteInstitute.Size = new System.Drawing.Size(130, 40);
            this.btnDeleteInstitute.TabIndex = 12;
            this.btnDeleteInstitute.Text = "Delete";
            this.btnDeleteInstitute.UseVisualStyleBackColor = false;
            this.btnDeleteInstitute.Click += new System.EventHandler(this.btnDeleteInstitute_Click);
            // 
            // dgvInstituteInfo
            // 
            this.dgvInstituteInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInstituteInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvInstituteInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstituteInfo.Location = new System.Drawing.Point(529, 102);
            this.dgvInstituteInfo.Name = "dgvInstituteInfo";
            this.dgvInstituteInfo.RowHeadersWidth = 51;
            this.dgvInstituteInfo.RowTemplate.Height = 24;
            this.dgvInstituteInfo.Size = new System.Drawing.Size(670, 337);
            this.dgvInstituteInfo.TabIndex = 1;
            this.dgvInstituteInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstituteInfo_CellClick);
            // 
            // InstituteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 702);
            this.Controls.Add(this.dgvInstituteInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "InstituteFrm";
            this.Text = "InstituteFrm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstituteInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInstituteId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnInsertInstitute;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInstituteName;
        private System.Windows.Forms.Button btnUpdateInstitute;
        private System.Windows.Forms.Button btnDeleteInstitute;
        private System.Windows.Forms.DataGridView dgvInstituteInfo;
    }
}