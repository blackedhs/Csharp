using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clase_8_Library;

namespace Clase_8
{
  public partial class frmEmpleado : Form
  {
    Empresa _empresa;

    public frmEmpleado()
    {
      InitializeComponent();
    }

    private void frmEmpleado_Load(object sender, EventArgs e)
    {
      //alumno cargar combo puesto jerarquico
      btnEmpresa_Click(sender, e);
    }

    private void btnEmpresa_Click(object sender, EventArgs e)
    {
      frmEmpresa frm = new frmEmpresa(this._empresa);
      frm.Show();
      //alumno
    }

    private void btnLimpiarForm_Click(object sender, EventArgs e)
    {
      txtNombre.Text = "";
      txtApellido.Text = "";
      txtLegajo.Text = "";
      cmbPuesto.SelectedIndex = -1;
    }

    private void btnAgregarItem_Click(object sender, EventArgs e)
    {
      Empleado.EPuestoJerarquico puesto;
      int salario;
      // Controlo que los valores ingresados respeten el tipo de dato
      if (!Enum.TryParse<Empleado.EPuestoJerarquico>(cmbPuesto.SelectedValue.ToString(), out puesto))
      {
        MessageBox.Show("Error en el combo de Puesto del empleado.");
        return;
      }
      if (!Int32.TryParse(txtSalario.Text.Substring(1, txtSalario.Text.Length - 1), out salario))
      {
        MessageBox.Show("Error en el salario del empleado.");
        return;
      }
      // Agrego el empleado a la empresa
      //Alumno
      int salario;
      int.TryParse(txtSalario.Text, out salario);
      Empleado empleado = new Empleado(txtNombre.Text,txtApellido.Text,txtLegajo.Text,(Empleado.EPuestoJerarquico)cmbPuesto.SelectedItem,salario);
      this._empresa += empleado;
      // Muestro la empresa por pantalla
      rtxtConsola.Text = this._empresa.MostrarEmpresa();
    }
  }
}
