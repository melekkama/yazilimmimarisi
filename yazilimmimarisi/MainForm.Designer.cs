
namespace yazilimmimarisi
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_main = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cb_kalkıs = new MaterialSkin.Controls.MaterialComboBox();
            this.cb_varıs = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(312, 318);
            this.dtp_start.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_start.MaxDate = new System.DateTime(2024, 4, 5, 0, 0, 0, 0);
            this.dtp_start.MinDate = new System.DateTime(2022, 5, 24, 0, 0, 0, 0);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(265, 22);
            this.dtp_start.TabIndex = 0;
            this.dtp_start.Value = new System.DateTime(2022, 5, 24, 0, 0, 0, 0);
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(312, 410);
            this.dtp_end.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_end.MaxDate = new System.DateTime(2024, 10, 18, 0, 0, 0, 0);
            this.dtp_end.MinDate = new System.DateTime(2022, 5, 24, 0, 0, 0, 0);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(265, 22);
            this.dtp_end.TabIndex = 1;
            this.dtp_end.Value = new System.DateTime(2022, 5, 24, 0, 0, 0, 0);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(79, 319);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 24);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Gidiş Tarihi:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(79, 411);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(113, 24);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Dönüş Tarihi";
            // 
            // btn_main
            // 
            this.btn_main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_main.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_main.Depth = 0;
            this.btn_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_main.HighEmphasis = true;
            this.btn_main.Icon = null;
            this.btn_main.Location = new System.Drawing.Point(4, 502);
            this.btn_main.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_main.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_main.Name = "btn_main";
            this.btn_main.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_main.Size = new System.Drawing.Size(699, 36);
            this.btn_main.TabIndex = 4;
            this.btn_main.Text = "N E X T";
            this.btn_main.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_main.UseAccentColor = false;
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(79, 106);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(133, 24);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Kalkış Noktası:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(79, 194);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(125, 24);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Varış Noktası:";
            // 
            // cb_kalkıs
            // 
            this.cb_kalkıs.AutoResize = false;
            this.cb_kalkıs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_kalkıs.Depth = 0;
            this.cb_kalkıs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_kalkıs.DropDownHeight = 174;
            this.cb_kalkıs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_kalkıs.DropDownWidth = 121;
            this.cb_kalkıs.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_kalkıs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_kalkıs.FormattingEnabled = true;
            this.cb_kalkıs.IntegralHeight = false;
            this.cb_kalkıs.ItemHeight = 43;
            this.cb_kalkıs.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cb_kalkıs.Location = new System.Drawing.Point(312, 95);
            this.cb_kalkıs.MaxDropDownItems = 4;
            this.cb_kalkıs.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_kalkıs.Name = "cb_kalkıs";
            this.cb_kalkıs.Size = new System.Drawing.Size(208, 49);
            this.cb_kalkıs.StartIndex = 0;
            this.cb_kalkıs.TabIndex = 7;
            // 
            // cb_varıs
            // 
            this.cb_varıs.AutoResize = false;
            this.cb_varıs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_varıs.Depth = 0;
            this.cb_varıs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_varıs.DropDownHeight = 174;
            this.cb_varıs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_varıs.DropDownWidth = 121;
            this.cb_varıs.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_varıs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_varıs.FormattingEnabled = true;
            this.cb_varıs.IntegralHeight = false;
            this.cb_varıs.ItemHeight = 43;
            this.cb_varıs.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cb_varıs.Location = new System.Drawing.Point(312, 184);
            this.cb_varıs.MaxDropDownItems = 4;
            this.cb_varıs.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_varıs.Name = "cb_varıs";
            this.cb_varıs.Size = new System.Drawing.Size(208, 49);
            this.cb_varıs.StartIndex = 0;
            this.cb_varıs.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 542);
            this.Controls.Add(this.cb_varıs);
            this.Controls.Add(this.cb_kalkıs);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.btn_main);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.dtp_start);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btn_main;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox cb_kalkıs;
        private MaterialSkin.Controls.MaterialComboBox cb_varıs;
    }
}

