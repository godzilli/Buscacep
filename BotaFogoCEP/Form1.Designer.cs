namespace BotaFogoCEP
{
    partial class JanelaCEP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaCEP));
            this.tbCep = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.Bemvindo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LimparCep = new System.Windows.Forms.Button();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.TbCidade = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbUf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Copiar = new System.Windows.Forms.Button();
            this.Copiar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCep
            // 
            this.tbCep.Font = new System.Drawing.Font("Bahnschrift", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCep.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbCep.Location = new System.Drawing.Point(273, 141);
            this.tbCep.Multiline = true;
            this.tbCep.Name = "tbCep";
            this.tbCep.Size = new System.Drawing.Size(262, 38);
            this.tbCep.TabIndex = 0;
            // 
            // Buscar
            // 
            this.Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buscar.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(273, 205);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(85, 47);
            this.Buscar.TabIndex = 1;
            this.Buscar.Text = "BUSCAR";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Bemvindo
            // 
            this.Bemvindo.AutoSize = true;
            this.Bemvindo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bemvindo.Font = new System.Drawing.Font("Bahnschrift", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bemvindo.Location = new System.Drawing.Point(299, 20);
            this.Bemvindo.Name = "Bemvindo";
            this.Bemvindo.Size = new System.Drawing.Size(196, 41);
            this.Bemvindo.TabIndex = 2;
            this.Bemvindo.Text = "Bem-Vindo!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insira o CEP desejado abaixo:\r\n";
            // 
            // LimparCep
            // 
            this.LimparCep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LimparCep.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimparCep.Location = new System.Drawing.Point(445, 205);
            this.LimparCep.Name = "LimparCep";
            this.LimparCep.Size = new System.Drawing.Size(90, 47);
            this.LimparCep.TabIndex = 4;
            this.LimparCep.Text = "LIMPAR CEP";
            this.LimparCep.UseVisualStyleBackColor = true;
            this.LimparCep.Click += new System.EventHandler(this.LimparCep_Click);
            // 
            // tbRua
            // 
            this.tbRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRua.Location = new System.Drawing.Point(85, 304);
            this.tbRua.Multiline = true;
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(222, 50);
            this.tbRua.TabIndex = 5;
            // 
            // TbCidade
            // 
            this.TbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCidade.Location = new System.Drawing.Point(85, 411);
            this.TbCidade.Multiline = true;
            this.TbCidade.Name = "TbCidade";
            this.TbCidade.Size = new System.Drawing.Size(222, 47);
            this.TbCidade.TabIndex = 6;
            // 
            // tbBairro
            // 
            this.tbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBairro.Location = new System.Drawing.Point(444, 304);
            this.tbBairro.Multiline = true;
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(218, 50);
            this.tbBairro.TabIndex = 7;
            // 
            // tbUf
            // 
            this.tbUf.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUf.Location = new System.Drawing.Point(446, 411);
            this.tbUf.Multiline = true;
            this.tbUf.Name = "tbUf";
            this.tbUf.Size = new System.Drawing.Size(216, 47);
            this.tbUf.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rua:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bairro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(442, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "UF:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(374, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 47);
            this.button1.TabIndex = 13;
            this.button1.Text = "LIMPAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Copiar
            // 
            this.Copiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Copiar.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copiar.Location = new System.Drawing.Point(313, 304);
            this.Copiar.Name = "Copiar";
            this.Copiar.Size = new System.Drawing.Size(71, 37);
            this.Copiar.TabIndex = 14;
            this.Copiar.Text = "COPIAR";
            this.Copiar.UseVisualStyleBackColor = true;
            this.Copiar.Click += new System.EventHandler(this.Copiar_Click);
            // 
            // Copiar2
            // 
            this.Copiar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Copiar2.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copiar2.Location = new System.Drawing.Point(668, 304);
            this.Copiar2.Name = "Copiar2";
            this.Copiar2.Size = new System.Drawing.Size(71, 37);
            this.Copiar2.TabIndex = 15;
            this.Copiar2.Text = "COPIAR";
            this.Copiar2.UseVisualStyleBackColor = true;
            this.Copiar2.Click += new System.EventHandler(this.Copiar2_Click);
            // 
            // JanelaCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(818, 545);
            this.Controls.Add(this.Copiar2);
            this.Controls.Add(this.Copiar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUf);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.TbCidade);
            this.Controls.Add(this.tbRua);
            this.Controls.Add(this.LimparCep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bemvindo);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.tbCep);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JanelaCEP";
            this.Text = "Buscador de CEP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCep;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Label Bemvindo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LimparCep;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.TextBox TbCidade;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbUf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Copiar;
        private System.Windows.Forms.Button Copiar2;
    }
}

