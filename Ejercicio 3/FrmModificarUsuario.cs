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
    public partial class Modificar_Usuario : Form
    {
        DataClasses1DataContext dataContext;
        public List<usuarios> listausuarios;
        public Modificar_Usuario()
        {
            InitializeComponent();
            string Conexion = ConfigurationManager.ConnectionStrings["Ejercicio_3.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void Modificar_Usuario_Load(object sender, EventArgs e)
        {
            var lista = dataContext.usuarios.OrderBy(x => x.id).ToList();
            foreach (var usuarios in lista)
            {
                cmvUsuarios.Items.Add(usuarios.usuario);
            }
        }

        private void Modificar_Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textUsuario.Text = "";
            textBoxPassword.Text = "";
            CmvEstado.Text = "";
            cmvUsuarios.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            usuarios user = dataContext.usuarios.FirstOrDefault(x => x.usuario.Equals(cmvUsuarios.SelectedItem.ToString()));
            user.usuario = textUsuario.Text;
            user.passwd = textBoxPassword.Text;
            user.estado = CmvEstado.Text;
            user.tipo_usuario = CmbTipoUsuario.Text;
            dataContext.SubmitChanges();
            MessageBox.Show("Usuario Modificado");
            cmvUsuarios.Items.Clear();
            cmvUsuarios.Text = "";
            textUsuario.Text = "";
            textBoxPassword.Text = "";
            CmvEstado.Text = "";
            cmvUsuarios.Text = "";
            Modificar_Usuario_Load(sender, e);
        }

        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            usuarios user = dataContext.usuarios.FirstOrDefault(x => x.usuario.Equals(cmvUsuarios.SelectedItem.ToString()));
            textUsuario.Text = user.usuario;
            textBoxPassword.Text = user.passwd;
            CmvEstado.Text = user.estado;
            CmbTipoUsuario.Text = user.tipo_usuario;
        }
    }
}
