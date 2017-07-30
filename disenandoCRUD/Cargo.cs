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
    public partial class Cargo : Form
    {
        public Cargo()
        {
            InitializeComponent();
        }

        private void Cargo_Load(object sender, EventArgs e)
        {
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
    }
    }

