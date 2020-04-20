using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Linsa
{
    public partial class user_consulta : Form
    {
        public user_consulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = new MySqlConnection();
            MySqlDataAdapter m_datos = new MySqlDataAdapter();
            bd_linsa bd_linsa = new bd_linsa();
            conexionBD = bd_linsa.conexion();
            string consulta = "SELECT  user_name AS 'Usuario',  password AS 'Contraseña',  name AS 'Nombre', last_name AS 'Apellido Paterno', last_name1 AS 'Apellido Materno', email AS 'Correo Electronico', activo AS 'Activo' FROM users";
            m_datos = bd_linsa.select_bd_users(consulta, conexionBD);
            conexionBD.Close();
            DataSet ds = new DataSet();
            m_datos.Fill(ds);
            //ds.Tables.
            //ds.Tables["contraseña"].Columns.IsReadOnly = true;
            //ds.Tables.Columns["nombre"].IsReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["nombre"].ReadOnly = true;
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Update the balance column whenever the value of any cell changes.
            UpdateBalance();
        }

        private void UpdateBalance()
        {
            String nombre;
            int counter;
            for (counter = 1; counter < (dataGridView1.Rows.Count - 1);
                counter++)
            {
                nombre = dataGridView1.Rows[counter - 1].Cells["nombre"].Value.ToString();
            }
        }
    }
}
