﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Bade_Butik_Otel_Rezervasyon_Otomasyonu
{
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ABDURRAHMAN\\SQLEXPRESS;Initial Catalog=BadeButikOtel;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


        private void verilergoster()

        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Mesajlar ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mesajid"].ToString();
                ekle.SubItems.Add(oku["Adsoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());


                listView1.Items.Add(ekle);
            }

            baglanti.Close();
        }

            private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            verilergoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Mesajlar(Adsoyad,Mesaj) values('"+textBox1.Text+"','"+richTextBox1.Text+"')",baglanti);
            komut .ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }
        
        private void FrmMesajlar_DoubleClick(object sender, EventArgs e)
        {
           
        }
        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
