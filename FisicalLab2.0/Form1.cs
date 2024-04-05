namespace FisicalLab2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rdbvelocidade.Checked = true;
            pnlData.BackColor = Color.FromArgb(190, 255, 255, 255);
            VerificarCondicao();
        }

        private void bntCalc_Click(object sender, EventArgs e)
        {
            if (rdbvelocidade.Checked)
            {
                float res = (float)numVariavel1.Value / (float)numVariavel2.Value;
                lblResposta.Text = res.ToString();
            }
            else if (rdbAceleracao.Checked)
            {
                float res = (float)numVariavel1.Value / (float)numVariavel2.Value;
                lblResposta.Text = res.ToString();
            }
            else if (rdbMovUni.Checked)
            {
                float res = (float)numVariavel1.Value + ((float)numVariavel2.Value * (float)numVariavel3.Value);
                lblResposta.Text = res.ToString();
            }
            else if (rdbTorricelli.Checked)
            {
                float v0 = (float)numVariavel1.Value;
                float a = (float)numVariavel2.Value;
                float s = (float)numVariavel3.Value;
                float res = (float)Math.Sqrt(Math.Pow(v0, 2) + 2 * a * s);
                lblResposta.Text = res.ToString();
            }
        }

        private void rdbvelocidade_CheckedChanged(object sender, EventArgs e)
        {
            VerificarCondicao();
            numVariavel3.Visible = false;
            lblNum3.Visible = false;
            lblNum1.Text = "Distancia:";
            lblNum2.Text = "Tempo";
            lblMosRes.Text = "Velocidade:";
        }

        private void rdbAceleracao_CheckedChanged(object sender, EventArgs e)
        {
            VerificarCondicao();
            numVariavel3.Visible = false;
            lblNum3.Visible = false;
            lblNum1.Text = "Velocidade:";
            lblNum2.Text = "Tempo:";
            lblMosRes.Text = "Acelera��o:";
        }

        private void rdbMovUni_CheckedChanged(object sender, EventArgs e)
        {
            lblNum1.Text = "Espa�o inicial:";
            lblNum2.Text = "Velocidade:";
            lblNum3.Text = "Tempo:";
            lblMosRes.Text = "Espa�o:";
            numVariavel3.Visible = true;
            lblNum3.Visible = true;
        }

        private void rdbTorricelli_CheckedChanged(object sender, EventArgs e)
        {
            lblNum1.Text = "Velocidade inicial:";
            lblNum2.Text = "acelera��o:";
            lblNum3.Text = "Espa�o:";
            lblMosRes.Text = "Velocidade:";
            numVariavel3.Visible = true;
            lblNum3.Visible = true;
        }

        private void numVariavel2_ValueChanged(object sender, EventArgs e)
        {
            VerificarCondicao();
        }
        private void VerificarCondicao() //fun��o para atualizar o teste de condi��o
        {
            if(numVariavel2.Value == 0)
                bntCalc.Enabled = false;
            else
                bntCalc.Enabled = true;
        }
    }
}
