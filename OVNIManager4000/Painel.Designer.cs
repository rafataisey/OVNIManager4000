namespace OVNIManager4000
{
    partial class Painel
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
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnAddTripulante = new System.Windows.Forms.Button();
            this.btnRmvTripulante = new System.Windows.Forms.Button();
            this.btnAbduzir = new System.Windows.Forms.Button();
            this.btnDesabduzir = new System.Windows.Forms.Button();
            this.btnMudarPlaneta = new System.Windows.Forms.Button();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.btnRetornarOrigem = new System.Windows.Forms.Button();
            this.grbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDados
            // 
            this.grbDados.BackColor = System.Drawing.Color.Black;
            this.grbDados.Controls.Add(this.lblPlaneta);
            this.grbDados.Controls.Add(this.lblTripulantes);
            this.grbDados.Controls.Add(this.lblAbduzidos);
            this.grbDados.Controls.Add(this.lblSituacao);
            this.grbDados.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDados.ForeColor = System.Drawing.Color.White;
            this.grbDados.Location = new System.Drawing.Point(12, 12);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(271, 225);
            this.grbDados.TabIndex = 0;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados:";
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaneta.Location = new System.Drawing.Point(7, 186);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(86, 25);
            this.lblPlaneta.TabIndex = 3;
            this.lblPlaneta.Text = "Planeta:";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripulantes.Location = new System.Drawing.Point(7, 137);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(119, 25);
            this.lblTripulantes.TabIndex = 2;
            this.lblTripulantes.Text = "Tripulantes:";
            this.lblTripulantes.Click += new System.EventHandler(this.lblTripulantes_Click);
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbduzidos.Location = new System.Drawing.Point(7, 87);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(113, 25);
            this.lblAbduzidos.TabIndex = 1;
            this.lblAbduzidos.Text = "Abduzidos:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(7, 38);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(96, 25);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação:";
            // 
            // btnLigar
            // 
            this.btnLigar.BackColor = System.Drawing.Color.Purple;
            this.btnLigar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigar.ForeColor = System.Drawing.Color.White;
            this.btnLigar.Location = new System.Drawing.Point(12, 243);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(271, 40);
            this.btnLigar.TabIndex = 1;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = false;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.BackColor = System.Drawing.Color.Purple;
            this.btnDesligar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesligar.ForeColor = System.Drawing.Color.White;
            this.btnDesligar.Location = new System.Drawing.Point(13, 289);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(271, 39);
            this.btnDesligar.TabIndex = 2;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = false;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnAddTripulante
            // 
            this.btnAddTripulante.BackColor = System.Drawing.Color.Purple;
            this.btnAddTripulante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTripulante.ForeColor = System.Drawing.Color.White;
            this.btnAddTripulante.Location = new System.Drawing.Point(290, 22);
            this.btnAddTripulante.Name = "btnAddTripulante";
            this.btnAddTripulante.Size = new System.Drawing.Size(217, 47);
            this.btnAddTripulante.TabIndex = 3;
            this.btnAddTripulante.Text = "Adicionar Tripulante";
            this.btnAddTripulante.UseVisualStyleBackColor = false;
            this.btnAddTripulante.Click += new System.EventHandler(this.btnAddTripulante_Click);
            // 
            // btnRmvTripulante
            // 
            this.btnRmvTripulante.BackColor = System.Drawing.Color.Purple;
            this.btnRmvTripulante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRmvTripulante.ForeColor = System.Drawing.Color.White;
            this.btnRmvTripulante.Location = new System.Drawing.Point(290, 76);
            this.btnRmvTripulante.Name = "btnRmvTripulante";
            this.btnRmvTripulante.Size = new System.Drawing.Size(217, 48);
            this.btnRmvTripulante.TabIndex = 4;
            this.btnRmvTripulante.Text = "Remover Tripulante";
            this.btnRmvTripulante.UseVisualStyleBackColor = false;
            this.btnRmvTripulante.Click += new System.EventHandler(this.btnRmvTripulante_Click);
            // 
            // btnAbduzir
            // 
            this.btnAbduzir.BackColor = System.Drawing.Color.Purple;
            this.btnAbduzir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbduzir.ForeColor = System.Drawing.Color.White;
            this.btnAbduzir.Location = new System.Drawing.Point(290, 130);
            this.btnAbduzir.Name = "btnAbduzir";
            this.btnAbduzir.Size = new System.Drawing.Size(217, 44);
            this.btnAbduzir.TabIndex = 5;
            this.btnAbduzir.Text = "Abduzir";
            this.btnAbduzir.UseVisualStyleBackColor = false;
            this.btnAbduzir.Click += new System.EventHandler(this.btnAbduzir_Click);
            // 
            // btnDesabduzir
            // 
            this.btnDesabduzir.BackColor = System.Drawing.Color.Purple;
            this.btnDesabduzir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesabduzir.ForeColor = System.Drawing.Color.White;
            this.btnDesabduzir.Location = new System.Drawing.Point(290, 180);
            this.btnDesabduzir.Name = "btnDesabduzir";
            this.btnDesabduzir.Size = new System.Drawing.Size(217, 43);
            this.btnDesabduzir.TabIndex = 6;
            this.btnDesabduzir.Text = "Desabduzir";
            this.btnDesabduzir.UseVisualStyleBackColor = false;
            this.btnDesabduzir.Click += new System.EventHandler(this.btnDesabduzir_Click);
            // 
            // btnMudarPlaneta
            // 
            this.btnMudarPlaneta.BackColor = System.Drawing.Color.Purple;
            this.btnMudarPlaneta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMudarPlaneta.ForeColor = System.Drawing.Color.White;
            this.btnMudarPlaneta.Location = new System.Drawing.Point(422, 287);
            this.btnMudarPlaneta.Name = "btnMudarPlaneta";
            this.btnMudarPlaneta.Size = new System.Drawing.Size(85, 37);
            this.btnMudarPlaneta.TabIndex = 7;
            this.btnMudarPlaneta.Text = "Mudar";
            this.btnMudarPlaneta.UseVisualStyleBackColor = false;
            this.btnMudarPlaneta.Click += new System.EventHandler(this.btnMudarPlaneta_Click);
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.BackColor = System.Drawing.Color.Purple;
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlanetas.ForeColor = System.Drawing.Color.White;
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(290, 287);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(121, 37);
            this.cmbPlanetas.TabIndex = 8;
            this.cmbPlanetas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnRetornarOrigem
            // 
            this.btnRetornarOrigem.BackColor = System.Drawing.Color.Purple;
            this.btnRetornarOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetornarOrigem.ForeColor = System.Drawing.Color.White;
            this.btnRetornarOrigem.Location = new System.Drawing.Point(290, 229);
            this.btnRetornarOrigem.Name = "btnRetornarOrigem";
            this.btnRetornarOrigem.Size = new System.Drawing.Size(217, 52);
            this.btnRetornarOrigem.TabIndex = 9;
            this.btnRetornarOrigem.Text = "Retornar a Origem";
            this.btnRetornarOrigem.UseVisualStyleBackColor = false;
            this.btnRetornarOrigem.Click += new System.EventHandler(this.btnRetornarOrigem_Click);
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(545, 340);
            this.Controls.Add(this.btnRetornarOrigem);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.btnMudarPlaneta);
            this.Controls.Add(this.btnDesabduzir);
            this.Controls.Add(this.btnAbduzir);
            this.Controls.Add(this.btnRmvTripulante);
            this.Controls.Add(this.btnAddTripulante);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.grbDados);
            this.Name = "Painel";
            this.Text = "Painel";
            this.Load += new System.EventHandler(this.Painel_Load);
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnAddTripulante;
        private System.Windows.Forms.Button btnRmvTripulante;
        private System.Windows.Forms.Button btnAbduzir;
        private System.Windows.Forms.Button btnDesabduzir;
        private System.Windows.Forms.Button btnMudarPlaneta;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Button btnRetornarOrigem;
    }
}