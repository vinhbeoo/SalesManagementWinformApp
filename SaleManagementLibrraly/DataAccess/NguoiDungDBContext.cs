using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SaleManagementLibrraly.BussinessObject;

namespace SaleManagementLibrraly.DataAccess
{
    public class NguoiDungDBContext : BaseDAL
    {
        private static NguoiDungDBContext instance = null;
        private static readonly object instanceLock = new object();
        private NguoiDungDBContext() { }
        public static NguoiDungDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new NguoiDungDBContext();
                    }
                    return instance;
                }
            }
        }
        public NguoiDung GetInfo(string tenDangNhap, string matKhau)
        {
            NguoiDung nguoiDung = null;
            IDataReader dataReader = null;
            var parameters = new List<SqlParameter>();
            string SQLSelect = "Select * From NguoiDung Where TenDangNhap = @TenDangNhap and MatKhau = @MatKhau";
            try
            {
                parameters.Add(dataProvider.CreateParameter("@TenDangNhap", 50, tenDangNhap, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@MatKhau", 50, matKhau, DbType.String));
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, parameters.ToArray());
                if (dataReader.Read())
                {
                    nguoiDung = new NguoiDung
                    {
                        TenDangNhap = dataReader.GetString(0),
                        MatKhau = dataReader.GetString(1)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return nguoiDung;
        }
    }
}
