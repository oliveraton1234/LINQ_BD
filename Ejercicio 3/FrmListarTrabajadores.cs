using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class FrmListarTrabajadores : Form
    {
        DataClasses1DataContext dataContext;
        public List<trabajador> listartrabajador;
        public FrmListarTrabajadores()
        {
            InitializeComponent();

            string Conexion = ConfigurationManager.ConnectionStrings["Ejercicio_3.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmListarTrabajadores_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void FrmListarTrabajadores_Load(object sender, EventArgs e)
        {
            var lista = dataContext.trabajador.OrderBy(x => x.id_trabajador).ToList();
            foreach (var trabajador in lista)
            {
                dataGridView1.Rows.Add(trabajador.id_trabajador, trabajador.nombre, trabajador.apellido_mat, trabajador.apellido_pat, trabajador.direccion, trabajador.direccion, trabajador.telefono, trabajador.num_empleado, trabajador.id_usuario, trabajador.id_puesto);
                textBox1.Text = textBox1.Text + trabajador.id_trabajador + "    " + trabajador.nombre + "    " + trabajador.apellido_mat + "    " + trabajador.apellido_pat+ "    " + trabajador.direccion + "    " + trabajador.telefono + "    " + trabajador.num_empleado + "    " + trabajador.id_usuario + "    " + trabajador.id_puesto + Environment.NewLine;
            }
        }
    }
}
