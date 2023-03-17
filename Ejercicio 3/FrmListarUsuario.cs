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
    public partial class Listar_Usuario : Form
    {
        DataClasses1DataContext dataContext;
        public List<usuarios> listausuarios;
        public Listar_Usuario()
        {
            InitializeComponent();

            string Conexion = ConfigurationManager.ConnectionStrings["Ejercicio_3.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void trabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Listar_Usuario_Load(object sender, EventArgs e)
        {
            var lista = dataContext.usuarios.OrderBy(x => x.id).ToList();
            foreach (var usuario in lista)
            {
                dataGridView1.Rows.Add(usuario.id, usuario.usuario , usuario.passwd, usuario.estado, usuario.tipo_usuario);
                textBox1.Text = textBox1.Text + usuario.id + "   " +  usuario.usuario +  usuario.passwd + usuario.estado + usuario.tipo_usuario + Environment.NewLine;
            }
        }

        private void Listar_Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
