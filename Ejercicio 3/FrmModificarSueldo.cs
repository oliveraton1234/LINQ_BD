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
    public partial class FrmModificarSueldo : Form
    {
        DataClasses1DataContext dataContext;
        public List<trabajador> listartrabajador;
        public List<sueldo> listasueldo;
        public List<puesto> listapuesto;
        public FrmModificarSueldo()
        {
            InitializeComponent();

            string Conexion = ConfigurationManager.ConnectionStrings["Ejercicio_3.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmModificarSueldo_Load(object sender, EventArgs e)
        {
            var lista = dataContext.sueldo.OrderBy(x => x.id_sueldo).ToList();
            foreach (var sueldo in lista)
            {
                comboBox1.Items.Add(sueldo.id_sueldo);
            }
            var lista2 = dataContext.trabajador.OrderBy(x => x.id_trabajador).ToList();
            foreach (var trabajador in lista2)
            {
                comboBox2.Items.Add(trabajador.nombre);
            }
            var lista3 = dataContext.puesto.OrderBy(x => x.id_puesto).ToList();
            foreach (var puesto in lista3)
            {
                comboBox3.Items.Add(puesto.puesto1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void FrmModificarSueldo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            puesto puestos = dataContext.puesto.FirstOrDefault(x => x.puesto1.Equals(comboBox3.SelectedItem.ToString()));
            trabajador trabajadores = dataContext.trabajador.FirstOrDefault(x => x.nombre.Equals(comboBox2.SelectedItem.ToString()));

            sueldo sueldos = dataContext.sueldo.FirstOrDefault(x => x.id_sueldo.Equals(comboBox1.SelectedItem.ToString()));

            sueldos.id_trabajador = trabajadores.id_trabajador;
            sueldos.id_puesto = puestos.id_puesto;
            sueldos.sueldo1 = Convert.ToInt32(textBox1.Text);
            dataContext.SubmitChanges();
            MessageBox.Show("Sueldo modificado correctamente");

            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Text = "";
            FrmModificarSueldo_Load(sender, e);
        }
    }
}
