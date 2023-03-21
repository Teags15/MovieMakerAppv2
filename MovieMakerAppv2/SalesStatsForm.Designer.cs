namespace MovieMakerAppv2
{
    partial class SalesStatsForm
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
            this.rtbSnackStats = new System.Windows.Forms.RichTextBox();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.lblSaleStats = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbSnackStats
            // 
            this.rtbSnackStats.Location = new System.Drawing.Point(12, 62);
            this.rtbSnackStats.Name = "rtbSnackStats";
            this.rtbSnackStats.ReadOnly = true;
            this.rtbSnackStats.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbSnackStats.Size = new System.Drawing.Size(337, 376);
            this.rtbSnackStats.TabIndex = 0;
            this.rtbSnackStats.Text = "";
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.Location = new System.Drawing.Point(364, 71);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(189, 78);
            this.lblTotalProfit.TabIndex = 1;
            this.lblTotalProfit.Text = "Total Profit: $";
            // 
            // lblSaleStats
            // 
            this.lblSaleStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleStats.Location = new System.Drawing.Point(231, 9);
            this.lblSaleStats.Name = "lblSaleStats";
            this.lblSaleStats.Size = new System.Drawing.Size(306, 62);
            this.lblSaleStats.TabIndex = 2;
            this.lblSaleStats.Text = "Sale Statistics";
            this.lblSaleStats.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(670, 380);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(118, 58);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Back To Home Screen";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // SalesStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblSaleStats);
            this.Controls.Add(this.lblTotalProfit);
            this.Controls.Add(this.rtbSnackStats);
            this.Name = "SalesStatsForm";
            this.Text = "Sales Stats";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSnackStats;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label lblSaleStats;
        private System.Windows.Forms.Button btnHome;
    }
}