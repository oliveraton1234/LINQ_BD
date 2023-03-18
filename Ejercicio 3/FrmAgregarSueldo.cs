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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio_3
{
    public partial class FrmAgregarSueldo : Form
    {
        DataClasses1DataContext dataContext;
        public List<trabajador> listartrabajador;
        public List<sueldo> listasueldo;
        public List<puesto> listapuesto;
        public FrmAgregarSueldo()
        {
            InitializeComponent();

            string Conexion = ConfigurationManager.ConnectionStrings["Ejercicio_3.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmAgregarSueldo_Load(object sender, EventArgs e)
        {
            var lista = dataContext.trabajador.OrderBy(x => x.id_trabajador).ToList();
            foreach (var trabajador in lista)
            {
                comboBox2.Items.Add(trabajador.nombre);
            }
            var lista2 = dataContext.puesto.OrderBy(x => x.id_puesto).ToList();
            foreach (var puesto in lista2)
            {
                comboBox3.Items.Add(puesto.puesto1);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void FrmAgregarSueldo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            puesto puestos = dataContext.puesto.FirstOrDefault(x => x.puesto1.Equals(comboBox3.SelectedItem.ToString()));
            trabajador trabajadores = dataContext.trabajador.FirstOrDefault(x => x.nombre.Equals(comboBox2.SelectedItem.ToString()));

            sueldo sueldos = new sueldo();
            sueldos.id_trabajador = trabajadores.id_trabajador;
            sueldos.id_puesto = puestos.id_puesto;
            sueldos.sueldo1 = Convert.ToInt32(textBox1.Text);
            dataContext.sueldo.InsertOnSubmit(sueldos);
            dataContext.SubmitChanges();
            MessageBox.Show("Sueldo agregado correctamente");
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Text = "";
            FrmAgregarSueldo_Load(sender, e);
        }
    }
}
