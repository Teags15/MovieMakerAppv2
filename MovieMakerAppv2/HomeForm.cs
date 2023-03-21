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
    public partial class HomeForm : Form
    {
        TicketManager tm;

        //constructer
        public HomeForm(TicketManager tm)
        {
            InitializeComponent();
            this.tm = tm;
        }

        private void btnAddTicketHolder_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTicketHolderForm myNewForm = new AddTicketHolderForm(tm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesStatsForm myNewForm = new SalesStatsForm(tm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
