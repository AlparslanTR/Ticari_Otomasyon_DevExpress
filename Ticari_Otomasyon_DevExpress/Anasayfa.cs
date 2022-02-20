using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon_DevExpress
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        Urunler fr;
        Musteriler fr2;
        Firmalar fr3;
        Personeller fr4;
        public Rehber fr5;
        Giderler fr6;
        Bankalar fr7;
        Faturalar fr8;
        Notlar fr9;
        Hareketler fr10;
        STOKLAR fr11;
        Kasa fr12;
        PersonelMaasOde fr13;
        Anasayfa1 fr14;
        private void btnurunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new Urunler();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btnmusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2==null || fr2.IsDisposed)
            {
                fr2 = new Musteriler();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }

        private void btnfirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3==null || fr3.IsDisposed)
            {
                fr3 = new Firmalar();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }

        private void btnpersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4==null || fr4.IsDisposed)
            {
                fr4 = new Personeller();
                fr4.MdiParent = this;
                fr4.Show();
            }
        }

        private void btnrehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5==null || fr5.IsDisposed)
            {
                fr5 = new Rehber();
                fr5.MdiParent = this;
                fr5.Show();
            }
        }

        private void btngiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6==null || fr6.IsDisposed)
            {
                fr6 = new Giderler();
                fr6.MdiParent = this;
                fr6.Show();
            }
        }

        private void btnbankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7==null || fr7.IsDisposed)
            {
                fr7 = new Bankalar();
                fr7.MdiParent = this;
                fr7.Show();
            }
        }

        private void btnfaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr8==null || fr8.IsDisposed)
            {
                fr8 = new Faturalar();
                fr8.MdiParent = this;
                fr8.Show();
            }
        }

        private void btnotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr9==null || fr9.IsDisposed)
            {
                fr9 = new Notlar();
                fr9.MdiParent = this;
                fr9.Show();
            }
        }

        private void btnhareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr10==null || fr10.IsDisposed)
            {
                fr10 = new Hareketler();
                fr10.MdiParent = this;
                fr10.Show();
            }
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            if (fr14 == null || fr14.IsDisposed)
            {
                fr14 = new Anasayfa1();
                fr14.MdiParent = this;
                fr14.Show();
            }
        }

        private void btnstoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr11==null || fr11.IsDisposed)
            {
                fr11 = new STOKLAR();
                fr11.MdiParent = this;
                fr11.Show();
            }
        }

        private void btnkasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr12==null || fr12.IsDisposed)
            {
                fr12 = new Kasa();
                fr12.MdiParent = this;
                fr12.Show();
            }
        }

        private void barSubItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr13==null || fr13.IsDisposed)
            {
                fr13 = new PersonelMaasOde();
                fr13.MdiParent = this;
                fr13.Show();
            }
           
        }

        private void btnanasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr14==null || fr14.IsDisposed)
            {
                fr14 = new Anasayfa1();
                fr14.MdiParent = this;
                fr14.Show();
            }
        }
    }
}
