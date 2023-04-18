using CEPBLLs;
using System.Net;
using System.Text.RegularExpressions;

namespace WinCeps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultaCEP consultaCEP = new ConsultaCEP();
            CEP cep = consultaCEP.Consultar(txtCEP.Text);
            txtEndereco.Text = cep.Logradouro;
            txtCidade.Text = cep.Localidade;
            txtBairro.Text = cep.Bairro;

            
            }

        }
    }





