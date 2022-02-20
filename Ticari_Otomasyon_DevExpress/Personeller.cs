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
    public partial class Personeller : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public Personeller()
        {
            InitializeComponent();
        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select*from Personeller", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizleme()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            masktel1.Text = "";
            masktc.Text = "";
            txtmail.Text = "";
            comboil.Text = "";
            comboilce.Text = "";
            richadres.Text = "";
            txtgorev.Text = "";
        }
        void satıralma()
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["Id"].ToString();
                txtad.Text = dr["Ad"].ToString();
                txtsoyad.Text = dr["Soyad"].ToString();
                masktel1.Text = dr["Tel"].ToString();
                masktc.Text = dr["Tc"].ToString();
                txtmail.Text = dr["Mail"].ToString();
                comboil.Text = dr["IL"].ToString();
                comboilce.Text = dr["Ilce"].ToString();
                richadres.Text = dr["Adres"].ToString();
                txtgorev.Text = dr["Gorev"].ToString();
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
        private void Personeller_Load(object sender, EventArgs e)
        {
            listele();
            temizleme();
            sehirlistesi();
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

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Kaydetmek İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SqlCommand ekle = new SqlCommand("Insert into Personeller(Ad,Soyad,Tel,Tc,Mail,IL,Ilce,Adres,Gorev)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
                    ekle.Parameters.AddWithValue("@p1", txtad.Text);
                    ekle.Parameters.AddWithValue("@p2", txtsoyad.Text);
                    ekle.Parameters.AddWithValue("@p3", masktel1.Text);
                    ekle.Parameters.AddWithValue("@p4", masktc.Text);
                    ekle.Parameters.AddWithValue("@p5", txtmail.Text);
                    ekle.Parameters.AddWithValue("@p6", comboil.Text);
                    ekle.Parameters.AddWithValue("@p7", comboilce.Text);
                    ekle.Parameters.AddWithValue("@p8", richadres.Text);
                    ekle.Parameters.AddWithValue("@p9", txtgorev.Text);
                    ekle.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    listele();
                    temizleme();
                }
                else
                {
                    MessageBox.Show("Ekleme İşlemi İptal Edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                    temizleme();
                }
            }
            catch
            {
                MessageBox.Show("Bir Hata Meydana Geldi. Bütün Satırları Doğru Girdiğinizden Emin Olun Veya Satırları Doldurduğunuzdan Emin Olun.!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                temizleme();
            }
            bgl.baglanti().Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Silmek İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SqlCommand sil = new SqlCommand("Delete from Personeller where Id=@p1", bgl.baglanti());
                    sil.Parameters.AddWithValue("@p1", txtid.Text);
                    sil.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    listele();
                    temizleme();
                }
                else
                {
                    MessageBox.Show("Silme İşlemi İptal Edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                    temizleme();
                }
            }
            catch
            {
                MessageBox.Show("Bir Hata Meydana Geldi.Lütfen Silmek İstediğiniz Stüna İki Kere Tıklayarak Tekrar Deneyiniz.!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                temizleme();
            }
            bgl.baglanti().Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Güncellemek İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SqlCommand guncelle = new SqlCommand("Update Personeller set Ad=@p1,Soyad=@p2,Tel=@p3,Tc=@p4,Mail=@p5,IL=@p6,Ilce=@p7,Adres=@p8,Gorev=@p9 where Id=@p10", bgl.baglanti());
                    guncelle.Parameters.AddWithValue("@p1", txtad.Text);
                    guncelle.Parameters.AddWithValue("@p2", txtsoyad.Text);
                    guncelle.Parameters.AddWithValue("@p3", masktel1.Text);
                    guncelle.Parameters.AddWithValue("@p4", masktc.Text);
                    guncelle.Parameters.AddWithValue("@p5", txtmail.Text);
                    guncelle.Parameters.AddWithValue("@p6", comboil.Text);
                    guncelle.Parameters.AddWithValue("@p7", comboilce.Text);
                    guncelle.Parameters.AddWithValue("@p8", richadres.Text);
                    guncelle.Parameters.AddWithValue("@p9", txtgorev.Text);
                    guncelle.Parameters.AddWithValue("@p10", txtid.Text);
                    guncelle.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    listele();
                    temizleme();
                }
                else
                {
                    MessageBox.Show("Güncelleme İşlemi İptal Edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                    temizleme();
                }
            }
            catch
            {
                MessageBox.Show("Bir Hata Meydana Geldi.Lütfen Güncellemek İstediğiniz Stünları Tekrar Kontrol Ediniz.!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                temizleme();
            }
            bgl.baglanti().Close();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizleme();
        }
    }
}
