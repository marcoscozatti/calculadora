namespace Calculadora1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.txtDisplay = new System.Windows.Forms.TextBox();
			this.btn7 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn0 = new System.Windows.Forms.Button();
			this.btnVirgula = new System.Windows.Forms.Button();
			this.btnDividir = new System.Windows.Forms.Button();
			this.btnMultiplicar = new System.Windows.Forms.Button();
			this.btnSubtracao = new System.Windows.Forms.Button();
			this.btnAdicao = new System.Windows.Forms.Button();
			this.btnC = new System.Windows.Forms.Button();
			this.btnIgual = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtDisplay
			// 
			this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDisplay.Location = new System.Drawing.Point(12, 12);
			this.txtDisplay.Multiline = true;
			this.txtDisplay.Name = "txtDisplay";
			this.txtDisplay.Size = new System.Drawing.Size(294, 66);
			this.txtDisplay.TabIndex = 0;
			this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btn7
			// 
			this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn7.Location = new System.Drawing.Point(14, 84);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(53, 61);
			this.btn7.TabIndex = 1;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = true;
			this.btn7.Click += new System.EventHandler(this.btnNumerador);
			// 
			// btn8
			// 
			this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn8.Location = new System.Drawing.Point(73, 84);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(53, 61);
			this.btn8.TabIndex = 2;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = true;
			this.btn8.Click += new System.EventHandler(this.btnNumerador);
			// 
			// btn9
			// 
			this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn9.Location = new System.Drawing.Point(132, 84);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(53, 61);
			this.btn9.TabIndex = 3;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = true;
			this.btn9.Click += new System.EventHandler(this.btnNumerador);
			// 
			// btn6
			// 
			this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn6.Location = new System.Drawing.Point(132, 151);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(53, 61);
			this.btn6.TabIndex = 7;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = true;
			this.btn6.Click += new System.EventHandler(this.btnNumerador);
			// 
			// btn5
			// 
			this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn5.Location = new System.Drawing.Point(73, 151);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(53, 61);
			this.btn5.TabIndex = 6;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = true;
			this.btn5.Click += new System.EventHandler(this.btnNumerador);
			// 
			// btn4
			// 
			this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn4.Location = new System.Drawing.Point(14, 151);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(53, 61);
			this.btn4.TabIndex = 5;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = true;
			this.btn4.Click += new System.EventHandler(this.btnNumerador);
			// 
			// btn3
			// 
			this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn3.Location = new System.Drawing.Point(132, 218);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(53, 61);
			this.btn3.TabIndex = 10;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = true;
			this.btn3.Click += new System.EventHandler(this.btnNumerador);
			// 
			// btn2
			// 
			this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn2.Location = new System.Drawing.Point(73, 218);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(53, 61);
			this.btn2.TabIndex = 9;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.btnNumerador);
			// 
			// btn1
			// 
			this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn1.Location = new System.Drawing.Point(14, 218);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(53, 61);
			this.btn1.TabIndex = 8;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.btnNumerador);
			// 
			// btn0
			// 
			this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn0.Location = new System.Drawing.Point(14, 285);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(112, 61);
			this.btn0.TabIndex = 11;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = true;
			this.btn0.Click += new System.EventHandler(this.btnNumerador);
			// 
			// btnVirgula
			// 
			this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVirgula.Location = new System.Drawing.Point(132, 285);
			this.btnVirgula.Name = "btnVirgula";
			this.btnVirgula.Size = new System.Drawing.Size(53, 61);
			this.btnVirgula.TabIndex = 12;
			this.btnVirgula.Text = ",";
			this.btnVirgula.UseVisualStyleBackColor = true;
			this.btnVirgula.Click += new System.EventHandler(this.btnNumerador);
			// 
			// btnDividir
			// 
			this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDividir.Location = new System.Drawing.Point(255, 218);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(53, 61);
			this.btnDividir.TabIndex = 18;
			this.btnDividir.Text = "/";
			this.btnDividir.UseVisualStyleBackColor = true;
			this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
			// 
			// btnMultiplicar
			// 
			this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMultiplicar.Location = new System.Drawing.Point(191, 218);
			this.btnMultiplicar.Name = "btnMultiplicar";
			this.btnMultiplicar.Size = new System.Drawing.Size(53, 61);
			this.btnMultiplicar.TabIndex = 17;
			this.btnMultiplicar.Text = "x";
			this.btnMultiplicar.UseVisualStyleBackColor = true;
			this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
			// 
			// btnSubtracao
			// 
			this.btnSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubtracao.Location = new System.Drawing.Point(255, 151);
			this.btnSubtracao.Name = "btnSubtracao";
			this.btnSubtracao.Size = new System.Drawing.Size(53, 61);
			this.btnSubtracao.TabIndex = 16;
			this.btnSubtracao.Text = "-";
			this.btnSubtracao.UseVisualStyleBackColor = true;
			this.btnSubtracao.Click += new System.EventHandler(this.btnSubracao);
			// 
			// btnAdicao
			// 
			this.btnAdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdicao.Location = new System.Drawing.Point(191, 151);
			this.btnAdicao.Name = "btnAdicao";
			this.btnAdicao.Size = new System.Drawing.Size(53, 61);
			this.btnAdicao.TabIndex = 15;
			this.btnAdicao.Text = "+";
			this.btnAdicao.UseVisualStyleBackColor = true;
			this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
			// 
			// btnC
			// 
			this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnC.Location = new System.Drawing.Point(191, 84);
			this.btnC.Name = "btnC";
			this.btnC.Size = new System.Drawing.Size(117, 61);
			this.btnC.TabIndex = 13;
			this.btnC.Text = "C";
			this.btnC.UseVisualStyleBackColor = true;
			this.btnC.Click += new System.EventHandler(this.btnC_Click);
			// 
			// btnIgual
			// 
			this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIgual.Location = new System.Drawing.Point(191, 285);
			this.btnIgual.Name = "btnIgual";
			this.btnIgual.Size = new System.Drawing.Size(115, 61);
			this.btnIgual.TabIndex = 19;
			this.btnIgual.Text = "=";
			this.btnIgual.UseVisualStyleBackColor = true;
			this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 20);
			this.label1.TabIndex = 21;
			this.label1.Text = "...";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 360);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnIgual);
			this.Controls.Add(this.btnDividir);
			this.Controls.Add(this.btnMultiplicar);
			this.Controls.Add(this.btnSubtracao);
			this.Controls.Add(this.btnAdicao);
			this.Controls.Add(this.btnC);
			this.Controls.Add(this.btnVirgula);
			this.Controls.Add(this.btn0);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.btn6);
			this.Controls.Add(this.btn5);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btn9);
			this.Controls.Add(this.btn8);
			this.Controls.Add(this.btn7);
			this.Controls.Add(this.txtDisplay);
			this.Name = "Form1";
			this.Text = "Calculadora";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Label label1;
    }
}

