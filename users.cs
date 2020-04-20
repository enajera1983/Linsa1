using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Linsa
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {

            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = new MySqlConnection();
            bd_linsa bd_linsa = new bd_linsa();
            conexionBD = bd_linsa.conexion();
            string activo_user;
            if (this.activo.Text == "Activo") {
                activo_user = "X";
            } else {
                activo_user = "";
            }
            //INSERT INTO `logis236_linsa`.`users` (`user_name`, `password`, `name`) VALUES('enajera', 'Nage1984#', 'enrique');
            string consulta = "INSERT INTO users (user_name,password,name,last_name,last_name1,email,activo) VALUES ('" + this.user_name.Text +"','" + this.password.Text + "','" + this.name.Text + "','" + this.last_name.Text + "','" + this.last_name1.Text + "','" + this.email.Text + "','" + activo_user +"')";
            string datos = bd_linsa.insert_bd(consulta, conexionBD);
            if (string.IsNullOrEmpty(datos)){
                MessageBox.Show("Agregado Exitosamente");
            }
            else
            {
                MessageBox.Show(datos);
            }
            //MessageBox.Show(datos);
            //Users.ActiveForm.Close();
        }
    }
}
