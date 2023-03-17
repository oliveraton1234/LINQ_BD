using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            salirToolStripMenuItem_Click(sender, e);
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Usuario agregar_Usuario = new Agregar_Usuario();
            agregar_Usuario.Show();
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Eliminar_Usuario eliminar_Usuario = new Eliminar_Usuario();
            eliminar_Usuario.Show();
            this.Hide();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar_Usuario modificar_Usuario = new Modificar_Usuario();
            modificar_Usuario.Show();
            this.Hide();
        }

        private void listarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar_Usuario listar_Usuario = new Listar_Usuario();
            listar_Usuario.Show();
            this.Hide();
        }

        private void agregarTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarTrabajadores frmAgregarTrabajadores = new FrmAgregarTrabajadores();
            frmAgregarTrabajadores.Show();
            this.Hide();
        }

        private void eliminarTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarTrabajador frmEliminarTrabajador = new FrmEliminarTrabajador();
            frmEliminarTrabajador.Show();
            this.Hide();
        }

        private void modificarTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmmodificarTrabajador frmmodificarTrabajador = new FrmmodificarTrabajador();
            frmmodificarTrabajador.Show();
            this.Hide();
        }

        private void listarTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarTrabajadores frmListarTrabajadores = new FrmListarTrabajadores();
            frmListarTrabajadores.Show();
            this.Hide();
        }
    }
}
