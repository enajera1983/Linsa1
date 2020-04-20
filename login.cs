using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Linsa
{
    public partial class login : Form
    {
        //private MySqlConnection connection;
        public login()
        {
            InitializeComponent();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(user.Text) && string.IsNullOrEmpty(password.Text.ToString()))
            {
                MessageBox.Show("Ingrese Usuario/Contraseña son obligatorios.");
            }
            else
            {
                //Instancia para conexión a MySQL, recibe la cadena de conexión
                MySqlConnection conexionBD = new MySqlConnection();
                bd_linsa bd_linsa = new bd_linsa();
                conexionBD = bd_linsa.conexion();
                //MySqlDataReader reader = null; //Variable para leer el resultado de la consulta

                //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.
                try
                {
                    //Consulta a MySQL (Muestra las bases de datos que tiene el servidor)
                    string consulta = "SELECT * FROM users WHERE user_name = '" + this.user.Text + "' AND password = '" + this.password.Text + "'";
                    string datos = bd_linsa.select_bd(consulta, conexionBD);
                    conexionBD.Close(); //Cierra la conexión a MySQL
                    //MessageBox.Show(datos); //Imprime en cuadro de dialogo el resultado
                    if (datos == this.user.Text)
                    {

                        Program.OpenMDI = true;
                        this.Close();
                        //MDIParent1 mDIParent1 = new MDIParent1();
                        //mDIParent1.MdiParent = this;
                        //mDIParent1.Show(); // mostramos el segun formulario
                        //login.ActiveForm.Close();
                        //login. childForm.Close();
                        //MDIParent1 mDIParent1 = new MDIParent1();
                        //mDIParent1.
                        //mDIParent1.Show();

                        //Menu menu = new Menu();
                        //menu.Show(); // mostramos el segun formulario
                        //main_control main_Control = new main_control();
                        //main_control.
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña incorrecta");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message); //Si existe un error aquí muestra el mensaje
                }
                //finally
                //{
                //    conexionBD.Close(); //Cierra la conexión a MySQL
                //}
            }
            }
        }
    }
