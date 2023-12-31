﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class DoiBongService
    {
        public static DoiBong GetDoiBongById(string MaDoi)
        {
            return DoiBongAccess.GetDoiBongById(MaDoi);
        }
        public static List<string> RetrieveAllNameDoiBong()
        {
            return DoiBongAccess.RetrieveAllNameDoiBong();
        }

		public static List<string> RetrieveAllIdDoiBong()
		{
			return DoiBongAccess.RetrieveAllIdDoiBong();
		}
		public static void SaveDoiBong(DoiBong doiBong)
        {
            DoiBongAccess.SaveDoiBong(doiBong);
        }

        public static void UpdateDoiBong(DoiBong doiBong)   
        {
            DoiBongAccess.UpdateDoiBong(doiBong);
        }

        public static void DeleteDoiBong(string MaDoi)
        {
            DoiBongAccess.DeleteDoiBong(MaDoi);
        }
        public static DataTable GetAllDoiBong()
        {
            return DoiBongAccess.GetAllTeam();
        }
		public static DataTable Filter(string TenDoi, Nullable<int> Diem)
		{
			return DoiBongAccess.Filter(TenDoi, Diem);
		}
        public static DataTable SortDoiByScore()
        {
            return DoiBongAccess.SortDoiByScore();
        }
        public static DoiBong DoiBongHayNhat()
        {
            return DoiBongAccess.DoiBongHayNhat();
        }
	}
}
