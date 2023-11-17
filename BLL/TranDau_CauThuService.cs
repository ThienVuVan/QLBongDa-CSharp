using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class TranDau_CauThuService
    {
        public static List<DataTable> GetAllPlayerInGame(TranDau tranDau)
        {
            return TranDau_CauThuAccess.RetriveAll(tranDau);
        }
    }
}
