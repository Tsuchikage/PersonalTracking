using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using DataAccessLayer.DataTransferObjects;
using BuisinessLogicLayer;

namespace PersonalTracking
{
	public partial class FrmTaskList : Form
	{
		public FrmTaskList()
		{
			InitializeComponent();
		}

		private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = General.isNumber(e);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		TaskDTO dto= new TaskDTO();
		private void FrmTaskList_Load(object sender, EventArgs e)
		{
			dto = TaskBLL.GetAll();	
			dataGridView1.DataSource = dto.Tasks;
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			FrmTask frm = new FrmTask();
			this.Hide();
			frm.ShowDialog();
			this.Visible= true;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			FrmTask frm = new FrmTask();
			this.Hide();
			frm.ShowDialog();
			this.Visible = true;
		}
	}
}
