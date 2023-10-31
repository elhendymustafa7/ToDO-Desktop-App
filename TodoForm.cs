using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDO_Desktop_App.Model;

namespace ToDO_Desktop_App
{
    public partial class TodoForm : Form
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        int i;
        private readonly int _userId;
        public TodoForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadTodos();
            var todo = db.Todo.OrderBy(x => x.Id).LastOrDefault();
            i = todo != null ? todo.Id+1 : 1;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            var todo = new Todo() { Id = i, Title = TitleBox.Text, Description = DescBox.Text, date = dateTimePicker1.Value,userId=_userId };
            ListViewItem item = new ListViewItem(todo.Id.ToString());
            item.Tag = todo;
            //item.SubItems.Add(todo.Id.ToString());
            item.SubItems.Add(todo.Title.ToString());
            item.SubItems.Add(todo.Description);
            item.SubItems.Add(todo.date.ToString());
            item.SubItems.Add(comboBox1.SelectedItem.ToString());
            pictureBox1.Image.Save($"Image/{todo.Title}{i}.jpg");
            todo.Imagepath = $"Image/{todo.Title}.jpg";
            item.SubItems.Add(todo.Imagepath);

            listView1.Items.Add(item);

            db.Todo.Add(todo);
            db.SaveChanges();


            TitleBox.Text = "";
            DescBox.Text = "";
            pictureBox1.Image = new PictureBox().Image;
            i++;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listView1.SelectedItems[0];


            if (listView1.SelectedItems.Count > 0)
            {
                var todo = db.Todo.Find(int.Parse(selectedItem.SubItems[0].Text));
                listView1.Items.Remove(listView1.SelectedItems[0]);
                db.Todo.Remove(todo);
                db.SaveChanges();
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (ofd.ShowDialog() == DialogResult.OK) pictureBox1.Image = Image.FromFile(ofd.FileName);
            if (!Directory.Exists("Image")) Directory.CreateDirectory("Image");
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            //if (listView1.SelectedItems.Count > 0) date = dateTimePicker1.Value
            ListViewItem selectedItem = listView1.SelectedItems[0];
            
            selectedItem.SubItems[1].Text = TitleBox.Text;
            selectedItem.SubItems[2].Text = DescBox.Text;
            selectedItem.SubItems[3].Text = dateTimePicker1.Value.ToString();
            selectedItem.SubItems[4].Text = comboBox1.SelectedItem.ToString();
            pictureBox1.Image.Save($"Image/{TitleBox.Text}{i}.jpg");
            selectedItem.SubItems[5].Text = $"Image/{TitleBox.Text}{i}.jpg";
            var todo = db.Todo.Find(int.Parse(selectedItem.SubItems[0].Text));
            todo.Title = TitleBox.Text;
            todo.Description = DescBox.Text;
            todo.date = dateTimePicker1.Value;

            db.Todo.Update(todo);
            db.SaveChanges();

            TitleBox.Text = "";
            DescBox.Text = "";
            pictureBox1.Image = new PictureBox().Image;
            i++;
        }

        private void LoadTodos()
        {
            List<Todo> todos = GetAllTodos();

            foreach (var todo in todos)
            {
                if (todo.userId == _userId)
                {
                    ListViewItem item = new ListViewItem(todo.Id.ToString());
                    item.Tag = todo; // Store the Todo object as the ListViewItem's Tag
                    item.SubItems.Add(todo.Title.ToString());
                    item.SubItems.Add(todo.Description);
                    item.SubItems.Add(todo.date.ToString());
                    item.SubItems.Add(todo.priority.ToString());
                    item.SubItems.Add(todo.Imagepath);
                    listView1.Items.Add(item);
                }
            }
        }

        private List<Todo> GetAllTodos()
        {

            return db.Todo.ToList();

        }

        private void todos_Click(object sender, EventArgs e)
        {

        }
    }
}
