namespace Ejercicio_3
{
    partial class Eliminar_Usuario
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.CmvUsuario = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(273, 181);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // CmvUsuario
            // 
            this.CmvUsuario.FormattingEnabled = true;
            this.CmvUsuario.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Suspendido",
            "Bloqueado\t"});
            this.CmvUsuario.Location = new System.Drawing.Point(73, 79);
            this.CmvUsuario.Name = "CmvUsuario";
            this.CmvUsuario.Size = new System.Drawing.Size(324, 24);
            this.CmvUsuario.TabIndex = 14;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(112, 181);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Eliminar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 282);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.CmvUsuario);
            this.Name = "Eliminar_Usuario";
            this.Text = "Eliminar_Usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Eliminar_Usuario_FormClosed);
            this.Load += new System.EventHandler(this.Eliminar_Usuario_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox CmvUsuario;
        private System.Windows.Forms.Button btnEliminar;
    }
}