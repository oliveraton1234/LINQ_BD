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
    public partial class Eliminar_Usuario : Form
    {
        DataClasses1DataContext dataContext;
        public List<usuarios> listausuarios;
        public Eliminar_Usuario()
        {
            InitializeComponent();

            string Conexion = ConfigurationManager.ConnectionStrings["Ejercicio_3.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuarios user = dataContext.usuarios.FirstOrDefault(us => us.usuario.Equals(CmvUsuario.SelectedItem.ToString()));
            dataContext.usuarios.DeleteOnSubmit(user);
            dataContext.SubmitChanges();
            MessageBox.Show("Usuario Eliminado");
            CmvUsuario.Items.Clear();
            CmvUsuario.Text = "";
            Eliminar_Usuario_Load(sender, e);   
        }

        private void Eliminar_Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Eliminar_Usuario_Load(object sender, EventArgs e)
        {
            var lista = dataContext.usuarios.OrderBy(x => x.id).ToList();
            foreach(var usuarios in lista)
            {
                CmvUsuario.Items.Add(usuarios.usuario);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
