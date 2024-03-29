using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bade_Butik_Otel_Rezervasyon_Otomasyonu
{
    public partial class FrmSifreGuncelle : Form
    {
        public FrmSifreGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ABDURRAHMAN\\SQLEXPRESS;Initial Catalog=BadeButikOtel;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update  AdminGiris  set Kullanici='" + TxtKullaniciAdi.Text + "',Sifre='" + TxtSifre.Text +  "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
           
        }

        private void FrmSifreGuncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
