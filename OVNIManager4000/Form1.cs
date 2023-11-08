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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            // Instanciar o outro form:
            Inicializador janela = new Inicializador();
            // Mostrar a janela:
            janela.ShowDialog();

            // Fechar o programa todo:
            Application.Exit();
        }
    }
}
