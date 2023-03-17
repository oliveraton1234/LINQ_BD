using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Ejercicio_3
{
    public partial class FrmEliminarTrabajador : Form
    {
        DataClasses1DataContext dataContext;
        public List<trabajador> listartrabajador;
        public FrmEliminarTrabajador()
        {
            InitializeComponent();
            string Conexion = ConfigurationManager.ConnectionStrings["Ejercicio_3.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmEliminarTrabajador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trabajador trabajador = dataContext.trabajador.FirstOrDefault(us => us.nombre.Equals(comboBox1.SelectedItem.ToString()));
            dataContext.trabajador.DeleteOnSubmit(trabajador);
            dataContext.SubmitChanges();
            MessageBox.Show("Trabajador Eliminado");
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            FrmEliminarTrabajador_Load(sender, e);
        }

        private void FrmEliminarTrabajador_Load(object sender, EventArgs e)
        {
            var lista = dataContext.trabajador.OrderBy(x => x.id_trabajador).ToList();
            foreach (var trabajador in lista)
            {
                comboBox1.Items.Add(trabajador.nombre);
            }
        }
    }
}
