namespace MovieMakerAppv2
{
    partial class HomeForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddTicketHolder = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(149, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(279, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Movie Maker App";
            // 
            // btnAddTicketHolder
            // 
            this.btnAddTicketHolder.Location = new System.Drawing.Point(202, 49);
            this.btnAddTicketHolder.Name = "btnAddTicketHolder";
            this.btnAddTicketHolder.Size = new System.Drawing.Size(172, 69);
            this.btnAddTicketHolder.TabIndex = 1;
            this.btnAddTicketHolder.Text = "Add Ticket Holder";
            this.btnAddTicketHolder.UseVisualStyleBackColor = true;
            this.btnAddTicketHolder.Click += new System.EventHandler(this.btnAddTicketHolder_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(202, 124);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(172, 81);
            this.btnStats.TabIndex = 2;
            this.btnStats.Text = "View Sale Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 412);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnAddTicketHolder);
            this.Controls.Add(this.lblTitle);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddTicketHolder;
        private System.Windows.Forms.Button btnStats;
    }
}

