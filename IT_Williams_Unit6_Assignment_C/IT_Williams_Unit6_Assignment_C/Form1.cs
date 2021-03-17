using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Williams_Unit6_Assignment_C
{
    public partial class Form1 : Form
    {
        private static int quantity = 10;
        private static int remaining = quantity;
        private static int count = 0;
        private static string[] words = new string[quantity];

        public Form1()
        {
            InitializeComponent();
            button1.Visible = false;
        }

        private static void insertWords (String word, int index)
        {
            words[index] = word;
        }

        private void sortAndDisplayWords ()
        {
            Array.Sort(words);
            

            for (int i = 0; i < words.Length; i++)
            {
                label1.Text += "\n" + words[i];
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            sortAndDisplayWords();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count == quantity - 1)
            {
                button1.Visible = true;
                button2.Visible = false;
            }

            if (textBox1.Text.Equals(null) || textBox1.Text.Equals(""))
                throw new NullReferenceException("Value cannot be null.");

            if (textBox1.Text.Contains("1") || textBox1.Text.Contains("2") || textBox1.Text.Contains("3") ||
                textBox1.Text.Contains("4") || textBox1.Text.Contains("5") || textBox1.Text.Contains("6") ||
                textBox1.Text.Contains("7") || textBox1.Text.Contains("8") || textBox1.Text.Contains("9") ||
                textBox1.Text.Contains("0") || textBox1.Text.Contains("!") || textBox1.Text.Contains("@") ||
                textBox1.Text.Contains("#") || textBox1.Text.Contains("$") || textBox1.Text.Contains("%") ||
                textBox1.Text.Contains("^") || textBox1.Text.Contains("&") || textBox1.Text.Contains("*") ||
                textBox1.Text.Contains("(") || textBox1.Text.Contains(")") || textBox1.Text.Contains("_") ||
                textBox1.Text.Contains("=") || textBox1.Text.Contains("+") || textBox1.Text.Contains("{") ||
                textBox1.Text.Contains("}") || textBox1.Text.Contains("[") || textBox1.Text.Contains("]") ||
                textBox1.Text.Contains("\\") || textBox1.Text.Contains("|") || textBox1.Text.Contains(":") ||
                textBox1.Text.Contains(";") || textBox1.Text.Contains("\"") || textBox1.Text.Contains("<") ||
                textBox1.Text.Contains(">") || textBox1.Text.Contains(",") || textBox1.Text.Contains(".") ||
                textBox1.Text.Contains("?") || textBox1.Text.Contains("/") || textBox1.Text.Contains("~") ||
                textBox1.Text.Contains("`"))
                throw new ArgumentException("Word cannot contain special characters");

            if (count != quantity)
            {
                insertWords(textBox1.Text, count);

                count++;
                remaining--;
                label1.Text = "You are allowed " + remaining + " more words.\nWords Sorted:";

                textBox1.Focus();
                textBox1.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
