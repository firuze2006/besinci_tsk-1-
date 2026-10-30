namespace besinci_tsk
{
    partial class Form1
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
            this.lblQeyd = new System.Windows.Forms.Label();
            this.lblAxtar = new System.Windows.Forms.Label();
            this.txtAxtar = new System.Windows.Forms.MaskedTextBox();
            this.rtbQeydler = new System.Windows.Forms.RichTextBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnButun = new System.Windows.Forms.Button();
            this.btnAxtar = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnCixis = new System.Windows.Forms.Button();
            this.txtQeyd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblQeyd
            // 
            this.lblQeyd.AutoSize = true;
            this.lblQeyd.Location = new System.Drawing.Point(23, 43);
            this.lblQeyd.Name = "lblQeyd";
            this.lblQeyd.Size = new System.Drawing.Size(103, 16);
            this.lblQeyd.TabIndex = 0;
            this.lblQeyd.Text = "Qeyd daxil edin:";
            // 
            // lblAxtar
            // 
            this.lblAxtar.AutoSize = true;
            this.lblAxtar.Location = new System.Drawing.Point(23, 165);
            this.lblAxtar.Name = "lblAxtar";
            this.lblAxtar.Size = new System.Drawing.Size(62, 16);
            this.lblAxtar.TabIndex = 1;
            this.lblAxtar.Text = "Acar soz:";
            // 
            // txtAxtar
            // 
            this.txtAxtar.Location = new System.Drawing.Point(26, 197);
            this.txtAxtar.Name = "txtAxtar";
            this.txtAxtar.Size = new System.Drawing.Size(264, 22);
            this.txtAxtar.TabIndex = 3;
            this.txtAxtar.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtAxtar_MaskInputRejected);
            // 
            // rtbQeydler
            // 
            this.rtbQeydler.Location = new System.Drawing.Point(26, 286);
            this.rtbQeydler.Name = "rtbQeydler";
            this.rtbQeydler.ReadOnly = true;
            this.rtbQeydler.Size = new System.Drawing.Size(264, 90);
            this.rtbQeydler.TabIndex = 4;
            this.rtbQeydler.Text = "";
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(38, 118);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(100, 23);
            this.btnYeni.TabIndex = 5;
            this.btnYeni.Text = "Yeni Qeyd";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click_1);
            // 
            // btnButun
            // 
            this.btnButun.Location = new System.Drawing.Point(189, 118);
            this.btnButun.Name = "btnButun";
            this.btnButun.Size = new System.Drawing.Size(101, 23);
            this.btnButun.TabIndex = 6;
            this.btnButun.Text = "Butun Qeydler";
            this.btnButun.UseVisualStyleBackColor = true;
            this.btnButun.Click += new System.EventHandler(this.btnButun_Click);
            // 
            // btnAxtar
            // 
            this.btnAxtar.Location = new System.Drawing.Point(104, 240);
            this.btnAxtar.Name = "btnAxtar";
            this.btnAxtar.Size = new System.Drawing.Size(90, 23);
            this.btnAxtar.TabIndex = 7;
            this.btnAxtar.Text = "Qeyd axtar";
            this.btnAxtar.UseVisualStyleBackColor = true;
            this.btnAxtar.Click += new System.EventHandler(this.btnAxtar_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(38, 404);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(128, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Butun qeydleri sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnCixis
            // 
            this.btnCixis.Location = new System.Drawing.Point(189, 404);
            this.btnCixis.Name = "btnCixis";
            this.btnCixis.Size = new System.Drawing.Size(75, 23);
            this.btnCixis.TabIndex = 9;
            this.btnCixis.Text = "Cixis";
            this.btnCixis.UseVisualStyleBackColor = true;
            this.btnCixis.Click += new System.EventHandler(this.btnCixis_Click);
            // 
            // txtQeyd
            // 
            this.txtQeyd.Location = new System.Drawing.Point(26, 80);
            this.txtQeyd.Multiline = true;
            this.txtQeyd.Name = "txtQeyd";
            this.txtQeyd.Size = new System.Drawing.Size(264, 22);
            this.txtQeyd.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.txtQeyd);
            this.Controls.Add(this.btnCixis);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnAxtar);
            this.Controls.Add(this.btnButun);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.rtbQeydler);
            this.Controls.Add(this.txtAxtar);
            this.Controls.Add(this.lblAxtar);
            this.Controls.Add(this.lblQeyd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQeyd;
        private System.Windows.Forms.Label lblAxtar;
        private System.Windows.Forms.MaskedTextBox txtAxtar;
        private System.Windows.Forms.RichTextBox rtbQeydler;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnButun;
        private System.Windows.Forms.Button btnAxtar;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnCixis;
        private System.Windows.Forms.TextBox txtQeyd;
    }
}

