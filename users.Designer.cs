namespace Linsa
{
    partial class Users
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.TextBox();
            this.last_name1 = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.activo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Paterno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido Materno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Correo Electronico";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Activo";
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(16, 29);
            this.user_name.MaxLength = 50;
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(210, 20);
            this.user_name.TabIndex = 7;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(15, 64);
            this.password.MaxLength = 50;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(211, 20);
            this.password.TabIndex = 8;
            this.password.UseSystemPasswordChar = true;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(15, 100);
            this.name.MaxLength = 50;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(211, 20);
            this.name.TabIndex = 9;
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(16, 139);
            this.last_name.MaxLength = 50;
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(210, 20);
            this.last_name.TabIndex = 10;
            // 
            // last_name1
            // 
            this.last_name1.Location = new System.Drawing.Point(15, 182);
            this.last_name1.MaxLength = 50;
            this.last_name1.Name = "last_name1";
            this.last_name1.Size = new System.Drawing.Size(211, 20);
            this.last_name1.TabIndex = 11;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(15, 224);
            this.email.MaxLength = 120;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(211, 20);
            this.email.TabIndex = 12;
            // 
            // activo
            // 
            this.activo.FormattingEnabled = true;
            this.activo.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.activo.Location = new System.Drawing.Point(16, 263);
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(121, 21);
            this.activo.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.activo);
            this.Controls.Add(this.email);
            this.Controls.Add(this.last_name1);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.name);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Users";
            this.Text = "Logistica Integral Najera SA de CV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.TextBox last_name1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.ComboBox activo;
        private System.Windows.Forms.Button button1;
    }
}