namespace AnimaisPrologApp
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
            this.labelInstrucao = new System.Windows.Forms.Label();
            this.comboBoxAnimalName = new System.Windows.Forms.ComboBox();
            this.btnIsBird = new System.Windows.Forms.Button();
            this.btnIsMammal = new System.Windows.Forms.Button();
            this.btnIsDangerous = new System.Windows.Forms.Button();
            this.btnIsDomestic = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInstrucao
            // 
            this.labelInstrucao.AutoSize = true;
            this.labelInstrucao.Font = new System.Drawing.Font("NSimSun", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstrucao.Location = new System.Drawing.Point(49, 33);
            this.labelInstrucao.Name = "labelInstrucao";
            this.labelInstrucao.Size = new System.Drawing.Size(378, 37);
            this.labelInstrucao.TabIndex = 0;
            this.labelInstrucao.Text = "Selecione o animal:";
            // 
            // comboBoxAnimalName
            // 
            this.comboBoxAnimalName.FormattingEnabled = true;
            this.comboBoxAnimalName.Location = new System.Drawing.Point(56, 96);
            this.comboBoxAnimalName.Name = "comboBoxAnimalName";
            this.comboBoxAnimalName.Size = new System.Drawing.Size(371, 21);
            this.comboBoxAnimalName.TabIndex = 1;
            // 
            // btnIsBird
            // 
            this.btnIsBird.Location = new System.Drawing.Point(56, 171);
            this.btnIsBird.Name = "btnIsBird";
            this.btnIsBird.Size = new System.Drawing.Size(95, 23);
            this.btnIsBird.TabIndex = 2;
            this.btnIsBird.Text = "É Pássaro?";
            this.btnIsBird.UseVisualStyleBackColor = true;
            this.btnIsBird.Click += new System.EventHandler(this.btnIsBird_Click);
            // 
            // btnIsMammal
            // 
            this.btnIsMammal.Location = new System.Drawing.Point(56, 218);
            this.btnIsMammal.Name = "btnIsMammal";
            this.btnIsMammal.Size = new System.Drawing.Size(95, 23);
            this.btnIsMammal.TabIndex = 3;
            this.btnIsMammal.Text = "É Mamífero?";
            this.btnIsMammal.UseVisualStyleBackColor = true;
            this.btnIsMammal.Click += new System.EventHandler(this.btnIsMammal_Click);
            // 
            // btnIsDangerous
            // 
            this.btnIsDangerous.Location = new System.Drawing.Point(56, 267);
            this.btnIsDangerous.Name = "btnIsDangerous";
            this.btnIsDangerous.Size = new System.Drawing.Size(95, 23);
            this.btnIsDangerous.TabIndex = 4;
            this.btnIsDangerous.Text = "É Perigoso?";
            this.btnIsDangerous.UseVisualStyleBackColor = true;
            this.btnIsDangerous.Click += new System.EventHandler(this.btnIsDangerous_Click);
            // 
            // btnIsDomestic
            // 
            this.btnIsDomestic.Location = new System.Drawing.Point(56, 306);
            this.btnIsDomestic.Name = "btnIsDomestic";
            this.btnIsDomestic.Size = new System.Drawing.Size(95, 23);
            this.btnIsDomestic.TabIndex = 5;
            this.btnIsDomestic.Text = "É Doméstico?";
            this.btnIsDomestic.UseVisualStyleBackColor = true;
            this.btnIsDomestic.Click += new System.EventHandler(this.btnIsDomestic_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Yi Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(56, 359);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 29);
            this.labelResult.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Feito por Rafael Costa Monte Alegre e Lucca Marchetti";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.btnIsDomestic);
            this.Controls.Add(this.btnIsDangerous);
            this.Controls.Add(this.btnIsMammal);
            this.Controls.Add(this.btnIsBird);
            this.Controls.Add(this.comboBoxAnimalName);
            this.Controls.Add(this.labelInstrucao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInstrucao;
        private System.Windows.Forms.ComboBox comboBoxAnimalName;
        private System.Windows.Forms.Button btnIsBird;
        private System.Windows.Forms.Button btnIsMammal;
        private System.Windows.Forms.Button btnIsDangerous;
        private System.Windows.Forms.Button btnIsDomestic;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label1;
    }
}

