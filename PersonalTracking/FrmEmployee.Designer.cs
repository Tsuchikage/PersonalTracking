﻿namespace PersonalTracking
{
	partial class FrmEmployee
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.chAdmin = new System.Windows.Forms.CheckBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCheck = new System.Windows.Forms.Button();
			this.txtUserNo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtImagePath = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txtSalary = new System.Windows.Forms.TextBox();
			this.cmbPosition = new System.Windows.Forms.ComboBox();
			this.cmbDepartment = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.txtAdress = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.chAdmin);
			this.panel1.Controls.Add(this.txtPassword);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btnCheck);
			this.panel1.Controls.Add(this.txtUserNo);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(884, 100);
			this.panel1.TabIndex = 0;
			// 
			// chAdmin
			// 
			this.chAdmin.AutoSize = true;
			this.chAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chAdmin.Location = new System.Drawing.Point(734, 16);
			this.chAdmin.Name = "chAdmin";
			this.chAdmin.Size = new System.Drawing.Size(106, 24);
			this.chAdmin.TabIndex = 7;
			this.chAdmin.Text = "is Admin?";
			this.chAdmin.UseVisualStyleBackColor = true;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtPassword.Location = new System.Drawing.Point(551, 12);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(166, 26);
			this.txtPassword.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(459, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Password";
			// 
			// btnCheck
			// 
			this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCheck.Location = new System.Drawing.Point(255, 9);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(103, 26);
			this.btnCheck.TabIndex = 4;
			this.btnCheck.Text = "Check";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// txtUserNo
			// 
			this.txtUserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtUserNo.Location = new System.Drawing.Point(83, 9);
			this.txtUserNo.Name = "txtUserNo";
			this.txtUserNo.Size = new System.Drawing.Size(166, 26);
			this.txtUserNo.TabIndex = 0;
			this.txtUserNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserNo_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(8, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "UserNo";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(8, 143);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Name";
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtName.Location = new System.Drawing.Point(138, 137);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(206, 26);
			this.txtName.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(8, 188);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Surname";
			// 
			// txtSurname
			// 
			this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtSurname.Location = new System.Drawing.Point(138, 182);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.Size = new System.Drawing.Size(206, 26);
			this.txtSurname.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(8, 230);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(101, 20);
			this.label5.TabIndex = 5;
			this.label5.Text = "Image Path";
			// 
			// txtImagePath
			// 
			this.txtImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtImagePath.Location = new System.Drawing.Point(138, 224);
			this.txtImagePath.Name = "txtImagePath";
			this.txtImagePath.Size = new System.Drawing.Size(206, 26);
			this.txtImagePath.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(494, 137);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(378, 289);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// btnBrowse
			// 
			this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnBrowse.Location = new System.Drawing.Point(366, 224);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(95, 26);
			this.btnBrowse.TabIndex = 3;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(8, 276);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "Salary";
			// 
			// txtSalary
			// 
			this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtSalary.Location = new System.Drawing.Point(138, 270);
			this.txtSalary.Name = "txtSalary";
			this.txtSalary.Size = new System.Drawing.Size(206, 26);
			this.txtSalary.TabIndex = 4;
			this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
			// 
			// cmbPosition
			// 
			this.cmbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cmbPosition.FormattingEnabled = true;
			this.cmbPosition.Location = new System.Drawing.Point(138, 357);
			this.cmbPosition.Name = "cmbPosition";
			this.cmbPosition.Size = new System.Drawing.Size(206, 28);
			this.cmbPosition.TabIndex = 6;
			// 
			// cmbDepartment
			// 
			this.cmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cmbDepartment.FormattingEnabled = true;
			this.cmbDepartment.Location = new System.Drawing.Point(138, 314);
			this.cmbDepartment.Name = "cmbDepartment";
			this.cmbDepartment.Size = new System.Drawing.Size(206, 28);
			this.cmbDepartment.TabIndex = 5;
			this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(8, 365);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 20);
			this.label7.TabIndex = 9;
			this.label7.Text = "Position";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(8, 322);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(104, 20);
			this.label8.TabIndex = 10;
			this.label8.Text = "Department";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(8, 407);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(75, 20);
			this.label9.TabIndex = 9;
			this.label9.Text = "Birthday";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(138, 406);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(206, 20);
			this.dateTimePicker1.TabIndex = 7;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(8, 443);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(65, 20);
			this.label10.TabIndex = 5;
			this.label10.Text = "Adress";
			// 
			// txtAdress
			// 
			this.txtAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtAdress.Location = new System.Drawing.Point(83, 443);
			this.txtAdress.Multiline = true;
			this.txtAdress.Name = "txtAdress";
			this.txtAdress.Size = new System.Drawing.Size(789, 150);
			this.txtAdress.TabIndex = 8;
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnClose.Location = new System.Drawing.Point(753, 621);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(119, 52);
			this.btnClose.TabIndex = 10;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSave.Location = new System.Drawing.Point(83, 621);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(119, 52);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// FrmEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 683);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.cmbPosition);
			this.Controls.Add(this.cmbDepartment);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtImagePath);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtSurname);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtSalary);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtAdress);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label3);
			this.Name = "FrmEmployee";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Employee";
			this.Load += new System.EventHandler(this.FrmEmployee_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtUserNo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.CheckBox chAdmin;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSurname;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtImagePath;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtSalary;
		private System.Windows.Forms.ComboBox cmbPosition;
		private System.Windows.Forms.ComboBox cmbDepartment;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtAdress;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSave;
	}
}