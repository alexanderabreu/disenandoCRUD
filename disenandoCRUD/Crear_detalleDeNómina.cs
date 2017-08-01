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
    public partial class Crear_detalleDeNómina : Form
    {
        SQLiteConnection conn = new SQLiteConnection("Data Source=C\\DB\\nominaCRUD.sqlite");

        public Crear_detalleDeNómina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=C\\DB\\nominaCRUD.sqlite");
            try
            {
                conn.Open();
                MessageBox.Show("Registrada correctamente");

                // Declarando todos los campos para cargar el formulario
                string det = txtDetallenomina.Text;
                string ISR = txtDescuentoISR.Text;
                string SS = txtDescuentoSS.Text;
                string OTROS = txtDescuentoOTROS.Text;
                string Tot = TXTtOTALdESCUENTO.Text;
                string fk_id_Empl = txtIdEmpelado.Text;
                string SNet = TXTsALARIOnETO.Text;
                

                // INGRESANDO DATOS A LA BASE DE DATOS VIA CRUD
                string sql = "insert into detalle_nomina(id_detallenomina, ISR_descuento, SS_descuento, OTROS_descuento, total_descuento, salario_neto, fk_id_empleado) values('" + det + "','" + ISR + "','" + SS + "','" + OTROS + "','" + Tot + "','" + fk_id_Empl + "','" + SNet + "') ";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en registro");
            }

            finally
            {

                conn.Close();
            }

        }

        private void txtDescuentoISR_TextChanged(object sender, EventArgs e)
        {
            
           
        }
    }
}
