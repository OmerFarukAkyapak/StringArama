using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string aranan;
        string degis;
        int arananindex;
        int degisenindex;
        int lengtharanan;
        int lengthmetin;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.HideSelection = false;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                aranan = textBox1.Text;
                lengtharanan = aranan.Length;
                arananindex = textBox3.Text.IndexOf(aranan);
                degisenindex = arananindex;

                if (textBox3.Text.Contains(aranan) == true)
                {
                    textBox3.Select(arananindex, lengtharanan);
                    arananindex = arananindex + lengtharanan;

                }
                else MessageBox.Show("Bulunamadı");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }           
        }

        public void button2_Click(object sender, EventArgs e)
        {
            try
            {
                lengthmetin = textBox3.Text.Length;
                if (arananindex<=lengthmetin)
                {
                    arananindex = textBox3.Text.IndexOf(aranan, arananindex);
                    degisenindex = arananindex;
                    textBox3.Select(arananindex,lengtharanan);
                    arananindex = arananindex + lengtharanan;

                }
                else MessageBox.Show("Daha fazla yok.");                
            }
            catch (Exception)
            {
                MessageBox.Show("Daha fazla yok.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            degis = textBox2.Text;
            if (textBox3.SelectedText == aranan)
            {
                textBox3.SelectedText = degis;
            }
            else MessageBox.Show("Aranan bulunamadı");
            

        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                bool wh = true;
                while (wh == true)
                {
                    aranan = textBox1.Text;
                    degis = textBox2.Text;

                    if (textBox3.Text.Contains(aranan) == true)
                    {
                        if (textBox3.SelectedText == aranan)
                        {
                            textBox3.SelectedText = degis;

                        }
                        else
                        {
                            arananindex = textBox3.Text.IndexOf(aranan);
                            textBox3.Select(arananindex, lengtharanan);
                            arananindex = arananindex + lengtharanan;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Tümü değiştirildi");
                        wh = false;
                    }

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Seçiniz.");

            }

            
        }
    }
}
