using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPractica
{
  public partial class FrmRegistro : Form
  {
    public FrmRegistro()
    {
      InitializeComponent();
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
     if( MessageBox.Show("Sus datos son:\n" + txtNombre.Text + "\n" + txtApellido.Text + "\n" + txtEmail.Text + "\n" + txtPassword.Text + "\n"
                        +cbCodigoArea.Text+" "+txtNumeroCelular.Text + "\n" + dtFechaNacimiento.Text + "\n","",MessageBoxButtons.YesNo)== DialogResult.Yes)
          this.Close();
    }

    private void FrmRegistro_FormClosing(object sender, FormClosingEventArgs e)
    {
      
    }
  }
}
