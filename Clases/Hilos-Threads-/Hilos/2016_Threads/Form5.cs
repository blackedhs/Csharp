using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Pelotita_Con_Threads
{
    delegate void AsignarNumeroDelegado(string text);

    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void BtnSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola.");
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000000; i++)
                this.LblNumero.Text = i.ToString();
        }

        public void Hacer()
        {
            for (int i = 0; i < 1000000; i++)
                AsignarNumero(i.ToString());
        }

        private void BtnCrearHilo_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(this.Hacer);
            th.Start();
        }

        public void AsignarNumero(string text)
        {
            try
            {
                //invokerequired devuelve TRUE si los hilos son distintos
                if (this.LblNumero.InvokeRequired)
                {
                    AsignarNumeroDelegado asigndelegate = new AsignarNumeroDelegado(AsignarNumero);
                    this.Invoke(asigndelegate, new object[] { text });
                }
                else
                    LblNumero.Text = text;

            }
            catch (Exception)
            {
                
                
            }
        }
    }
}
