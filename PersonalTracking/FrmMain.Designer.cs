﻿namespace PersonalTracking
{
	partial class FrmMain
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
			this.btnEmployee = new System.Windows.Forms.Button();
			this.btnTask = new System.Windows.Forms.Button();
			this.btnSalary = new System.Windows.Forms.Button();
			this.btnPermission = new System.Windows.Forms.Button();
			this.btnDepartment = new System.Windows.Forms.Button();
			this.btnPosition = new System.Windows.Forms.Button();
			this.btnLogOut = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnEmployee
			// 
			this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnEmployee.Location = new System.Drawing.Point(12, 12);
			this.btnEmployee.Name = "btnEmployee";
			this.btnEmployee.Size = new System.Drawing.Size(145, 120);
			this.btnEmployee.TabIndex = 0;
			this.btnEmployee.Text = "Employee";
			this.btnEmployee.UseVisualStyleBackColor = false;
			this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
			// 
			// btnTask
			// 
			this.btnTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnTask.Location = new System.Drawing.Point(175, 12);
			this.btnTask.Name = "btnTask";
			this.btnTask.Size = new System.Drawing.Size(145, 120);
			this.btnTask.TabIndex = 1;
			this.btnTask.Text = "Tasks";
			this.btnTask.UseVisualStyleBackColor = false;
			this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
			// 
			// btnSalary
			// 
			this.btnSalary.BackColor = System.Drawing.Color.Lime;
			this.btnSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSalary.Location = new System.Drawing.Point(337, 12);
			this.btnSalary.Name = "btnSalary";
			this.btnSalary.Size = new System.Drawing.Size(145, 120);
			this.btnSalary.TabIndex = 2;
			this.btnSalary.Text = "Salary";
			this.btnSalary.UseVisualStyleBackColor = false;
			this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
			// 
			// btnPermission
			// 
			this.btnPermission.BackColor = System.Drawing.Color.Green;
			this.btnPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnPermission.Location = new System.Drawing.Point(12, 152);
			this.btnPermission.Name = "btnPermission";
			this.btnPermission.Size = new System.Drawing.Size(145, 120);
			this.btnPermission.TabIndex = 3;
			this.btnPermission.Text = "Permission";
			this.btnPermission.UseVisualStyleBackColor = false;
			this.btnPermission.Click += new System.EventHandler(this.btnPermission_Click);
			// 
			// btnDepartment
			// 
			this.btnDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.btnDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDepartment.Location = new System.Drawing.Point(175, 152);
			this.btnDepartment.Name = "btnDepartment";
			this.btnDepartment.Size = new System.Drawing.Size(145, 120);
			this.btnDepartment.TabIndex = 4;
			this.btnDepartment.Text = "Department";
			this.btnDepartment.UseVisualStyleBackColor = false;
			this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
			// 
			// btnPosition
			// 
			this.btnPosition.BackColor = System.Drawing.Color.Fuchsia;
			this.btnPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnPosition.Location = new System.Drawing.Point(337, 152);
			this.btnPosition.Name = "btnPosition";
			this.btnPosition.Size = new System.Drawing.Size(145, 120);
			this.btnPosition.TabIndex = 5;
			this.btnPosition.Text = "Position";
			this.btnPosition.UseVisualStyleBackColor = false;
			this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
			// 
			// btnLogOut
			// 
			this.btnLogOut.BackColor = System.Drawing.Color.Yellow;
			this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnLogOut.Location = new System.Drawing.Point(95, 291);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(145, 120);
			this.btnLogOut.TabIndex = 6;
			this.btnLogOut.Text = "LogOut";
			this.btnLogOut.UseVisualStyleBackColor = false;
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.Red;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnExit.Location = new System.Drawing.Point(246, 291);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(145, 120);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(528, 437);
			this.Controls.Add(this.btnSalary);
			this.Controls.Add(this.btnTask);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnLogOut);
			this.Controls.Add(this.btnPosition);
			this.Controls.Add(this.btnDepartment);
			this.Controls.Add(this.btnPermission);
			this.Controls.Add(this.btnEmployee);
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Employee Tracking";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnEmployee;
		private System.Windows.Forms.Button btnTask;
		private System.Windows.Forms.Button btnSalary;
		private System.Windows.Forms.Button btnPermission;
		private System.Windows.Forms.Button btnDepartment;
		private System.Windows.Forms.Button btnPosition;
		private System.Windows.Forms.Button btnLogOut;
		private System.Windows.Forms.Button btnExit;
	}
}