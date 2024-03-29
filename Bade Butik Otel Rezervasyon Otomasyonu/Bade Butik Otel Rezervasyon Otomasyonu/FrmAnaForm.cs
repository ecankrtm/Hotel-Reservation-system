using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bade_Butik_Otel_Rezervasyon_Otomasyonu
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fr = new FrmYeniMusteri();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bade Butik Otel Kayıt Otomasyonu//2023-Mersin");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Odalar fr = new Odalar();
            fr.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Odalar fr = new Odalar();
            fr.Show();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelle fr =new FrmSifreGuncelle();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmMesajlar fr =new FrmMesajlar();
            fr.Show();
        }
    }
}
