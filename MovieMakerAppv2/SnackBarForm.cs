using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMakerAppv2
{
    public partial class SnackBarForm : Form
    {
        TicketManager tm;

        public SnackBarForm(TicketManager tm)
        {
            this.tm = tm;
            InitializeComponent();

            //set maximum items available using number of tickets purchased
            foreach (var item in nudSnackQuantities)
            {
                item.Maximum = tm.GetRecentlyPurchasedTickets();
            }
            
            foreach (var item in nudDrinkQuantities)
            {
                item.Maximum = tm.GetRecentlyPurchasedTickets();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            //store the snacks ordered in an int list
            List<int> sitems = new List<int>();
            List<int> sQuantities = new List<int>();

            int indexCounter = 0;
            foreach (var item in nudSnackQuantities)
            {
                if (item.Value >0)
                {
                    sitems.Add(indexCounter);
                    sQuantities.Add((int)item.Value);
                }
                indexCounter++;
            }

            //store the drinks ordered in an int list
            List<int> ditems = new List<int>();
            List<int> dQuantities = new List<int>();

            indexCounter = 0;
            foreach (var item in nudDrinkQuantities)
            {
                if (item.Value > 0)
                {
                    ditems.Add(indexCounter);
                    dQuantities.Add((int)item.Value);
                }
                indexCounter++;
            }


            //store the ordered snacks and drinks for the ticket holder
            tm.AddSnacksDrinksOrder(sitems, sQuantities, ditems, dQuantities);

            //display reciept via a messagebox
            string message = tm.GenerateRecentReciept();
            string title = "Reciept";
            MessageBox.Show(message, title);


            //close snack bar form and open home form
            this.Hide();
            HomeForm myNewForm = new HomeForm(tm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
