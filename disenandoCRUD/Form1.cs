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
    public partial class frmInsertarEmpelado : Form
    {
      
        public frmInsertarEmpelado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                                // Conexion a la base de dato
                                
            SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\DB\\nominaCRUD.sqlite");
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

    
                   // Insertar datos a la base de datos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\DB\\nominaCRUD.sqlite");

            try
            {
                conn.Open();
                MessageBox.Show("Registrada correctamente");

                string nom = tbxNombre.Text;
                string apel = tbxApellido.Text;
                string ced = tbxCedula.Text;
                string sex = tbxSexo.Text;
                string sal = tbxSalario.Text;
                string fk_id_cargo = txtfkidcargo.Text;
                string nac = tbxFechanacimiento.Text;
                string ingr = tbxFechaingreso.Text;

                string sql = "insert into empleado(nombre_empleado, apellido_empleado, cedula_empleado, sexo_empleado, salario_empleado, fk_id_cargo, Fecha_ingreso, Fecha_nacimiento) values('" + nom + "','" + apel + "','" + ced + "','" + sex + "','" + sal + "','" + fk_id_cargo + "','"+nac+"','"+ingr+"') ";
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
                
             
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


