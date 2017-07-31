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
            frmEmpleado DTGV = new frmEmpleado();
          
            DTGV.ShowDialog();
            this.Enabled = true;
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
