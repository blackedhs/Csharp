using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Clase22
{
  public partial class SinHilos : Form
  {
    public bool f1 = true, f2 = true, f3 = true, f4 = true;

    private void timer1_Tick(object sender, EventArgs e)
    {
      recorrer();
    }

    #region btn
    private void BtnUno_Click(object sender, EventArgs e)
    {
      f1 = !f1;
    }

    private void BtnDos_Click(object sender, EventArgs e)
    {
      f2 = !f2;
    }

    private void BtnTres_Click(object sender, EventArgs e)
    {
      f3 = !f3;
    }

    private void BtnCuatro_Click(object sender, EventArgs e)
    {
      f4 = !f4;
    } 
    #endregion

    public SinHilos()
    {
      InitializeComponent();
      TxtUno.Text = "1";
      TxtTres.Text = "1";
      TxtDos.Text = "1";
      TxtCuatro.Text = "1";
    }

    public void recorrer()
    {
      if (f1)
        TxtUno.Text = (1 + int.Parse(TxtUno.Text)).ToString();
      if (f2)
        TxtDos.Text = (1 + int.Parse(TxtDos.Text)).ToString();
      if (f3)
        TxtTres.Text = (1 + int.Parse(TxtTres.Text)).ToString();
      if (f4)
        TxtCuatro.Text = (1 + int.Parse(TxtCuatro.Text)).ToString();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }
  }
}
