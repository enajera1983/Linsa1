using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
//using MySql.Data;
using MySql.Data.MySqlClient;

namespace Linsa
{
    public partial class customer : Form
    {
        //private System.Windows.Forms.ErrorProvider errorProvider1;
        public customer()
        {
            InitializeComponent();

        }

        private void cp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //\r
            string key_press = e.KeyChar.ToString();
            if (e.KeyChar.Equals(Keys.Enter))
            {
                MessageBox.Show("hola");
            }
        }

        private void cp_KeyDown(object sender, KeyEventArgs e)
        {
            //\r
            string key_press = e.KeyCode.ToString();
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (cp.TextLength == 5)
                {
                    MySqlConnection conexionBD = new MySqlConnection();
                    //MySqlDataAdapter m_datos = new MySqlDataAdapter();
                    bd_linsa bd_linsa = new bd_linsa();
                    conexionBD = bd_linsa.conexion();
                    ArrayList datos = new ArrayList();
                    string consulta = "SELECT * FROM codigo_postal WHERE cp = '" + cp.Text.ToString() + "'";
                    datos = bd_linsa.select_bd_cp(consulta, conexionBD);
                    conexionBD.Close();
                    colonia.Items.Clear();
                    municipio.Text = "";
                    estado.Text = "";
                    foreach (Object[] row in datos)
                    {
                        colonia.Items.Add(row[5].ToString());
                        String edo = row[7].ToString();
                        String mpio = row[6].ToString();
                        municipio.Text = mpio.ToString();
                        estado.Text = edo.ToString();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool procesar = validate_field();
            if (procesar == true)
            {
                MySqlConnection conexionBD = new MySqlConnection();
                bd_linsa bd_Linsa = new bd_linsa();
                String uso_cfdi_id = get_uso_cfid();
                String metodo_pago_id = get_metodo_pago();
                String forma_pago_id = get_forma_de_pago();
                String 
                insert_bd = "INSERT INTO logis236_linsa.customers(nombre, razon_social, last_name, last_name1, street, num_ext, num_int, colonia, cp, municipio, estado, telefono, rfc, usocfdi," +
                            "forma_de_pago, metodo_de_pago, correo, fecha_creacion, fecha_modificacion, user_name)VALUES('" + nombre.Text.ToString() + "', '" + razon_social.Text.ToString() + "'," +
                            "'" + last_name.Text.ToString() + "', '" + last_name1.Text.ToString() + "', '" + street.Text.ToString() + "', '" + num_ext.Text.ToString() + "', '" + num_int.Text.ToString() +
                            "', '" + colonia.SelectedItem.ToString() + "', '" + cp.Text.ToString() + "', '" + municipio.Text.ToString() + "', '" + estado.Text.ToString() + "', '" +
                            telefono.Text.ToString() + "', '" + rfc.Text.ToString() + "', '" + uso_cfdi_id + "', '" + forma_pago_id + "', '" + metodo_pago_id + "', '" + email.Text.ToString() + "', '" +
                            fecha_creacion.Value.ToString() + "', '" + fecha_modificacion.Value.ToString() + "', 'enajera');";
            }
        }

        private string get_forma_de_pago()
        {
            //throw new NotImplementedException();
            String forma_pago_id = "";
            if (forma_pago.SelectedItem == "Efectivo")
            {
                forma_pago_id = "01";
            }
            if (forma_pago.SelectedItem == "Cheque nominativo")
            {
                forma_pago_id = "02";
            }
            if (forma_pago.SelectedItem == "Transferencia electrónica de fondos")
            {
                forma_pago_id = "03";
            }
            if (forma_pago.SelectedItem == "Tarjeta de crédito")
            {
                forma_pago_id = "04";
            }
            if (forma_pago.SelectedItem == "Monedero electrónico")
            {
                forma_pago_id = "05";
            }
            if (forma_pago.SelectedItem == "Dinero electrónico")
            {
                forma_pago_id = "06";
            }
            if (forma_pago.SelectedItem == "Vales de despensa")
            {
                forma_pago_id = "08";
            }
            if (forma_pago.SelectedItem == "Dación en pago")
            {
                forma_pago_id = "12";
            }
            if (forma_pago.SelectedItem == "Pago por subrogación")
            {
                forma_pago_id = "13";
            }
            if (forma_pago.SelectedItem == "Pago por consignación")
            {
                forma_pago_id = "14";
            }
            if (forma_pago.SelectedItem == "Condonación")
            {
                forma_pago_id = "15";
            }
            if (forma_pago.SelectedItem == "Compensación")
            {
                forma_pago_id = "17";
            }
            if (forma_pago.SelectedItem == "Novación")
            {
                forma_pago_id = "23";
            }
            if (forma_pago.SelectedItem == "Confusión")
            {
                forma_pago_id = "24";
            }
            if (forma_pago.SelectedItem == "Remisión de deuda")
            {
                forma_pago_id = "25";
            }
            if (forma_pago.SelectedItem == "Prescripción o caducidad")
            {
                forma_pago_id = "26";
            }
            if (forma_pago.SelectedItem == "A satisfacción del acreedor")
            {
                forma_pago_id = "27";
            }
            if (forma_pago.SelectedItem == "Tarjeta de débito")
            {
                forma_pago_id = "28";
            }
            if (forma_pago.SelectedItem == "Tarjeta de servicios")
            {
                forma_pago_id = "29";
            }
            if (forma_pago.SelectedItem == "Aplicación de anticipos")
            {
                forma_pago_id = "30";
            }
            if (forma_pago.SelectedItem == "Por definir")
            {
                forma_pago_id = "99";
            }
            return forma_pago_id;
        }

        private string get_metodo_pago()
        {
            //throw new NotImplementedException();
            string metodo_pago_id = "";
            if (metodo_pago.SelectedItem == "Pago en Parcialidades o diferido")
            {
                metodo_pago_id = "PPD";
            }
            if (metodo_pago.SelectedItem == "Pago en Una sola Exhibición")
            {
                metodo_pago_id = "PUE";
            }
            return metodo_pago_id;
        }

        private string get_uso_cfid()
        {
            String uso_cfdi_id = "";
            if (uso_cfdi.SelectedItem == "Adquisición de mercancias")
            {
                uso_cfdi_id = "G01";
            }
            if (uso_cfdi.SelectedItem == "Devoluciones, descuentos o bonificaciones")
            {
                uso_cfdi_id = "G02";
            }
            if (uso_cfdi.SelectedItem == "Gastos en general")
            {
                uso_cfdi_id = "G03";
            }
            if (uso_cfdi.SelectedItem == "Construcciones")
            {
                uso_cfdi_id = "I01";
            }
            if (uso_cfdi.SelectedItem == "Mobilario y equipo de oficina por inversiones")
            {
                uso_cfdi_id = "I02";
            }
            if (uso_cfdi.SelectedItem == "Equipo de transporte")
            {
                uso_cfdi_id = "I03";
            }
            if (uso_cfdi.SelectedItem == "Equipo de computo y accesorios")
            {
                uso_cfdi_id = "I04";
            }
            if (uso_cfdi.SelectedItem == "Dados, troqueles, moldes, matrices y herramental")
            {
                uso_cfdi_id = "I05";
            }
            if (uso_cfdi.SelectedItem == "Comunicaciones telefónicas")
            {
                uso_cfdi_id = "I06";
            }
            if (uso_cfdi.SelectedItem == "Comunicaciones satelitales")
            {
                uso_cfdi_id = "I07";
            }
            if (uso_cfdi.SelectedItem == "Otra maquinaria y equipo")
            {
                uso_cfdi_id = "I08";
            }
            if (uso_cfdi.SelectedItem == "Honorarios médicos, dentales y gastos hospitalarios.")
            {
                uso_cfdi_id = "D01";
            }
            if (uso_cfdi.SelectedItem == "Gastos médicos por incapacidad o discapacidad")
            {
                uso_cfdi_id = "D02";
            }
            if (uso_cfdi.SelectedItem == "Gastos funerales.")
            {
                uso_cfdi_id = "D03";
            }
            if (uso_cfdi.SelectedItem == "Donativos.")
            {
                uso_cfdi_id = "D04";
            }
            if (uso_cfdi.SelectedItem == "Intereses reales efectivamente pagados por créditos hipotecarios (casa habitación).")
            {
                uso_cfdi_id = "D05";
            }
            if (uso_cfdi.SelectedItem == "Aportaciones voluntarias al SAR.")
            {
                uso_cfdi_id = "D06";
            }
            if (uso_cfdi.SelectedItem == "Primas por seguros de gastos médicos.")
            {
                uso_cfdi_id = "D07";
            }
            if (uso_cfdi.SelectedItem == "Gastos de transportación escolar obligatoria.")
            {
                uso_cfdi_id = "D08";
            }
            if (uso_cfdi.SelectedItem == "Depósitos en cuentas para el ahorro, primas que tengan como base planes de pensiones.")
            {
                uso_cfdi_id = "D09";
            }
            if (uso_cfdi.SelectedItem == "Pagos por servicios educativos (colegiaturas)")
            {
                uso_cfdi_id = "D10";
            }
            if (uso_cfdi.SelectedItem == "Por definir")
            {
                uso_cfdi_id = "P01";
            }
            return uso_cfdi_id;
            //throw new NotImplementedException();
        }

        private void customer_Load(object sender, EventArgs e)
        {
            errorProvider1.ContainerControl = this;
        }

        private void textbox_Validated(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //throw new NotImplementedException();
            validate_field();
        }

        private void init_Validated()
        {
            errorProvider1.SetError(this.nombre, String.Empty);
            errorProvider1.SetError(this.last_name, String.Empty);
            errorProvider1.SetError(this.razon_social, String.Empty);
            errorProvider1.SetError(this.uso_cfdi, String.Empty);
            errorProvider1.SetError(this.forma_pago, String.Empty);
            errorProvider1.SetError(this.metodo_pago, String.Empty);
            errorProvider1.SetError(this.street, String.Empty);
            errorProvider1.SetError(this.num_int, String.Empty);
            errorProvider1.SetError(this.colonia, String.Empty);
            errorProvider1.SetError(this.municipio, String.Empty);
            errorProvider1.SetError(this.cp, String.Empty);
            errorProvider1.SetError(this.estado, String.Empty);
            errorProvider1.SetError(this.email, String.Empty);
            errorProvider1.SetError(this.telefono, String.Empty);
            errorProvider1.SetError(this.rfc, String.Empty);
        }

        private bool validate_field()
        {
            bool band = true;
            init_Validated();
            if (string.IsNullOrEmpty(this.nombre.Text.ToString()))
            {
                errorProvider1.SetError(this.nombre, "Es requerido.");
                band = false;
            }
            if (string.IsNullOrEmpty(this.last_name.Text.ToString()))
            {
                errorProvider1.SetError(this.last_name, "Es requerido.");
                band = false;
            }
            if (string.IsNullOrEmpty(this.telefono.Text.ToString()))
            {
                errorProvider1.SetError(this.telefono, "Es requerido.");
                band = false;
            }
            if (string.IsNullOrEmpty(this.razon_social.Text.ToString()))
            {
                errorProvider1.SetError(this.razon_social, "Es requerido.");
                band = false;
            }
            if (string.IsNullOrEmpty(this.rfc.Text.ToString()))
            {
                errorProvider1.SetError(this.rfc, "Es requerido.");
                band = false;
            }
            if (this.uso_cfdi.SelectedItem == null)
            {
                errorProvider1.SetError(this.uso_cfdi, "Es requerido.");
                band = false;
            }
            if (this.forma_pago.SelectedItem == null)
            {
                errorProvider1.SetError(this.forma_pago, "Es requerido.");
                band = false;
            }
            if (this.metodo_pago.SelectedItem == null)
            {
                errorProvider1.SetError(this.metodo_pago, "Es requerido.");
                band = false;
            }
            if (string.IsNullOrEmpty(this.street.Text.ToString()))
            {
                errorProvider1.SetError(this.street, "Es requerido.");
                band = false;
            }
            if (string.IsNullOrEmpty(this.num_int.Text.ToString()))
            {
                errorProvider1.SetError(this.num_int, "Es requerido.");
                band = false;
            }
            if (this.colonia.SelectedItem == null)
            {
                errorProvider1.SetError(this.colonia, "Es requerido.");
                band = false;
            }
            if (string.IsNullOrEmpty(this.municipio.Text.ToString()))
            {
                errorProvider1.SetError(this.municipio, "Es requerido.");
                band = false;
            }
            if (string.IsNullOrEmpty(this.cp.Text.ToString()))
            {
                errorProvider1.SetError(this.cp, "Es requerido.");
                band = false;
            }
            if (string.IsNullOrEmpty(this.estado.Text.ToString()))
            {
                errorProvider1.SetError(this.estado, "Es requerido.");
                band = false;
            }
            if (string.IsNullOrEmpty(this.email.Text.ToString()))
            {
                errorProvider1.SetError(this.email, "Es requerido.");
                band = false;
            }

            return band;
        }
    }
}
