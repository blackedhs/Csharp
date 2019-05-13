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
  public partial class Form1 : Form
  {
        Maquina maquina = new Maquina("Asus");
    public Form1()
    {
            InitializeComponent();            
    }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PlacaVideo placa = new PlacaVideo(txtMarca.Text, txtModelo.Text, (int)nudMemoria.Value);
            MessageBox.Show(maquina + (Periferico)placa);
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            PlacaVideo placa = new PlacaVideo(txtMarca.Text, txtModelo.Text, (int)nudMemoria.Value);
            MessageBox.Show(maquina - (Periferico)placa);
        }

        private void btnSystemInfo_Click(object sender, EventArgs e)
        {
            rtxtSystemInfo.Text =maquina.SystemInfo;
        }
    }
}
