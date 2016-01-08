using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DatabaseLib;

namespace DataAccess
{
    public partial class Model
    {     
        public static List<tblThongandSP> GettblThongvaSPItems()
        {
            
            var sql = "select tblSanPham.MASP, tblSanPham.HANG, tblSanPham.TENSP, tblSanPham.GIA ,tblThongTinsp.SIZE, tblThongTinsp.SOLUONG, tblSanPham.TGBAOHANH from tblSanPham inner join tblThongTinsp on tblSanPham.MASP = tblThongTinsp.MASP where tblSanPham.ID=1";
            var param = new List<SqlParameter>();
         
            return db.GetList<tblThongandSP>(sql, param);
        }

       

       public static List<tblThongandSP> GetCombo(string cur)
        {
            var sql = "SELECT tblSanPham.HANG, tblSanPham.TENSP, tblSanPham.GIA ,tblThongTinsp.SIZE  from tblSanPham inner join tblThongTinSP on tblSanPham.MASP = tblThongTinsp.MASP where tblSanPham.MASP=@MASP";
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter
                {
                    ParameterName = "@MASP",
                    Value = cur,
                    SqlDbType = SqlDbType.NChar

                });
           return db.GetList<tblThongandSP>(sql, param);
        }

        public static List<tblThongandSP> GettblThongvaSPPKItems()
        {

            var sql = "select tblSanPham.MASP, tblSanPham.HANG, tblSanPham.TENSP, tblSanPham.GIA ,tblThongTinsp.SIZE, tblThongTinsp.SOLUONG, tblSanPham.TGBAOHANH from tblSanPham inner join tblThongTinsp on tblSanPham.MASP = tblThongTinsp.MASP where tblSanPham.ID=2";
            var param = new List<SqlParameter>();

            return db.GetList<tblThongandSP>(sql, param);
        }

        public static List<PhanLoai> GetNamePL()
        {
            var sql = "select * from PhanLoai";
            var param = new List<SqlParameter>();

            return db.GetList<PhanLoai>(sql, param);
        }
/*public static int DeleteKhoGoc(tblThongandSP cur)
        {
            var sql = "delete from tblSanPham where MASP =@MASP";
            // sql = " delete from tblThongTinSP where MASP = @MASP";
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter
                {
                    ParameterName = "@MASP",
                    Value = cur.MASP,
                    SqlDbType = SqlDbType.NChar
                });
            return db.ExecuteNonQuery(sql, param);
        }
        public static int DeleteKhoGoc1(tblThongandSP cur)
        {
           // var sql = "delete from tblSanPham where MASP =@MASP";
            var sql = " delete from tblThongTinSP where MASP = @MASP";
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter
            {
                ParameterName = "@MASP",
                Value = cur.MASP,
                SqlDbType = SqlDbType.NChar
            });
            return db.ExecuteNonQuery(sql, param);
        }
     */   
    }
}
