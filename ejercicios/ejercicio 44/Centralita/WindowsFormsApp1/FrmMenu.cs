using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsFormsApp1
{
    public partial class FrmMenu : Form
    {
        Centralita central;
        public FrmMenu()
        {
            InitializeComponent();
            central = new Centralita("MiEmpresa");
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            Form frmLlamador = new FrmLlamador(central);
            frmLlamador.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFacturaTotal_Click(object sender, EventArgs e)
        {
            Form frmMostrar = new FrmMostrar(central);
            frmMostrar.Show();
        }
    }
}
