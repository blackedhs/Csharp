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
    public partial class FrmLlamador : Form
    {
        Centralita central;
        public FrmLlamador(Centralita centralita)
        {
            this.central = centralita;
            InitializeComponent();
            // Carga
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = "Nro Destino";
            txtNroOrigen.Text = "Nro Origen";
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(30);

            if (string.Compare(txtNroDestino.Text.Substring(0, 1), "#") == 0)
            {
                Provincial.Franja franjas;
                Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
                this.central = central + new Provincial(txtNroOrigen.Text, franjas, rnd.Next(30), txtNroDestino.Text);
            }
            else
            {
                this.central = central + new Local(txtNroOrigen.Text, rnd.Next(30), txtNroDestino.Text, rnd.Next(1, 5));
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (string.Compare(txtNroDestino.Text, "Nro Destino") == 0)
                txtNroDestino.Text = "";
            txtNroDestino.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {

            if (string.Compare(txtNroDestino.Text, "Nro Destino") == 0)
                txtNroDestino.Text = "";
            txtNroDestino.Text += "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {

            if (string.Compare(txtNroDestino.Text, "Nro Destino") == 0)
                txtNroDestino.Text = "";
            txtNroDestino.Text += "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {

            if (string.Compare(txtNroDestino.Text, "Nro Destino") == 0)
                txtNroDestino.Text = "";
            txtNroDestino.Text += "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {

            if (string.Compare(txtNroDestino.Text, "Nro Destino") == 0)
                txtNroDestino.Text = "";
            txtNroDestino.Text += "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {

            if (string.Compare(txtNroDestino.Text, "Nro Destino") == 0)
                txtNroDestino.Text = "";
            txtNroDestino.Text += "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            {
                if (string.Compare(txtNroDestino.Text, "Nro Destino") == 0)
                    txtNroDestino.Text = "";
                txtNroDestino.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {

            if (string.Compare(txtNroDestino.Text, "Nro Destino") == 0)
                txtNroDestino.Text = "";
            txtNroDestino.Text += "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {

            if (string.Compare(txtNroDestino.Text, "Nro Destino") == 0)
                txtNroDestino.Text = "";
            txtNroDestino.Text += "9";

        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {

            if (string.Compare(txtNroDestino.Text, "Nro Destino") == 0)
                txtNroDestino.Text = "";
            txtNroDestino.Text += "*";

        }

        private void btn0_Click(object sender, EventArgs e)
        {

            if (string.Compare(txtNroDestino.Text, "Nro Destino") == 0)
                txtNroDestino.Text = "";
            txtNroDestino.Text += "0";

        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            if (string.Compare(txtNroDestino.Text, "Nro Destino") == 0)
                txtNroDestino.Text = "";
            txtNroDestino.Text += "#";
        }
    }
}
