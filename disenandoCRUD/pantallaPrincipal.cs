using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace disenandoCRUD
{
    public partial class pantallaPrincipal : Form
    {
        public pantallaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cargando los datos en el Data Grid View ... Aqui se muetran los datos de la base de datos en el Data Grid View.
            frmEmpleado DTGV = new frmEmpleado();
          
            DTGV.ShowDialog();
            this.Enabled = true;
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Cargando los datos en el Data Grid View ... Aqui se muetran los datos de la base de datos en el Data Grid View.

            Crear_detalleDeNómina fact = new Crear_detalleDeNómina();
            fact.ShowDialog();
            this.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Cargando los datos en el Data Grid View ... Aqui se muetran los datos de la base de datos en el Data Grid View.

            Cabecera_Nómina cabecerra = new Cabecera_Nómina();
            cabecerra.ShowDialog();
            this.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cargo kRGO = new Cargo();
            kRGO.ShowDialog();
            this.Enabled = true;
        }
    }
}
