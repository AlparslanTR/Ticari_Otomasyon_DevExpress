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
    public partial class Firmalar : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public Firmalar()
        {
            InitializeComponent();
        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select*from Firmalar", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            txtad.Text = "";
            txtgorev.Text = "";
            txtyetkili.Text = "";
            masktc.Text = "";
            txtsektor.Text = "";
            masktel1.Text = "";
            masktel2.Text = "";
            masktel3.Text = "";
            txtmail.Text = "";
            maskfaks.Text = "";
            comboil.Text = "";
            comboilce.Text = "";
            txtvergi.Text = "";
            richadres.Text = "";
            txtozel.Text = "";
            txtozel2.Text = "";
            txtozel3.Text = "";
        }
        void satıralma()
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["Id"].ToString();
                txtad.Text = dr["Ad"].ToString();
                txtgorev.Text = dr["YetkiliGorev"].ToString();
                txtyetkili.Text = dr["YetkiliAdSoyad"].ToString();
                masktc.Text = dr["YetkiliTC"].ToString();
                txtsektor.Text = dr["Sektor"].ToString();
                masktel1.Text = dr["Tel"].ToString();
                masktel2.Text = dr["Tel2"].ToString();
                masktel3.Text = dr["Tel3"].ToString();
                txtmail.Text = dr["Mail"].ToString();
                maskfaks.Text = dr["Fax"].ToString();
                comboil.Text = dr["IL"].ToString();
                comboilce.Text = dr["Ilce"].ToString();
                txtvergi.Text = dr["VergiDaire"].ToString();
                richadres.Text = dr["Adres"].ToString();
                txtozel.Text = dr["Ozelkod1"].ToString();
                txtozel2.Text = dr["Ozelkod2"].ToString();
                txtozel3.Text = dr["Ozelkod3"].ToString();
            }
        }
        void sehirlistesi()
        {
            SqlCommand cek = new SqlCommand("Select Sehir from Iller", bgl.baglanti());
            SqlDataReader dr = cek.ExecuteReader();
            while (dr.Read())
            {
                comboil.Properties.Items.Add(dr[0].ToString());
            }
            bgl.baglanti().Close();
        }
        void ozelkodlar()
        {
            SqlCommand ozel = new SqlCommand("Select Firmakod1 From Kodlar", bgl.baglanti());
            SqlDataReader dr = ozel.ExecuteReader();
            while (dr.Read())
            {
                richozel1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }
        private void Firmalar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
            sehirlistesi();
            ozelkodlar();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Kaydetmek İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SqlCommand ekle = new SqlCommand("Insert into Firmalar(Ad,YetkiliGorev,YetkiliAdSoyad,YetkiliTC,Sektor,Tel,Tel2,Tel3,Mail,Fax,IL,Ilce,VergiDaire,Adres,Ozelkod1,Ozelkod2,Ozelkod3)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", bgl.baglanti());
                    ekle.Parameters.AddWithValue("@p1", txtad.Text);
                    ekle.Parameters.AddWithValue("@p2", txtgorev.Text);
                    ekle.Parameters.AddWithValue("@p3", txtyetkili.Text);
                    ekle.Parameters.AddWithValue("@p4", masktc.Text);
                    ekle.Parameters.AddWithValue("@p5", txtsektor.Text);
                    ekle.Parameters.AddWithValue("@p6", masktel1.Text);
                    ekle.Parameters.AddWithValue("@p7", masktel2.Text);
                    ekle.Parameters.AddWithValue("@p8", masktel3.Text);
                    ekle.Parameters.AddWithValue("@p9", txtmail.Text);
                    ekle.Parameters.AddWithValue("@p10", maskfaks.Text);
                    ekle.Parameters.AddWithValue("@p11", comboil.Text);
                    ekle.Parameters.AddWithValue("@p12", comboilce.Text);
                    ekle.Parameters.AddWithValue("@p13", txtvergi.Text);
                    ekle.Parameters.AddWithValue("@p14", richadres.Text);
                    ekle.Parameters.AddWithValue("@p15", txtozel.Text);
                    ekle.Parameters.AddWithValue("@p16", txtozel2.Text);
                    ekle.Parameters.AddWithValue("@p17", txtozel3.Text);
                    ekle.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    listele();
                    temizle();
                }
                else
                {
                    MessageBox.Show("Ekleme İşlemi İptal Edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                    temizle();
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            satıralma();
        }

        private void comboil_SelectedIndexChanged(object sender, EventArgs e) 
        {
            comboilce.Properties.Items.Clear();
            SqlCommand cek2 = new SqlCommand("Select Ilce from Ilceler where Sehir=@p1", bgl.baglanti());
            cek2.Parameters.AddWithValue("@p1", comboil.SelectedIndex + 1);
            SqlDataReader dr = cek2.ExecuteReader();
            while (dr.Read())
            {
                comboilce.Properties.Items.Add(dr[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Silmek İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SqlCommand sil = new SqlCommand("Delete from Firmalar where Id=@p1", bgl.baglanti());
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
                    SqlCommand guncelle = new SqlCommand("Update Firmalar set Ad=@p1,YetkiliGorev=@p2,YetkiliAdSoyad=@p3,YetkiliTC=@p4,Sektor=@p5,Tel=@p6,Tel2=@p7,Tel3=@p8,Mail=@p9,Fax=@p10,IL=@p11,Ilce=@p12,VergiDaire=@p13,Adres=@p14,Ozelkod1=@p15,Ozelkod2=@p16,Ozelkod3=@p17 where Id=@p18", bgl.baglanti());
                    guncelle.Parameters.AddWithValue("@p1", txtad.Text);
                    guncelle.Parameters.AddWithValue("@p2", txtgorev.Text);
                    guncelle.Parameters.AddWithValue("@p3", txtyetkili.Text);
                    guncelle.Parameters.AddWithValue("@p4", masktc.Text);
                    guncelle.Parameters.AddWithValue("@p5", txtsektor.Text);
                    guncelle.Parameters.AddWithValue("@p6", masktel1.Text);
                    guncelle.Parameters.AddWithValue("@p7", masktel2.Text);
                    guncelle.Parameters.AddWithValue("@p8", masktel3.Text);
                    guncelle.Parameters.AddWithValue("@p9", txtmail.Text);
                    guncelle.Parameters.AddWithValue("@p10", maskfaks.Text);
                    guncelle.Parameters.AddWithValue("@p11", comboil.Text);
                    guncelle.Parameters.AddWithValue("@p12", comboilce.Text);
                    guncelle.Parameters.AddWithValue("@p13", txtvergi.Text);
                    guncelle.Parameters.AddWithValue("@p14", richadres.Text);
                    guncelle.Parameters.AddWithValue("@p15", txtozel.Text);
                    guncelle.Parameters.AddWithValue("@p16", txtozel2.Text);
                    guncelle.Parameters.AddWithValue("@p17", txtozel3.Text);
                    guncelle.Parameters.AddWithValue("@p18", txtid.Text);
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
            bgl.baglanti().Close();
        }
    }
}
