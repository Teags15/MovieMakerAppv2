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
    public partial class AddTicketHolderForm : Form
    {
        TicketManager tm;

        public AddTicketHolderForm(TicketManager tm)
        {
            this.tm = tm;
            InitializeComponent();

            rbnCash.Checked = true;

            nudAge.Minimum = tm.GetAgeLimit(0);

            nudNoTickets.Maximum = tm.CalculateAvailableSeats();
            
        }

        private void btnSnackBar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxTicketHolderName.Text))
            {
                //add new Ticket holder to tm 
                tm.AddTicketHolder(new TicketHolder(CapitaliseName(), (int)nudAge.Value, (int)nudNoTickets.Value, rbnCard.Checked));

                //continue to snack bar form
                this.Hide();
                SnackBarForm myNewForm = new SnackBarForm(tm);
                myNewForm.Closed += (s, args) => this.Close();
                myNewForm.Show();
            }
            else
            {

                MessageBox.Show("Please make sure you enter a name");
            
            }
           
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm myNewForm = new HomeForm(tm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private string CapitaliseName()
        {
            string name = tbxTicketHolderName.Text;

            name = string.Concat(name[0].ToString().ToUpper(), name.Substring(1));

            return name;


        }
    }
}
