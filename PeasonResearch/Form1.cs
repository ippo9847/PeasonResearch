using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PeasonResearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        public Person(string Name, int Age, int Height)
        {
            this.Name = Name;
            this.Age = Age;
            this.Height = Height;
        }
        */

        class Person
        {
            public string Name;
            public int Age;
            public double Height;

            public Person(string name, int age, int height)//よくわからん
            {
                Name = name;
                Age = age;
                Height = height;
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            List<Person> a = new List<Person>();
            listBox1.Items.Clear();
            ////

            using (StreamReader sr = new StreamReader("data.csv"))
            {
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    string[] vs = s.Split(',');
                    String Name = vs[0];
                    int age = int.Parse(vs[1]);
                    int height = int.Parse(vs[2]);
                    a.Add(new Person(Name, age, height));//
                }            
            }

            String text1 = textBox1.Text;
            if (comboBox1.Text == "一致")
            {
                for (int i = 0; i < a.Count; i++)
                {
                    if (text1 == a[i].Name) listBox1.Items.Add(a[i].Name);
                }
            }
            else if (comboBox1.Text == "前方一致")
            {
                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i].Name.StartsWith(text1)) listBox1.Items.Add(a[i].Name);
                }
            }
            else if (comboBox1.Text == "含む")
            {
                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i].Name.Contains(text1)) listBox1.Items.Add(a[i].Name);
                }
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        
        }


        private void button2_Click(object sender, EventArgs e)//年齢
        {
            List<Person> a = new List<Person>();
            listBox1.Items.Clear();
            ////

            using (StreamReader sr = new StreamReader("data.csv"))
            {
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    string[] vs = s.Split(',');
                    String Name = vs[0];
                    int age = int.Parse(vs[1]);
                    int height = int.Parse(vs[2]);
                    a.Add(new Person(Name, age, height));//
                }
            }

            int text2 = int.Parse(textBox2.Text);
            if (comboBox2.Text == "以上")
            {
                for (int i = 0; i < a.Count; i++)
                {
                    if (text2 <= a[i].Age) listBox1.Items.Add(a[i].Name);
                }
            }
            else if (comboBox2.Text == "等しい")
            {
                for (int i = 0; i < a.Count; i++)
                {
                    if (text2 == a[i].Age) listBox1.Items.Add(a[i].Name);
                }
            }
            else if (comboBox2.Text == "以下")
            {
                for (int i = 0; i < a.Count; i++)
                {
                    if (text2 >= a[i].Age) listBox1.Items.Add(a[i].Name);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//身長
        {
            List<Person> a = new List<Person>();
            listBox1.Items.Clear();
            ////

            using (StreamReader sr = new StreamReader("data.csv"))
            {
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    string[] vs = s.Split(',');
                    String Name = vs[0];
                    int age = int.Parse(vs[1]);
                    int height = int.Parse(vs[2]);
                    a.Add(new Person(Name, age, height));//
                }
            }

            int text3 = int.Parse(textBox3.Text);
            if (comboBox3.Text == "以上")
            {
                for (int i = 0; i < a.Count; i++)
                {
                    if (text3 <= a[i].Height) listBox1.Items.Add(a[i].Name);
                }
            }
            else if (comboBox3.Text == "等しい")
            {
                for (int i = 0; i < a.Count; i++)
                {
                    if (text3 == a[i].Height) listBox1.Items.Add(a[i].Name);
                }
            }
            else if (comboBox3.Text == "以下")
            {
                for (int i = 0; i < a.Count; i++)
                {
                    if (text3 >= a[i].Height) listBox1.Items.Add(a[i].Name);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
