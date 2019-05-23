namespace WindowsFormsApp1
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerarLlamada = new System.Windows.Forms.Button();
            this.btnFacturaTotal = new System.Windows.Forms.Button();
            this.btnFacturaLoc = new System.Windows.Forms.Button();
            this.btnFacturaProv = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarLlamada
            // 
            this.btnGenerarLlamada.Location = new System.Drawing.Point(56, 47);
            this.btnGenerarLlamada.Name = "btnGenerarLlamada";
            this.btnGenerarLlamada.Size = new System.Drawing.Size(215, 54);
            this.btnGenerarLlamada.TabIndex = 0;
            this.btnGenerarLlamada.Text = "Generar Llamada";
            this.btnGenerarLlamada.UseVisualStyleBackColor = true;
            this.btnGenerarLlamada.Click += new System.EventHandler(this.btnGenerarLlamada_Click);
            // 
            // btnFacturaTotal
            // 
            this.btnFacturaTotal.Location = new System.Drawing.Point(56, 123);
            this.btnFacturaTotal.Name = "btnFacturaTotal";
            this.btnFacturaTotal.Size = new System.Drawing.Size(215, 54);
            this.btnFacturaTotal.TabIndex = 1;
            this.btnFacturaTotal.Text = "Facturacion Total";
            this.btnFacturaTotal.UseVisualStyleBackColor = true;
            this.btnFacturaTotal.Click += new System.EventHandler(this.btnFacturaTotal_Click);
            // 
            // btnFacturaLoc
            // 
            this.btnFacturaLoc.Location = new System.Drawing.Point(56, 197);
            this.btnFacturaLoc.Name = "btnFacturaLoc";
            this.btnFacturaLoc.Size = new System.Drawing.Size(215, 54);
            this.btnFacturaLoc.TabIndex = 2;
            this.btnFacturaLoc.Text = "Facturacion Local";
            this.btnFacturaLoc.UseVisualStyleBackColor = true;
            // 
            // btnFacturaProv
            // 
            this.btnFacturaProv.Location = new System.Drawing.Point(56, 275);
            this.btnFacturaProv.Name = "btnFacturaProv";
            this.btnFacturaProv.Size = new System.Drawing.Size(215, 54);
            this.btnFacturaProv.TabIndex = 3;
            this.btnFacturaProv.Text = "Facturacion Provincial";
            this.btnFacturaProv.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(56, 358);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(215, 54);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFacturaProv);
            this.Controls.Add(this.btnFacturaLoc);
            this.Controls.Add(this.btnFacturaTotal);
            this.Controls.Add(this.btnGenerarLlamada);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central telefonica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarLlamada;
        private System.Windows.Forms.Button btnFacturaTotal;
        private System.Windows.Forms.Button btnFacturaLoc;
        private System.Windows.Forms.Button btnFacturaProv;
        private System.Windows.Forms.Button btnSalir;
    }
}

