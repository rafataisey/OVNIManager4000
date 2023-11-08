namespace OVNIManager4000
{
    partial class Inicializador
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblPlanetaOrigem = new System.Windows.Forms.Label();
            this.nudAbduzidos = new System.Windows.Forms.NumericUpDown();
            this.nudTripulantes = new System.Windows.Forms.NumericUpDown();
            this.pibImagem = new System.Windows.Forms.PictureBox();
            this.cmbPlaneta = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAbduzidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTripulantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(131, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(297, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "OVNI Manager 4000";
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbduzidos.Location = new System.Drawing.Point(259, 88);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(143, 23);
            this.lblAbduzidos.TabIndex = 1;
            this.lblAbduzidos.Text = "Max.Abduzidos:";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripulantes.Location = new System.Drawing.Point(254, 119);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(148, 23);
            this.lblTripulantes.TabIndex = 2;
            this.lblTripulantes.Text = "Max.Tripulantes:";
            // 
            // lblPlanetaOrigem
            // 
            this.lblPlanetaOrigem.AutoSize = true;
            this.lblPlanetaOrigem.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetaOrigem.Location = new System.Drawing.Point(231, 156);
            this.lblPlanetaOrigem.Name = "lblPlanetaOrigem";
            this.lblPlanetaOrigem.Size = new System.Drawing.Size(171, 23);
            this.lblPlanetaOrigem.TabIndex = 3;
            this.lblPlanetaOrigem.Text = "Planeta de Origem:";
            // 
            // nudAbduzidos
            // 
            this.nudAbduzidos.Location = new System.Drawing.Point(408, 88);
            this.nudAbduzidos.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudAbduzidos.Name = "nudAbduzidos";
            this.nudAbduzidos.Size = new System.Drawing.Size(120, 20);
            this.nudAbduzidos.TabIndex = 4;
            // 
            // nudTripulantes
            // 
            this.nudTripulantes.Location = new System.Drawing.Point(408, 119);
            this.nudTripulantes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTripulantes.Name = "nudTripulantes";
            this.nudTripulantes.Size = new System.Drawing.Size(120, 20);
            this.nudTripulantes.TabIndex = 5;
            this.nudTripulantes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pibImagem
            // 
            this.pibImagem.Image = global::OVNIManager4000.Properties.Resources._65799991;
            this.pibImagem.Location = new System.Drawing.Point(12, 60);
            this.pibImagem.Name = "pibImagem";
            this.pibImagem.Size = new System.Drawing.Size(218, 199);
            this.pibImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibImagem.TabIndex = 7;
            this.pibImagem.TabStop = false;
            // 
            // cmbPlaneta
            // 
            this.cmbPlaneta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlaneta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlaneta.FormattingEnabled = true;
            this.cmbPlaneta.Location = new System.Drawing.Point(408, 156);
            this.cmbPlaneta.Name = "cmbPlaneta";
            this.cmbPlaneta.Size = new System.Drawing.Size(120, 24);
            this.cmbPlaneta.TabIndex = 8;
            // 
            // btnIniciar
            // 
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciar.Location = new System.Drawing.Point(299, 205);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(202, 54);
            this.btnIniciar.TabIndex = 9;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Inicializador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 284);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cmbPlaneta);
            this.Controls.Add(this.pibImagem);
            this.Controls.Add(this.nudTripulantes);
            this.Controls.Add(this.nudAbduzidos);
            this.Controls.Add(this.lblPlanetaOrigem);
            this.Controls.Add(this.lblTripulantes);
            this.Controls.Add(this.lblAbduzidos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Inicializador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicializador";
            this.Load += new System.EventHandler(this.Inicializador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAbduzidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTripulantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblPlanetaOrigem;
        private System.Windows.Forms.NumericUpDown nudAbduzidos;
        private System.Windows.Forms.NumericUpDown nudTripulantes;
        private System.Windows.Forms.PictureBox pibImagem;
        private System.Windows.Forms.ComboBox cmbPlaneta;
        private System.Windows.Forms.Button btnIniciar;
    }
}