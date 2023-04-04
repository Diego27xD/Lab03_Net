namespace Lab03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtServidor = new TextBox();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            txtBaseDatos = new TextBox();
            chkAutenticacion = new CheckBox();
            btnConectar = new Button();
            btnDesconectar = new Button();
            btnEstado = new Button();
            btnPersona = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 93);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Servidor";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 190);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 190);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "Base de datos";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(381, 93);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "Usuario";
            // 
            // txtServidor
            // 
            txtServidor.Location = new Point(63, 127);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(188, 23);
            txtServidor.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Enabled = false;
            txtPassword.Location = new Point(381, 221);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(188, 23);
            txtPassword.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Enabled = false;
            txtUsuario.Location = new Point(381, 127);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(188, 23);
            txtUsuario.TabIndex = 6;
            // 
            // txtBaseDatos
            // 
            txtBaseDatos.Location = new Point(63, 221);
            txtBaseDatos.Name = "txtBaseDatos";
            txtBaseDatos.Size = new Size(188, 23);
            txtBaseDatos.TabIndex = 7;
            // 
            // chkAutenticacion
            // 
            chkAutenticacion.AutoSize = true;
            chkAutenticacion.Checked = true;
            chkAutenticacion.CheckState = CheckState.Checked;
            chkAutenticacion.Location = new Point(63, 278);
            chkAutenticacion.Name = "chkAutenticacion";
            chkAutenticacion.Size = new Size(153, 19);
            chkAutenticacion.TabIndex = 8;
            chkAutenticacion.Text = "Autenticacion integrada";
            chkAutenticacion.UseVisualStyleBackColor = true;
            chkAutenticacion.CheckedChanged += chkAutenticacion_CheckedChanged;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(141, 328);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 9;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Enabled = false;
            btnDesconectar.Location = new Point(421, 328);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(82, 23);
            btnDesconectar.TabIndex = 10;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // btnEstado
            // 
            btnEstado.Location = new Point(280, 328);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(75, 23);
            btnEstado.TabIndex = 11;
            btnEstado.Text = "Estado";
            btnEstado.UseVisualStyleBackColor = true;
            btnEstado.Click += btnEstado_Click;
            // 
            // btnPersona
            // 
            btnPersona.Location = new Point(278, 379);
            btnPersona.Name = "btnPersona";
            btnPersona.Size = new Size(75, 23);
            btnPersona.TabIndex = 12;
            btnPersona.Text = "Personas";
            btnPersona.UseVisualStyleBackColor = true;
            btnPersona.Click += btnPersona_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 450);
            Controls.Add(btnPersona);
            Controls.Add(btnEstado);
            Controls.Add(btnDesconectar);
            Controls.Add(btnConectar);
            Controls.Add(chkAutenticacion);
            Controls.Add(txtBaseDatos);
            Controls.Add(txtUsuario);
            Controls.Add(txtPassword);
            Controls.Add(txtServidor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtServidor;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private TextBox txtBaseDatos;
        private CheckBox chkAutenticacion;
        private Button btnConectar;
        private Button btnDesconectar;
        private Button btnEstado;
        private Button btnPersona;
    }
}