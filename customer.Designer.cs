using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace Linsa
{
    partial class customer
    {
        private const ErrorBlinkStyle alwaysBlink = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
        private System.Windows.Forms.ErrorProvider errorProvider1;


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer));
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.razon_social = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rfc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.last_name1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.num_int = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.num_ext = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.uso_cfdi = new System.Windows.Forms.ComboBox();
            this.forma_pago = new System.Windows.Forms.ComboBox();
            this.metodo_pago = new System.Windows.Forms.ComboBox();
            this.fecha_creacion = new System.Windows.Forms.DateTimePicker();
            this.fecha_modificacion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.colonia = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.TextBox();
            this.municipio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(22, 37);
            this.nombre.MaxLength = 40;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(128, 20);
            this.nombre.TabIndex = 1;
            this.nombre.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validated);
            // 
            // razon_social
            // 
            this.razon_social.Location = new System.Drawing.Point(22, 76);
            this.razon_social.MaxLength = 120;
            this.razon_social.Name = "razon_social";
            this.razon_social.Size = new System.Drawing.Size(414, 20);
            this.razon_social.TabIndex = 3;
            this.razon_social.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Razon Social";
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(22, 154);
            this.street.MaxLength = 100;
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(244, 20);
            this.street.TabIndex = 5;
            this.street.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validated);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 138);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "Calle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Colonia";
            // 
            // cp
            // 
            this.cp.Location = new System.Drawing.Point(356, 193);
            this.cp.MaxLength = 5;
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(80, 20);
            this.cp.TabIndex = 15;
            this.cp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cp_KeyDown);
            this.cp.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Codigo Postal";
            // 
            // rfc
            // 
            this.rfc.Location = new System.Drawing.Point(22, 115);
            this.rfc.MaxLength = 13;
            this.rfc.Name = "rfc";
            this.rfc.Size = new System.Drawing.Size(100, 20);
            this.rfc.TabIndex = 13;
            this.rfc.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "RFC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fecha Creacion";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(184, 232);
            this.email.MaxLength = 80;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(252, 20);
            this.email.TabIndex = 9;
            this.email.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Correo electronico";
            // 
            // last_name1
            // 
            this.last_name1.Location = new System.Drawing.Point(310, 37);
            this.last_name1.MaxLength = 40;
            this.last_name1.Name = "last_name1";
            this.last_name1.Size = new System.Drawing.Size(126, 20);
            this.last_name1.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Apellido Materno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(128, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Uso CFDI";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(239, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Forma de Pago";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(353, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Metodo de Pago";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(181, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Municipio";
            // 
            // num_int
            // 
            this.num_int.Location = new System.Drawing.Point(283, 154);
            this.num_int.MaxLength = 8;
            this.num_int.Name = "num_int";
            this.num_int.Size = new System.Drawing.Size(64, 20);
            this.num_int.TabIndex = 21;
            this.num_int.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validated);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(280, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Num. Interior";
            // 
            // num_ext
            // 
            this.num_ext.Location = new System.Drawing.Point(369, 154);
            this.num_ext.MaxLength = 8;
            this.num_ext.Name = "num_ext";
            this.num_ext.Size = new System.Drawing.Size(67, 20);
            this.num_ext.TabIndex = 19;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(366, 138);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(70, 13);
            this.label.TabIndex = 18;
            this.label.Text = "Num. Exterior";
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(165, 37);
            this.last_name.MaxLength = 40;
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(131, 20);
            this.last_name.TabIndex = 17;
            this.last_name.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validated);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(162, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Apellido Paterno";
            // 
            // uso_cfdi
            // 
            this.uso_cfdi.FormattingEnabled = true;
            this.uso_cfdi.Items.AddRange(new object[] {
            "Adquisición de mercancias",
            "Devoluciones, descuentos o bonificaciones",
            "Gastos en general",
            "Construcciones",
            "Mobilario y equipo de oficina por inversiones",
            "Equipo de transporte",
            "Equipo de computo y accesorios",
            "Dados, troqueles, moldes, matrices y herramental",
            "Comunicaciones telefónicas",
            "Comunicaciones satelitales",
            "Otra maquinaria y equipo",
            "Honorarios médicos, dentales y gastos hospitalarios.",
            "Gastos médicos por incapacidad o discapacidad",
            "Gastos funerales.",
            "Donativos.",
            "Intereses reales efectivamente pagados por créditos hipotecarios (casa habitación" +
                ").",
            "Aportaciones voluntarias al SAR.",
            "Primas por seguros de gastos médicos.",
            "Gastos de transportación escolar obligatoria.",
            "Depósitos en cuentas para el ahorro, primas que tengan como base planes de pensio" +
                "nes.",
            "Pagos por servicios educativos (colegiaturas)",
            "Por definir"});
            this.uso_cfdi.Location = new System.Drawing.Point(128, 115);
            this.uso_cfdi.MaxLength = 100;
            this.uso_cfdi.Name = "uso_cfdi";
            this.uso_cfdi.Size = new System.Drawing.Size(105, 21);
            this.uso_cfdi.TabIndex = 32;
            this.uso_cfdi.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validated);
            // 
            // forma_pago
            // 
            this.forma_pago.FormattingEnabled = true;
            this.forma_pago.Items.AddRange(new object[] {
            "Efectivo",
            "Cheque nominativo",
            "Transferencia electrónica de fondos",
            "Tarjeta de crédito",
            "Monedero electrónico",
            "Dinero electrónico",
            "Vales de despensa",
            "Dación en pago",
            "Pago por subrogación",
            "Pago por consignación",
            "Condonación",
            "Compensación",
            "Novación",
            "Confusión",
            "Remisión de deuda",
            "Prescripción o caducidad",
            "A satisfacción del acreedor",
            "Tarjeta de débito",
            "Tarjeta de servicios",
            "Aplicación de anticipos",
            "Por definir"});
            this.forma_pago.Location = new System.Drawing.Point(242, 114);
            this.forma_pago.Name = "forma_pago";
            this.forma_pago.Size = new System.Drawing.Size(105, 21);
            this.forma_pago.TabIndex = 33;
            this.forma_pago.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validated);
            // 
            // metodo_pago
            // 
            this.metodo_pago.FormattingEnabled = true;
            this.metodo_pago.Items.AddRange(new object[] {
            "Pago en Parcialidades o diferido",
            "Pago en Una sola Exhibición"});
            this.metodo_pago.Location = new System.Drawing.Point(356, 114);
            this.metodo_pago.MaxLength = 100;
            this.metodo_pago.Name = "metodo_pago";
            this.metodo_pago.Size = new System.Drawing.Size(80, 21);
            this.metodo_pago.TabIndex = 34;
            this.metodo_pago.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validated);
            // 
            // fecha_creacion
            // 
            this.fecha_creacion.CustomFormat = "yyyy\'-\'mm\'-\'dd hh\':\'mm tt\"";
            this.fecha_creacion.Location = new System.Drawing.Point(22, 310);
            this.fecha_creacion.Name = "fecha_creacion";
            this.fecha_creacion.Size = new System.Drawing.Size(128, 20);
            this.fecha_creacion.TabIndex = 35;
            // 
            // fecha_modificacion
            // 
            this.fecha_modificacion.CustomFormat = "yyyy\'-\'mm\'-\'dd hh\':\'mm tt\"";
            this.fecha_modificacion.Location = new System.Drawing.Point(165, 310);
            this.fecha_modificacion.Name = "fecha_modificacion";
            this.fecha_modificacion.Size = new System.Drawing.Size(131, 20);
            this.fecha_modificacion.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Fecha Modificacion";
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(310, 310);
            this.user_name.MaxLength = 45;
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(128, 20);
            this.user_name.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(307, 294);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Usuario";
            // 
            // colonia
            // 
            this.colonia.FormattingEnabled = true;
            this.colonia.Location = new System.Drawing.Point(22, 192);
            this.colonia.Name = "colonia";
            this.colonia.Size = new System.Drawing.Size(156, 21);
            this.colonia.TabIndex = 40;
            this.colonia.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validated);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 215);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Estado";
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(22, 232);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(156, 20);
            this.estado.TabIndex = 44;
            this.estado.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validated);
            // 
            // municipio
            // 
            this.municipio.Location = new System.Drawing.Point(184, 192);
            this.municipio.Name = "municipio";
            this.municipio.Size = new System.Drawing.Size(163, 20);
            this.municipio.TabIndex = 45;
            this.municipio.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validated);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(22, 271);
            this.telefono.MaxLength = 10;
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(156, 20);
            this.telefono.TabIndex = 48;
            this.telefono.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validated);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 255);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "Telefono";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.municipio);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.colonia);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.fecha_modificacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fecha_creacion);
            this.Controls.Add(this.metodo_pago);
            this.Controls.Add(this.forma_pago);
            this.Controls.Add(this.uso_cfdi);
            this.Controls.Add(this.last_name1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.num_int);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.num_ext);
            this.Controls.Add(this.label);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rfc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.street);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.razon_social);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "customer";
            this.Text = "Alta de Clientes";
            this.Load += new System.EventHandler(this.customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox razon_social;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rfc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox last_name1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox num_int;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox num_ext;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox uso_cfdi;
        private System.Windows.Forms.ComboBox forma_pago;
        private System.Windows.Forms.ComboBox metodo_pago;
        private System.Windows.Forms.DateTimePicker fecha_creacion;
        private System.Windows.Forms.DateTimePicker fecha_modificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox colonia;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.TextBox municipio;
        private System.Windows.Forms.Button button1;
        private TextBox telefono;
        private Label label18;
    }
}