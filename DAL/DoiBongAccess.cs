﻿using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DoiBongAccess
    {
        public static void SaveDoiBong(DoiBong doiBong)
        {
            string sql = $"insert into DOIBONG ([MADOI],[MASAN],[MATINH],[TENDOI],[HLV],[LOGO],[SODIEM],[SOBANTHANG],[SOBANTHUA],[SOLUONGCAUTHU]) " +
                $"values('{doiBong.MaDoi}','{doiBong.MaSan}','{doiBong.MaTinh}',N'{doiBong.TenDoi}',N'{doiBong.HLV}','{doiBong.LoGo}',0,0,0,0)";
            DatabaseAccess.Excute(sql);
        }

        public static void UpdateDoiBong(DoiBong doiBong)
        {
            string sql = $"Update DOIBONG set MADOI = '{doiBong.MaDoi}',MASAN = '{doiBong.MaSan}',MATINH = '{doiBong.MaTinh}'," +
                $"TENDOI = N'{doiBong.TenDoi}',HLV = N'{doiBong.HLV}',LOGO = '{doiBong.LoGo}'";
            DatabaseAccess.Excute(sql);
        }
        //TODO
        public static void DeleteDoiBong(string MaDoi)
        {
            string sql = "...";
            DatabaseAccess.Excute(sql);
        }
        public static DataTable GetAllTeam()
        {
            string sql = "select * from DOIBONG";
            return DatabaseAccess.ReadTable(sql);
        }
    }
}
