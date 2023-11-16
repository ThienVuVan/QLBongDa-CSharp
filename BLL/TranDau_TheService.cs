using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TranDau_TheService
    {
        public static DataTable PenatylCard(TranDau tranDau)
        {
            return TranDau_TheAccess.GetPenatylCard(tranDau);
        }
    }
}
