namespace Makrosoft
{
    partial class FrmSunucuAyar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSunucuAyar));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnDosyaIndir = new DevExpress.XtraEditors.SimpleButton();
            this.btnDevam = new DevExpress.XtraEditors.SimpleButton();
            this.txtSQLSunucusu = new DevExpress.XtraEditors.ButtonEdit();
            this.txtBaglantiCumle = new DevExpress.XtraEditors.ButtonEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKurulumVeriDizini = new DevExpress.XtraEditors.TextEdit();
            this.txtVeriCalismaDizini = new DevExpress.XtraEditors.ButtonEdit();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSQLSunucusu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaglantiCumle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKurulumVeriDizini.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVeriCalismaDizini.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnDosyaIndir);
            this.groupControl1.Controls.Add(this.btnDevam);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 259);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(502, 53);
            this.groupControl1.TabIndex = 25;
            // 
            // btnDosyaIndir
            // 
            this.btnDosyaIndir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDosyaIndir.Image = ((System.Drawing.Image)(resources.GetObject("btnDosyaIndir.Image")));
            this.btnDosyaIndir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDosyaIndir.Location = new System.Drawing.Point(342, 2);
            this.btnDosyaIndir.Name = "btnDosyaIndir";
            this.btnDosyaIndir.Size = new System.Drawing.Size(79, 49);
            this.btnDosyaIndir.TabIndex = 1;
            this.btnDosyaIndir.Click += new System.EventHandler(this.btnDosyaIndir_Click);
            // 
            // btnDevam
            // 
            this.btnDevam.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnDevam.Appearance.Options.UseFont = true;
            this.btnDevam.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDevam.Image = ((System.Drawing.Image)(resources.GetObject("btnDevam.Image")));
            this.btnDevam.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDevam.Location = new System.Drawing.Point(421, 2);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(79, 49);
            this.btnDevam.TabIndex = 0;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // txtSQLSunucusu
            // 
            this.txtSQLSunucusu.Location = new System.Drawing.Point(168, 147);
            this.txtSQLSunucusu.Name = "txtSQLSunucusu";
            this.txtSQLSunucusu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtSQLSunucusu.Size = new System.Drawing.Size(144, 20);
            this.txtSQLSunucusu.TabIndex = 29;
            this.txtSQLSunucusu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtSQLSunucusu_ButtonClick);
            // 
            // txtBaglantiCumle
            // 
            this.txtBaglantiCumle.Location = new System.Drawing.Point(168, 197);
            this.txtBaglantiCumle.Name = "txtBaglantiCumle";
            this.txtBaglantiCumle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtBaglantiCumle.Size = new System.Drawing.Size(320, 20);
            this.txtBaglantiCumle.TabIndex = 28;
            this.txtBaglantiCumle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtBaglantiCumle_ButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(12, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Kurulum için Veri Dizini";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Bağlantı Cümlesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Veri çalışma dizini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "SQL Sunucusu";
            // 
            // txtKurulumVeriDizini
            // 
            this.txtKurulumVeriDizini.EditValue = "C:\\Makro\\V14xx";
            this.txtKurulumVeriDizini.Location = new System.Drawing.Point(168, 222);
            this.txtKurulumVeriDizini.Name = "txtKurulumVeriDizini";
            this.txtKurulumVeriDizini.Size = new System.Drawing.Size(320, 20);
            this.txtKurulumVeriDizini.TabIndex = 27;
            // 
            // txtVeriCalismaDizini
            // 
            this.txtVeriCalismaDizini.EditValue = "C:\\Makro\\V14xx";
            this.txtVeriCalismaDizini.Location = new System.Drawing.Point(168, 172);
            this.txtVeriCalismaDizini.Name = "txtVeriCalismaDizini";
            this.txtVeriCalismaDizini.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtVeriCalismaDizini.Size = new System.Drawing.Size(320, 20);
            this.txtVeriCalismaDizini.TabIndex = 26;
            this.txtVeriCalismaDizini.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtVeriCalismaDizini_ButtonClick);
            // 
            // FrmSunucuAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(502, 312);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtSQLSunucusu);
            this.Controls.Add(this.txtBaglantiCumle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKurulumVeriDizini);
            this.Controls.Add(this.txtVeriCalismaDizini);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSunucuAyar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sunucu Ayarları";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSQLSunucusu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaglantiCumle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKurulumVeriDizini.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVeriCalismaDizini.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnDevam;
        private DevExpress.XtraEditors.ButtonEdit txtSQLSunucusu;
        private DevExpress.XtraEditors.ButtonEdit txtBaglantiCumle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtKurulumVeriDizini;
        private DevExpress.XtraEditors.ButtonEdit txtVeriCalismaDizini;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private DevExpress.XtraEditors.SimpleButton btnDosyaIndir;
    }
}