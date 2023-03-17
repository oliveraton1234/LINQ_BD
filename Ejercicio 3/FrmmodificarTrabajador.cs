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
    public partial class FrmmodificarTrabajador : Form
    {
        DataClasses1DataContext dataContext;
        public List<usuarios> listausuarios;
        public List<puesto> listapuesto;
        public List<trabajador> listatrabajador;
        public FrmmodificarTrabajador()
        {
            InitializeComponent();

            string Conexion = ConfigurationManager.ConnectionStrings["Ejercicio_3.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmmodificarTrabajador_Load(object sender, EventArgs e)
        {
            var lista3 = dataContext.trabajador.OrderBy(x => x.id_trabajador).ToList();
            foreach (var trabajador in lista3)
            {
                comboBox3.Items.Add(trabajador.nombre);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox5.Text = "";
            textBoxPassword.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void FrmmodificarTrabajador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            trabajador trabajador = dataContext.trabajador.FirstOrDefault(x => x.nombre.Equals(comboBox3.SelectedItem.ToString()));

            if (trabajador != null)
            {
                textBoxPassword.Text = trabajador.nombre;
                textBox1.Text = trabajador.apellido_pat;
                textBox2.Text = trabajador.apellido_mat;
                textBox3.Text = trabajador.telefono;
                textBox4.Text = trabajador.direccion;
                comboBox1.Text = trabajador.id_usuario.ToString();
                comboBox2.Text = trabajador.id_puesto.ToString();
                textBox5.Text = trabajador.num_empleado.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            trabajador trabajador = dataContext.trabajador.FirstOrDefault(x => x.nombre.Equals(comboBox3.SelectedItem.ToString()));
            usuarios user = dataContext.usuarios.FirstOrDefault(x => x.usuario.Equals(comboBox1.SelectedItem.ToString()));
            puesto puestos = dataContext.puesto.FirstOrDefault(x => x.puesto1.Equals(comboBox2.SelectedItem.ToString()));

            trabajador.nombre = textBoxPassword.Text;
            trabajador.apellido_pat = textBox1.Text;
            trabajador.apellido_mat = textBox2.Text;
            trabajador.telefono = textBox3.Text;
            trabajador.direccion = textBox4.Text;
            trabajador.id_usuario = user.id;
            trabajador.id_puesto = puestos.id_puesto;
            trabajador.num_empleado = int.Parse(textBox5.Text);

            dataContext.SubmitChanges();
            MessageBox.Show("Trabajador modificado");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox5.Text = "";
            textBoxPassword.Text = "";
        }
    }
}
