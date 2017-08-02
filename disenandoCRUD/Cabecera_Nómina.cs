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

            //SQLiteConnection conn = new SQLiteConnection();
            //DataTable dgvdatos = new DataTable("select * from detalle_nomina inner join cabecera_nomina,cargo where detalle_id = '" + txtidcn.Text + "' and nomina_id = '" + txtidcn.Text + "' and cargo_id = '" + txtidcn.Text + "' ");
            //foreach (DataRow dr in dgvdatos.Rows)

            //string IDnomina, Mes, Ano, ISR, SS, Otros, tot_ISR, tot_SS, tot_Otros, t_dedu, sueld, empl_id;
            //IDnomina = dr["nomina_id"].ToString();
            //                                              //*pendiente a completar


        }
        

        // Sentencia para agregar Registro de nomina; se agregan todos los campos solicitados y se hace click en en Guardar.

        private void btnGuardarNomina_Click(object sender, EventArgs e)
        {
            //Realizando la conexion a la base de datos

            SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\DB\\nominaCRUD.sqlite");
            try
            { 
            conn.Open(); // Con este comando se abre la conexion
                MessageBox.Show("Nomina agregada con exito");
            
                //Cargando informacion al formulario
                string idnomina = txtIDnomina.Text;
                string mes = cbxMes.Text;
                string ano = cbxAño.Text;
                string empres = txtNokmbreempresa.Text;

                // Sentencia que agrea los datos de nomina a la base de datos
                string sql = "insert into nomina(id_nomina, mes, ano, nombre_empresa) values('" + idnomina + "','" + mes + "','" + ano + "','" + empres + "') ";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar nomina");
                  
            }
            finally
            {
                conn.Close(); // Cerrando la conexion a la base de datos
            }
        }

        // Codigo para eliminar Registro de nomina; se agrega el ID de nomina y se hace click en Eliminar.
        private void button1_Click(object sender, EventArgs e)
        {
            //Realizando la conexion a la base de datos
            SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\DB\\nominaCRUD.sqlite");

            try // Agregando capturador de error en caso de que se presente error al intentar eliminar un registro.
            {
                conn.Open(); // Abriendo la conexion
                MessageBox.Show("Nomina agregada con exito");

                string idnomina = txtIDnomina.Text;
                string mes = cbxMes.Text;
                string ano = cbxAño.Text;
                string empres = txtNokmbreempresa.Text;

                //Sentencia para eliminar
                string sql = "DELETE FROM nomina where id=='"+txtIDnomina+"' ";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar nomina");

            }
            finally
            {
                conn.Close(); // Cerrando la conexion a la base de datos
            }
        }
    }
    }

