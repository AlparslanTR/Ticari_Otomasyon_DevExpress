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
    public partial class Hareketler : Form
    {
        public Hareketler()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        void listeleMusteri()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute MusteriHareketler1 ",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void listeleFirma()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Execute FirmaHareketler1 ", bgl.baglanti());
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;
        }
        private void Hareketler_Load(object sender, EventArgs e)
        {
            listeleMusteri();
            listeleFirma();
        }
    }
}
