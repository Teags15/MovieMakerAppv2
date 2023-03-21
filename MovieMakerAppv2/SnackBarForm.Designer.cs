using System.Collections.Generic;

namespace MovieMakerAppv2
{
    partial class SnackBarForm
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
            int tabIndex = 0;
            
            //initialise controls 
            this.lblSnackBar = new System.Windows.Forms.Label();
            this.lblSnacks = new System.Windows.Forms.Label();
            this.lblDrinks = new System.Windows.Forms.Label();
            
            this.snackItems = new List<System.Windows.Forms.Label>();
            this.nudSnackQuantities = new List<System.Windows.Forms.NumericUpDown>();
            this.drinkItems = new List<System.Windows.Forms.Label>();
            this.nudDrinkQuantities = new List<System.Windows.Forms.NumericUpDown>();   
            
            this.btnCheckOut = new System.Windows.Forms.Button();
            
            foreach (var item in nudSnackQuantities)
            {
                ((System.ComponentModel.ISupportInitialize)(item)).BeginInit();
            }

            foreach (var item in nudDrinkQuantities)
            {
                ((System.ComponentModel.ISupportInitialize)(item)).BeginInit();
            }
           
            this.SuspendLayout();
           
            // 
            // lblSnackBar
            // 
            this.lblSnackBar.AutoSize = true;
            this.lblSnackBar.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnackBar.Location = new System.Drawing.Point(297, 9);
            this.lblSnackBar.Name = "lblSnackBar";
            this.lblSnackBar.Size = new System.Drawing.Size(165, 41);
            this.lblSnackBar.TabIndex = tabIndex;
            tabIndex++;
            this.lblSnackBar.Text = "Snack Bar";
            this.lblSnackBar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            
            // 
            // lblSnacks
            // 
            this.lblSnacks.AutoSize = true;
            this.lblSnacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnacks.Location = new System.Drawing.Point(12, 69);
            this.lblSnacks.Name = "lblSnacks";
            this.lblSnacks.Size = new System.Drawing.Size(89, 25);
            this.lblSnacks.TabIndex = tabIndex;
            tabIndex++;
            this.lblSnacks.Text = "Snacks";
            
            // 
            // lblDrinks
            // 
            this.lblDrinks.AutoSize = true;
            this.lblDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinks.Location = new System.Drawing.Point(459, 69);
            this.lblDrinks.Name = "lblDrinks";
            this.lblDrinks.Size = new System.Drawing.Size(79, 25);
            this.lblDrinks.TabIndex = tabIndex;
            tabIndex++;
            this.lblDrinks.Text = "Drinks";

            // 
            // lblSnackItem
            // 

            int lblSnackY = 91;

            foreach (string snack in tm.GetAvailableSnacks())
            {
                lblSnackY += 25;

                snackItems.Add(new System.Windows.Forms.Label());
                this.snackItems[snackItems.Count - 1].AutoSize = true;
                this.snackItems[snackItems.Count - 1].Location = new System.Drawing.Point(14, lblSnackY);
                this.snackItems[snackItems.Count - 1].Name = $"lbl{snack}";
                this.snackItems[snackItems.Count - 1].Size = new System.Drawing.Size(61, 13);
                this.snackItems[snackItems.Count - 1].TabIndex = tabIndex;
                this.snackItems[snackItems.Count - 1].Text = snack;

                tabIndex++;

            }

            // 
            // nudSnackItems
            // 
            int nudSnackY = 91;
     

            foreach (string snack in tm.GetAvailableSnacks())
            {
                nudSnackY += 25;
                
                this.nudSnackQuantities.Add(new System.Windows.Forms.NumericUpDown());
                this.nudSnackQuantities[this.nudSnackQuantities.Count-1].Location = new System.Drawing.Point(90, nudSnackY);
                this.nudSnackQuantities[this.nudSnackQuantities.Count - 1].Maximum = new decimal(new int[] { 20, 0, 0, 0 });
                this.nudSnackQuantities[this.nudSnackQuantities.Count - 1].Name = $"nud{snack}";
                this.nudSnackQuantities[this.nudSnackQuantities.Count - 1].Size = new System.Drawing.Size(74, 20);
                this.nudSnackQuantities[this.nudSnackQuantities.Count - 1].TabIndex = tabIndex;
                tabIndex++;
            }

