using System;
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
    // CREANDO EL CRUD PARA LA TABLA DE CARGO

    public partial class Cargo : Form
    {
        public Cargo()
        {
            InitializeComponent();
        }

        private void Cargo_Load(object sender, EventArgs e)
        {
            // CREANDO LA CONEXION A LA BASE DE DATOS
            SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\DB\\nominaCRUD.sqlite");

            // AGREGANDO EL CAPTURADOR DE ERROR
            try
            {
                conn.Open();
                MessageBox.Show("Conexion hecha");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la conexion");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\DB\\nominaCRUD.sqlite");

            {
                conn.Open();
                string IDcargo = txtIdCargo.Text;
                string NameCargo = txtNombrecargo.Text;

                // Sentencia que agrea los datos de nomina a la base de datos
                string sql = "insert into cargo(id_cargo, nombre_cargo) values('" + IDcargo + "','" + NameCargo + "') ";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
    

