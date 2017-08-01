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
    public partial class Cabecera_Nómina : Form
    {
        public Cabecera_Nómina()
        {
            InitializeComponent();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          


              

            
        }

        private void btnGuardarNomina_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\DB\\nominaCRUD.sqlite");
            try
            { 
            conn.Open();
                MessageBox.Show("Nomina agregada con exito");
            string empres = txtNokmbreempresa.Text;
            string idnomina = txtIdDetalleNomina.Text;
            string fini = DTPInicio.Text;
            string final = DTPFinal.Text;

            
            string sql = "insert into nomina(id_nomina, fecha_inicio, fecha_final,  nombre_empresa) values('" + idnomina + "','" + fini + "','" + final + "','" + empres + "') ";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar nomina");
                  
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
