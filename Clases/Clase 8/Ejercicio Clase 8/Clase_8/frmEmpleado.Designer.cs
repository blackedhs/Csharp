﻿namespace Clase_8
{
    partial class frmEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.MaskedTextBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.rtxtConsola = new System.Windows.Forms.RichTextBox();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.MaskedTextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(137, 38);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(186, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 41);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(137, 64);
            this.txtLegajo.Mask = "000-0000-00";
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(186, 20);
            this.txtLegajo.TabIndex = 3;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(12, 93);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(40, 13);
            this.lblPuesto.TabIndex = 7;
            this.lblPuesto.Text = "Puesto";
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(137, 90);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(186, 21);
            this.cmbPuesto.TabIndex = 4;
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Location = new System.Drawing.Point(244, 151);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(79, 35);
            this.btnAgregarItem.TabIndex = 10;
            this.btnAgregarItem.Text = "Agregar";
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // rtxtConsola
            // 
            this.rtxtConsola.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxtConsola.Location = new System.Drawing.Point(0, 192);
            this.rtxtConsola.Name = "rtxtConsola";
            this.rtxtConsola.Size = new System.Drawing.Size(335, 213);
            this.rtxtConsola.TabIndex = 13;
            this.rtxtConsola.TabStop = false;
            this.rtxtConsola.Text = "";
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Location = new System.Drawing.Point(15, 151);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(79, 35);
            this.btnEmpresa.TabIndex = 12;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(137, 117);
            this.txtSalario.Mask = "$00000";
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(79, 20);
            this.txtSalario.TabIndex = 5;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(12, 120);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 13;
            this.lblSalario.Text = "Salario";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 14);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(186, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 405);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.rtxtConsola);
            this.Controls.Add(this.btnAgregarItem);
            this.Controls.Add(this.cmbPuesto);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmEmpleado";
            this.Text = "Clase 8";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.MaskedTextBox txtLegajo;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.RichTextBox rtxtConsola;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.MaskedTextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
    private System.Windows.Forms.TextBox txtNombre;
  }
}

