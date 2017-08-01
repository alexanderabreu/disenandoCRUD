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
        SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\DB\\nominaCRUD.sqlite");

        public Crear_detalleDeNómina()
        {
            InitializeComponent();
        }

        // Declarando una clase privada para la carga automatica de los detalles de nomina.
        private void cargarnomina()
        {
            conn.Open();  // Abro la conexion a la base de datos
            SQLiteDataAdapter da = new SQLiteDataAdapter("Select * from detalle_nomina", conn);
            DataTable dt = new DataTable("detalle_nomina");
            da.Fill(dt);
            DTGVDetalleNomina.DataSource = dt;
            conn.Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\DB\\nominaCRUD.sqlite");

            //CAPTURADOR DE ERROR SI AL INGRESAR DATOS SE PRODUCE UN ERROR
            try
            {
                conn.Open();  // Abro la conexion a la base de datos
                MessageBox.Show("Nomina registrada correctamente");

                // Declarando todos los campos para cargar el formulario
                string det = txtDetallenomina.Text;
                string ISR = txtISR.Text;
                string SS = txtSS.Text;
                string OTROS = txtOTROS.Text;
                string Tot = TXTtOTALdESCUENTO.Text;
                string fk_id_Empl = txtIdEmpelado.Text;
                string SNet = TXTsALARIOnETO.Text;


                // INGRESANDO DATOS A LA BASE DE DATOS VIA CRUD
                string sql = "insert into detalle_nomina(id_detallenomina, ISR_descuento, SS_descuento, OTROS_descuento, total_descuento, salario_neto, fk_id_empleado) values('" + det + "','" + ISR + "','" + SS + "','" + OTROS + "','" + Tot + "','" + fk_id_Empl + "','" + SNet + "') ";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
                cargarnomina(); // MUESTRA EL DETALLE DE NOMINA EN LA DATA GRID VIEW "DetalleNomina".


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en registro"); //CAPTURADOR DE ERROR SI AL INGRESAR DATOS SE PRODUCE UN ERROR
            }

            finally
            {

                conn.Close();
            }

        }


        private void txtDescuentoISR_TextChanged(object sender, EventArgs e)
        {


        }

        private void Crear_detalleDeNómina_Load(object sender, EventArgs e)
        {
            // ESTABLECIENDO CONEXION A LA BASE DE DATOS INMEDIATAMENTE SE CARGA EL FORMULARIO.

            SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\DB\\nominaCRUD.sqlite");
            try
            {
                conn.Open(); // Abro la conexion a la base de datos
                MessageBox.Show("Conexion hecha");
                cargarnomina();
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

        private void btnEliminarNomina_Click(object sender, EventArgs e)
        {
            // ESTABLECIENDO CONEXION A LA BASE DE DATOS INMEDIATAMENTE SE CARGA EL FORMULARIO.

            SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\DB\\nominaCRUD.sqlite");
            try
            {
                conn.Open(); // Abro la conexion a la base de datos
                MessageBox.Show("Detalle de nomina eliminada existosamente");

                //Declarando todos los campos para cargar el formulario
                string det = txtDetallenomina.Text;
                string ISR = txtISR.Text;
                string SS = txtSS.Text;
                string OTROS = txtOTROS.Text;
                string Tot = TXTtOTALdESCUENTO.Text;
                string fk_id_Empl = txtIdEmpelado.Text;
                string SNet = TXTsALARIOnETO.Text;


                // INGRESANDO DATOS A LA BASE DE DATOS VIA CRUD
                string sql = "delete from detalle_nomina where id_detallenomina='" + txtDetallenomina + "'";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error eliminando registro");
            }

            finally
            {

                conn.Close();
            }
        }


        private void DTGVDetalleNomina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\DB\\nominaCRUD.sqlite");
                conn.Open();
                MessageBox.Show("Conexion hecha");
                cargarnomina();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Error de conexion");
            }
        }
    }
}

