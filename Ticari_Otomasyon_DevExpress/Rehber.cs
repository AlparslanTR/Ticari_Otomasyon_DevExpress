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
    public partial class Rehber : Form
    {
        public Rehber()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        void MusteriListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Ad,Soyad,Tel,Tel2,Mail from Musteriler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void FirmaListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Ad,YetkiliAdSoyad,Tel,Tel2,Tel3,Mail,Fax from Firmalar", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }
        private void Rehber_Load(object sender, EventArgs e)
        {
            MusteriListele();
            FirmaListele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Mail fr = new Mail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                fr.mail = dr["Mail"].ToString();
            }
            fr.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            Mail fr = new Mail();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                fr.mail = dr["Mail"].ToString();
            }
            fr.Show();

        }
    }
}
