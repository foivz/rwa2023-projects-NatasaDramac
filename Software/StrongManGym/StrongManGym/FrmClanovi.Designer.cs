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
            this.btnPrikaziClana = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClanovi
            // 
            this.dgvClanovi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanovi.Location = new System.Drawing.Point(12, 72);
            this.dgvClanovi.Name = "dgvClanovi";
            this.dgvClanovi.RowHeadersWidth = 51;
            this.dgvClanovi.RowTemplate.Height = 24;
            this.dgvClanovi.Size = new System.Drawing.Size(1040, 420);
            this.dgvClanovi.TabIndex = 0;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzlaz.Location = new System.Drawing.Point(743, 550);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(124, 38);
            this.btnIzlaz.TabIndex = 1;
            this.btnIzlaz.Text = "Zabilježi izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnUlaz
            // 
            this.btnUlaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUlaz.Location = new System.Drawing.Point(743, 505);
            this.btnUlaz.Name = "btnUlaz";
            this.btnUlaz.Size = new System.Drawing.Size(124, 37);
            this.btnUlaz.TabIndex = 2;
            this.btnUlaz.Text = "Zabilježi ulaz";
            this.btnUlaz.UseVisualStyleBackColor = true;
            this.btnUlaz.Click += new System.EventHandler(this.btnUlaz_Click);
            // 
            // btnNoviClan
            // 
            this.btnNoviClan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNoviClan.Location = new System.Drawing.Point(24, 505);
            this.btnNoviClan.Name = "btnNoviClan";
            this.btnNoviClan.Size = new System.Drawing.Size(131, 37);
            this.btnNoviClan.TabIndex = 3;
            this.btnNoviClan.Text = "Upis novog člana";
            this.btnNoviClan.UseVisualStyleBackColor = true;
            this.btnNoviClan.Click += new System.EventHandler(this.btnNoviClan_Click);
            // 
            // btnPrikaziClana
            // 
            this.btnPrikaziClana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrikaziClana.Location = new System.Drawing.Point(893, 522);
            this.btnPrikaziClana.Name = "btnPrikaziClana";
            this.btnPrikaziClana.Size = new System.Drawing.Size(129, 53);
            this.btnPrikaziClana.TabIndex = 4;
            this.btnPrikaziClana.Text = "Prikaži ulaze i izlaze člana";
            this.btnPrikaziClana.UseVisualStyleBackColor = true;
            this.btnPrikaziClana.Click += new System.EventHandler(this.btnPrikaziClana_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(357, 24);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(294, 22);
            this.txtFilter.TabIndex = 5;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(37, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(256, 16);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Pretraži člana prema imenu i/ili prezimenu:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(670, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmClanovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 600);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnPrikaziClana);
            this.Controls.Add(this.btnNoviClan);
            this.Controls.Add(this.btnUlaz);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.dgvClanovi);
            this.Name = "FrmClanovi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis Članova";
            this.Load += new System.EventHandler(this.FrmClanovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClanovi;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnUlaz;
        private System.Windows.Forms.Button btnNoviClan;
        private System.Windows.Forms.Button btnPrikaziClana;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}