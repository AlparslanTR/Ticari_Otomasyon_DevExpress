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
    public partial class Giderler : Form
    {
        public Giderler()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select*from Giderler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void satıralma()
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["Id"].ToString();
                comboay.Text = dr["Ay"].ToString();
                comboyil.Text = dr["Yıl"].ToString();
                txtelektrik.Text = dr["Elektrik"].ToString();
                txtsu.Text = dr["Su"].ToString();
                txtdogalgaz.Text = dr["Dogalgaz"].ToString();
                txtint.Text = dr["Internet"].ToString();
                txtmaas.Text = dr["Maaslar"].ToString();
                txtextra.Text = dr["Ekstra"].ToString();
                richnot.Text = dr["Notlar"].ToString();
            }
        }
        void temizle()
        {
            txtid.Text = "";
            comboay.Text = "";
            comboyil.Text = "";
            txtelektrik.Text = "";
            txtsu.Text = "";
            txtdogalgaz.Text = "";
            txtint.Text = "";
            txtmaas.Text = "";
            txtextra.Text = "";
            richnot.Text = "";
        }
        private void Giderler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            satıralma();
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
                    SqlCommand ekle = new SqlCommand("Insert into Giderler(Ay,Yıl,Elektrik,Su,Dogalgaz,Internet,Maaslar,Ekstra,Notlar)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
                    ekle.Parameters.AddWithValue("@p1", comboay.Text);
                    ekle.Parameters.AddWithValue("@p2", comboyil.Text);
                    ekle.Parameters.AddWithValue("@p3", decimal.Parse(txtelektrik.Text));
                    ekle.Parameters.AddWithValue("@p4", decimal.Parse(txtsu.Text));
                    ekle.Parameters.AddWithValue("@p5", decimal.Parse(txtdogalgaz.Text));
                    ekle.Parameters.AddWithValue("@p6", decimal.Parse(txtint.Text));
                    ekle.Parameters.AddWithValue("@p7", decimal.Parse(txtmaas.Text));
                    ekle.Parameters.AddWithValue("@p8", decimal.Parse(txtextra.Text));
                    ekle.Parameters.AddWithValue("@p9", richnot.Text);
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
            bgl.baglanti().Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Silmek İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SqlCommand sil = new SqlCommand("Delete from Giderler where Id=@p1", bgl.baglanti());
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
            bgl.baglanti().Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Güncellemek İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SqlCommand guncelle = new SqlCommand("Update Giderler set Ay=@p1,Yıl=@p2,Elektrik=@p3,Su=@p4,Dogalgaz=@p5,Internet=@p6,Maaslar=@p7,Ekstra=@p8,Notlar=@p9 where Id=@p10", bgl.baglanti());
                    guncelle.Parameters.AddWithValue("@p1", comboay.Text);
                    guncelle.Parameters.AddWithValue("@p2", comboyil.Text);
                    guncelle.Parameters.AddWithValue("@p3", decimal.Parse(txtelektrik.Text));
                    guncelle.Parameters.AddWithValue("@p4", decimal.Parse(txtsu.Text));
                    guncelle.Parameters.AddWithValue("@p5", decimal.Parse(txtdogalgaz.Text));
                    guncelle.Parameters.AddWithValue("@p6", decimal.Parse(txtint.Text));
                    guncelle.Parameters.AddWithValue("@p7", decimal.Parse(txtmaas.Text));
                    guncelle.Parameters.AddWithValue("@p8", decimal.Parse(txtextra.Text));
                    guncelle.Parameters.AddWithValue("@p9", richnot.Text);
                    guncelle.Parameters.AddWithValue("@p10", txtid.Text);
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

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
