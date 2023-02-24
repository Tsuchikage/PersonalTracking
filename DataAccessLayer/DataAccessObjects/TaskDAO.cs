using DataAccessLayer.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccessObjects
{
	public class TaskDAO : EmployeeContext
	{
		public static void AddTask(TASK task)
		{
			try
			{
				db.TASKs.InsertOnSubmit(task);
				db.SubmitChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public static List<TaskDetailDTO> GetTasks()
		{
			List<TaskDetailDTO> taskList = new List<TaskDetailDTO>();

			var list = (from t in db.TASKs
						join s in db.TASKSTATEs on t.TaskState equals s.ID
						join e in db.EMPLOYEEs on t.EmployeeID equals e.ID
						join d in db.DEPARTMENTs on e.DepartmentID equals d.ID
						join p in db.POSITIONs on e.PositionID equals p.ID
						select new
						{
							taskID = t.ID,
							title = t.TaskTitle,
							content = t.TaskContent,
							startdate = t.TaskStartDate,
							deliveryDate = t.TaskDeliveryDate,
							taskStateName = s.StateName,
							taskStateID = t.TaskState,
							UserNo = e.UserNo,
							Name = e.Name,
							EmployeeId = t.EmployeeID,
							Surname = e.Surname,
							positionName = p.PositionName,
							departmentName = d.DepartmentName,
							positionID = e.PositionID,
							departmentId = e.DepartmentID,

						}).OrderBy(x => x.startdate).ToList();

			foreach ( var item in list)
			{
				TaskDetailDTO dto = new TaskDetailDTO();
				dto.TaskID = item.taskID;
				dto.Title = item.title;
				dto.Content = item.content;
				dto.TaskStartDate = (DateTime)item.startdate;
				dto.TaskDeliveryDate = (DateTime)item.deliveryDate;
				dto.TaskStateName = item.taskStateName;
				dto.TaskStateID= item.taskStateID;
				dto.UserNo = item.UserNo;
				dto.Name= item.Name;
				dto.Surname = item.Surname;
				dto.DepartmentName = item.departmentName;
				dto.PositionID = item.positionID;
				dto.PositionName = item.positionName;
				dto.EmployeeID = item.EmployeeId;
				taskList.Add(dto);




			}

			return taskList;
		}

		public static List<TASKSTATE> GetTaskStates()
		{
			return db.TASKSTATEs.ToList();
		}
	}
}
