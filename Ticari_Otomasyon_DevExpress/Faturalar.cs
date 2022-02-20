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
    public partial class Faturalar : Form
    {
        public Faturalar()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select*from FaturaBilgi", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void SatırAlma()
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["FaturaBilgid"].ToString();
                txtseri.Text = dr["Seri"].ToString();
                txtsıra.Text = dr["SıraNo"].ToString();
                masktarih.Text = dr["Tarih"].ToString();
                masksaat.Text = dr["Saat"].ToString();
                txtvergi.Text = dr["VergiDaire"].ToString();
                txtalici.Text = dr["Alıcı"].ToString();
                txteden.Text = dr["TeslimEden"].ToString();
                txtalan.Text = dr["TeslimAlan"].ToString();
            }
        }
        void temizle()
        {
            txtid.Text = "";
            txtseri.Text = "";
            txtsıra.Text = "";
            masktarih.Text = "";
            masksaat.Text = "";
            txtvergi.Text = "";
            txtalici.Text = "";
            txteden.Text = "";
            txtalan.Text = "";
        }
        private void Faturalar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

     

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            SatırAlma();
        }

        private void btnkaydet_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Kaydetmek İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    if (txtid.Text == "")
                    {
                        SqlCommand kaydet = new SqlCommand("Insert into FaturaBilgi(Seri,SıraNo,Tarih,Saat,VergiDaire,Alıcı,TeslimEden,TeslimAlan)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                        kaydet.Parameters.AddWithValue("@p1", txtseri.Text);
                        kaydet.Parameters.AddWithValue("@p2", txtsıra.Text);
                        kaydet.Parameters.AddWithValue("@p3", masktarih.Text);
                        kaydet.Parameters.AddWithValue("@p4", masksaat.Text);
                        kaydet.Parameters.AddWithValue("@p5", txtvergi.Text);
                        kaydet.Parameters.AddWithValue("@p6", txtalici.Text);
                        kaydet.Parameters.AddWithValue("@p7", txteden.Text);
                        kaydet.Parameters.AddWithValue("@p8", txtalan.Text);
                        kaydet.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        listele();
                    }
                }
                else
                {
                    MessageBox.Show("Ekleme İşlemi İptal Edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();

                }
            }
            catch
            {
                MessageBox.Show("Bir Hata Meydana Geldi. Bütün Satırları Doğru Girdiğinizden Emin Olun Veya Satırları Doldurduğunuzdan Emin Olun.!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                temizle();
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnkaydet2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Kaydetmek İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    double adet, tutar, fiyat;
                    fiyat = Convert.ToDouble(txtfiyat.Text);
                    adet = Convert.ToDouble(txtadet.Text);
                    tutar = fiyat * adet;
                    txtutar.Text = tutar.ToString();
                    SqlCommand kaydet2 = new SqlCommand("Insert into FaturaUrunDetay(UrunAd,Adet,Fiyat,Tutar,Faturaid)values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                    kaydet2.Parameters.AddWithValue("@p1", txturunad.Text);
                    kaydet2.Parameters.AddWithValue("@p2", txtadet.Text);
                    kaydet2.Parameters.AddWithValue("@p3", decimal.Parse(txtfiyat.Text));
                    kaydet2.Parameters.AddWithValue("@p4", decimal.Parse(txtutar.Text));
                    kaydet2.Parameters.AddWithValue("@p5", txtfaturadetayid.Text);
                    kaydet2.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    listele();
                    ////Hareket tablosuna veri girişi
                    SqlCommand kaydet4 = new SqlCommand("Insert into FirmaHareketler(Urunid,Adet,Fiyat,Toplam,Faturaid)values(@h1,@h2,@h3,@h4,@h5)", bgl.baglanti());
                    kaydet4.Parameters.AddWithValue("@h1",txturunid.Text);
                    kaydet4.Parameters.AddWithValue("@h2",txtadet.Text);
                    kaydet4.Parameters.AddWithValue("@h3", decimal.Parse(txtfiyat.Text));
                    kaydet4.Parameters.AddWithValue("@h4", decimal.Parse(txtutar.Text));
                    kaydet4.Parameters.AddWithValue("@h5",txtfaturadetayid.Text);
                    kaydet4.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    listele();
                    ////Stok Sayısını Düşürme
                    SqlCommand komut5 = new SqlCommand("Update Urunler set Adet=Adet-@k1 where Id=@k2",bgl.baglanti());
                    komut5.Parameters.AddWithValue("@k1", txtadet.Text);
                    komut5.Parameters.AddWithValue("@k2", txturunid.Text);
                    komut5.ExecuteNonQuery();
                    bgl.baglanti().Close();
                }
                else
                {
                    MessageBox.Show("Ekleme İşlemi İptal Edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();

                }
            }
            catch
            {
                MessageBox.Show("Bir Hata Meydana Geldi. Bütün Satırları Doğru Girdiğinizden Emin Olun Veya Satırları Doldurduğunuzdan Emin Olun.!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                temizle();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Silmek İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SqlCommand sil = new SqlCommand("Delete from FaturaBilgi where FaturaBilgid=@p1", bgl.baglanti());
                    sil.Parameters.AddWithValue("@p1", txtid.Text);
                    sil.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    listele();
                    temizle();
                }
                else
                {
                    MessageBox.Show("Silme İşlemi İptal Edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                    temizle();
                }
            }
            catch
            {
                MessageBox.Show("Bir Hata Meydana Geldi.Lütfen Silmek İstediğiniz Stüna İki Kere Tıklayarak Tekrar Deneyiniz.!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                temizle();
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Güncellemek İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SqlCommand guncelle = new SqlCommand("Update FaturaBilgi set Seri=@p1,SıraNo=@p2,Tarih=@p3,Saat=@p4,VergiDaire=@p5,Alıcı=@p6,TeslimEden=@p7,TeslimAlan=@p8 where FaturaBilgid=@p9", bgl.baglanti());
                    guncelle.Parameters.AddWithValue("@p1", txtseri.Text);
                    guncelle.Parameters.AddWithValue("@p2", txtsıra.Text);
                    guncelle.Parameters.AddWithValue("@p3", masktarih.Text);
                    guncelle.Parameters.AddWithValue("@p4", masksaat.Text);
                    guncelle.Parameters.AddWithValue("@p5", txtvergi.Text);
                    guncelle.Parameters.AddWithValue("@p6", txtalici.Text);
                    guncelle.Parameters.AddWithValue("@p7", txteden.Text);
                    guncelle.Parameters.AddWithValue("@p8", txtalan.Text);
                    guncelle.Parameters.AddWithValue("@p9", txtid.Text);
                    guncelle.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    listele();
                    temizle();
                }
                else
                {
                    MessageBox.Show("Güncelleme İşlemi İptal Edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                    temizle();
                }
            }
            catch
            {
                MessageBox.Show("Bir Hata Meydana Geldi.Lütfen Güncellemek İstediğiniz Stünları Tekrar Kontrol Ediniz.!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                temizle();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FaturaUrunDetay fr = new FaturaUrunDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                fr.id = dr["FaturaBilgid"].ToString();
            }
            fr.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand getir = new SqlCommand("Select Fiyat from FaturaUrunDetay where UrunAd=@p1",bgl.baglanti());
            getir.Parameters.AddWithValue("@p1", txturunad.Text);
            SqlDataReader sqlDataReader = getir.ExecuteReader();
            while (sqlDataReader.Read())
            {
                txtfiyat.Text = sqlDataReader[0].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
