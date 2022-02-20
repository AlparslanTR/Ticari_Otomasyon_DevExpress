
namespace Ticari_Otomasyon_DevExpress
{
    partial class Bankalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bankalar));
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.txtyetkili = new DevExpress.XtraEditors.TextEdit();
            this.comboilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.masktel = new System.Windows.Forms.MaskedTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnlistele = new DevExpress.XtraEditors.SimpleButton();
            this.btntemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookfirma = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txthesaptur = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.masktarih = new System.Windows.Forms.MaskedTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txthesapno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtiban = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtsube = new DevExpress.XtraEditors.TextEdit();
            this.lblsoyad = new DevExpress.XtraEditors.LabelControl();
            this.txtad = new DevExpress.XtraEditors.TextEdit();
            this.lblad = new DevExpress.XtraEditors.LabelControl();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.lblid = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtyetkili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookfirma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthesaptur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthesapno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtiban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
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
            // gridControl1
            // 
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridControl1.Location = new System.Drawing.Point(0, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1653, 813);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // txtyetkili
            // 
            this.txtyetkili.Location = new System.Drawing.Point(93, 256);
            this.txtyetkili.Name = "txtyetkili";
            this.txtyetkili.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyetkili.Properties.Appearance.Options.UseFont = true;
            this.txtyetkili.Size = new System.Drawing.Size(150, 24);
            this.txtyetkili.TabIndex = 9;
            // 
            // comboilce
            // 
            this.comboilce.Location = new System.Drawing.Point(94, 103);
            this.comboilce.Name = "comboilce";
            this.comboilce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboilce.Properties.Appearance.Options.UseFont = true;
            this.comboilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboilce.Size = new System.Drawing.Size(149, 24);
            this.comboilce.TabIndex = 8;
            // 
            // comboil
            // 
            this.comboil.Location = new System.Drawing.Point(94, 64);
            this.comboil.Name = "comboil";
            this.comboil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboil.Properties.Appearance.Options.UseFont = true;
            this.comboil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboil.Size = new System.Drawing.Size(149, 24);
            this.comboil.TabIndex = 7;
            this.comboil.SelectedIndexChanged += new System.EventHandler(this.comboil_SelectedIndexChanged);
            // 
            // masktel
            // 
            this.masktel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masktel.Location = new System.Drawing.Point(94, 295);
            this.masktel.Mask = "(999) 000-0000";
            this.masktel.Name = "masktel";
            this.masktel.Size = new System.Drawing.Size(149, 26);
            this.masktel.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(51, 259);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 18);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Yetkili:";
            // 
            // btnlistele
            // 
            this.btnlistele.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlistele.Appearance.Options.UseFont = true;
            this.btnlistele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnlistele.ImageOptions.Image")));
            this.btnlistele.Location = new System.Drawing.Point(94, 467);
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
            this.btntemizle.Location = new System.Drawing.Point(94, 709);
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
            this.btnguncelle.Location = new System.Drawing.Point(93, 650);
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
            this.btnsil.Location = new System.Drawing.Point(93, 588);
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
            this.btnkaydet.Location = new System.Drawing.Point(93, 526);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(108, 34);
            this.btnkaydet.TabIndex = 12;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookfirma);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txthesaptur);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.masktarih);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txthesapno);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtiban);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtyetkili);
            this.groupControl1.Controls.Add(this.comboilce);
            this.groupControl1.Controls.Add(this.comboil);
            this.groupControl1.Controls.Add(this.masktel);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnlistele);
            this.groupControl1.Controls.Add(this.btntemizle);
            this.groupControl1.Controls.Add(this.btnguncelle);
            this.groupControl1.Controls.Add(this.btnsil);
            this.groupControl1.Controls.Add(this.btnkaydet);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtsube);
            this.groupControl1.Controls.Add(this.lblsoyad);
            this.groupControl1.Controls.Add(this.txtad);
            this.groupControl1.Controls.Add(this.lblad);
            this.groupControl1.Controls.Add(this.txtid);
            this.groupControl1.Controls.Add(this.lblid);
            this.groupControl1.Location = new System.Drawing.Point(1659, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(245, 813);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "BANKALARIN BİLGİSİ";
            // 
            // lookfirma
            // 
            this.lookfirma.Location = new System.Drawing.Point(94, 422);
            this.lookfirma.Name = "lookfirma";
            this.lookfirma.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lookfirma.Properties.Appearance.Options.UseFont = true;
            this.lookfirma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookfirma.Properties.NullText = "Firma Seç";
            this.lookfirma.Size = new System.Drawing.Size(149, 24);
            this.lookfirma.TabIndex = 36;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(51, 425);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 18);
            this.labelControl7.TabIndex = 35;
            this.labelControl7.Text = "Firma:";
            // 
            // txthesaptur
            // 
            this.txthesaptur.Location = new System.Drawing.Point(94, 380);
            this.txthesaptur.Name = "txthesaptur";
            this.txthesaptur.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txthesaptur.Properties.Appearance.Options.UseFont = true;
            this.txthesaptur.Size = new System.Drawing.Size(149, 24);
            this.txthesaptur.TabIndex = 32;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(10, 383);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(82, 18);
            this.labelControl6.TabIndex = 33;
            this.labelControl6.Text = "Hesap Türü:";
            // 
            // masktarih
            // 
            this.masktarih.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masktarih.Location = new System.Drawing.Point(94, 336);
            this.masktarih.Mask = "00/00/0000";
            this.masktarih.Name = "masktarih";
            this.masktarih.Size = new System.Drawing.Size(149, 26);
            this.masktarih.TabIndex = 30;
            this.masktarih.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(54, 339);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 18);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "Tarih:";
            // 
            // txthesapno
            // 
            this.txthesapno.Location = new System.Drawing.Point(93, 217);
            this.txthesapno.Name = "txthesapno";
            this.txthesapno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txthesapno.Properties.Appearance.Options.UseFont = true;
            this.txthesapno.Size = new System.Drawing.Size(149, 24);
            this.txthesapno.TabIndex = 28;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(23, 220);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 18);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "Hesap No:";
            // 
            // txtiban
            // 
            this.txtiban.Location = new System.Drawing.Point(94, 178);
            this.txtiban.Name = "txtiban";
            this.txtiban.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtiban.Properties.Appearance.Options.UseFont = true;
            this.txtiban.Size = new System.Drawing.Size(149, 24);
            this.txtiban.TabIndex = 26;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(53, 181);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 18);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "IBAN:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(62, 102);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(28, 18);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "İlçe:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(77, 67);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(13, 18);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "İl:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(38, 298);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 18);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Telefon:";
            // 
            // txtsube
            // 
            this.txtsube.Location = new System.Drawing.Point(94, 140);
            this.txtsube.Name = "txtsube";
            this.txtsube.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsube.Properties.Appearance.Options.UseFont = true;
            this.txtsube.Size = new System.Drawing.Size(149, 24);
            this.txtsube.TabIndex = 2;
            // 
            // lblsoyad
            // 
            this.lblsoyad.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoyad.Appearance.Options.UseFont = true;
            this.lblsoyad.Location = new System.Drawing.Point(53, 143);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(37, 18);
            this.lblsoyad.TabIndex = 5;
            this.lblsoyad.Text = "Şube:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(93, 26);
            this.txtad.Name = "txtad";
            this.txtad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Properties.Appearance.Options.UseFont = true;
            this.txtad.Size = new System.Drawing.Size(149, 24);
            this.txtad.TabIndex = 1;
            // 
            // lblad
            // 
            this.lblad.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblad.Appearance.Options.UseFont = true;
            this.lblad.Location = new System.Drawing.Point(67, 30);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(22, 18);
            this.lblad.TabIndex = 3;
            this.lblad.Text = "Ad:";
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
            // Bankalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 861);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bankalar";
            this.Text = "BANKALAR";
            this.Load += new System.EventHandler(this.Bankalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtyetkili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookfirma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthesaptur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthesapno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtiban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.TextEdit txtyetkili;
        private DevExpress.XtraEditors.ComboBoxEdit comboilce;
        private DevExpress.XtraEditors.ComboBoxEdit comboil;
        private System.Windows.Forms.MaskedTextBox masktel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnlistele;
        private DevExpress.XtraEditors.SimpleButton btntemizle;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtsube;
        private DevExpress.XtraEditors.LabelControl lblsoyad;
        private DevExpress.XtraEditors.TextEdit txtad;
        private DevExpress.XtraEditors.LabelControl lblad;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.LabelControl lblid;
        private DevExpress.XtraEditors.TextEdit txthesapno;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtiban;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txthesaptur;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.MaskedTextBox masktarih;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit lookfirma;
    }
}