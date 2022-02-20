
namespace Ticari_Otomasyon_DevExpress
{
    partial class Personeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personeller));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.richadres = new System.Windows.Forms.RichTextBox();
            this.txtgorev = new DevExpress.XtraEditors.TextEdit();
            this.comboilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.masktc = new System.Windows.Forms.MaskedTextBox();
            this.masktel1 = new System.Windows.Forms.MaskedTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnlistele = new DevExpress.XtraEditors.SimpleButton();
            this.btntemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lbltel = new DevExpress.XtraEditors.LabelControl();
            this.txtsoyad = new DevExpress.XtraEditors.TextEdit();
            this.lblsoyad = new DevExpress.XtraEditors.LabelControl();
            this.txtad = new DevExpress.XtraEditors.TextEdit();
            this.lblad = new DevExpress.XtraEditors.LabelControl();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.lblid = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgorev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1653, 812);
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
            // richadres
            // 
            this.richadres.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richadres.Location = new System.Drawing.Point(90, 353);
            this.richadres.Name = "richadres";
            this.richadres.Size = new System.Drawing.Size(150, 145);
            this.richadres.TabIndex = 10;
            this.richadres.Text = "";
            // 
            // txtgorev
            // 
            this.txtgorev.Location = new System.Drawing.Point(91, 312);
            this.txtgorev.Name = "txtgorev";
            this.txtgorev.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgorev.Properties.Appearance.Options.UseFont = true;
            this.txtgorev.Size = new System.Drawing.Size(152, 24);
            this.txtgorev.TabIndex = 9;
            // 
            // comboilce
            // 
            this.comboilce.Location = new System.Drawing.Point(93, 268);
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
            this.comboil.Location = new System.Drawing.Point(93, 222);
            this.comboil.Name = "comboil";
            this.comboil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboil.Properties.Appearance.Options.UseFont = true;
            this.comboil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboil.Size = new System.Drawing.Size(149, 24);
            this.comboil.TabIndex = 7;
            this.comboil.SelectedIndexChanged += new System.EventHandler(this.comboil_SelectedIndexChanged);
            // 
            // masktc
            // 
            this.masktc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masktc.Location = new System.Drawing.Point(93, 144);
            this.masktc.Mask = "00000000000";
            this.masktc.Name = "masktc";
            this.masktc.Size = new System.Drawing.Size(149, 26);
            this.masktc.TabIndex = 5;
            this.masktc.ValidatingType = typeof(int);
            // 
            // masktel1
            // 
            this.masktel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masktel1.Location = new System.Drawing.Point(93, 102);
            this.masktel1.Mask = "(999) 000-0000";
            this.masktel1.Name = "masktel1";
            this.masktel1.Size = new System.Drawing.Size(149, 26);
            this.masktel1.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(45, 315);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 18);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Görev:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(42, 353);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(42, 18);
            this.labelControl10.TabIndex = 24;
            this.labelControl10.Text = "Adres:";
            // 
            // btnlistele
            // 
            this.btnlistele.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlistele.Appearance.Options.UseFont = true;
            this.btnlistele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnlistele.ImageOptions.Image")));
            this.btnlistele.Location = new System.Drawing.Point(90, 515);
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
            this.btntemizle.Location = new System.Drawing.Point(90, 742);
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
            this.btnguncelle.Location = new System.Drawing.Point(90, 690);
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
            this.btnsil.Location = new System.Drawing.Point(90, 630);
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
            this.btnkaydet.Location = new System.Drawing.Point(90, 567);
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
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(61, 267);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(28, 18);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "İlçe:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(76, 224);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(13, 18);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "İl:";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(93, 186);
            this.txtmail.Name = "txtmail";
            this.txtmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmail.Properties.Appearance.Options.UseFont = true;
            this.txtmail.Size = new System.Drawing.Size(149, 24);
            this.txtmail.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(65, 146);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 18);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "TC:";
            // 
            // lbltel
            // 
            this.lbltel.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltel.Appearance.Options.UseFont = true;
            this.lbltel.Location = new System.Drawing.Point(64, 104);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(25, 18);
            this.lbltel.TabIndex = 7;
            this.lbltel.Text = "Tel:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(93, 65);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyad.Properties.Appearance.Options.UseFont = true;
            this.txtsoyad.Size = new System.Drawing.Size(149, 24);
            this.txtsoyad.TabIndex = 2;
            // 
            // lblsoyad
            // 
            this.lblsoyad.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoyad.Appearance.Options.UseFont = true;
            this.lblsoyad.Location = new System.Drawing.Point(44, 68);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(45, 18);
            this.lblsoyad.TabIndex = 5;
            this.lblsoyad.Text = "Soyad:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(93, 27);
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
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(60, 189);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(29, 18);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Mail:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.richadres);
            this.groupControl1.Controls.Add(this.txtgorev);
            this.groupControl1.Controls.Add(this.comboilce);
            this.groupControl1.Controls.Add(this.comboil);
            this.groupControl1.Controls.Add(this.masktc);
            this.groupControl1.Controls.Add(this.masktel1);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.btnlistele);
            this.groupControl1.Controls.Add(this.btntemizle);
            this.groupControl1.Controls.Add(this.btnguncelle);
            this.groupControl1.Controls.Add(this.btnsil);
            this.groupControl1.Controls.Add(this.btnkaydet);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtmail);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.lbltel);
            this.groupControl1.Controls.Add(this.txtsoyad);
            this.groupControl1.Controls.Add(this.lblsoyad);
            this.groupControl1.Controls.Add(this.txtad);
            this.groupControl1.Controls.Add(this.lblad);
            this.groupControl1.Controls.Add(this.txtid);
            this.groupControl1.Controls.Add(this.lblid);
            this.groupControl1.Location = new System.Drawing.Point(1659, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(245, 812);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "PERSONEL BİLGİSİ";
            // 
            // Personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 861);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Personeller";
            this.Text = "PERSONELLER";
            this.Load += new System.EventHandler(this.Personeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgorev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.RichTextBox richadres;
        private DevExpress.XtraEditors.TextEdit txtgorev;
        private DevExpress.XtraEditors.ComboBoxEdit comboilce;
        private DevExpress.XtraEditors.ComboBoxEdit comboil;
        private System.Windows.Forms.MaskedTextBox masktc;
        private System.Windows.Forms.MaskedTextBox masktel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnlistele;
        private DevExpress.XtraEditors.SimpleButton btntemizle;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtmail;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lbltel;
        private DevExpress.XtraEditors.TextEdit txtsoyad;
        private DevExpress.XtraEditors.LabelControl lblsoyad;
        private DevExpress.XtraEditors.TextEdit txtad;
        private DevExpress.XtraEditors.LabelControl lblad;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.LabelControl lblid;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}