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
using System.Windows.Forms.Design;
using System.IO;



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
            // Conexion a la base de dato + INSERTANDO UN DETECTOR DE ERROR PARA MOSTRAR ESTATUS DE LA CONEXION A LA BASE DE DATOS

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

            //INSERTANDO UN DETECTOR DE ERROR PARA MOSTRAR ESTATUS DE LA CONEXION A LA BASE DE DATOS
            try
            {
                conn.Open();
                MessageBox.Show("Registrada correctamente");
// Declarando todos los campos para cargar el formulario
                string nom = tbxNombre.Text;
                string apel = tbxApellido.Text;
                string ced = tbxCedula.Text;
                string sex = tbxSexo.Text;
                string sal = tbxSalario.Text;
                string fk_id_cargo = txtfkidcargo.Text;
                string nac = tbxFechanacimiento.Text;
                string ingr = tbxFechaingreso.Text;
                pictureBox1.Image = pictureBox1.Image;
                
                // INGRESANDO DATOS A LA BASE DE DATOS VIA CRUD
                string sql = "insert into empleado(nombre_empleado, apellido_empleado, cedula_empleado, sexo_empleado, salario_empleado, fk_id_cargo, Fecha_ingreso, Fecha_nacimiento, Foto) values('" + nom + "','" + apel + "','" + ced + "','" + sex + "','" + sal + "','" + fk_id_cargo + "','"+nac+"','"+ingr+"') ";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                //frmEmpleado DTGV = new frmEmpleado();
                //DTGV.ShowDialog();
                //this.Enabled = true;

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

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            //LLAMANDO AL FORMULARIO MostrarDatos
            frmEmpleado DTGV = new frmEmpleado();
            DTGV.ShowDialog();
            this.Enabled = true;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
           
        }

        private void txtfkidcargo_TextChanged(object sender, EventArgs e)
        {
            //LLAMANDO AL FORMULARIO Cargo desde el txt fkidcargo
            Cargo krgo = new Cargo();
            krgo.ShowDialog();
            this.Enabled = true;
        }

        //EVENTO DE DOBLE CLICK SOBRE EL LABEL Id_cargo para que muestre un Windows Form y DataGView con todos los cargos. 
        private void label9_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Cargo krgo = new Cargo();
            krgo.ShowDialog();
            this.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)

        {
            pictureBox1.Image = Image.FromFile("user.jpg");

        }

        private void btnCalcularedad_Click(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        
        {
            var ImgEmpleado = pictureBox1;

            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Formatos de imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
               ImgEmpleado.ImageLocation = getImage.FileName;
            }
            else
            {
                MessageBox.Show("Por favor seleccione foto", "Sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}


