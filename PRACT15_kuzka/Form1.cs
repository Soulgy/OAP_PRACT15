using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace PRACT15_kuzka
{
    public partial class Form1 : Form
    {
        public void WriteListbox()
        {
            try
            {
                listBox1.Items.Clear();
                StreamReader sr = File.OpenText("file1.txt");
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                    listBox1.Items.Add($"Индекс: {line[0]} Страна: {line[1]} Город: {line[2]} Улица: {line[3]} Номер дома: {line[4]} Номер офиса: {line[5]}");
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        public Form1()
        {
            InitializeComponent();
            WriteListbox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Class1.Test(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text))
            {
                Adres adres = new Adres(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, int.Parse(textBox5.Text), int.Parse(textBox6.Text));
                Adres.AddAddress(adres);
                WriteListbox();
            }
            else
            {
                MessageBox.Show("Неверный ввод!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = int.Parse(textBox7.Text);
            Adres.RemoveAddress(index);
            WriteListbox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WriteListbox();
        }
    }
}
