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
    public partial class SalesStatsForm : Form
    {
        TicketManager tm;

        public SalesStatsForm(TicketManager tm)
        {
            InitializeComponent();
            this.tm = tm;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm myNewForm = new HomeForm(tm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
