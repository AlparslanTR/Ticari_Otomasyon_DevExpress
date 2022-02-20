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
    public partial class Anasayfa1 : Form
    {
        public Anasayfa1()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl=new SqlBaglanti();
        void ajanda()
        {
            DataTable dt = new DataTable();
           SqlDataAdapter da = new SqlDataAdapter("Select top 15 Tarih,Saat,Baslik,Hitap,Detay from Notlar order by ID desc",bgl.baglanti());
            da.Fill(dt);
            gridControl3.DataSource = dt; 
        }
        private void Anasayfa1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ticariOtomasyonDataSetFirmaBilgileri.FirmaBilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.firmaBilgileriTableAdapter.Fill(this.ticariOtomasyonDataSetFirmaBilgileri.FirmaBilgileri);
            // TODO: Bu kod satırı 'ticariOtomasyonDataSetSon10Hareket.firmahareket2' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.firmahareket2TableAdapter.Fill(this.ticariOtomasyonDataSetSon10Hareket.firmahareket2);
            // TODO: Bu kod satırı 'ticariOtomasyonDataSetAzalan1.azalan1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.azalan1TableAdapter.Fill(this.ticariOtomasyonDataSetAzalan1.azalan1);
            ajanda();
            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/kurlar_tr.html");
            webBrowser2.Navigate("https://halktv.com.tr/haberler");
        }
    }
}
