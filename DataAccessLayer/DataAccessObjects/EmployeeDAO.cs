﻿using DataAccessLayer.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataAccessObjects
{
	public class EmployeeDAO : EmployeeContext
	{
		public static void AddEmployee(EMPLOYEE employee)
		{
			try
			{
				db.EMPLOYEEs.InsertOnSubmit(employee);
				db.SubmitChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public static List<EmployeeDetailDTO> GetEmployees()
		{
			List<EmployeeDetailDTO> employeeList = new List<EmployeeDetailDTO>();
			var list = (from e in db.EMPLOYEEs
						join d in db.DEPARTMENTs on e.DepartmentID equals d.ID
						join p in db.POSITIONs on e.PositionID equals p.ID
						select new
						{
							UserNo = e.UserNo,
							Name = e.Name,
							Surname = e.Surname,
							EmployeeID = e.ID,
							Password = e.Password,
							DepartmentName = d.DepartmentName,
							PositionName = p.PositionName,
							DepartmentID = e.DepartmentID,
							PositionId = e.PositionID,
							isAdmin = e.isAdmin,
							Salary = e.Salary,
							ImagePath = e.ImagePath,
							birthDay = e.BirthDay,
							Adress = e.Adress

						}).OrderBy(x=> x.UserNo).ToList();
			foreach(var item in list)
			{
				EmployeeDetailDTO dto = new EmployeeDetailDTO();
				dto.Name = item.Name;
				dto.UserNo = item.UserNo;
				dto.Surname = item.Surname;
				dto.EmployeeID = item.EmployeeID;
				dto.Password = item.Password;
				dto.DepartmentName = item.DepartmentName;
				dto.DepartmentID = item.DepartmentID;
				dto.PositionID = item.PositionId;
				dto.PositionName = item.PositionName;
				dto.isAdmin = (bool)item.isAdmin;
				dto.Salary = item.Salary;
				dto.BirthDay = item.birthDay;
				employeeList.Add(dto);
			}

			return employeeList;
		}

		public static List<EMPLOYEE> GetUsers(int v)
		{
			return db.EMPLOYEEs.Where(x=> x.UserNo == v).ToList();
		}
	}
}
