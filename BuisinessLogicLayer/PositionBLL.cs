using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DataAccessObjects;
using DataAccessLayer.DataTransferObjects;

namespace BuisinessLogicLayer
{
	public class PositionBLL
	{
		public static void AddPosition(POSITION position)
		{
			PositionDAO.AddPosition(position);
		}

		public static List<PositionDTO> GetPositions()
		{
			return PositionDAO.GetPositions();
		}
	}
}
