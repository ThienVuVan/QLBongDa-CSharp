﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class DoiBongService
    {
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
    }
}