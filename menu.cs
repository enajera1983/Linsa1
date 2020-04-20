using System;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace Linsa
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // El formulario se está cerrando. Llamamos al evento
            // Click del control Button1.
            //
            this.Close();

        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Menu.ActiveForm.Visible = false;
            //Users users = new Users();
            //users.Show(); // mostramos el segun formulario
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Users users = new Users();
            users.Show(); // mostramos el segun formulario
        }
    }
}
