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
            lblMosRes.Text = "Aceleração:";
        }

        private void rdbMovUni_CheckedChanged(object sender, EventArgs e)
        {
            lblNum1.Text = "Espaço inicial:";
            lblNum2.Text = "Velocidade:";
            lblNum3.Text = "Tempo:";
            lblMosRes.Text = "Espaço:";
            numVariavel3.Visible = true;
            lblNum3.Visible = true;
        }

        private void rdbTorricelli_CheckedChanged(object sender, EventArgs e)
        {
            lblNum1.Text = "Velocidade inicial:";
            lblNum2.Text = "aceleração:";
            lblNum3.Text = "Espaço:";
            lblMosRes.Text = "Velocidade:";
            numVariavel3.Visible = true;
            lblNum3.Visible = true;
        }

        private void numVariavel2_ValueChanged(object sender, EventArgs e)
        {
            VerificarCondicao();
        }
        private void VerificarCondicao() //função para atualizar o teste de condição
        {
            if(numVariavel2.Value == 0)
                bntCalc.Enabled = false;
            else
                bntCalc.Enabled = true;
        }
    }
}
