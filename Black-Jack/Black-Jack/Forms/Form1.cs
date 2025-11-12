using Black_Jack.Clases;
using Black_Jack.Servicios;
using System.Collections;

namespace Black_Jack
{
    public partial class Form1 : Form
    {
        public CartasService CartasService = new CartasService();
        public ArrayList mano = new ArrayList();
        public int SumaTotal = 0;

        public Form1()
        {
            InitializeComponent();
            CartasService.GenerarCartas();
        }

        private void btnSacarCarta_Click(object sender, EventArgs e)
        {

            Cartas carta = CartasService.SacarCarta();

            lbUltimaCarta.Text = carta.Palo;

            if (carta.Id == 11)
            {
                lbNumero.Text = "J";
            }
            else if (carta.Id == 12)
            {
                lbNumero.Text = "Q";
            }
            else if (carta.Id == 13)
            {
                lbNumero.Text = "K";
            }
            else
            {
                lbNumero.Text = carta.Id.ToString();
            }

            

            SumaTotal += carta.Valor;

            lbValor.Text = SumaTotal.ToString();
        }

        private void refresh()
        {
            SumaTotal = 0;
            lbValor.Text = "";
            lbNumero.Text = "";
            lbUltimaCarta.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
