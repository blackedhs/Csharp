using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Clase22
{
  public partial class ConHilos : Form
  {
    List<Thread> hilos = new List<Thread>();
    public ConHilos()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      Numero n1 = new Numero(1);
      Numero n2 = new Numero(2);
      Numero n3 = new Numero(3);
      Numero n4 = new Numero(4);
      n1.MuestraNumeroEvent += mostrar;
      n2.MuestraNumeroEvent += mostrar;
      n3.MuestraNumeroEvent += mostrar;
      n4.MuestraNumeroEvent += mostrar;


      hilos.Add(new Thread(new ParameterizedThreadStart(sumar)));
      hilos.Add(new Thread(new ParameterizedThreadStart(sumar)));
      hilos.Add(new Thread(new ParameterizedThreadStart(sumar)));
      hilos.Add(new Thread(new ParameterizedThreadStart(sumar)));

      int i = 0;
      foreach (Thread t in hilos)
      {

        t.Start(i);
        i++;
      }
    }


    public int[] numeros = { 0, 0, 0, 0 };
    public void sumar(object o)
    {
      int posicion = (int)(o);
      while (this.numeros[posicion] < 5000)
      {

        try
        {
          System.Threading.Thread.Sleep(40);
          this.numeros[posicion]++;
          mostrar(this.numeros[posicion], posicion);
        }
        catch (ThreadInterruptedException e)
        {

        }
      }

    }

    public void mostrar(int num, int posicion)
    {

      switch (posicion)
      {
        case 1:
          if (this.TxtUno.InvokeRequired)
          {
            this.TxtUno.BeginInvoke((MethodInvoker)delegate ()
            {
              this.TxtUno.Text = num.ToString();
            });

          }
          else
            this.TxtUno.Text = num.ToString();
          break;
        case 2:
          if (this.TxtDos.InvokeRequired)
          {
            this.TxtDos.BeginInvoke((MethodInvoker)delegate ()
            {
              this.TxtDos.Text = num.ToString();
            });

          }
          else
            this.TxtDos.Text = num.ToString();
          break;
        case 3:
          if (this.TxtTres.InvokeRequired)
          {
            this.TxtTres.BeginInvoke((MethodInvoker)delegate ()
            {
              this.TxtTres.Text = num.ToString();
            });

          }
          else
            this.TxtTres.Text = num.ToString();
          break;
        case 0:
          if (this.TxtCuatro.InvokeRequired)
          {
            this.TxtCuatro.BeginInvoke((MethodInvoker)delegate ()
            {
              this.TxtCuatro.Text = num.ToString();
            });

          }
          else
            this.TxtCuatro.Text = num.ToString();
          break;
      }


    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      foreach (Thread t in hilos)
      {
        if (t.IsAlive)
          t.Abort();

      }
    }

    private void BtnDos_Click(object sender, EventArgs e)
    {
      if (hilos[1].IsAlive)
        hilos[1].Abort();
      else
      {
        Numero n1 = new Numero(2);
        n1.Num = int.Parse(TxtDos.Text);
        n1.MuestraNumeroEvent += mostrar;


        hilos[1] = new Thread(n1.sumar);
        hilos[1].Start();

      }
    }

    private void BtnUno_Click(object sender, EventArgs e)
    {
      if (hilos[0].IsAlive)
        hilos[0].Abort();
      else
      {
        Numero n1 = new Numero(1);
        n1.Num = int.Parse(TxtUno.Text);
        n1.MuestraNumeroEvent += mostrar;


        hilos[0] = new Thread(n1.sumar);
        hilos[0].Start();

      }
    }

    private void BtnTres_Click(object sender, EventArgs e)
    {
      if (hilos[2].IsAlive)
        hilos[2].Abort();
      else
      {
        Numero n1 = new Numero(3);
        n1.Num = int.Parse(TxtTres.Text);
        n1.MuestraNumeroEvent += mostrar;


        hilos[2] = new Thread(n1.sumar);
        hilos[2].Start();

      }
    }

    private void BtnCuatro_Click(object sender, EventArgs e)
    {
      if (hilos[3].IsAlive)
        hilos[3].Abort();
      else
      {
        Numero n1 = new Numero(4);
        n1.Num = int.Parse(TxtCuatro.Text);
        n1.MuestraNumeroEvent += mostrar;


        hilos[3] = new Thread(n1.sumar);
        hilos[3].Start();

      }
    }
  }
}
