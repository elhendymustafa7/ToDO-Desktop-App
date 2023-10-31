using Microsoft.AspNet.Identity;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class AdminForm : Form
    {
        private IEnumerable<user> users;
        private ApplicationDbContext db = new ApplicationDbContext();
        Dictionary<int, Dictionary<priority, int>> userTodoCounts = new Dictionary<int, Dictionary<priority, int>>();

        private Dictionary<string, Label> userLabels = new Dictionary<string, Label>();

        
        public AdminForm()
        {
            InitializeComponent();
            users= GetAllTodos();

        }

        private IEnumerable<user> GetAllTodos()
        {

            return db.user.Where(u => u.Name != "admin").ToList();

        }
        private int[] count(user user)
        {
            var todos = db.Todo.ToList();
            int[] arr = new int[3];// 0 low 1 high
            foreach(var todo in todos)
            {
                if(todo.userId == user.Id)
                {
                    if (todo.priority == priority.low)
                    {
                        arr[0] += 1;
                    }
                    else if (todo.priority == priority.high)
                    {
                        arr[1]++;
                    }
                    else arr[2]++;

                }
            }
            return arr;
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            
            int u = 0;
            foreach (user user in users)
            {
                int[] arr = count(user);
                Label lblUserName = new Label
                {
                    Text = user.Name
                };

                Label lblHigh = new Label
                {
                    Text = "High"
                };

                Label lblLow = new Label
                {
                    Text = "Low"
                };

                Label lblMed = new Label
                {
                    Text = "Medium"
                };
                TextBox lblHightext = new TextBox
                {
                    Text = arr[1].ToString()
                };

                TextBox lblLowtext = new TextBox
                {
                    Text = arr[0].ToString()
                };

                TextBox lblMedtext = new TextBox
                {
                    Text = arr[2].ToString()

                };

                userLabels[user.Name] = lblUserName;

                TextBox textBox1 = new TextBox();
                textBox1.Size = new Size { Height=7, Width=70};

                TextBox textBox2 = new TextBox();
                textBox2.Size = new Size { Height=7, Width=70};



                this.Controls.Add(lblUserName);

                Button btn1 = new Button
                {
                    Text = "Edit Email",
                    Size = new Size { Height = 30, Width = 100 },
                    Tag = user
                };

                Button btn2 = new Button
                {
                    Text = "Rest Password",
                    Size = new Size { Height = 30, Width = 100 },
                    Tag = user
                };


                btn1.Click += Button_Click;
                btn2.Click += Button_Click;


                //this.Controls.Add(btn1);
                //this.Controls.Add(btn2);
                //this.Controls.Add(textBox1);
                //this.Controls.Add(textBox2);
                this.Controls.Add(lblHightext);
                this.Controls.Add(lblLowtext);
                this.Controls.Add(lblMedtext);
                this.Controls.Add(lblHigh);
                this.Controls.Add(lblLow);
                this.Controls.Add(lblMed);

                lblUserName.Location = new Point(5, 10+u);
                lblHightext.Location = new Point(100,40+u);
                lblLowtext.Location = new Point(200,40+u);
                lblMedtext.Location = new Point(300, 40+u);
                //btn2.Location = new Point(260, 10 + u);
                lblHigh.Location = new Point(100, 10 + u);
                lblLow.Location = new Point(200, 10 + u);
                lblMed.Location = new Point(300, 10 + u);

                u += 100;
            }
        }
        private void Button_Click(object sender, EventArgs e/*,user user*/)
        {
            Button clickedButton = (Button)sender;
            string buttonTag = clickedButton.Text;
            user user = (user)clickedButton.Tag;

            switch (buttonTag)
            {
                case "Edit Email":

                        UpdateUserLabel(user);
  
                    break;
                case "Rest Password":
                    MessageBox.Show($"bt2 successfully!");
                    break;
                default:
                    break;
            }
        }
        private void UpdateUserLabel(user user)
        {
            Label lblUserName = Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Text == user.Name);

            if (lblUserName != null)
            {
                lblUserName.Text = "new";
                lblUserName.Refresh();
            }
        }

    }
}
