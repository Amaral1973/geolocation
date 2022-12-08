using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;

namespace geolocalizador_de_ip
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            //this.ActiveControl = txbIpPublico; //Método que retorna o objeto que recebeu o Focus, no caso 'txbIpPublico'.
            //txbIpPublico.Focus(); //Chama o método Focus para definir o foco no controle TextBox com Name 'txbIpPublico'.

            if (!txbIpPublico.Focus()) //Quando ininicado o form, se o textbox 'txbIpPublico' não estiver com o cursor...
            {
                btnRecarregar_Click(new object(), new EventArgs()); //Chama a função do botão 'btnRecarrecgar' para preencher o textbox automaticamente com o IP Público da rede;
            }
        }

        private void txbIpPublico_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Vai verificar se os caracteres digitados não são números;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != '.') //Não aceita os caracteres de letras do teclado e ´números do teclado númerico sem o NumLock;
            {
                e.Handled = true; //Cancela o evento se o usuário digitar tecla não numérica no 'txbIpPublico'.
            }
        }

        /*
         private void tbxIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //1º vai verificar se os caracteres digitados não são números;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44 && e.KeyChar != '.') //Não aceita os caracteres de letras do teclado e ´números do teclado númerico sem o NumLock;
            {
                e.Handled = true; //Cancela o evento se o usuário digitar tecla não numérica no 'txbIpPublico'.
            }
        }
         */

        private void btnGeolocalizar_Click(object sender, EventArgs e)
        {
            FrmResultados localizacao = new FrmResultados(); //Cria o objeto 'FormResultado'.

            localizacao.ipString = txbIpPublico.Text; //Enviando o texto da textbox 'txbIpPublico' para a string 'ipString' do form 'FormResultados';

            localizacao.Show(); //Exibe o objeto (janela) do 'FormResultado.'
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            string ipExterno = client.DownloadString("https://ipinfo.io/ip"); //Acessando webservice que retorna o IP Público;

            txbIpPublico.Text = ipExterno; //Textbox recebe a string 'ipExterno' com o IP Público;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close(); //Fecha o programa.
        }
    }
}