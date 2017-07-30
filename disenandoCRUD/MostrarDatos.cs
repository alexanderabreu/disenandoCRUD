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
    public partial class frmEmpleado : Form
    {
        SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\DB\\nominaCRUD.sqlite");
        

        public frmEmpleado()
        {
            
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

          
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmInsertarEmpelado crear = new frmInsertarEmpelado();
            crear.ShowDialog(); 
            this.Enabled = true;
        
        }
    }
}
