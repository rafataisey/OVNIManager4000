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
            // Ativar os botões de acordo com o estado da nave:
            btnLigar.Enabled = !ovni.Situacao;
            btnDesligar.Enabled = ovni.Situacao;
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
            if (ovni.Ligar() == false)
            {
                MessageBox.Show("A nave já está ligada!");
            }
            AtualizarDados();
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            if (ovni.Desligar() == false)
            {
                MessageBox.Show("A nave já está desligada!");
            }
            AtualizarDados();
        }

        private void btnAddTripulante_Click(object sender, EventArgs e)
        {
            if (ovni.AdicionarTripulante() == false)
            {
                MessageBox.Show("Limite máximo de tripulantes atingido!");
            }
            AtualizarDados();
        }

        private void btnRmvTripulante_Click(object sender, EventArgs e)
        {
            if (ovni.RemoverTripulante() == false)
            {
                MessageBox.Show("É preciso ter pelo menos um tripulante na sua nave!");
            }
            AtualizarDados();
        }

        private void btnAbduzir_Click(object sender, EventArgs e)
        {
            if (ovni.Situacao)
            {
                if (ovni.Abduzir() == false)
                {
                    MessageBox.Show("Limite máximo de abduzidos atingido!");
                }
                AtualizarDados();
            }
            else
            {
                MessageBox.Show("A nave não pode realizar esta ação enquanto\n" +
                    "estiver desligada!");
            }
        }

        private void btnDesabduzir_Click(object sender, EventArgs e)
        {
            if(ovni.Situacao)
            {
                if(ovni.Desabduzir() == false)
                {
                    MessageBox.Show("Já não há mais quem desabduzir!");
                }
                AtualizarDados();
            }
            else
            {
                MessageBox.Show("A nave não pode realizar esta ação enquanto\n" +
                    "estiver desligada!");
            }
        }

        private void btnRetornarOrigem_Click(object sender, EventArgs e)
        {
            if(ovni.Situacao)
            {
                if(ovni.RetornarAoPlanetaDeOrigem() == false)
                {
                    MessageBox.Show("Você já está no seu Planeta de Origem!");
                }
                AtualizarDados();
            }
            else
            {
                MessageBox.Show("A nave não pode realizar esta ação enquanto\n" +
                    "estiver desligada!");
            }
        }

        private void btnMudarPlaneta_Click(object sender, EventArgs e)
        {
            if(ovni.Situacao)
            {
                if (ovni.MudarPlaneta(cmbPlanetas.Text))
                {
                    AtualizarDados();
                }
                else 
                {
                    MessageBox.Show("Você já está neste planeta!");
                }
            }
            else
            {
                MessageBox.Show("A nave não pode realizar esta ação enquanto\n" +
                    "estiver desligada!");
            }
        }
    }
}
