namespace QuimicaOrganica
{
    partial class frm_Lista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Lista));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.listHidro1 = new System.Windows.Forms.ListBox();
            this.listHidro2 = new System.Windows.Forms.ListBox();
            this.listHidro3 = new System.Windows.Forms.ListBox();
            this.listHidro4 = new System.Windows.Forms.ListBox();
            this.listHidro5 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(495, 401);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(80, 30);
            this.btnVoltar.TabIndex = 32;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // listHidro1
            // 
            this.listHidro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.listHidro1.FormattingEnabled = true;
            this.listHidro1.ItemHeight = 17;
            this.listHidro1.Items.AddRange(new object[] {
            "- Benzeno",
            "- Octano",
            "- Heptano",
            "- Isopentano",
            "- Pentano",
            "- Propano",
            "- Etano",
            "- Etileno",
            "- Acetileno",
            "- Buteno",
            "- Etilacetileno"});
            this.listHidro1.Location = new System.Drawing.Point(11, 12);
            this.listHidro1.Name = "listHidro1";
            this.listHidro1.Size = new System.Drawing.Size(108, 378);
            this.listHidro1.TabIndex = 33;
            // 
            // listHidro2
            // 
            this.listHidro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.listHidro2.FormattingEnabled = true;
            this.listHidro2.ItemHeight = 17;
            this.listHidro2.Location = new System.Drawing.Point(125, 12);
            this.listHidro2.Name = "listHidro2";
            this.listHidro2.Size = new System.Drawing.Size(108, 378);
            this.listHidro2.TabIndex = 34;
            // 
            // listHidro3
            // 
            this.listHidro3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.listHidro3.FormattingEnabled = true;
            this.listHidro3.ItemHeight = 17;
            this.listHidro3.Location = new System.Drawing.Point(239, 12);
            this.listHidro3.Name = "listHidro3";
            this.listHidro3.Size = new System.Drawing.Size(108, 378);
            this.listHidro3.TabIndex = 35;
            // 
            // listHidro4
            // 
            this.listHidro4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.listHidro4.FormattingEnabled = true;
            this.listHidro4.ItemHeight = 17;
            this.listHidro4.Location = new System.Drawing.Point(353, 12);
            this.listHidro4.Name = "listHidro4";
            this.listHidro4.Size = new System.Drawing.Size(108, 378);
            this.listHidro4.TabIndex = 36;
            // 
            // listHidro5
            // 
            this.listHidro5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.listHidro5.FormattingEnabled = true;
            this.listHidro5.ItemHeight = 17;
            this.listHidro5.Location = new System.Drawing.Point(467, 12);
            this.listHidro5.Name = "listHidro5";
            this.listHidro5.Size = new System.Drawing.Size(108, 378);
            this.listHidro5.TabIndex = 37;
            // 
            // frm_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(586, 448);
            this.Controls.Add(this.listHidro5);
            this.Controls.Add(this.listHidro4);
            this.Controls.Add(this.listHidro3);
            this.Controls.Add(this.listHidro2);
            this.Controls.Add(this.listHidro1);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(602, 487);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(602, 487);
            this.Name = "frm_Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Hidrocarbonetos";
            this.Load += new System.EventHandler(this.frm_Lista_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ListBox listHidro1;
        private System.Windows.Forms.ListBox listHidro2;
        private System.Windows.Forms.ListBox listHidro3;
        private System.Windows.Forms.ListBox listHidro4;
        private System.Windows.Forms.ListBox listHidro5;
    }
}