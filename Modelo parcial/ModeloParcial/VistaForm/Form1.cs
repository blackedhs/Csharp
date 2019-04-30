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

namespace VistaForm
{
  public partial class Form1 : Form
  {
    private DirectorTecnico dt;
    public Form1()
    {
      InitializeComponent();
    }

    private void btnCrear_Click(object sender, EventArgs e)
    {
      this.dt = new DirectorTecnico(txtNombre.Text, txtApellido.Text, (int)(numericUpDownEdad.Value), (int)(numericUpDownDni.Value), (int)(numericUpDownExperiencia.Value));
      MessageBox.Show("Se ha creado un DT!");
    }

    private void btnValidar_Click(object sender, EventArgs e)
    {
      if (dt is null)
        MessageBox.Show("Aún no se ha creado el DT del formulario");
      else
        if (dt.ValidadAptitud())
          MessageBox.Show("El Dt es apto");
        else
          MessageBox.Show("El Dt no es apto");
    }
  }
}
