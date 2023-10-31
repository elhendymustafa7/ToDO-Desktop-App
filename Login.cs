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
    public partial class Login : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public Login()
        {
            InitializeComponent();
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            
                if (EmailBox.Text == "admin@admin" && PasswordBox.Text == "admin@admin")
                {
                    AdminForm todo = new AdminForm();
                todo.ShowDialog();
            }
                else
                {
                    var user = db.user.FirstOrDefault(u => u.Email ==  EmailBox.Text );
                    if(user.Password == PasswordBox.Text) {         
                    TodoForm todo = new TodoForm(user.Id);
                        todo.ShowDialog();
                   }
                    else MessageBox.Show($"Email Or Password Incorrect");
                }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register re = new Register();
            re.ShowDialog();
        }
    }
}