            // 
            // lblDrinkItems
            // 
            int lblDrinkY = 91;

            foreach (var item in tm.GetAvailableDrinks())
            {
                lblDrinkY += 25;
                drinkItems.Add(new System.Windows.Forms.Label());

                drinkItems[drinkItems.Count-1].AutoSize = true;
                drinkItems[drinkItems.Count - 1].Location = new System.Drawing.Point(461, lblDrinkY);
                drinkItems[drinkItems.Count - 1].Name = $"lbl{item}";
                drinkItems[drinkItems.Count - 1].Size = new System.Drawing.Size(55, 13);
                drinkItems[drinkItems.Count - 1].TabIndex = tabIndex;
                drinkItems[drinkItems.Count - 1].Text = item;
                tabIndex++;
            }

            // 
            // nubDrinkItems
            // 
            int drinkQuantityY = 91;
            
            foreach (var item in tm.GetAvailableDrinks())
            {
                drinkQuantityY += 25;
                nudDrinkQuantities.Add(new System.Windows.Forms.NumericUpDown());
                nudDrinkQuantities[nudDrinkQuantities.Count-1].Location = new System.Drawing.Point(522, drinkQuantityY);
                nudDrinkQuantities[nudDrinkQuantities.Count - 1].Maximum = new decimal(new int[] { 20, 0, 0, 0 });
                nudDrinkQuantities[nudDrinkQuantities.Count - 1].Name = $"nud{item}";
                nudDrinkQuantities[nudDrinkQuantities.Count - 1].Size = new System.Drawing.Size(75, 20);
                nudDrinkQuantities[nudDrinkQuantities.Count - 1].TabIndex = tabIndex;
                tabIndex++;
            }

            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(286, 381);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(157, 44);
            this.btnCheckOut.TabIndex = tabIndex;
            this.btnCheckOut.Text = "Checkout";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            tabIndex++;

            // 
            // SnackBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 437);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.lblDrinks);
            this.Controls.Add(this.lblSnacks);
            this.Controls.Add(this.lblSnackBar);

            //adding each snack label as a control on the snack bar form
            foreach (var item in snackItems)
            {
                this.Controls.Add(item);
            }

            //adding each snack quantity as a control on the snack bar form
            foreach (var item in nudSnackQuantities)
            {
                this.Controls.Add(item);
            }

            //adding each drink label as a control on the snack bar form
            foreach (var item in drinkItems)
            {
                this.Controls.Add(item);
            }

            //adding each drink quantity as a control on the snack bar form
            foreach (var item in nudDrinkQuantities)
            {
                this.Controls.Add(item);
            }


            this.Name = "SnackBarForm";
            this.Text = "Snack Bar";
            foreach (System.Windows.Forms.NumericUpDown item in nudSnackQuantities)
            {
                ((System.ComponentModel.ISupportInitialize)(item)).EndInit();
            }
            
            foreach (System.Windows.Forms.NumericUpDown item in nudDrinkQuantities)
            {
                ((System.ComponentModel.ISupportInitialize)(item)).EndInit();
            }


            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //declare controls
        private System.Windows.Forms.Label lblSnackBar;
        private System.Windows.Forms.Label lblSnacks;
        private System.Windows.Forms.Label lblDrinks;

        private List<System.Windows.Forms.Label> snackItems;
        private List<System.Windows.Forms.NumericUpDown> nudSnackQuantities;
        private List<System.Windows.Forms.Label> drinkItems;
        private List<System.Windows.Forms.NumericUpDown> nudDrinkQuantities;
        
        private System.Windows.Forms.Button btnCheckOut;
    }
}