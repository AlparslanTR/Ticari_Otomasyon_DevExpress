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
    public partial class FaturaUrunDetay : Form
    {
        public FaturaUrunDetay()
        {
            InitializeComponent();
        }
        public string id;
        SqlBaglanti bgl = new SqlBaglanti();
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from FaturaUrunDetay where FaturaUrunId='" + id + "'", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FaturaUrunDetay_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
