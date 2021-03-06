﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace disenandoCRUD
{
    public class Operacion
    {
        private string cadena = "Data Source=C:\\DB\\nominaCRUD.sqlite";
        public SQLiteConnection cn;

        public void conectar()
        {
            cn = new SQLiteConnection(cadena);

        }
        public Operacion()
        {
            conectar();
        }

        public bool consultarSinResultado(string sql)
        {
            try
            {
                cn.Open();
                SQLiteCommand comando = new SQLiteCommand(sql, cn);
                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;

            }
            finally
            {
                cn.Close();
            }
            return true;
        }

        public DataTable consultar2(string sql)
        {
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cn.Open();
                SQLiteCommand cmd;
                cmd = cn.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (SQLiteException ex)
            {
            }
            finally
            {
                cn.Close();
            }

            return dt;
        }

    }


}

