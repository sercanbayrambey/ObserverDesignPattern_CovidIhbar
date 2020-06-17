namespace Observer
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
            this.btnIhbar = new System.Windows.Forms.Button();
            this.tboxSehir = new System.Windows.Forms.TextBox();
            this.tboxIlce = new System.Windows.Forms.TextBox();
            this.tboxAcikAdres = new System.Windows.Forms.TextBox();
            this.lblSehir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.tboxAciklama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIhbar
            // 
            this.btnIhbar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIhbar.Location = new System.Drawing.Point(477, 272);
            this.btnIhbar.Name = "btnIhbar";
            this.btnIhbar.Size = new System.Drawing.Size(258, 91);
            this.btnIhbar.TabIndex = 0;
            this.btnIhbar.Text = "IHBAR";
            this.btnIhbar.UseVisualStyleBackColor = true;
            this.btnIhbar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tboxSehir
            // 
            this.tboxSehir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxSehir.Location = new System.Drawing.Point(483, 130);
            this.tboxSehir.Name = "tboxSehir";
            this.tboxSehir.Size = new System.Drawing.Size(252, 26);
            this.tboxSehir.TabIndex = 1;
            // 
            // tboxIlce
            // 
            this.tboxIlce.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxIlce.Location = new System.Drawing.Point(483, 162);
            this.tboxIlce.Name = "tboxIlce";
            this.tboxIlce.Size = new System.Drawing.Size(252, 26);
            this.tboxIlce.TabIndex = 2;
            // 
            // tboxAcikAdres
            // 
            this.tboxAcikAdres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxAcikAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxAcikAdres.Location = new System.Drawing.Point(483, 194);
            this.tboxAcikAdres.Name = "tboxAcikAdres";
            this.tboxAcikAdres.Size = new System.Drawing.Size(252, 26);
            this.tboxAcikAdres.TabIndex = 3;
            // 
            // lblSehir
            // 
            this.lblSehir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSehir.AutoSize = true;
            this.lblSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSehir.Location = new System.Drawing.Point(418, 132);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(59, 24);
            this.lblSehir.TabIndex = 4;
            this.lblSehir.Text = "Şehir:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(433, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "İlçe:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(371, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Açık Adres:";
            // 
            // lblAciklama
            // 
            this.lblAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(386, 229);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(91, 24);
            this.lblAciklama.TabIndex = 8;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // tboxAciklama
            // 
            this.tboxAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxAciklama.Location = new System.Drawing.Point(483, 229);
            this.tboxAciklama.Name = "tboxAciklama";
            this.tboxAciklama.Size = new System.Drawing.Size(252, 26);
            this.tboxAciklama.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 629);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.tboxAciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSehir);
            this.Controls.Add(this.tboxAcikAdres);
            this.Controls.Add(this.tboxIlce);
            this.Controls.Add(this.tboxSehir);
            this.Controls.Add(this.btnIhbar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIhbar;
        private System.Windows.Forms.TextBox tboxSehir;
        private System.Windows.Forms.TextBox tboxIlce;
        private System.Windows.Forms.TextBox tboxAcikAdres;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox tboxAciklama;
    }
}

