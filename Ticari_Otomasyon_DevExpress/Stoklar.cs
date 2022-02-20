using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Ticari_Otomasyon_DevExpress
{
    public partial class STOKLAR : Form
    {
        public STOKLAR()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void STOKLAR_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Urunler.Ad,sum(Urunler.Adet) as'Stoklar' from Urunler group by Ad",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            //Charta Stok Ekleme
            SqlCommand ekle=new SqlCommand("Select Urunler.Ad,sum(Urunler.Adet) as'Stoklar' from Urunler group by Ad",bgl.baglanti());
            SqlDataReader dr=ekle.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            bgl.baglanti().Close();
            /////////////////////////////LABEL VERİ TAŞIMA////////////////////////////////////////
            SqlCommand veri1 = new SqlCommand("Select Count (*)from Urunler", bgl.baglanti());
            SqlDataReader dr2 = veri1.ExecuteReader();
            while (dr2.Read())
            {
                labelControl4.Text = dr2[0].ToString();
            }
            bgl.baglanti().Close();
            //////////////////////////////LABELA TOPLAM ÜRÜN SAYISI YAZDIRMA////////////////////////////////////////////////////////
            SqlCommand veri2 = new SqlCommand("select (sum(Adet+Adet)) from Urunler", bgl.baglanti());
            SqlDataReader dr3 = veri2.ExecuteReader();
            while (dr3.Read())
            {
                labelControl5.Text = dr3[0].ToString();
            }
            bgl.baglanti().Close();
            //////////////////////////////////LABELA TOPLAM ÜRÜNLERİN FİYATİ///////////////////////////////////////////////////////////////////////
            SqlCommand veri3 = new SqlCommand("select (sum(SatisFiyat*Adet)) from Urunler", bgl.baglanti());
            SqlDataReader dr4 = veri3.ExecuteReader();
            while (dr4.Read())
            {
                labelControl6.Text = dr4[0]+" "+"TL".ToString();
            }
            bgl.baglanti().Close();
        }

    }
}
