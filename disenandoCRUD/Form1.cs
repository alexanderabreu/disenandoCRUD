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
        SQLiteConnection conexion;

        public frmInsertarEmpelado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try

           
            {
                SQLiteConnection conex = new SQLiteConnection("Data Source==C:\\DB\nomina.s3db");

                conex.Open();
                MessageBox.Show("Conexion hecha");
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Hubo un error");
            }

            string nom = this.tbxNombre.Text;
            string apell = this.tbxApellido.Text;
            string ced = this.tbxCedula.Text;
            string sex = this.tbxSexo.Text;
            string nac = this.tbxFechanacimiento.Text;
            string ingr = this.tbxFechaingreso.Text;
            string sal = this.tbxSalario.Text;
            string edad = this.tbxCalcularedad.Text;
            string antig = this.tbxCalcularantiguedad.Text;
            string sql = "INSERT INTO empleado(Nombre,Apellido,Cedula, Sexo, Fecha_nac,Fecha_ingreso,Salario) values('"+nom+"','"+apell+"','"+ced+"','"+sex+"','"+nac+"','"+ingr+"','"+sal+"')";

            SQLiteCommand cmd = new SQLiteCommand(sql, conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
