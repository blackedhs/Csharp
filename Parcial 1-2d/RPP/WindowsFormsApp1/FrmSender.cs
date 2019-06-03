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
    public partial class FrmSender : Form
    {
        private ManejadorDeEmisores manejador;
        private List<Emisor.EProducto> productos;
        
        /// <summary>
        /// Constructor del form, inicializa un manejador ,la lista de productos y el comboBox con los datos
        /// de Emisor.Eproducto 
        /// </summary>
        public FrmSender()
        {
            InitializeComponent();
            manejador = new ManejadorDeEmisores("West Europe");
            productos = new List<Emisor.EProducto>();
            this.comboBoxProductos.DataSource = Enum.GetNames(typeof(Entidades.Emisor.EProducto));
        }
        /// <summary>
        /// Envia todos los mensajes dentro del manejador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            richConsola.Text = manejador.EnviarMensajes();
        }
        /// <summary>
        /// intenta guardar un msj en el manejadore y avisa con un msj si pudo o no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Emisor.EProducto producto;
            Enum.TryParse(this.comboBoxProductos.SelectedItem.ToString(), out producto);
            EmisorDeWhatsapp wasap = new EmisorDeWhatsapp(richMensaje.Text, producto);
            int tel = 0;
            if (manejador+wasap)
            {
                int.TryParse(txtTelefono.Text, out tel);
                wasap.NumeroTelefono = tel;
                MessageBox.Show("Se pudo agregar tu msj");
            }else
                MessageBox.Show("Msj no agregado");
        }
    }
}
