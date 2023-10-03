using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        bool optDurum=false;
        double sonuc = 0;
        string opt = "";

        public Form1()
        {
            InitializeComponent();

            btnyuzde.Click += new EventHandler(btnyuzde_Click);
            btnus.Click += new EventHandler(btnus_Click);
            btnmod.Click += new EventHandler(btnmod_Click);
            btnkarekok.Click += new EventHandler(btnkarekok_Click);
        }

        private void rakam(object sender, EventArgs e)
        {
            if(txtsonuc.Text=="0" || optDurum)
                txtsonuc.Clear();
            optDurum = false;
            Button btn = (Button)sender;
            txtsonuc.Text += btn.Text;

        }

        private void OptHesap(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;
            lblsonuc.Text = lblsonuc.Text+ " "+ txtsonuc.Text+ " "+ yeniOpt;
            switch (opt)
            {
                case "+":txtsonuc.Text = (sonuc+ double.Parse(txtsonuc.Text)).ToString(); break;
                case "-": txtsonuc.Text = (sonuc- double.Parse(txtsonuc.Text)).ToString(); break;
                case "*": txtsonuc.Text = (sonuc* double.Parse(txtsonuc.Text)).ToString(); break;
                case "/": txtsonuc.Text = (sonuc/ double.Parse(txtsonuc.Text)).ToString(); break;
            }
            sonuc=double.Parse(txtsonuc.Text);
            txtsonuc.Text=sonuc.ToString();
            opt = yeniOpt;
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            txtsonuc.Text = "0";
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtsonuc.Text = "0";
            lblsonuc.Text = " ";
            opt = "";
            sonuc = 0;
            optDurum = false;

        }

        private void btnsonuc_Click(object sender, EventArgs e)
        {
            lblsonuc.Text = "";
            optDurum = true;
            switch (opt)
            {
                case "+": txtsonuc.Text = (sonuc + double.Parse(txtsonuc.Text)).ToString(); break;
                case "-": txtsonuc.Text = (sonuc - double.Parse(txtsonuc.Text)).ToString(); break;
                case "*": txtsonuc.Text = (sonuc * double.Parse(txtsonuc.Text)).ToString(); break;
                case "/": txtsonuc.Text = (sonuc / double.Parse(txtsonuc.Text)).ToString(); break;
            }
            sonuc = double.Parse(txtsonuc.Text);
            txtsonuc.Text = sonuc.ToString();
            opt = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtsonuc.Text == "0") 
            { 
                txtsonuc.Text = "0";
            }
            else if (optDurum) 
            { 
                txtsonuc.Text = "0";
            }
            if(!txtsonuc.Text.Contains(",")) 
            {
                txtsonuc.Text += ",";            
            }
            optDurum= false;

        }

        private void btnyuzde_Click(object sender, EventArgs e)
        {
            double percent = double.Parse(txtsonuc.Text) / 100;
            txtsonuc.Text = percent.ToString();
            optDurum = true;
        }

        private void btnus_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtsonuc.Text);
            double result = Math.Pow(number, 2); 
            txtsonuc.Text = result.ToString();
            optDurum = true;
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtsonuc.Text);
            double modValue = number % 2; 
            txtsonuc.Text = modValue.ToString();
            optDurum = true;
        }

        private void btnkarekok_Click(object sender, EventArgs e)
        {
            double number = double.Parse(txtsonuc.Text);
            double sqrtValue = Math.Sqrt(number);
            txtsonuc.Text = sqrtValue.ToString();
            optDurum = true;
        }
    }
}
