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

    public bool[] bul = new bool[4] { true, true, true, true };
    private void timer1_Tick(object sender, EventArgs e)
    {
      recorrer();
    }

    #region btn
    private void BtnUno_Click(object sender, EventArgs e)
    {
      bul[0] = !bul[0];
    }

    private void BtnDos_Click(object sender, EventArgs e)
    {
      bul[1] = !bul[1];
    }

    private void BtnTres_Click(object sender, EventArgs e)
    {
      bul[2] = !bul[2];
    }

    private void BtnCuatro_Click(object sender, EventArgs e)
    {
      bul[3] = !bul[3];
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
      if (bul[0])
        TxtUno.Text = (1 + int.Parse(TxtUno.Text)).ToString();
      if (bul[1])
        TxtDos.Text = (1 + int.Parse(TxtDos.Text)).ToString();
      if (bul[2])
        TxtTres.Text = (1 + int.Parse(TxtTres.Text)).ToString();
      if (bul[3])
        TxtCuatro.Text = (1 + int.Parse(TxtCuatro.Text)).ToString();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }
  }
}
