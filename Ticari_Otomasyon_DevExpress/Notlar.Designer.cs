
namespace Ticari_Otomasyon_DevExpress
{
    partial class Notlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notlar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.richdetay = new System.Windows.Forms.RichTextBox();
            this.Masktarih = new System.Windows.Forms.MaskedTextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnlistele = new DevExpress.XtraEditors.SimpleButton();
            this.btntemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lbltel2 = new DevExpress.XtraEditors.LabelControl();
            this.lbltel = new DevExpress.XtraEditors.LabelControl();
            this.txtbaslik = new DevExpress.XtraEditors.TextEdit();
            this.lblsoyad = new DevExpress.XtraEditors.LabelControl();
            this.lblad = new DevExpress.XtraEditors.LabelControl();
            this.masksaat = new System.Windows.Forms.MaskedTextBox();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.lblid = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txthitap = new DevExpress.XtraEditors.TextEdit();
            this.txtolusturan = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txthitap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtolusturan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1653, 818);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridView1.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // richdetay
            // 
            this.richdetay.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richdetay.Location = new System.Drawing.Point(93, 235);
            this.richdetay.Name = "richdetay";
            this.richdetay.Size = new System.Drawing.Size(150, 161);
            this.richdetay.TabIndex = 10;
            this.richdetay.Text = "";
            // 
            // Masktarih
            // 
            this.Masktarih.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Masktarih.Location = new System.Drawing.Point(93, 24);
            this.Masktarih.Mask = "00/00/0000";
            this.Masktarih.Name = "Masktarih";
            this.Masktarih.Size = new System.Drawing.Size(149, 26);
            this.Masktarih.TabIndex = 3;
            this.Masktarih.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(45, 235);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(44, 18);
            this.labelControl10.TabIndex = 24;
            this.labelControl10.Text = "Detay:";
            // 
            // btnlistele
            // 
            this.btnlistele.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlistele.Appearance.Options.UseFont = true;
            this.btnlistele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnlistele.ImageOptions.Image")));
            this.btnlistele.Location = new System.Drawing.Point(93, 417);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(108, 34);
            this.btnlistele.TabIndex = 11;
            this.btnlistele.Text = "Listele";
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizle.Appearance.Options.UseFont = true;
            this.btntemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntemizle.ImageOptions.Image")));
            this.btntemizle.Location = new System.Drawing.Point(93, 688);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(108, 34);
            this.btntemizle.TabIndex = 15;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Appearance.Options.UseFont = true;
            this.btnguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguncelle.ImageOptions.Image")));
            this.btnguncelle.Location = new System.Drawing.Point(93, 621);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(108, 34);
            this.btnguncelle.TabIndex = 14;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Appearance.Options.UseFont = true;
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(93, 554);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(108, 34);
            this.btnsil.TabIndex = 13;
            this.btnsil.Text = "Sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Appearance.Options.UseFont = true;
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(93, 481);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(108, 34);
            this.btnkaydet.TabIndex = 12;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(51, 184);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 18);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Hitap:";
            // 
            // lbltel2
            // 
            this.lbltel2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltel2.Appearance.Options.UseFont = true;
            this.lbltel2.Location = new System.Drawing.Point(24, 146);
            this.lbltel2.Name = "lbltel2";
            this.lbltel2.Size = new System.Drawing.Size(67, 18);
            this.lbltel2.TabIndex = 9;
            this.lbltel2.Text = "Oluşturan:";
            // 
            // lbltel
            // 
            this.lbltel.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltel.Appearance.Options.UseFont = true;
            this.lbltel.Location = new System.Drawing.Point(51, 105);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(40, 18);
            this.lbltel.TabIndex = 7;
            this.lbltel.Text = "Başlık:";
            // 
            // txtbaslik
            // 
            this.txtbaslik.Location = new System.Drawing.Point(93, 102);
            this.txtbaslik.Name = "txtbaslik";
            this.txtbaslik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbaslik.Properties.Appearance.Options.UseFont = true;
            this.txtbaslik.Size = new System.Drawing.Size(149, 24);
            this.txtbaslik.TabIndex = 2;
            // 
            // lblsoyad
            // 
            this.lblsoyad.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoyad.Appearance.Options.UseFont = true;
            this.lblsoyad.Location = new System.Drawing.Point(56, 68);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(34, 18);
            this.lblsoyad.TabIndex = 5;
            this.lblsoyad.Text = "Saat:";
            // 
            // lblad
            // 
            this.lblad.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblad.Appearance.Options.UseFont = true;
            this.lblad.Location = new System.Drawing.Point(51, 29);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(38, 18);
            this.lblad.TabIndex = 3;
            this.lblad.Text = "Tarih:";
            // 
            // masksaat
            // 
            this.masksaat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masksaat.Location = new System.Drawing.Point(93, 65);
            this.masksaat.Mask = "00:00";
            this.masksaat.Name = "masksaat";
            this.masksaat.Size = new System.Drawing.Size(149, 26);
            this.masksaat.TabIndex = 4;
            this.masksaat.ValidatingType = typeof(System.DateTime);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(93, 26);
            this.txtid.Name = "txtid";
            this.txtid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Properties.Appearance.Options.UseFont = true;
            this.txtid.Size = new System.Drawing.Size(128, 24);
            this.txtid.TabIndex = 1;
            this.txtid.Visible = false;
            // 
            // lblid
            // 
            this.lblid.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblid.Appearance.Options.UseFont = true;
            this.lblid.Location = new System.Drawing.Point(68, 29);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 18);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID:";
            this.lblid.Visible = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txthitap);
            this.groupControl1.Controls.Add(this.txtolusturan);
            this.groupControl1.Controls.Add(this.richdetay);
            this.groupControl1.Controls.Add(this.Masktarih);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.btnlistele);
            this.groupControl1.Controls.Add(this.btntemizle);
            this.groupControl1.Controls.Add(this.btnguncelle);
            this.groupControl1.Controls.Add(this.btnsil);
            this.groupControl1.Controls.Add(this.btnkaydet);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.lbltel2);
            this.groupControl1.Controls.Add(this.lbltel);
            this.groupControl1.Controls.Add(this.txtbaslik);
            this.groupControl1.Controls.Add(this.lblsoyad);
            this.groupControl1.Controls.Add(this.lblad);
            this.groupControl1.Controls.Add(this.masksaat);
            this.groupControl1.Controls.Add(this.txtid);
            this.groupControl1.Controls.Add(this.lblid);
            this.groupControl1.Location = new System.Drawing.Point(1656, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(245, 818);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "MÜŞTERİ BİLGİSİ";
            // 
            // txthitap
            // 
            this.txthitap.Location = new System.Drawing.Point(93, 181);
            this.txthitap.Name = "txthitap";
            this.txthitap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txthitap.Properties.Appearance.Options.UseFont = true;
            this.txthitap.Size = new System.Drawing.Size(149, 24);
            this.txthitap.TabIndex = 26;
            // 
            // txtolusturan
            // 
            this.txtolusturan.Location = new System.Drawing.Point(93, 143);
            this.txtolusturan.Name = "txtolusturan";
            this.txtolusturan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtolusturan.Properties.Appearance.Options.UseFont = true;
            this.txtolusturan.Size = new System.Drawing.Size(149, 24);
            this.txtolusturan.TabIndex = 25;
            // 
            // Notlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 861);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Notlar";
            this.Text = "NOTLAR";
            this.Load += new System.EventHandler(this.Notlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txthitap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtolusturan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.RichTextBox richdetay;
        private System.Windows.Forms.MaskedTextBox Masktarih;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnlistele;
        private DevExpress.XtraEditors.SimpleButton btntemizle;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lbltel2;
        private DevExpress.XtraEditors.LabelControl lbltel;
        private DevExpress.XtraEditors.TextEdit txtbaslik;
        private DevExpress.XtraEditors.LabelControl lblsoyad;
        private DevExpress.XtraEditors.LabelControl lblad;
        private System.Windows.Forms.MaskedTextBox masksaat;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.LabelControl lblid;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txthitap;
        private DevExpress.XtraEditors.TextEdit txtolusturan;
    }
}