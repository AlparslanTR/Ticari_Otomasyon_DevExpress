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
    public partial class Bankalar : Form
    {
        public Bankalar()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
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
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute Bankabilgisi1", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void satıralma()
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["Id"].ToString();
                txtad.Text = dr["Adı"].ToString();
                txtsube.Text = dr["Sube"].ToString();
                txtiban.Text = dr["Iban"].ToString();
                txtyetkili.Text = dr["Yetkili"].ToString();
                txthesapno.Text = dr["HesapNo"].ToString();
                masktel.Text = dr["Tel"].ToString();
                comboil.Text = dr["IL"].ToString();
                comboilce.Text = dr["Ilce"].ToString();
                masktarih.Text = dr["Tarih"].ToString();
                txthesaptur.Text = dr["HesapTuru"].ToString();
              // lookfirma.Text = dr["FirmaId"].ToString();
            }
        }
        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsube.Text = "";
            txtiban.Text = "";
            txtyetkili.Text = "";
            txthesapno.Text = "";
            masktel.Text = "";
            comboil.Text = "";
            comboilce.Text = "";
            masktarih.Text = "";
            txthesaptur.Text = "";
            lookfirma.Text = "";
        }
        void firmaliste()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Id,Ad from Firmalar", bgl.baglanti());
            da.Fill(dt);
            lookfirma.Properties.ValueMember = "Id";
            lookfirma.Properties.DisplayMember = "Ad";
            lookfirma.Properties.DataSource = dt;
        }
        private void Bankalar_Load(object sender, EventArgs e)
        {
            sehirlistesi();
            listele();
            temizle();
            firmaliste();
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
                    SqlCommand ekle = new SqlCommand("Insert into Bankalar(Adı,IL,Ilce,Sube,Iban,HesapNo,Yetkili,Tel,Tarih,HesapTuru,FirmaId)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
                    ekle.Parameters.AddWithValue("@p1", txtad.Text);
                    ekle.Parameters.AddWithValue("@p2", comboil.Text);
                    ekle.Parameters.AddWithValue("@p3", comboilce.Text);
                    ekle.Parameters.AddWithValue("@p4", txtsube.Text);
                    ekle.Parameters.AddWithValue("@p5", txtiban.Text);
                    ekle.Parameters.AddWithValue("@p6", txthesapno.Text);
                    ekle.Parameters.AddWithValue("@p7", txtyetkili.Text);
                    ekle.Parameters.AddWithValue("@p8", masktel.Text);
                    ekle.Parameters.AddWithValue("@p9", masktarih.Text);
                    ekle.Parameters.AddWithValue("@p10", txthesaptur.Text);
                    ekle.Parameters.AddWithValue("@p11", lookfirma.EditValue);
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
                    SqlCommand sil = new SqlCommand("Delete from Bankalar where Id=@p1", bgl.baglanti());
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
                    SqlCommand guncelle = new SqlCommand("Update Bankalar set Adı=@p1,IL=@p2,Ilce=@p3,Sube=@p4,Iban=@p5,HesapNo=@p6,Yetkili=@p7,Tel=@p8,Tarih=@p9,HesapTuru=@p10,FirmaId=@p11 where Id=@p12", bgl.baglanti());
                    guncelle.Parameters.AddWithValue("@p1", txtad.Text);
                    guncelle.Parameters.AddWithValue("@p2", comboil.Text);
                    guncelle.Parameters.AddWithValue("@p3", comboilce.Text);
                    guncelle.Parameters.AddWithValue("@p4", txtsube.Text);
                    guncelle.Parameters.AddWithValue("@p5", txtiban.Text);
                    guncelle.Parameters.AddWithValue("@p6", txthesapno.Text);
                    guncelle.Parameters.AddWithValue("@p7", txtyetkili.Text);
                    guncelle.Parameters.AddWithValue("@p8", masktel.Text);
                    guncelle.Parameters.AddWithValue("@p9", masktarih.Text);
                    guncelle.Parameters.AddWithValue("@p10", txthesaptur.Text);
                    guncelle.Parameters.AddWithValue("@p11", lookfirma.EditValue);            
                    guncelle.Parameters.AddWithValue("@p12", txtid.Text);
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
