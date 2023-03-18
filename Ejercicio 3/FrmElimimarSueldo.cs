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
    public partial class FrmElimimarSueldo : Form
    {
        DataClasses1DataContext dataContext;
        public List<sueldo> listasueldo;
        public FrmElimimarSueldo()
        {
            InitializeComponent();

            string Conexion = ConfigurationManager.ConnectionStrings["Ejercicio_3.Properties.Settings.ejercicioConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(Conexion);
        }

        private void FrmElimimarSueldo_FormClosed(object sender, FormClosedEventArgs e)
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

        private void FrmElimimarSueldo_Load(object sender, EventArgs e)
        {
            var lista = dataContext.sueldo.OrderBy(x => x.id_sueldo).ToList();
            foreach (var sueldo in lista)
            {
                comboBox1.Items.Add(sueldo.id_sueldo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sueldo sueldos = dataContext.sueldo.FirstOrDefault(x => x.id_sueldo.Equals(comboBox1.SelectedItem.ToString()));
            dataContext.sueldo.DeleteOnSubmit(sueldos);
            dataContext.SubmitChanges();
            MessageBox.Show("Sueldo eliminado");
            comboBox1.Text = "";
            FrmElimimarSueldo_Load(sender, e);

        }
    }
}
