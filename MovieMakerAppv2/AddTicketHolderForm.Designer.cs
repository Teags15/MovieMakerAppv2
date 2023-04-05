namespace MovieMakerAppv2
{
    partial class AddTicketHolderForm
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
            this.lblTicketHolderName = new System.Windows.Forms.Label();
            this.tbxTicketHolderName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.lblNoTickets = new System.Windows.Forms.Label();
            this.nudNoTickets = new System.Windows.Forms.NumericUpDown();
            this.btnSnackBar = new System.Windows.Forms.Button();
            this.lblAddTicketHolder = new System.Windows.Forms.Label();
            this.rbnCash = new System.Windows.Forms.RadioButton();
            this.rbnCard = new System.Windows.Forms.RadioButton();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTicketHolderName
            // 
            this.lblTicketHolderName.AutoSize = true;
            this.lblTicketHolderName.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketHolderName.Location = new System.Drawing.Point(13, 70);
            this.lblTicketHolderName.Name = "lblTicketHolderName";
            this.lblTicketHolderName.Size = new System.Drawing.Size(161, 14);
            this.lblTicketHolderName.TabIndex = 0;
            this.lblTicketHolderName.Text = "Enter the ticket holders name:";
            // 
            // tbxTicketHolderName
            // 
            this.tbxTicketHolderName.Location = new System.Drawing.Point(12, 86);
            this.tbxTicketHolderName.Name = "tbxTicketHolderName";
            this.tbxTicketHolderName.Size = new System.Drawing.Size(149, 20);
            this.tbxTicketHolderName.TabIndex = 1;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(13, 125);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(152, 14);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Enter the ticket holders age:";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(12, 141);
            this.nudAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(149, 20);
            this.nudAge.TabIndex = 3;
            this.nudAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNoTickets
            // 
            this.lblNoTickets.AutoSize = true;
            this.lblNoTickets.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTickets.Location = new System.Drawing.Point(13, 183);
            this.lblNoTickets.Name = "lblNoTickets";
            this.lblNoTickets.Size = new System.Drawing.Size(214, 14);
            this.lblNoTickets.TabIndex = 4;
            this.lblNoTickets.Text = "Enter the number of tickets to purchase:";
            // 
            // nudNoTickets
            // 
            this.nudNoTickets.Location = new System.Drawing.Point(12, 199);
            this.nudNoTickets.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudNoTickets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoTickets.Name = "nudNoTickets";
            this.nudNoTickets.Size = new System.Drawing.Size(149, 20);
            this.nudNoTickets.TabIndex = 5;
            this.nudNoTickets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSnackBar
            // 
            this.btnSnackBar.BackColor = System.Drawing.Color.White;
            this.btnSnackBar.Location = new System.Drawing.Point(12, 290);
            this.btnSnackBar.Name = "btnSnackBar";
            this.btnSnackBar.Size = new System.Drawing.Size(149, 46);
            this.btnSnackBar.TabIndex = 6;
            this.btnSnackBar.Text = "Continue to Snack Bar";
            this.btnSnackBar.UseVisualStyleBackColor = false;
            this.btnSnackBar.Click += new System.EventHandler(this.btnSnackBar_Click);
            // 
            // lblAddTicketHolder
            // 
            this.lblAddTicketHolder.AutoSize = true;
            this.lblAddTicketHolder.Font = new System.Drawing.Font("Mongolian Baiti", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTicketHolder.Location = new System.Drawing.Point(214, 9);
            this.lblAddTicketHolder.Name = "lblAddTicketHolder";
            this.lblAddTicketHolder.Size = new System.Drawing.Size(346, 34);
            this.lblAddTicketHolder.TabIndex = 7;
            this.lblAddTicketHolder.Text = "Add New Ticket Holder";
            this.lblAddTicketHolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbnCash
            // 
            this.rbnCash.AutoSize = true;
            this.rbnCash.Location = new System.Drawing.Point(16, 253);
            this.rbnCash.Name = "rbnCash";
            this.rbnCash.Size = new System.Drawing.Size(49, 17);
            this.rbnCash.TabIndex = 8;
            this.rbnCash.TabStop = true;
            this.rbnCash.Text = "Cash";
            this.rbnCash.UseVisualStyleBackColor = true;
            // 
            // rbnCard
            // 
            this.rbnCard.AutoSize = true;
            this.rbnCard.Location = new System.Drawing.Point(95, 253);
            this.rbnCard.Name = "rbnCard";
            this.rbnCard.Size = new System.Drawing.Size(47, 17);
            this.rbnCard.TabIndex = 9;
            this.rbnCard.TabStop = true;
            this.rbnCard.Text = "Card";
            this.rbnCard.UseVisualStyleBackColor = true;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.Location = new System.Drawing.Point(13, 234);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(139, 14);
            this.lblPaymentType.TabIndex = 10;
            this.lblPaymentType.Text = "Choose Payment Method:";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(644, 386);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(144, 52);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Cancel ";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // AddTicketHolderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(163)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblPaymentType);
            this.Controls.Add(this.rbnCard);
            this.Controls.Add(this.rbnCash);
            this.Controls.Add(this.lblAddTicketHolder);
            this.Controls.Add(this.btnSnackBar);
            this.Controls.Add(this.nudNoTickets);
            this.Controls.Add(this.lblNoTickets);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.tbxTicketHolderName);
            this.Controls.Add(this.lblTicketHolderName);
            this.Name = "AddTicketHolderForm";
            this.Text = "Add Ticket Holder";
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTicketHolderName;
        private System.Windows.Forms.TextBox tbxTicketHolderName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Label lblNoTickets;
        private System.Windows.Forms.NumericUpDown nudNoTickets;
        private System.Windows.Forms.Button btnSnackBar;
        private System.Windows.Forms.Label lblAddTicketHolder;
        private System.Windows.Forms.RadioButton rbnCash;
        private System.Windows.Forms.RadioButton rbnCard;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Button btnHome;
    }
}