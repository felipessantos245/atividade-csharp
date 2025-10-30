namespace Meneli_Burgueria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHamburger.Checked == true)
            {
                numericHamburguer.Enabled = true;
                txtTotalHamburguer.Enabled = true;
            }
            else
            {
                numericHamburguer.Enabled = false;
                txtTotalHamburguer.Enabled = false;
                numericHamburguer.Value = 0;
                txtTotalHamburguer.Text = "0,00";
            }
        }    

        private void checkBoxOvo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOvo.Checked == true)
            {
                numericOvo.Enabled = true;
                txtTotalOvo.Enabled = true;
            }
            else
            {
                numericOvo.Enabled = false;
                txtTotalOvo.Enabled = false;
                numericOvo.Value = 0;
                txtTotalOvo.Text = "0,00";
            }
        }

        private void checkBoxPresunto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPresunto.Checked == true)
            {
                numericPresunto.Enabled = true;
                txtTotalPresunto.Enabled= true;
            }
            else
            {
                numericPresunto.Enabled = false;
                txtTotalPresunto.Enabled = false;
                numericPresunto.Value = 0;
                txtTotalPresunto.Text = "0,00";
            }
        }

        private void checkBoxMussarela_CheckedChanged(object sender, EventArgs e)
        {
          if (checkBoxMussarela.Checked == true)
            {
                numericMussarela.Enabled = true;
                txtTotalMussarela.Enabled= true;
            }
            else 
            {
                numericMussarela.Enabled = false;
                txtTotalMussarela.Enabled = false;
                numericMussarela.Value = 0;
                txtTotalMussarela.Text = "0,00";
            }

        }
    }
            
}