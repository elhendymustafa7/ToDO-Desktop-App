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
    public partial class Register : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public Register( )
        {
            InitializeComponent();
        }

        private void userNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            var user = new user { Name = userNameBox.Text, Email = EmailBox.Text, Password = PasswordBox.Text };
            db.user.Add(user);
            db.SaveChanges();
            MessageBox.Show($"Register successfully!");
        }
    }
}
