using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLib;
using System.Data.SqlClient;

namespace DataAccess
{
    public partial class Model
    {
        public static List<tblSanPham> GettblSanPhamItems()
        {
            var item = new tblSanPham();
            return SelectGeneric<tblSanPham>(item);
        }

     
        
    }
}
