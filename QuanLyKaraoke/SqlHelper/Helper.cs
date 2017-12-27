using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKaraoke.SqlHelper
{
    public class Helper
    {
        public string connection = "";
        public Helper()
        {
            this.connection = GetConnectionString();
        }
        public string GetConnectionString()
        {
            return @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyKaraoke;Integrated Security=True";
            
        }

        public int ExcuteNonQuery(string Procname, params SqlParameter[] procParams)
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            int affectedRow = 0;
            string Paramname = "";
            try
            {
                conn = new SqlConnection(connection);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = Procname;
                cmd.CommandType = CommandType.StoredProcedure;
                if (procParams != null)
                {
                    for (int i = 0; i < procParams.Length; i++)
                    {
                        cmd.Parameters.Add(procParams[i]);
                        Paramname += procParams[i].ParameterName + ":" + procParams[i].Value + "|";
                    }
                }
                affectedRow = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                if (conn != null && conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            return affectedRow;
        }


        public DataSet ExcuteDataSet(string ProcName, params SqlParameter[] procParams)
        {
            SqlConnection conn = null;
            SqlDataAdapter adapter = null;
            DataSet ds = new DataSet();
            SqlCommand cmd = null;
            try
            {
                conn = new SqlConnection(connection);
                cmd = new SqlCommand(ProcName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (procParams != null)
                {
                    for (int i = 0; i < procParams.Length; i++)
                    {
                       procParams[i].ToString();

                        cmd.Parameters.Add(procParams[i]);
                    }
                }
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();

                }
                if (adapter != null)
                {
                    adapter.Dispose();

                }
                if (conn != null && conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            return ds;
        }

        public string ExecuteScalar(string Procname, params SqlParameter[] procParams)
        {
            SqlCommand cmd = null;
            SqlConnection conn = null;
            string affectedRow;
            try
            {
                conn = new SqlConnection(connection);
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = Procname;
                cmd.CommandType = CommandType.StoredProcedure;
                if (procParams != null)
                {
                    for (int i = 0; i < procParams.Length; i++)
                    {
                        cmd.Parameters.Add(procParams[i]);

                    }
                }
                cmd.Parameters.Add(new SqlParameter("@ketqua", SqlDbType.VarChar, 50));
                cmd.Parameters["@ketqua"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                string kq = cmd.Parameters["@ketqua"].Value.ToString();

                return kq;




            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                if (conn != null && conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
#pragma warning disable CS0162 // Unreachable code detected
            return affectedRow;
#pragma warning restore CS0162 // Unreachable code detected
        }



    }
}
