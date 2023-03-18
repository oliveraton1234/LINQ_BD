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
    public partial class FrmListarSueldo : Form
    {
        DataClasses1DataContext dataContext;
        public List<sueldo> listarsueldo;
        public FrmListarSueldo()
        {
            InitializeComponent();

            string Conexion = ConfigurationManager.ConnectionStrings["Ejercicio_3.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmListarSueldo_Load(object sender, EventArgs e)
        {
            var lista = dataContext.sueldo.OrderBy(x => x.id_sueldo).ToList();
            foreach (var sueldo in lista)
            {
                dataGridView1.Rows.Add(sueldo.id_sueldo, sueldo.id_trabajador, sueldo.id_puesto, sueldo.sueldo1);
                textBox1.Text = textBox1.Text + "     " + sueldo.id_sueldo + "     " + sueldo.id_trabajador + "     " + sueldo.id_puesto + "     " + sueldo.sueldo1 +Environment.NewLine;
            }
        }

        private void FrmListarSueldo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
