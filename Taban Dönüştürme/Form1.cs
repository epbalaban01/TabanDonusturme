using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taban_Dönüştürme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(textBox1.Text);
                int taban = Convert.ToInt32(textBox3.Text);

                textBox2.Text = TabanDonusum(sayi, taban).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        int TabanDonusum(int sayi,int taban)
        {
            int basamak,sonuc=0,us=1;
            while(sayi>=1)
            {
                basamak=sayi%taban;
                sayi=sayi/taban;
                sonuc+=basamak*us;
                us*=2;
            }
            return sonuc;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {

                int sayi = Convert.ToInt32(textBox6.Text);
                int taban = Convert.ToInt32(textBox4.Text);

                textBox5.Text = TabanDonusum1(sayi, taban).ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }
        int TabanDonusum1(int sayi, int taban)
        {
            int basamak, sonuc = 0, us = 1;
            while (sayi >= 1)
            {
                basamak = sayi % taban;
                sayi = sayi / taban;
                sonuc += basamak * us;
                us *= 8;
            }
            return sonuc;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                int sayi = Convert.ToInt32(textBox9.Text);
                int taban = Convert.ToInt32(textBox7.Text);

                textBox8.Text = TabanDonusum2(sayi, taban).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        int TabanDonusum2(int sayi, int taban)
        {
            int basamak,sonuc=0,us=1;
            while(sayi>=1)
            {
                basamak=sayi%taban;
                sayi=sayi/taban;
                sonuc+=basamak*us;
                us*=10;

            }
            return sonuc;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(textBox12);
                int taban = Convert.ToInt32(textBox10);

                textBox11.Text = TabanDonusum3(sayi, taban).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int TabanDonusum3(int sayi,int taban)
        {
            int basamak,sonuc=0,us=1;
            while(sayi>=1)
            {
                basamak=sayi%taban;
                sayi=sayi/taban;
                sonuc+=basamak*us;
                us*=16;

            }
            return sonuc;

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();


        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();


        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();


        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string saat = DateTime.Now.ToLongTimeString();

            label18.Text = saat;
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hazırlayan : Eyüp Can Balaban\nÜcretsizdir ve her yere dağıtabilirsiniz\nGeliştirmeye devam edilecektir.","Hakkında");
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Listede olanlar sayıyı yazarsanız o sayıya göre dönüşür mesela ikilik sayı sistemi olarak (1010)2 gibi tabana 10 yazarsanız sonuç çıkacaktır.\nİyi Dersler..", "Yardım");
        }

        
        private void timer3_Tick(object sender, EventArgs e)
        {
            label19.Text = label19.Text.Substring(1) + label19.Text.Substring(0, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            label19.Text = " - http://www.gameserver.epizy.com ziyaret edin.";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.gameserver.epizy.com");
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }





        }








        }



   

