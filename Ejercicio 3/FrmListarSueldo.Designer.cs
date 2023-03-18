namespace Ejercicio_3
{
    partial class FrmListarSueldo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Id_Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Trabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Sueldo,
            this.Id_Trabajador,
            this.Id_Puesto,
            this.Sueldo});
            this.dataGridView1.Location = new System.Drawing.Point(44, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(831, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(831, 231);
            this.textBox1.TabIndex = 1;
            // 
            // Id_Sueldo
            // 
            this.Id_Sueldo.HeaderText = "Column1";
            this.Id_Sueldo.MinimumWidth = 6;
            this.Id_Sueldo.Name = "Id_Sueldo";
            this.Id_Sueldo.Width = 125;
            // 
            // Id_Trabajador
            // 
            this.Id_Trabajador.HeaderText = "Column1";
            this.Id_Trabajador.MinimumWidth = 6;
            this.Id_Trabajador.Name = "Id_Trabajador";
            this.Id_Trabajador.Width = 125;
            // 
            // Id_Puesto
            // 
            this.Id_Puesto.HeaderText = "Column1";
            this.Id_Puesto.MinimumWidth = 6;
            this.Id_Puesto.Name = "Id_Puesto";
            this.Id_Puesto.Width = 125;
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Column1";
            this.Sueldo.MinimumWidth = 6;
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.Width = 125;
            // 
            // FrmListarSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 540);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmListarSueldo";
            this.Text = "FrmListarSueldo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmListarSueldo_FormClosed);
            this.Load += new System.EventHandler(this.FrmListarSueldo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Trabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
    }
}