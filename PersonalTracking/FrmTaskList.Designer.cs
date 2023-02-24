﻿namespace PersonalTracking
{
	partial class FrmTaskList
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnApprove = new System.Windows.Forms.Button();
			this.pnlForAdmin = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtUserNo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbPosition = new System.Windows.Forms.ComboBox();
			this.cmbDepartment = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.dpStart = new System.Windows.Forms.DateTimePicker();
			this.dpEnd = new System.Windows.Forms.DateTimePicker();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbStartDate = new System.Windows.Forms.RadioButton();
			this.rbDeliveryDate = new System.Windows.Forms.RadioButton();
			this.label9 = new System.Windows.Forms.Label();
			this.cmbTaskState = new System.Windows.Forms.ComboBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.pnlForAdmin.SuspendLayout();
			this.panel3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.pnlForAdmin);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(934, 209);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnClose);
			this.panel2.Controls.Add(this.btnDelete);
			this.panel2.Controls.Add(this.btnUpdate);
			this.panel2.Controls.Add(this.btnApprove);
			this.panel2.Controls.Add(this.btnNew);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 573);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(934, 109);
			this.panel2.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 209);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(934, 364);
			this.dataGridView1.TabIndex = 2;
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnClose.Location = new System.Drawing.Point(699, 17);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(143, 76);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDelete.Location = new System.Drawing.Point(539, 17);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(143, 76);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnUpdate.Location = new System.Drawing.Point(381, 17);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(143, 76);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnNew
			// 
			this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnNew.Location = new System.Drawing.Point(223, 17);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(143, 76);
			this.btnNew.TabIndex = 1;
			this.btnNew.Text = "New";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnApprove
			// 
			this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnApprove.Location = new System.Drawing.Point(62, 17);
			this.btnApprove.Name = "btnApprove";
			this.btnApprove.Size = new System.Drawing.Size(143, 76);
			this.btnApprove.TabIndex = 0;
			this.btnApprove.Text = "Approve";
			this.btnApprove.UseVisualStyleBackColor = true;
			// 
			// pnlForAdmin
			// 
			this.pnlForAdmin.Controls.Add(this.cmbPosition);
			this.pnlForAdmin.Controls.Add(this.cmbDepartment);
			this.pnlForAdmin.Controls.Add(this.label5);
			this.pnlForAdmin.Controls.Add(this.label4);
			this.pnlForAdmin.Controls.Add(this.txtSurname);
			this.pnlForAdmin.Controls.Add(this.txtName);
			this.pnlForAdmin.Controls.Add(this.label3);
			this.pnlForAdmin.Controls.Add(this.txtUserNo);
			this.pnlForAdmin.Controls.Add(this.label2);
			this.pnlForAdmin.Controls.Add(this.label1);
			this.pnlForAdmin.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlForAdmin.Location = new System.Drawing.Point(0, 0);
			this.pnlForAdmin.Name = "pnlForAdmin";
			this.pnlForAdmin.Size = new System.Drawing.Size(451, 209);
			this.pnlForAdmin.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnClear);
			this.panel3.Controls.Add(this.btnSearch);
			this.panel3.Controls.Add(this.cmbTaskState);
			this.panel3.Controls.Add(this.groupBox1);
			this.panel3.Controls.Add(this.dpEnd);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.dpStart);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(451, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(483, 209);
			this.panel3.TabIndex = 1;
			// 
			// txtSurname
			// 
			this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtSurname.Location = new System.Drawing.Point(117, 90);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.Size = new System.Drawing.Size(261, 26);
			this.txtSurname.TabIndex = 2;
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtName.Location = new System.Drawing.Point(117, 47);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(261, 26);
			this.txtName.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(11, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Surname";
			// 
			// txtUserNo
			// 
			this.txtUserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtUserNo.Location = new System.Drawing.Point(117, 7);
			this.txtUserNo.Name = "txtUserNo";
			this.txtUserNo.Size = new System.Drawing.Size(261, 26);
			this.txtUserNo.TabIndex = 0;
			this.txtUserNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserNo_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(11, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(11, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "UserNo";
			// 
			// cmbPosition
			// 
			this.cmbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cmbPosition.FormattingEnabled = true;
			this.cmbPosition.Location = new System.Drawing.Point(117, 169);
			this.cmbPosition.Name = "cmbPosition";
			this.cmbPosition.Size = new System.Drawing.Size(261, 28);
			this.cmbPosition.TabIndex = 4;
			// 
			// cmbDepartment
			// 
			this.cmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cmbDepartment.FormattingEnabled = true;
			this.cmbDepartment.Location = new System.Drawing.Point(117, 126);
			this.cmbDepartment.Name = "cmbDepartment";
			this.cmbDepartment.Size = new System.Drawing.Size(261, 28);
			this.cmbDepartment.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(12, 177);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "Position";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 134);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 20);
			this.label4.TabIndex = 11;
			this.label4.Text = "Department";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(9, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 20);
			this.label6.TabIndex = 8;
			this.label6.Text = "Task Date";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(9, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(49, 20);
			this.label7.TabIndex = 8;
			this.label7.Text = "Start";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(9, 98);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(41, 20);
			this.label8.TabIndex = 8;
			this.label8.Text = "End";
			// 
			// dpStart
			// 
			this.dpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dpStart.Location = new System.Drawing.Point(67, 55);
			this.dpStart.Name = "dpStart";
			this.dpStart.Size = new System.Drawing.Size(241, 21);
			this.dpStart.TabIndex = 0;
			// 
			// dpEnd
			// 
			this.dpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dpEnd.Location = new System.Drawing.Point(67, 97);
			this.dpEnd.Name = "dpEnd";
			this.dpEnd.Size = new System.Drawing.Size(241, 21);
			this.dpEnd.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbDeliveryDate);
			this.groupBox1.Controls.Add(this.rbStartDate);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(314, 37);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(157, 100);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			// 
			// rbStartDate
			// 
			this.rbStartDate.AutoSize = true;
			this.rbStartDate.Location = new System.Drawing.Point(6, 17);
			this.rbStartDate.Name = "rbStartDate";
			this.rbStartDate.Size = new System.Drawing.Size(100, 21);
			this.rbStartDate.TabIndex = 0;
			this.rbStartDate.TabStop = true;
			this.rbStartDate.Text = "Start Date";
			this.rbStartDate.UseVisualStyleBackColor = true;
			// 
			// rbDeliveryDate
			// 
			this.rbDeliveryDate.AutoSize = true;
			this.rbDeliveryDate.Location = new System.Drawing.Point(6, 58);
			this.rbDeliveryDate.Name = "rbDeliveryDate";
			this.rbDeliveryDate.Size = new System.Drawing.Size(124, 21);
			this.rbDeliveryDate.TabIndex = 1;
			this.rbDeliveryDate.TabStop = true;
			this.rbDeliveryDate.Text = "Delivery Date";
			this.rbDeliveryDate.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(9, 152);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(96, 20);
			this.label9.TabIndex = 10;
			this.label9.Text = "Task State";
			// 
			// cmbTaskState
			// 
			this.cmbTaskState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cmbTaskState.FormattingEnabled = true;
			this.cmbTaskState.Location = new System.Drawing.Point(111, 144);
			this.cmbTaskState.Name = "cmbTaskState";
			this.cmbTaskState.Size = new System.Drawing.Size(197, 28);
			this.cmbTaskState.TabIndex = 2;
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnClear.Location = new System.Drawing.Point(409, 140);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(62, 34);
			this.btnClear.TabIndex = 4;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSearch.Location = new System.Drawing.Point(314, 140);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(78, 34);
			this.btnSearch.TabIndex = 3;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// FrmTaskList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(934, 682);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FrmTaskList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Task List";
			this.Load += new System.EventHandler(this.FrmTaskList_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.pnlForAdmin.ResumeLayout(false);
			this.pnlForAdmin.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel pnlForAdmin;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnApprove;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.TextBox txtSurname;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUserNo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbTaskState;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbDeliveryDate;
		private System.Windows.Forms.RadioButton rbStartDate;
		private System.Windows.Forms.DateTimePicker dpEnd;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DateTimePicker dpStart;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbPosition;
		private System.Windows.Forms.ComboBox cmbDepartment;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnSearch;
	}
}