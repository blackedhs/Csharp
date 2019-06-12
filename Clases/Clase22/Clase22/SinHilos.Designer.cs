namespace Clase22
{
  partial class SinHilos
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
            this.components = new System.ComponentModel.Container();
            this.BtnUno = new System.Windows.Forms.Button();
            this.BtnDos = new System.Windows.Forms.Button();
            this.BtnTres = new System.Windows.Forms.Button();
            this.BtnCuatro = new System.Windows.Forms.Button();
            this.TxtUno = new System.Windows.Forms.TextBox();
            this.TxtDos = new System.Windows.Forms.TextBox();
            this.TxtTres = new System.Windows.Forms.TextBox();
            this.TxtCuatro = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BtnUno
            // 
            this.BtnUno.Location = new System.Drawing.Point(12, 100);
            this.BtnUno.Name = "BtnUno";
            this.BtnUno.Size = new System.Drawing.Size(75, 23);
            this.BtnUno.TabIndex = 0;
            this.BtnUno.Text = "1";
            this.BtnUno.UseVisualStyleBackColor = true;
            this.BtnUno.Click += new System.EventHandler(this.BtnUno_Click);
            // 
            // BtnDos
            // 
            this.BtnDos.Location = new System.Drawing.Point(143, 100);
            this.BtnDos.Name = "BtnDos";
            this.BtnDos.Size = new System.Drawing.Size(75, 23);
            this.BtnDos.TabIndex = 1;
            this.BtnDos.Text = "2";
            this.BtnDos.UseVisualStyleBackColor = true;
            this.BtnDos.Click += new System.EventHandler(this.BtnDos_Click);
            // 
            // BtnTres
            // 
            this.BtnTres.Location = new System.Drawing.Point(274, 100);
            this.BtnTres.Name = "BtnTres";
            this.BtnTres.Size = new System.Drawing.Size(75, 23);
            this.BtnTres.TabIndex = 2;
            this.BtnTres.Text = "3";
            this.BtnTres.UseVisualStyleBackColor = true;
            this.BtnTres.Click += new System.EventHandler(this.BtnTres_Click);
            // 
            // BtnCuatro
            // 
            this.BtnCuatro.Location = new System.Drawing.Point(405, 100);
            this.BtnCuatro.Name = "BtnCuatro";
            this.BtnCuatro.Size = new System.Drawing.Size(75, 23);
            this.BtnCuatro.TabIndex = 3;
            this.BtnCuatro.Text = "4";
            this.BtnCuatro.UseVisualStyleBackColor = true;
            this.BtnCuatro.Click += new System.EventHandler(this.BtnCuatro_Click);
            // 
            // TxtUno
            // 
            this.TxtUno.Location = new System.Drawing.Point(12, 12);
            this.TxtUno.Name = "TxtUno";
            this.TxtUno.Size = new System.Drawing.Size(125, 20);
            this.TxtUno.TabIndex = 4;
            // 
            // TxtDos
            // 
            this.TxtDos.Location = new System.Drawing.Point(143, 12);
            this.TxtDos.Name = "TxtDos";
            this.TxtDos.Size = new System.Drawing.Size(125, 20);
            this.TxtDos.TabIndex = 5;
            // 
            // TxtTres
            // 
            this.TxtTres.Location = new System.Drawing.Point(274, 12);
            this.TxtTres.Name = "TxtTres";
            this.TxtTres.Size = new System.Drawing.Size(125, 20);
            this.TxtTres.TabIndex = 6;
            // 
            // TxtCuatro
            // 
            this.TxtCuatro.Location = new System.Drawing.Point(405, 12);
            this.TxtCuatro.Name = "TxtCuatro";
            this.TxtCuatro.Size = new System.Drawing.Size(125, 20);
            this.TxtCuatro.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 135);
            this.Controls.Add(this.TxtCuatro);
            this.Controls.Add(this.TxtTres);
            this.Controls.Add(this.TxtDos);
            this.Controls.Add(this.TxtUno);
            this.Controls.Add(this.BtnCuatro);
            this.Controls.Add(this.BtnTres);
            this.Controls.Add(this.BtnDos);
            this.Controls.Add(this.BtnUno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BtnUno;
    private System.Windows.Forms.Button BtnDos;
    private System.Windows.Forms.Button BtnTres;
    private System.Windows.Forms.Button BtnCuatro;
    private System.Windows.Forms.TextBox TxtUno;
    private System.Windows.Forms.TextBox TxtDos;
    private System.Windows.Forms.TextBox TxtTres;
    private System.Windows.Forms.TextBox TxtCuatro;
    private System.Windows.Forms.Timer timer1;
  }
}

