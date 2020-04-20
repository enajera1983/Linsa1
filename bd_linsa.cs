using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Linsa
{
    class bd_linsa
    {
        public MySqlConnection conexion()
        {
            string servidor = "logisticaintegralnajera.com.mx"; //Nombre o ip del servidor de MySQL
            string bd = "logis236_linsa"; //Nombre de la base de datos
            string usuario = "logis236_linsa"; //Usuario de acceso a MySQL
            string password = "Linsa2020#"; //Contraseña de usuario de acceso a MySQL
            //string datos = null; //Variable para almacenar el resultado

            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "; CharSet=utf8";

            //Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

            return conexionBD;
        }

        public string select_bd(string consulta, MySqlConnection conexionBD)
        {
            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta
            string datos = null;
            MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
            //return comando;

            //MySqlCommand comando = new MySqlCommand(); //Declaración SQL para ejecutar contra una base de datos MySQL
            //comando = bd_linsa.select_bd(consulta);
            comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
            conexionBD.Open(); //Abre la conexión
            reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader

            while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
            {
                datos += reader.GetString(0); // + "\n"; //Almacena cada registro con un salto de linea
            }
            return datos;
        }

        public MySqlDataAdapter select_bd_users(string consulta, MySqlConnection conexionBD)
        {
            //MySqlDataReader reader = null; //Variable para leer el resultado de la consulta
            //string datos = null;
            MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
            //return comando;

            //MySqlCommand comando = new MySqlCommand(); //Declaración SQL para ejecutar contra una base de datos MySQL
            //comando = bd_linsa.select_bd(consulta);
            comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
            conexionBD.Open(); //Abre la conexión
            MySqlDataAdapter m_datos = new MySqlDataAdapter(comando);
            //ds = new DataSet();
            //m_datos.Fill(ds);
            //reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader
            return m_datos;
        }

        public string insert_bd(string insert_query, MySqlConnection conexionBD)
        {
            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta
            string datos = null;
            MySqlCommand comando = new MySqlCommand(insert_query); //Declaración SQL para ejecutar contra una base de datos MySQL
            //INSERT INTO `logis236_linsa`.`users` (`user_name`, `password`, `name`) VALUES('enajera', 'Nage1984#', 'enrique');
            comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
            try { 
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader
                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    datos += reader.GetString(0); // + "\n"; //Almacena cada registro con un salto de linea
                }
                return datos;
            }  
            catch (Exception ex)  
            {
                //MessageBox.Show(ex.Message);  
                return ex.Message;
            }
            //return datos;
        }

        public ArrayList select_bd_cp(string consulta, MySqlConnection conexionBD)
        {
            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta
            //string[] datos = null;
            ArrayList datos = new ArrayList();
            MySqlCommand comando = new MySqlCommand(consulta); //Declaración SQL para ejecutar contra una base de datos MySQL
            //return comando;

            //MySqlCommand comando = new MySqlCommand(); //Declaración SQL para ejecutar contra una base de datos MySQL
            //comando = bd_linsa.select_bd(consulta);
            comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
            conexionBD.Open(); //Abre la conexión
            reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader
            //object[] values = null;
            while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
            {

                Object[] values = new Object[reader.FieldCount];
                reader.GetValues(values);
                datos.Add(values);
            }
            return datos;
        }

        public string insert_bd_customers(string insert_query, MySqlConnection conexionBD)
        {
            MySqlDataReader reader = null; //Variable para leer el resultado de la consulta
            string datos = null;
            MySqlCommand comando = new MySqlCommand(insert_query); //Declaración SQL para ejecutar contra una base de datos MySQL
            //INSERT INTO `logis236_linsa`.`users` (`user_name`, `password`, `name`) VALUES('enajera', 'Nage1984#', 'enrique');
            comando.Connection = conexionBD; //Establece la MySqlConnection utilizada por esta instancia de MySqlCommand
            try
            {
                conexionBD.Open(); //Abre la conexión
                reader = comando.ExecuteReader(); //Ejecuta la consulta y crea un MySqlDataReader
                while (reader.Read()) //Avanza MySqlDataReader al siguiente registro
                {
                    datos += reader.GetString(0); // + "\n"; //Almacena cada registro con un salto de linea
                }
                return datos;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);  
                return ex.Message;
            }
            //return datos;
        }
    }
}
