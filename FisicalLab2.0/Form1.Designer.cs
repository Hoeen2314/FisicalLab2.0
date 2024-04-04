namespace FisicalLab2._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlFormula = new Panel();
            rdbTorricelli = new RadioButton();
            rdbMovUni = new RadioButton();
            rdbAceleracao = new RadioButton();
            rdbvelocidade = new RadioButton();
            numVariavel1 = new NumericUpDown();
            numVariavel2 = new NumericUpDown();
            numVariavel3 = new NumericUpDown();
            lblNum1 = new Label();
            lblNum2 = new Label();
            lblNum3 = new Label();
            lblMosRes = new Label();
            lblResposta = new Label();
            bntCalc = new Button();
            pnlData = new Panel();
            pnlFormula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numVariavel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVariavel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVariavel3).BeginInit();
            pnlData.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFormula
            // 
            pnlFormula.Controls.Add(rdbTorricelli);
            pnlFormula.Controls.Add(rdbMovUni);
            pnlFormula.Controls.Add(rdbAceleracao);
            pnlFormula.Controls.Add(rdbvelocidade);
            pnlFormula.Location = new Point(11, 12);
            pnlFormula.Name = "pnlFormula";
            pnlFormula.Size = new Size(776, 83);
            pnlFormula.TabIndex = 0;
            // 
            // rdbTorricelli
            // 
            rdbTorricelli.AutoSize = true;
            rdbTorricelli.Font = new Font("Bahnschrift SemiCondensed", 12F);
            rdbTorricelli.ForeColor = SystemColors.Desktop;
            rdbTorricelli.Location = new Point(622, 31);
            rdbTorricelli.Name = "rdbTorricelli";
            rdbTorricelli.Size = new Size(97, 28);
            rdbTorricelli.TabIndex = 3;
            rdbTorricelli.TabStop = true;
            rdbTorricelli.Text = "Torricelli";
            rdbTorricelli.UseVisualStyleBackColor = true;
            rdbTorricelli.CheckedChanged += rdbTorricelli_CheckedChanged;
            // 
            // rdbMovUni
            // 
            rdbMovUni.AutoSize = true;
            rdbMovUni.Font = new Font("Bahnschrift SemiCondensed", 12F);
            rdbMovUni.ForeColor = SystemColors.Desktop;
            rdbMovUni.Location = new Point(399, 31);
            rdbMovUni.Name = "rdbMovUni";
            rdbMovUni.Size = new Size(141, 28);
            rdbMovUni.TabIndex = 2;
            rdbMovUni.TabStop = true;
            rdbMovUni.Text = "Mov. Uniforme";
            rdbMovUni.UseVisualStyleBackColor = true;
            rdbMovUni.CheckedChanged += rdbMovUni_CheckedChanged;
            // 
            // rdbAceleracao
            // 
            rdbAceleracao.AutoSize = true;
            rdbAceleracao.Font = new Font("Bahnschrift SemiCondensed", 12F);
            rdbAceleracao.ForeColor = SystemColors.Desktop;
            rdbAceleracao.Location = new Point(213, 31);
            rdbAceleracao.Name = "rdbAceleracao";
            rdbAceleracao.Size = new Size(117, 28);
            rdbAceleracao.TabIndex = 1;
            rdbAceleracao.TabStop = true;
            rdbAceleracao.Text = "Aceleração";
            rdbAceleracao.UseVisualStyleBackColor = true;
            rdbAceleracao.CheckedChanged += rdbAceleracao_CheckedChanged;
            // 
            // rdbvelocidade
            // 
            rdbvelocidade.AutoSize = true;
            rdbvelocidade.Font = new Font("Bahnschrift SemiCondensed", 12F);
            rdbvelocidade.ForeColor = SystemColors.Desktop;
            rdbvelocidade.Location = new Point(25, 31);
            rdbvelocidade.Name = "rdbvelocidade";
            rdbvelocidade.Size = new Size(112, 28);
            rdbvelocidade.TabIndex = 0;
            rdbvelocidade.TabStop = true;
            rdbvelocidade.Text = "Velocidade";
            rdbvelocidade.UseVisualStyleBackColor = true;
            rdbvelocidade.CheckedChanged += rdbvelocidade_CheckedChanged;
            // 
            // numVariavel1
            // 
            numVariavel1.DecimalPlaces = 1;
            numVariavel1.Font = new Font("Bahnschrift SemiCondensed", 12F);
            numVariavel1.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numVariavel1.Location = new Point(297, 17);
            numVariavel1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numVariavel1.Name = "numVariavel1";
            numVariavel1.Size = new Size(279, 32);
            numVariavel1.TabIndex = 1;
            // 
            // numVariavel2
            // 
            numVariavel2.DecimalPlaces = 1;
            numVariavel2.Font = new Font("Bahnschrift SemiCondensed", 12F);
            numVariavel2.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numVariavel2.Location = new Point(297, 67);
            numVariavel2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numVariavel2.Name = "numVariavel2";
            numVariavel2.Size = new Size(279, 32);
            numVariavel2.TabIndex = 2;
            numVariavel2.ValueChanged += numVariavel2_ValueChanged;
            // 
            // numVariavel3
            // 
            numVariavel3.DecimalPlaces = 1;
            numVariavel3.Font = new Font("Bahnschrift SemiCondensed", 12F);
            numVariavel3.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numVariavel3.Location = new Point(297, 121);
            numVariavel3.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numVariavel3.Name = "numVariavel3";
            numVariavel3.Size = new Size(279, 32);
            numVariavel3.TabIndex = 3;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.BackColor = Color.Transparent;
            lblNum1.Font = new Font("Bahnschrift", 12F);
            lblNum1.ForeColor = SystemColors.Desktop;
            lblNum1.Location = new Point(80, 23);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(62, 24);
            lblNum1.TabIndex = 4;
            lblNum1.Text = "label1";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.BackColor = Color.Transparent;
            lblNum2.Font = new Font("Bahnschrift", 12F);
            lblNum2.ForeColor = SystemColors.Desktop;
            lblNum2.Location = new Point(80, 73);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(62, 24);
            lblNum2.TabIndex = 5;
            lblNum2.Text = "label1";
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.BackColor = Color.Transparent;
            lblNum3.Font = new Font("Bahnschrift", 12F);
            lblNum3.ForeColor = SystemColors.Desktop;
            lblNum3.Location = new Point(80, 127);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(65, 24);
            lblNum3.TabIndex = 6;
            lblNum3.Text = "label2";
            // 
            // lblMosRes
            // 
            lblMosRes.AutoSize = true;
            lblMosRes.BackColor = Color.Transparent;
            lblMosRes.Font = new Font("Bahnschrift", 12F);
            lblMosRes.ForeColor = SystemColors.Desktop;
            lblMosRes.Location = new Point(111, 256);
            lblMosRes.Name = "lblMosRes";
            lblMosRes.Size = new Size(99, 24);
            lblMosRes.TabIndex = 7;
            lblMosRes.Text = "Resposta:";
            // 
            // lblResposta
            // 
            lblResposta.AutoSize = true;
            lblResposta.BackColor = Color.Transparent;
            lblResposta.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResposta.Location = new Point(299, 256);
            lblResposta.Name = "lblResposta";
            lblResposta.Size = new Size(0, 24);
            lblResposta.TabIndex = 8;
            // 
            // bntCalc
            // 
            bntCalc.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntCalc.ForeColor = SystemColors.Desktop;
            bntCalc.Location = new Point(297, 183);
            bntCalc.Name = "bntCalc";
            bntCalc.Size = new Size(165, 45);
            bntCalc.TabIndex = 9;
            bntCalc.Text = "Calcular";
            bntCalc.UseVisualStyleBackColor = true;
            bntCalc.Click += bntCalc_Click;
            // 
            // pnlData
            // 
            pnlData.Controls.Add(numVariavel2);
            pnlData.Controls.Add(lblResposta);
            pnlData.Controls.Add(bntCalc);
            pnlData.Controls.Add(numVariavel1);
            pnlData.Controls.Add(numVariavel3);
            pnlData.Controls.Add(lblMosRes);
            pnlData.Controls.Add(lblNum1);
            pnlData.Controls.Add(lblNum3);
            pnlData.Controls.Add(lblNum2);
            pnlData.Location = new Point(11, 115);
            pnlData.Name = "pnlData";
            pnlData.Size = new Size(776, 337);
            pnlData.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(800, 467);
            Controls.Add(pnlData);
            Controls.Add(pnlFormula);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "FisicalLab 2.0 - Top";
            pnlFormula.ResumeLayout(false);
            pnlFormula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numVariavel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVariavel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVariavel3).EndInit();
            pnlData.ResumeLayout(false);
            pnlData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFormula;
        private RadioButton rdbTorricelli;
        private RadioButton rdbMovUni;
        private RadioButton rdbAceleracao;
        private RadioButton rdbvelocidade;
        private NumericUpDown numVariavel1;
        private NumericUpDown numVariavel2;
        private NumericUpDown numVariavel3;
        private Label lblNum1;
        private Label lblNum2;
        private Label lblNum3;
        private Label lblMosRes;
        private Label lblResposta;
        private Button bntCalc;
        private Panel pnlData;
    }
}
