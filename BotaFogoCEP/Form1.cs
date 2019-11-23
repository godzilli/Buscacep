using BotaFogoCEP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotaFogoCEP
{
    public partial class JanelaCEP : Form
    {
        public JanelaCEP()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            Endereco en = new Endereco();
            string DadosColetados = null;
            string[] split = null;

            try
            {
                if (tbCep.Text != "")
                {
                    WebClient client = new WebClient();
                    client.Encoding = Encoding.UTF8;

                    DadosColetados = client.DownloadString("https://viacep.com.br/ws/" + tbCep.Text + "/json/");
                    split = DadosColetados.Split('"', '"');

                    tbRua.Text = split[7];
                    tbBairro.Text = split[15];
                    TbCidade.Text = split[19];
                    tbUf.Text = split[23];


                }
                else
                {
                    MessageBox.Show("Certifique-se de inserir um valor!",
                        "Bota Fogo - Busca CEP", MessageBoxButtons.OK);
                }
            }catch(InvalidOperationException)
            {
                MessageBox.Show(" Um erro inesperado foi encontrado.\n Reinicie a aplicação ou tente novamente." +
                    "\n Certifique-se de inserir um CEP válido.",
                    "Bota Fogo - Busca CEP", MessageBoxButtons.OK);
            }
        }
        

        private void LimparCep_Click(object sender, EventArgs e)
        {
            LimparLinhaCep();
        }
        private void LimparLinhaCep()
        {
            tbCep.Clear();
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            LimparTudo();
        }
        private void LimparTudo()
        {
            tbCep.Clear();
            TbCidade.Clear();
            tbRua.Clear();
            tbBairro.Clear();
            tbUf.Clear();

            WebClient client = new WebClient();
            Endereco en = new Endereco();

        }

        private void Copiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRua.Text);
        }

        private void Copiar2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbBairro.Text);

        }
        
    }
}
