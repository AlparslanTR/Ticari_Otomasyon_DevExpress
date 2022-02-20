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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select*from Urunler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            txtad.Text = "";
            txtmarka.Text = "";
            txtmodel.Text = "";
            maskyil.Text = "";
            numadet.Text = "";
            txtalis.Text = "";
            txtsatis.Text = "";
            richdetay.Text = "";
        }
        void satıralma()
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                txtid.Text = dr["Id"].ToString();
                txtad.Text = dr["Ad"].ToString();
                txtmarka.Text = dr["Marka"].ToString();
                txtmodel.Text = dr["Model"].ToString();
                maskyil.Text = dr["Yıl"].ToString();
                numadet.Value = decimal.Parse(dr["Adet"].ToString());
                txtalis.Text = dr["AlisFiyat"].ToString();
                txtsatis.Text = dr["SatisFiyat"].ToString();
                richdetay.Text = dr["Detay"].ToString();
            }
            
        }
        private void Urunler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Kaydetmek İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SqlCommand ekle = new SqlCommand("Insert into Urunler(Ad,Marka,Model,Yıl,Adet,AlisFiyat,SatisFiyat,Detay)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                    ekle.Parameters.AddWithValue("@p1", txtad.Text);
                    ekle.Parameters.AddWithValue("@p2", txtmarka.Text);
                    ekle.Parameters.AddWithValue("@p3", txtmodel.Text);
                    ekle.Parameters.AddWithValue("@p4", maskyil.Text);
                    ekle.Parameters.AddWithValue("@p5", ((numadet.Value).ToString()));
                    ekle.Parameters.AddWithValue("@p6", decimal.Parse(txtalis.Text));
                    ekle.Parameters.AddWithValue("@p7", decimal.Parse(txtsatis.Text));
                    ekle.Parameters.AddWithValue("@p8", richdetay.Text);
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

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Silmek İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SqlCommand sil = new SqlCommand("Delete from Urunler where Id=@p1", bgl.baglanti());
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            satıralma();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Güncellemek İstediğinize Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SqlCommand guncelle = new SqlCommand("Update Urunler set Ad=@p1,Marka=@p2,Model=@p3,Yıl=@p4,Adet=@p5,AlisFiyat=@p6,SatisFiyat=@p7,Detay=@p8 where Id=@p9", bgl.baglanti());
                    guncelle.Parameters.AddWithValue("@p1", txtad.Text);
                    guncelle.Parameters.AddWithValue("@p2", txtmarka.Text);
                    guncelle.Parameters.AddWithValue("@p3", txtmodel.Text);
                    guncelle.Parameters.AddWithValue("@p4", maskyil.Text);
                    guncelle.Parameters.AddWithValue("@p5", decimal.Parse((numadet.Value).ToString()));
                    guncelle.Parameters.AddWithValue("@p6", decimal.Parse(txtalis.Text));
                    guncelle.Parameters.AddWithValue("@p7", decimal.Parse(txtsatis.Text));
                    guncelle.Parameters.AddWithValue("@p8", richdetay.Text);
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
    }
}
