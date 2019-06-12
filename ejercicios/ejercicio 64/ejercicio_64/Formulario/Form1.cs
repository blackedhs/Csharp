using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Formulario
{
  public partial class Form1 : Form
  {
    
    Thread llamarHora;
    delegate void Callback();
    public Form1()
    {
      InitializeComponent();
      
      llamarHora = new Thread(LlamarHora);
      llamarHora.Start();
    }

    public void AsignarHora()
    {

      if (this.lblHora.InvokeRequired)
      {
        Callback d = new Callback(this.AsignarHora);
        this.lblHora.BeginInvoke(d);
      }
      else
        this.lblHora.Text = DateTime.Now.ToString();
    }
    public void LlamarHora()
    {
      while (true)
      {
        Thread.Sleep(1000);
        AsignarHora();
      }
    }
    private void Form1_Load(object sender, EventArgs e)
    {

    }




  }
}
