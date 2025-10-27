using System.Drawing;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}

private void btnIgual_Click(object sender, EventArgs e)
{
    try
    {
        switch (operacaoselecionada)
        {
            case "adicao":
                resultado = valor + decimal.Parse(lblVisor.Text);
                break;
            case "subtracao":
                resultado = valor - decimal.Parse(lblVisor.Text);
                break;
            case "divisao":
                if (decimal.Parse(lblVisor.Text) == 0)
                {
                    throw new DivideByZeroException("Não é possível dividir o número " + valor);
                }
                resultado = valor / decimal.Parse(lblVisor.Text);
                break;
            case "multiplicacao":
                resultado = valor * decimal.Parse(lblVisor.Text);
                break;
        }

        lblVisor.Text = resultado.ToString();
    }
    catch (DivideByZeroException ex)
    {
        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        lblVisor.Text = "";
    }
}

private void btnSoma_Click(object sender, EventArgs e)
{
    operacaoselecionada = "adicao";
    valor = decimal.Parse(lblVisor.Text);
    lblVisor.Text = "";
    lblOperacao.Text = "+";
}

private void btnSubtrair_Click(object sender, EventArgs e)
{
    operacaoselecionada = "subtracao";
    valor = decimal.Parse(lblVisor.Text);
    lblVisor.Text = "";
    lblOperacao.Text = "-";
}

private void btnMultiplicar_Click(object sender, EventArgs e)
{
    operacaoselecionada = "multiplicacao";
    valor = decimal.Parse(lblVisor.Text);
    lblVisor.Text = "";
    lblOperacao.Text = "x";
}

private void btnDividir_Click(object sender, EventArgs e)
{
    operacaoselecionada = "divisao";
    valor = decimal.Parse(lblVisor.Text);
    lblVisor.Text = "";
    lblOperacao.Text = "÷";
}

private void btnApagar_Click(object sender, EventArgs e)
{
    lblVisor.Text = "";
    lblOperacao.Text = "";
    resultado = 0;
    valor = 0;
}