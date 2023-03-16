namespace Ejercicio_3
{
    partial class Modificar_Usuario
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
            this.btnVerDatos = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.CmvEstado = new System.Windows.Forms.ComboBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.cmvUsuarios = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerDatos
            // 
            this.btnVerDatos.Location = new System.Drawing.Point(356, 44);
            this.btnVerDatos.Name = "btnVerDatos";
            this.btnVerDatos.Size = new System.Drawing.Size(75, 23);
            this.btnVerDatos.TabIndex = 33;
            this.btnVerDatos.Text = "Ver Datos";
            this.btnVerDatos.UseVisualStyleBackColor = true;
            this.btnVerDatos.Click += new System.EventHandler(this.btnVerDatos_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(390, 183);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 32;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(390, 246);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Password:";
            // 
            // CmbTipoUsuario
            // 
            this.CmbTipoUsuario.FormattingEnabled = true;
            this.CmbTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Root",
            "Trabajador",
            "Normal",
            "Solo Lectura",
            "Restringido"});
            this.CmbTipoUsuario.Location = new System.Drawing.Point(183, 324);
            this.CmbTipoUsuario.Name = "CmbTipoUsuario";
            this.CmbTipoUsuario.Size = new System.Drawing.Size(121, 24);
            this.CmbTipoUsuario.TabIndex = 27;
            // 
            // CmvEstado
            // 
            this.CmvEstado.FormattingEnabled = true;
            this.CmvEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Suspendido",
            "Bloqueado\t"});
            this.CmvEstado.Location = new System.Drawing.Point(183, 280);
            this.CmvEstado.Name = "CmvEstado";
            this.CmvEstado.Size = new System.Drawing.Size(121, 24);
            this.CmvEstado.TabIndex = 26;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(183, 231);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(121, 22);
            this.textBoxPassword.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Usuario:";
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(183, 183);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(121, 22);
            this.textUsuario.TabIndex = 23;
            // 
            // cmvUsuarios
            // 
            this.cmvUsuarios.FormattingEnabled = true;
            this.cmvUsuarios.Items.AddRange(new object[] {
            "Administrador",
            "Root",
            "Trabajador",
            "Normal",
            "Solo Lectura",
            "Restringido"});
            this.cmvUsuarios.Location = new System.Drawing.Point(138, 43);
            this.cmvUsuarios.Name = "cmvUsuarios";
            this.cmvUsuarios.Size = new System.Drawing.Size(166, 24);
            this.cmvUsuarios.TabIndex = 34;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(390, 309);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 23);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Modificar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmvUsuarios);
            this.Controls.Add(this.btnVerDatos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbTipoUsuario);
            this.Controls.Add(this.CmvEstado);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textUsuario);
            this.Name = "Modificar_Usuario";
            this.Text = "Modificar_Usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Modificar_Usuario_FormClosed);
            this.Load += new System.EventHandler(this.Modificar_Usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerDatos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbTipoUsuario;
        private System.Windows.Forms.ComboBox CmvEstado;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.ComboBox cmvUsuarios;
        private System.Windows.Forms.Button btnUpdate;
    }
}