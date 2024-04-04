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
            pnlFormula.Location = new Point(10, 9);
            pnlFormula.Margin = new Padding(3, 2, 3, 2);
            pnlFormula.Name = "pnlFormula";
            pnlFormula.Size = new Size(679, 62);
            pnlFormula.TabIndex = 0;
            // 
            // rdbTorricelli
            // 
            rdbTorricelli.AutoSize = true;
            rdbTorricelli.Font = new Font("Bahnschrift SemiCondensed", 12F);
            rdbTorricelli.ForeColor = SystemColors.Desktop;
            rdbTorricelli.Location = new Point(544, 23);
            rdbTorricelli.Margin = new Padding(3, 2, 3, 2);
            rdbTorricelli.Name = "rdbTorricelli";
            rdbTorricelli.Size = new Size(82, 23);
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
            rdbMovUni.Location = new Point(349, 23);
            rdbMovUni.Margin = new Padding(3, 2, 3, 2);
            rdbMovUni.Name = "rdbMovUni";
            rdbMovUni.Size = new Size(116, 23);
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
            rdbAceleracao.Location = new Point(186, 23);
            rdbAceleracao.Margin = new Padding(3, 2, 3, 2);
            rdbAceleracao.Name = "rdbAceleracao";
            rdbAceleracao.Size = new Size(97, 23);
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
            rdbvelocidade.Location = new Point(22, 23);
            rdbvelocidade.Margin = new Padding(3, 2, 3, 2);
            rdbvelocidade.Name = "rdbvelocidade";
            rdbvelocidade.Size = new Size(94, 23);
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
            numVariavel1.Location = new Point(260, 13);
            numVariavel1.Margin = new Padding(3, 2, 3, 2);
            numVariavel1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numVariavel1.Name = "numVariavel1";
            numVariavel1.Size = new Size(244, 27);
            numVariavel1.TabIndex = 1;
            // 
            // numVariavel2
            // 
            numVariavel2.DecimalPlaces = 1;
            numVariavel2.Font = new Font("Bahnschrift SemiCondensed", 12F);
            numVariavel2.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numVariavel2.Location = new Point(260, 50);
            numVariavel2.Margin = new Padding(3, 2, 3, 2);
            numVariavel2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numVariavel2.Name = "numVariavel2";
            numVariavel2.Size = new Size(244, 27);
            numVariavel2.TabIndex = 2;
            // 
            // numVariavel3
            // 
            numVariavel3.DecimalPlaces = 1;
            numVariavel3.Font = new Font("Bahnschrift SemiCondensed", 12F);
            numVariavel3.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numVariavel3.Location = new Point(260, 91);
            numVariavel3.Margin = new Padding(3, 2, 3, 2);
            numVariavel3.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numVariavel3.Name = "numVariavel3";
            numVariavel3.Size = new Size(244, 27);
            numVariavel3.TabIndex = 3;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.BackColor = Color.Transparent;
            lblNum1.Font = new Font("Bahnschrift", 12F);
            lblNum1.ForeColor = SystemColors.Desktop;
            lblNum1.Location = new Point(70, 17);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(51, 19);
            lblNum1.TabIndex = 4;
            lblNum1.Text = "label1";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.BackColor = Color.Transparent;
            lblNum2.Font = new Font("Bahnschrift", 12F);
            lblNum2.ForeColor = SystemColors.Desktop;
            lblNum2.Location = new Point(70, 55);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(51, 19);
            lblNum2.TabIndex = 5;
            lblNum2.Text = "label1";
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.BackColor = Color.Transparent;
            lblNum3.Font = new Font("Bahnschrift", 12F);
            lblNum3.ForeColor = SystemColors.Desktop;
            lblNum3.Location = new Point(70, 95);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(54, 19);
            lblNum3.TabIndex = 6;
            lblNum3.Text = "label2";
            // 
            // lblMosRes
            // 
            lblMosRes.AutoSize = true;
            lblMosRes.BackColor = Color.Transparent;
            lblMosRes.Font = new Font("Bahnschrift", 12F);
            lblMosRes.ForeColor = SystemColors.Desktop;
            lblMosRes.Location = new Point(97, 192);
            lblMosRes.Name = "lblMosRes";
            lblMosRes.Size = new Size(80, 19);
            lblMosRes.TabIndex = 7;
            lblMosRes.Text = "Resposta:";
            // 
            // lblResposta
            // 
            lblResposta.AutoSize = true;
            lblResposta.BackColor = Color.Transparent;
            lblResposta.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResposta.Location = new Point(262, 192);
            lblResposta.Name = "lblResposta";
            lblResposta.Size = new Size(0, 19);
            lblResposta.TabIndex = 8;
            // 
            // bntCalc
            // 
            bntCalc.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntCalc.ForeColor = SystemColors.Desktop;
            bntCalc.Location = new Point(260, 137);
            bntCalc.Margin = new Padding(3, 2, 3, 2);
            bntCalc.Name = "bntCalc";
            bntCalc.Size = new Size(144, 34);
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
            pnlData.Location = new Point(10, 86);
            pnlData.Margin = new Padding(3, 2, 3, 2);
            pnlData.Name = "pnlData";
            pnlData.Size = new Size(679, 253);
            pnlData.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(700, 350);
            Controls.Add(pnlData);
            Controls.Add(pnlFormula);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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
