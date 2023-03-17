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
    public partial class Agregar_Usuario : Form
    {
        DataClasses1DataContext dataContext;
        public Agregar_Usuario()
        {
            InitializeComponent();

            string Conexion = ConfigurationManager.ConnectionStrings["Ejercicio_3.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
           Menu menu = new Menu();
           menu.Show();
           this.Hide();
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textUsuario.Text = "";
            textBoxPassword.Text = "";
            CmvEstado.Text = "";
            CmbTipoUsuario.Text = "";
        }

        private void Agregar_Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnCerrar_Click(sender, e);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            usuarios datos = new usuarios();
            datos.usuario = textUsuario.Text;
            datos.passwd = textBoxPassword.Text;
            datos.estado = CmvEstado.SelectedItem.ToString();
            datos.tipo_usuario = CmbTipoUsuario.SelectedItem.ToString();
            dataContext.usuarios.InsertOnSubmit(datos);
            dataContext.SubmitChanges();
        }

        private void Agregar_Usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
