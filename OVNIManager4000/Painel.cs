using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OVNIManager4000
{
    public partial class Painel : Form
    {
        // Objetos globais:
        BibliotecaOVNI.OVNI ovni;
        public Painel(BibliotecaOVNI.OVNI ovni)
        {
            InitializeComponent();
            this.ovni = ovni;
            AtualizarDados();
            // Popular o CMB:
            cmbPlanetas.DataSource = BibliotecaOVNI.OVNI.PlanetasValidos;
        }

       // Método para atualizar os dados:
       public void AtualizarDados()
        {
            lblAbduzidos.Text = "Abduzidos: " + ovni.QtdAbduzidos;
            lblTripulantes.Text = "Tripulantes: " + ovni.QtdTripulantes;
            lblSituacao.Text = "Situação: " + (ovni.Situacao ? "Ligado" : "Desligado");
            lblPlaneta.Text = "Planeta: " + ovni.PlanetaAtual;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTripulantes_Click(object sender, EventArgs e)
        {

        }

        private void Painel_Load(object sender, EventArgs e)
        {

        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            if(ovni.Ligar() == false)
            {
                MessageBox.Show("A nave já está ligada!");
            }
            AtualizarDados();
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            if(ovni.Desligar() == false)
            {
                MessageBox.Show("A nave já está desligada!");
            }
            AtualizarDados();
        }
    }
}
