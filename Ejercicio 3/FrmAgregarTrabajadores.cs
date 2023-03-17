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
    public partial class FrmAgregarTrabajadores : Form
    {
        DataClasses1DataContext dataContext;
        public List<usuarios> listausuarios;
        public List<puesto> listapuesto;
        public FrmAgregarTrabajadores()
        {
            InitializeComponent();

            string Conexion = ConfigurationManager.ConnectionStrings["Ejercicio_3.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAgregarTrabajadores_Load(object sender, EventArgs e)
        {
            var lista = dataContext.usuarios.OrderBy(x => x.id).ToList();
            foreach (var usuarios in lista)
            {
                comboBox1.Items.Add(usuarios.usuario);
            }
            var lista2 = dataContext.puesto.OrderBy(x => x.id_puesto).ToList();
            foreach (var puesto in lista2)
            {
                comboBox2.Items.Add(puesto.puesto1);
            }
        }

        private void FrmAgregarTrabajadores_FormClosed(object sender, FormClosedEventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            usuarios user = dataContext.usuarios.FirstOrDefault(x => x.usuario.Equals(comboBox1.SelectedItem.ToString()));
            puesto puestos = dataContext.puesto.FirstOrDefault(x => x.puesto1.Equals(comboBox2.SelectedItem.ToString()));

            trabajador trabajador = new trabajador();
            trabajador.nombre = textBoxPassword.Text;
            trabajador.apellido_pat = textBox1.Text;
            trabajador.apellido_mat = textBox2.Text;
            trabajador.direccion = textBox4.Text;
            trabajador.telefono = textBox3.Text;
            trabajador.num_empleado = Convert.ToInt16(textBox5.Text);
            trabajador.id_puesto = user.id;
            trabajador.id_usuario = puestos.id_puesto;
            dataContext.trabajador.InsertOnSubmit(trabajador);
            dataContext.SubmitChanges();
            MessageBox.Show("Trabajador Agregado");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox5.Text = "";
            textBoxPassword.Text = "";
            FrmAgregarTrabajadores_Load(sender, e);
        }
    }
}
