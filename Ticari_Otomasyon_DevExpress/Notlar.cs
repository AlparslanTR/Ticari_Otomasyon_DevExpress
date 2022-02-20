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
    public partial class Notlar : Form
    {
        public Notlar()
        {
            InitializeComponent();
        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select*from Notlar", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = (dt);
        }
        SqlBaglanti bgl = new SqlBaglanti();
        void temizle()
        {
            Masktarih.Text = "";
            masksaat.Text = "";
            txtbaslik.Text = "";
            richdetay.Text = "";
            txtolusturan.Text = "";
            txthitap.Text = "";
        }
        void satıralma()
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["Id"].ToString();
                Masktarih.Text = dr["Tarih"].ToString();
                masksaat.Text = dr["Saat"].ToString();
                txtbaslik.Text = dr["Baslik"].ToString();
                richdetay.Text = dr["Detay"].ToString();
                txtolusturan.Text = dr["Olusturan"].ToString();
                txthitap.Text = dr["Hitap"].ToString();
            }
        }
        private void Notlar_Load(object sender, EventArgs e)
        {
            listele();
            satıralma();
            temizle();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Kaydetmek İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SqlCommand ekle = new SqlCommand("Insert into Notlar(Tarih,Saat,Baslik,Detay,Olusturan,Hitap)values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                    ekle.Parameters.AddWithValue("@p1", Masktarih.Text);
                    ekle.Parameters.AddWithValue("@p2", masksaat.Text);
                    ekle.Parameters.AddWithValue("@p3", txtbaslik.Text);
                    ekle.Parameters.AddWithValue("@p4", richdetay.Text);
                    ekle.Parameters.AddWithValue("@p5", txtolusturan.Text);
                    ekle.Parameters.AddWithValue("@p6", txthitap.Text);
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

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            satıralma();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Silmek İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SqlCommand sil = new SqlCommand("Delete from Notlar where Id=@p1", bgl.baglanti());
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
                    SqlCommand guncelle = new SqlCommand("Update Notlar set Tarih=@p1,Saat=@p2,Baslik=@p3,Detay=@p4,Olusturan=@p5,Hitap=@p6 where Id=@p7", bgl.baglanti());
                    guncelle.Parameters.AddWithValue("@p1", Masktarih.Text);
                    guncelle.Parameters.AddWithValue("@p2", masksaat.Text);
                    guncelle.Parameters.AddWithValue("@p3", txtbaslik.Text);
                    guncelle.Parameters.AddWithValue("@p4", richdetay.Text);
                    guncelle.Parameters.AddWithValue("@p5", txtolusturan.Text);
                    guncelle.Parameters.AddWithValue("@p6", txthitap.Text);
                    guncelle.Parameters.AddWithValue("@p7", txtid.Text);
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
    }
}
