using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDO_Desktop_App.Model;

namespace ToDO_Desktop_App
{
    public partial class Home : Form
    {
        private ApplicationDbContext db = new ApplicationDbContext(); 
        public Home()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            // Show the new form
            //login.Show();
            login.ShowDialog();
            //this.Hide();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();

            // Show the new form
            //register.Show();
            register.ShowDialog();
        }
    }
}
