using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupboxkontorulu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbcbulR5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbcbulR3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            double tabanFiyat = 500;
            double cpuFiyat = 0;
            if (rblcbul7.Checked)
                cpuFiyat = 300;
            else if (rblcbul5.Checked)
                cpuFiyat = 200;
            else if (rbcbul3.Checked)
                cpuFiyat = 100;
            else if (rbcbulR5.Checked)
                cpuFiyat = 250;
            else if (rbcbulR3.Checked)
                cpuFiyat = 150;
            tabanFiyat += cpuFiyat;
            
            double ramFiyat = 0;
            if (radioButton.Checked)
                ramFiyat = 125;
            else if (radioButton29.Checked)
                ramFiyat = 75;
            else if (radioButton30.Checked)
                ramFiyat = 45;
            tabanFiyat += ramFiyat;
            
            double ssdFiyat = 0;
            if (rdhmm1000.Checked)
                ssdFiyat = 1000;
            else if (rdhmm500.Checked)
                ssdFiyat = 500;
            else if (rdhmm320.Checked)
                ssdFiyat = 320;
            tabanFiyat += ssdFiyat;
            
            double ekdonanim = 0;
            if (cbDVD.Checked)
                ekdonanim+= 350;
            if (cbwebcam.Checked)
                ekdonanim+= 600;
            if (cbwifi.Checked)
                ekdonanim += 450;
            tabanFiyat += ekdonanim;
            MessageBox.Show(string.Format("Toplam Fiyat ={0:C}", tabanFiyat));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
