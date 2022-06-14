using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;

namespace TNCSDLPT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        public static SqlConnection conn = new SqlConnection();
        public static String connstr = "";
        public static String connstr_publisher = "Data Source=DESKTOP-6O3U2OP;Initial Catalog=TN_CSDLPT;User ID=sa; Password=123";

        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";
        public static String svLogin = "";
        public static String svPass = "";

        public static String database = "TN_CSDLPT";
        public static String remotelogin = "htkn";
        public static String remotepassword = "123";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mCoSo = 0;
        public static BindingSource bds_dspm = new BindingSource();
        public static frmMain frmChinh;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source = " + servername + "; Initial Catalog=TN_CSDLPT;";
                Program.connstr += "User Id= " + Program.mlogin + " ;";
                Program.connstr += "Password= " + Program.password + ";";
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối dữ liệu. \nBạn xem lại username và password. \n" +
                    e.Message);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException e)
            {
                Program.conn.Close();

                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd,conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static int ExecSqlNonQuery(String strLenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strLenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed) conn.Open();

            try
            {
                Sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
                return e.State;
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            frmChinh= new frmMain();
            Application.Run(frmChinh);
        }
    }
}
