namespace Ejercicio_3
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTrabajadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTrabajadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarTrabajadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTrabajadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.trabajadoresToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem,
            this.modificarUsuarioToolStripMenuItem,
            this.listarUsuarioToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.agregarUsuarioToolStripMenuItem.Text = "Agregar Usuario";
            this.agregarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.agregarUsuarioToolStripMenuItem_Click);
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuarioToolStripMenuItem_Click);
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.modificarUsuarioToolStripMenuItem.Text = "Modificar Usuario";
            this.modificarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuarioToolStripMenuItem_Click);
            // 
            // listarUsuarioToolStripMenuItem
            // 
            this.listarUsuarioToolStripMenuItem.Name = "listarUsuarioToolStripMenuItem";
            this.listarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.listarUsuarioToolStripMenuItem.Text = "Listar Usuario";
            this.listarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.listarUsuarioToolStripMenuItem_Click);
            // 
            // trabajadoresToolStripMenuItem
            // 
            this.trabajadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarTrabajadorToolStripMenuItem,
            this.eliminarTrabajadorToolStripMenuItem,
            this.modificarTrabajadorToolStripMenuItem,
            this.listarTrabajadorToolStripMenuItem});
            this.trabajadoresToolStripMenuItem.Name = "trabajadoresToolStripMenuItem";
            this.trabajadoresToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.trabajadoresToolStripMenuItem.Text = "Trabajadores";
            // 
            // agregarTrabajadorToolStripMenuItem
            // 
            this.agregarTrabajadorToolStripMenuItem.Name = "agregarTrabajadorToolStripMenuItem";
            this.agregarTrabajadorToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.agregarTrabajadorToolStripMenuItem.Text = "Agregar Trabajador";
            this.agregarTrabajadorToolStripMenuItem.Click += new System.EventHandler(this.agregarTrabajadorToolStripMenuItem_Click);
            // 
            // eliminarTrabajadorToolStripMenuItem
            // 
            this.eliminarTrabajadorToolStripMenuItem.Name = "eliminarTrabajadorToolStripMenuItem";
            this.eliminarTrabajadorToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.eliminarTrabajadorToolStripMenuItem.Text = "Eliminar Trabajador";
            this.eliminarTrabajadorToolStripMenuItem.Click += new System.EventHandler(this.eliminarTrabajadorToolStripMenuItem_Click);
            // 
            // modificarTrabajadorToolStripMenuItem
            // 
            this.modificarTrabajadorToolStripMenuItem.Name = "modificarTrabajadorToolStripMenuItem";
            this.modificarTrabajadorToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.modificarTrabajadorToolStripMenuItem.Text = "Modificar Trabajador";
            this.modificarTrabajadorToolStripMenuItem.Click += new System.EventHandler(this.modificarTrabajadorToolStripMenuItem_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.pagosToolStripMenuItem.Text = "Pagos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // listarTrabajadorToolStripMenuItem
            // 
            this.listarTrabajadorToolStripMenuItem.Name = "listarTrabajadorToolStripMenuItem";
            this.listarTrabajadorToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.listarTrabajadorToolStripMenuItem.Text = "Listar Trabajador";
            this.listarTrabajadorToolStripMenuItem.Click += new System.EventHandler(this.listarTrabajadorToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabajadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarTrabajadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTrabajadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarTrabajadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTrabajadorToolStripMenuItem;
    }
}

