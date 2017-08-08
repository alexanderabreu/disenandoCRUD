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
    // CREANDO EL CRUD PARA LA TABLA DE CARGO

    public partial class Cargo : Form

    {
        SQLiteConnection conn = new SQLiteConnection();
        public Cargo()
        {
            InitializeComponent();
        }
        private void CargarDatos()

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

            SQLiteDataAdapter da = new SQLiteDataAdapter("Select * from cargo", conn);
            DataTable Tabla = new DataTable("Cargo");
            da.Fill(Tabla);
            DTGVcargo.DataSource = Tabla;
        }

        private void Cargo_Load(object sender, EventArgs e)
        { 

        // CREANDO LA CONEXION A LA BASE DE DATOS
        SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\DB\\nominaCRUD.sqlite");

            // AGREGANDO EL CAPTURADOR DE ERROR
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

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\DB\\nominaCRUD.sqlite");
            try
            {
                conn.Open();
                MessageBox.Show("Cargo ha sido registado con exito");
                CargarDatos(); 
                string IDcargo = txtIdCargo.Text;
                string NameCargo = txtNombrecargo.Text;
              // Sentencia que agrea los datos de nomina a la base de datos
                string sql = "insert into cargo(id_cargo, nombre_cargo) values('" + IDcargo + "','" + NameCargo + "') ";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Error registrando Cargo");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void DTGVcargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\DB\\nominaCRUD.sqlite");
            SQLiteCommand cmd = new SQLiteCommand ("Select * from cargo", conn);

            try
            {

                SQLiteDataAdapter da = new SQLiteDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                DTGVcargo.DataSource = bsource;
                da.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error, favor revise listado de cargo");
            }
            finally
            { 
                conn.Close();
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=C:\\DB\\nominaCRUD.sqlite");
            SQLiteCommand cmd = new SQLiteCommand("Select * from cargo", conn);

            try
            {

                SQLiteDataAdapter da = new SQLiteDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                DTGVcargo.DataSource = bsource;
                da.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error, favor revise listado de cargo");
            }
            finally
            {
                conn.Close();
            }
        }
    }
    }
    

    

