namespace Pelotita_Con_Threads
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblNumero = new System.Windows.Forms.Label();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnSaludar = new System.Windows.Forms.Button();
            this.BtnCrearHilo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Location = new System.Drawing.Point(54, 9);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(13, 13);
            this.LblNumero.TabIndex = 1;
            this.LblNumero.Text = "0";
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(16, 34);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(51, 23);
            this.BtnIniciar.TabIndex = 2;
            this.BtnIniciar.Text = "&Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // BtnSaludar
            // 
            this.BtnSaludar.Location = new System.Drawing.Point(74, 33);
            this.BtnSaludar.Name = "BtnSaludar";
            this.BtnSaludar.Size = new System.Drawing.Size(53, 23);
            this.BtnSaludar.TabIndex = 3;
            this.BtnSaludar.Text = "&Saludar";
            this.BtnSaludar.UseVisualStyleBackColor = true;
            this.BtnSaludar.Click += new System.EventHandler(this.BtnSaludar_Click);
            // 
            // BtnCrearHilo
            // 
            this.BtnCrearHilo.Location = new System.Drawing.Point(32, 63);
            this.BtnCrearHilo.Name = "BtnCrearHilo";
            this.BtnCrearHilo.Size = new System.Drawing.Size(75, 23);
            this.BtnCrearHilo.TabIndex = 4;
            this.BtnCrearHilo.Text = "CrearHlo";
            this.BtnCrearHilo.UseVisualStyleBackColor = true;
            this.BtnCrearHilo.Click += new System.EventHandler(this.BtnCrearHilo_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(137, 101);
            this.Controls.Add(this.BtnCrearHilo);
            this.Controls.Add(this.BtnSaludar);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button BtnSaludar;
        private System.Windows.Forms.Button BtnCrearHilo;
    }
}