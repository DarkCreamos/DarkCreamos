using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            if (sayi < 10)
            {
                MessageBox.Show("Hava Soğuk.");
            }
            else if (sayi < 25)
            {
                MessageBox.Show("Hava Hafif Sıcak.");
            } 
                
            
            else if (sayi > 25)
                {
                    MessageBox.Show("Hava Sıcak!");
                }
            }
        }
    }