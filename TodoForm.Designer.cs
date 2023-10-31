namespace ToDO_Desktop_App
{
    partial class TodoForm
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
            todos = new Label();
            Title = new Label();
            Description = new Label();
            TitleBox = new TextBox();
            DescBox = new TextBox();
            panel1 = new Panel();
            Edit = new Button();
            priorityLabel = new Label();
            DateLabel = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            Remove = new Button();
            submit = new Button();
            listView1 = new ListView();
            id = new ColumnHeader();
            TitleLable = new ColumnHeader();
            Desc = new ColumnHeader();
            Date = new ColumnHeader();
            propirty = new ColumnHeader();
            img = new ColumnHeader();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // todos
            // 
            todos.AutoSize = true;
            todos.Location = new Point(339, 9);
            todos.Name = "todos";
            todos.Size = new Size(43, 20);
            todos.TabIndex = 0;
            todos.Text = "Todo";
            todos.Click += todos_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(45, 15);
            Title.Name = "Title";
            Title.Size = new Size(38, 20);
            Title.TabIndex = 0;
            Title.Text = "Title";
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Location = new Point(12, 59);
            Description.Name = "Description";
            Description.Size = new Size(85, 20);
            Description.TabIndex = 1;
            Description.Text = "Description";
            // 
            // TitleBox
            // 
            TitleBox.Location = new Point(109, 15);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(289, 27);
            TitleBox.TabIndex = 4;
            // 
            // DescBox
            // 
            DescBox.Location = new Point(109, 56);
            DescBox.Name = "DescBox";
            DescBox.Size = new Size(289, 27);
            DescBox.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(Edit);
            panel1.Controls.Add(priorityLabel);
            panel1.Controls.Add(DateLabel);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Remove);
            panel1.Controls.Add(submit);
            panel1.Controls.Add(DescBox);
            panel1.Controls.Add(TitleBox);
            panel1.Controls.Add(Description);
            panel1.Controls.Add(Title);
            panel1.Location = new Point(12, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 204);
            panel1.TabIndex = 2;
            // 
            // Edit
            // 
            Edit.Location = new Point(680, 175);
            Edit.Name = "Edit";
            Edit.Size = new Size(94, 29);
            Edit.TabIndex = 16;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new Point(33, 144);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(61, 20);
            priorityLabel.TabIndex = 15;
            priorityLabel.Text = "priority ";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(33, 104);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(41, 20);
            DateLabel.TabIndex = 14;
            DateLabel.Text = "Date";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "High", "Low", "Medium" });
            comboBox1.Location = new Point(109, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(289, 28);
            comboBox1.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(109, 99);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(289, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(848, 111);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Add Image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(833, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Remove
            // 
            Remove.Location = new Point(563, 175);
            Remove.Name = "Remove";
            Remove.Size = new Size(94, 29);
            Remove.TabIndex = 9;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = true;
            Remove.Click += Remove_Click;
            // 
            // submit
            // 
            submit.Location = new Point(448, 174);
            submit.Name = "submit";
            submit.Size = new Size(94, 29);
            submit.TabIndex = 8;
            submit.Text = "Add";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { id, TitleLable, Desc, Date, propirty, img });
            listView1.GridLines = true;
            listView1.Location = new Point(24, 277);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(1041, 250);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // id
            // 
            id.Text = "id";
            id.Width = 80;
            // 
            // TitleLable
            // 
            TitleLable.Text = "Title";
            TitleLable.Width = 80;
            // 
            // Desc
            // 
            Desc.Text = "Desc";
            // 
            // Date
            // 
            Date.Text = "date";
            // 
            // propirty
            // 
            propirty.Text = "propirty";
            // 
            // img
            // 
            img.Text = "img";
            // 
            // TodoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 562);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Controls.Add(todos);
            Name = "TodoForm";
            Text = "Todo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label todos;
        private Label Title;
        private Label Description;
        private TextBox TitleBox;
        private TextBox DescBox;
        private Panel panel1;
        private ListView listView1;
        private Button submit;
        private Button Remove;
        private PictureBox pictureBox1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label priorityLabel;
        private Label DateLabel;
        private Button Edit;
        private ColumnHeader id;
        private ColumnHeader TitleLable;
        private ColumnHeader Desc;
        private ColumnHeader Date;
        private ColumnHeader propirty;
        private ColumnHeader img;
    }
}