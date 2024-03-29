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
            panel1 = new Panel();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numVariavel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVariavel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVariavel3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(rdbTorricelli);
            panel1.Controls.Add(rdbMovUni);
            panel1.Controls.Add(rdbAceleracao);
            panel1.Controls.Add(rdbvelocidade);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 83);
            panel1.TabIndex = 0;
            // 
            // rdbTorricelli
            // 
            rdbTorricelli.AutoSize = true;
            rdbTorricelli.Location = new Point(622, 31);
            rdbTorricelli.Name = "rdbTorricelli";
            rdbTorricelli.Size = new Size(87, 24);
            rdbTorricelli.TabIndex = 3;
            rdbTorricelli.TabStop = true;
            rdbTorricelli.Text = "Torricelli";
            rdbTorricelli.UseVisualStyleBackColor = true;
            rdbTorricelli.CheckedChanged += rdbTorricelli_CheckedChanged;
            // 
            // rdbMovUni
            // 
            rdbMovUni.AutoSize = true;
            rdbMovUni.Location = new Point(399, 31);
            rdbMovUni.Name = "rdbMovUni";
            rdbMovUni.Size = new Size(128, 24);
            rdbMovUni.TabIndex = 2;
            rdbMovUni.TabStop = true;
            rdbMovUni.Text = "Mov. Uniforme";
            rdbMovUni.UseVisualStyleBackColor = true;
            rdbMovUni.CheckedChanged += rdbMovUni_CheckedChanged;
            // 
            // rdbAceleracao
            // 
            rdbAceleracao.AutoSize = true;
            rdbAceleracao.Location = new Point(212, 31);
            rdbAceleracao.Name = "rdbAceleracao";
            rdbAceleracao.Size = new Size(104, 24);
            rdbAceleracao.TabIndex = 1;
            rdbAceleracao.TabStop = true;
            rdbAceleracao.Text = "Aceleração";
            rdbAceleracao.UseVisualStyleBackColor = true;
            rdbAceleracao.CheckedChanged += rdbAceleracao_CheckedChanged;
            // 
            // rdbvelocidade
            // 
            rdbvelocidade.AutoSize = true;
            rdbvelocidade.Location = new Point(25, 31);
            rdbvelocidade.Name = "rdbvelocidade";
            rdbvelocidade.Size = new Size(104, 24);
            rdbvelocidade.TabIndex = 0;
            rdbvelocidade.TabStop = true;
            rdbvelocidade.Text = "Velocidade";
            rdbvelocidade.UseVisualStyleBackColor = true;
            rdbvelocidade.CheckedChanged += rdbvelocidade_CheckedChanged;
            // 
            // numVariavel1
            // 
            numVariavel1.Font = new Font("Segoe UI", 12F);
            numVariavel1.Location = new Point(293, 138);
            numVariavel1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numVariavel1.Name = "numVariavel1";
            numVariavel1.Size = new Size(279, 34);
            numVariavel1.TabIndex = 1;
            // 
            // numVariavel2
            // 
            numVariavel2.Font = new Font("Segoe UI", 12F);
            numVariavel2.Location = new Point(293, 188);
            numVariavel2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numVariavel2.Name = "numVariavel2";
            numVariavel2.Size = new Size(279, 34);
            numVariavel2.TabIndex = 2;
            // 
            // numVariavel3
            // 
            numVariavel3.Font = new Font("Segoe UI", 12F);
            numVariavel3.Location = new Point(293, 242);
            numVariavel3.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numVariavel3.Name = "numVariavel3";
            numVariavel3.Size = new Size(279, 34);
            numVariavel3.TabIndex = 3;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Segoe UI", 12F);
            lblNum1.Location = new Point(76, 144);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(65, 28);
            lblNum1.TabIndex = 4;
            lblNum1.Text = "label1";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Font = new Font("Segoe UI", 12F);
            lblNum2.Location = new Point(76, 194);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(65, 28);
            lblNum2.TabIndex = 5;
            lblNum2.Text = "label1";
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.Font = new Font("Segoe UI", 12F);
            lblNum3.Location = new Point(76, 248);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(65, 28);
            lblNum3.TabIndex = 6;
            lblNum3.Text = "label2";
            // 
            // lblMosRes
            // 
            lblMosRes.AutoSize = true;
            lblMosRes.Font = new Font("Segoe UI", 12F);
            lblMosRes.Location = new Point(104, 357);
            lblMosRes.Name = "lblMosRes";
            lblMosRes.Size = new Size(94, 28);
            lblMosRes.TabIndex = 7;
            lblMosRes.Text = "Resposta:";
            // 
            // lblResposta
            // 
            lblResposta.AutoSize = true;
            lblResposta.Font = new Font("Segoe UI", 12F);
            lblResposta.Location = new Point(270, 357);
            lblResposta.Name = "lblResposta";
            lblResposta.Size = new Size(0, 28);
            lblResposta.TabIndex = 8;
            // 
            // bntCalc
            // 
            bntCalc.Font = new Font("Segoe UI", 12F);
            bntCalc.Location = new Point(293, 304);
            bntCalc.Name = "bntCalc";
            bntCalc.Size = new Size(164, 46);
            bntCalc.TabIndex = 9;
            bntCalc.Text = "Calcular";
            bntCalc.UseVisualStyleBackColor = true;
            bntCalc.Click += bntCalc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bntCalc);
            Controls.Add(lblResposta);
            Controls.Add(lblMosRes);
            Controls.Add(lblNum3);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Controls.Add(numVariavel3);
            Controls.Add(numVariavel2);
            Controls.Add(numVariavel1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "FisicalLab 2.0 - Top";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numVariavel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVariavel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVariavel3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
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
    }
}
