using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        // Asal sayı kontrolü
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")   //TextBox boş ise uyarı verir
            {
                MessageBox.Show("Bir Sayı giriniz!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            else
            {
                int sayac = 0;
                double sayi = Convert.ToDouble(textBox1.Text);
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        sayac++;
                        break;
                    }
                }
                if (sayac == 0)
                {
                    label3.Text = "Sayı Asaldır";
                }
                else
                {
                    label3.Text = "Sayı Asal Değil";
                }
            }

        }

        // Karekök alma
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") //TextBox boş ise uyarı verir
            {
                MessageBox.Show("Bir Sayı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                double karekok;
                double sayi = Convert.ToDouble(textBox1.Text);
                karekok = Math.Sqrt(sayi);
                label3.Text = karekok.ToString();
            }
        }

        // Faktoriyel bulma
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") //TextBox boş ise uyarı verir
            {
                MessageBox.Show("Bir Sayı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                double faktoriyel = 1;
                double girilenSayi = Convert.ToDouble(textBox1.Text);
                for (double i = 1; i < girilenSayi; i++)
                {
                    faktoriyel += faktoriyel * i;
                }
                label3.Text = faktoriyel.ToString();
            }
        }

        // Texbox1 ve label3'ü temizleme
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label3.Text = "";
        }

        // Texbox1'e string değeri yazamama
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) 
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        // Çıkış için mesaj
    
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult giriskapanis = MessageBox.Show("Programı kapatmak istediğinizden eminmisiniz ? ", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (giriskapanis == DialogResult.No)
            {
                e.Cancel = true;
                return;

            }
            Environment.Exit(0);
        }
    }
}
