namespace StrongManGym
{
    partial class FrmSelectedClan
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
            this.dgvSelectedClan = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedClan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelectedClan
            // 
            this.dgvSelectedClan.AllowUserToAddRows = false;
            this.dgvSelectedClan.AllowUserToDeleteRows = false;
            this.dgvSelectedClan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedClan.Location = new System.Drawing.Point(12, 28);
            this.dgvSelectedClan.Name = "dgvSelectedClan";
            this.dgvSelectedClan.ReadOnly = true;
            this.dgvSelectedClan.RowHeadersWidth = 51;
            this.dgvSelectedClan.RowTemplate.Height = 24;
            this.dgvSelectedClan.Size = new System.Drawing.Size(655, 291);
            this.dgvSelectedClan.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(571, 360);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 38);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Natrag";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmSelectedClan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 436);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvSelectedClan);
            this.Name = "FrmSelectedClan";
            this.Text = "FrmSelectedClan";
            this.Load += new System.EventHandler(this.FrmSelectedClan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedClan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelectedClan;
        private System.Windows.Forms.Button btnBack;
    }
}