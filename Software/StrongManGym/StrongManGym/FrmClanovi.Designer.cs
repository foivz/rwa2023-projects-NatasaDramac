namespace StrongManGym
{
    partial class FrmClanovi
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
            this.dgvClanovi = new System.Windows.Forms.DataGridView();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnUlaz = new System.Windows.Forms.Button();
            this.btnNoviClan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClanovi
            // 
            this.dgvClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanovi.Location = new System.Drawing.Point(23, 12);
            this.dgvClanovi.Name = "dgvClanovi";
            this.dgvClanovi.RowHeadersWidth = 51;
            this.dgvClanovi.RowTemplate.Height = 24;
            this.dgvClanovi.Size = new System.Drawing.Size(752, 346);
            this.dgvClanovi.TabIndex = 0;
            this.dgvClanovi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClanovi_CellContentClick);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(623, 394);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(124, 38);
            this.btnIzlaz.TabIndex = 1;
            this.btnIzlaz.Text = "Zabilježi izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnUlaz
            // 
            this.btnUlaz.Location = new System.Drawing.Point(479, 394);
            this.btnUlaz.Name = "btnUlaz";
            this.btnUlaz.Size = new System.Drawing.Size(124, 37);
            this.btnUlaz.TabIndex = 2;
            this.btnUlaz.Text = "Zabilježi ulaz";
            this.btnUlaz.UseVisualStyleBackColor = true;
            this.btnUlaz.Click += new System.EventHandler(this.btnUlaz_Click);
            // 
            // btnNoviClan
            // 
            this.btnNoviClan.Location = new System.Drawing.Point(324, 394);
            this.btnNoviClan.Name = "btnNoviClan";
            this.btnNoviClan.Size = new System.Drawing.Size(131, 37);
            this.btnNoviClan.TabIndex = 3;
            this.btnNoviClan.Text = "Upis novog člana";
            this.btnNoviClan.UseVisualStyleBackColor = true;
            this.btnNoviClan.Click += new System.EventHandler(this.btnNoviClan_Click);
            // 
            // FrmClanovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNoviClan);
            this.Controls.Add(this.btnUlaz);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.dgvClanovi);
            this.Name = "FrmClanovi";
            this.Text = "Popis Članova";
            this.Load += new System.EventHandler(this.FrmClanovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClanovi;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnUlaz;
        private System.Windows.Forms.Button btnNoviClan;
    }
}