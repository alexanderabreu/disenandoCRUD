using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace disenandoCRUD
{

    public class operacion
    {
        private string conn = ("Data Source=C:\\DB\\nominaCRUD.sqlite");
        public SQLiteConnection cn;
        private SQLiteCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SQLiteDataAdapter da;
        public SQLiteCommand comando;

        public void conectar()
        {
            cn = new SQLiteConnection(conn);

        }
        public void conx()
        {
            conectar();
        }

        public void consultar(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new SQLiteDataAdapter(sql, cn);
            cmb = new SQLiteCommandBuilder(da);
            da.Fill(ds, tabla);
        }

        //Codigo para para eliminar datos

        public bool eliminar(string tabla, string condicion)
        {
            cn.Open();
            string sql = "delete from " + tabla + " where " + condicion;
            comando = new SQLiteCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //Codigo para actualizar
        public bool actualizar(string tabla, string campos, string condicion)
        {
            cn.Open();
            string sql = "update" + tabla + "set" + "where" + condicion;
            comando = new SQLiteCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Clone();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable consultar2(string tabla)
        {
            string sql = "select * from " + tabla;
            da = new SQLiteDataAdapter(sql, cn);
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];
            return dt;



        }
        // Codigo para insertar los datos en la nomina
        public bool insertar(string sql)
        {
            cn.Open();
            comando = new SQLiteCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}