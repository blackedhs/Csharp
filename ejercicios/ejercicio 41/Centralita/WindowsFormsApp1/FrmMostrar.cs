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
    public partial class FrmMostrar : Form
    {
        private Centralita central;

        public FrmMostrar(Centralita central)
        {
            this.central = central;
            InitializeComponent();
            richTextBox1.Text = central.Mostrar();
        }

    }
}
