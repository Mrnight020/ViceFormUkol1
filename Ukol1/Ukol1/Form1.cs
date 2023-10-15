using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Ukol1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2;
        private void button1_Click(object sender, EventArgs e)
        {
            form2 = new Form2(listBox1);
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
    public partial class Form2 : Form
    {
        Button button2 = new Button();
        Button button3 = new Button();
        TextBox textBox1 = new TextBox();

        ListBox listik = new ListBox();
        public Form2(ListBox listbox)
        {
            listik = listbox;
            this.ClientSize = new System.Drawing.Size(400, 250);
            // 
            // textBox1
            textBox1.Location = new System.Drawing.Point(68, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(240, 22);
            textBox1.TabIndex = 3;           
            textBox1.KeyDown += textBox1_KeyDown;
            textBox1.Focus();
            // 
            // button2
            button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            button2.ForeColor = System.Drawing.Color.Black;
            button2.Location = new System.Drawing.Point(68, 123);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(112, 77);
            button2.TabIndex = 4;
            button2.Text = "Ulož";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            button3.ForeColor = System.Drawing.Color.Black;
            button3.Location = new System.Drawing.Point(196, 123);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(112, 77);
            button3.TabIndex = 5;
            button3.Text = "Zruš";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;

            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (listik.Items.Count == 10)
            {
                MessageBox.Show("Maximalně 10 prvku !!!");
            }
            else
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Nic si nezadal");
                }
                else
                {
                    listik.Items.Add("" + textBox1.Text);
                }
            }
            textBox1.Focus();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }

        }
    }

}
