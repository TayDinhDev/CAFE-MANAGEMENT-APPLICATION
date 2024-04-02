using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//Tương tác với CSDL (SQL/ ACCESS/ Bộ OFFICE)
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLiQuanCafeNew.DataAccess
{
    class ConnectDB
    {
        //cho biet dia chỉ của server ở đâu và kết nối tới
        public SqlConnection Conn = new SqlConnection();
        public SqlCommand Comm = new SqlCommand();
        public SqlDataReader sqlDR;
        //public void Conect_QLT()
        //{
        //    Conn = new SqlConnection("Data Source=SAIOKENKI\\SQLEXPRESS;Initial Catalog=QL_QuanCafe;Integrated Security=True");
        //    //Data Source=SAIOKENKI\SQLEXPRESS;Initial Catalog=QL_QuanCafe;Integrated Security=True
        //    Conn.Open();
        //}
        public SqlConnection GetCon()
        {
            Conn = new SqlConnection("Data Source=SAIOKENKI\\SQLEXPRESS;Initial Catalog=QL_QuanCafe;Integrated Security=True");
            Conn.Open();
            return Conn;
        }
        public DataTable TaoBang(string Caulenhtruyvan)
        {
            Conn = GetCon(); 
            Comm = new SqlCommand(Caulenhtruyvan, Conn); // Khởi tạo đối tượng SqlCommand với câu lệnh truy vấn và đối tượng SqlConnection
            SqlDataAdapter DT_Ap = new SqlDataAdapter(Comm); // Truyền đối tượng SqlCommand vào đối tượng SqlDataAdapter
            DataTable DT_Ta = new DataTable();
            DT_Ap.Fill(DT_Ta);
            return DT_Ta;
        }
        public void ExcuteNonQuery(string CauLenhCapNhat) // Lay dl
        {
            GetCon();
            Comm = new SqlCommand(CauLenhCapNhat, Conn);
            Comm.ExecuteNonQuery();
        }
        public bool kiemtra(string sql)
        {
            Conn = GetCon();
            Conn.Open();
            Comm = new SqlCommand(sql, Conn);
            int n = (int)Comm.ExecuteScalar();
            Conn.Close();
            if (n > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public string LoadLable(string sql)
        {
            string ketqua = "";
            Conn = GetCon();
            Comm = new SqlCommand(sql, Conn);
            sqlDR = Comm.ExecuteReader();
            while (sqlDR.Read())
            {
                ketqua = sqlDR[0].ToString();
            }
            Conn.Close();
            return ketqua;
        }
        public void LoadLenCombobox(ComboBox cb, string SQL, int chiso)
        {
            cb.Items.Clear();
            Conn = GetCon();
            Comm = new SqlCommand(SQL, Conn);
            sqlDR = Comm.ExecuteReader();
            while (sqlDR.Read())
            {
                cb.Items.Add(sqlDR[chiso].ToString());
            }
            Conn.Close();
        }
        public bool KiemtraUsername(string strsql)
        {
            Conn = GetCon();
            Conn.Open();
            Comm = new SqlCommand(strsql, Conn);
            int tontai = (int)(Comm.ExecuteScalar());
            Conn.Close();
            if (tontai > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
