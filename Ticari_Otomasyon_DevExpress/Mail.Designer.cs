
namespace Ticari_Otomasyon_DevExpress
{
    partial class Mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mail));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.richmesaj = new System.Windows.Forms.RichTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btngonder = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtkonu = new DevExpress.XtraEditors.TextEdit();
            this.txtalıcı = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkonu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtalıcı.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 154);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(119, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Alıcı Mail Adresi:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(82, 185);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Konu:";
            // 
            // richmesaj
            // 
            this.richmesaj.Location = new System.Drawing.Point(126, 213);
            this.richmesaj.Name = "richmesaj";
            this.richmesaj.Size = new System.Drawing.Size(245, 311);
            this.richmesaj.TabIndex = 4;
            this.richmesaj.Text = "";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(78, 213);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 19);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Mesaj:";
            // 
            // btngonder
            // 
            this.btngonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btngonder.Location = new System.Drawing.Point(193, 530);
            this.btngonder.Name = "btngonder";
            this.btngonder.Size = new System.Drawing.Size(89, 23);
            this.btngonder.TabIndex = 0;
            this.btngonder.Text = "GÖNDER";
            this.btngonder.Click += new System.EventHandler(this.btngonder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = global::Ticari_Otomasyon_DevExpress.Properties.Resources.Feature_Image4;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 152);
            this.panel1.TabIndex = 6;
            // 
            // txtkonu
            // 
            this.txtkonu.Location = new System.Drawing.Point(125, 187);
            this.txtkonu.Name = "txtkonu";
            this.txtkonu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkonu.Properties.Appearance.Options.UseFont = true;
            this.txtkonu.Size = new System.Drawing.Size(246, 22);
            this.txtkonu.TabIndex = 3;
            // 
            // txtalıcı
            // 
            this.txtalıcı.Location = new System.Drawing.Point(125, 156);
            this.txtalıcı.Name = "txtalıcı";
            this.txtalıcı.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtalıcı.Properties.Appearance.Options.UseFont = true;
            this.txtalıcı.Size = new System.Drawing.Size(246, 22);
            this.txtalıcı.TabIndex = 1;
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 573);
            this.Controls.Add(this.btngonder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.richmesaj);
            this.Controls.Add(this.txtkonu);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtalıcı);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Mail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail";
            this.Load += new System.EventHandler(this.Mail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtkonu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtalıcı.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtalıcı;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtkonu;
        private System.Windows.Forms.RichTextBox richmesaj;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btngonder;
    }
}