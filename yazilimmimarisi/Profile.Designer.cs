namespace yazilimmimarisi
{
    partial class Profile
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.tb_email = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_telNo = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_profil = new MaterialSkin.Controls.MaterialButton();
            this.tb_firstName = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_tc = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_lastName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 556);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialCard2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PROFIL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.tb_email);
            this.materialCard2.Controls.Add(this.tb_telNo);
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Controls.Add(this.materialLabel1);
            this.materialCard2.Controls.Add(this.btn_profil);
            this.materialCard2.Controls.Add(this.tb_firstName);
            this.materialCard2.Controls.Add(this.tb_tc);
            this.materialCard2.Controls.Add(this.tb_lastName);
            this.materialCard2.Controls.Add(this.materialLabel4);
            this.materialCard2.Controls.Add(this.materialLabel5);
            this.materialCard2.Controls.Add(this.materialLabel6);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(3, 3);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(780, 521);
            this.materialCard2.TabIndex = 0;
            // 
            // tb_email
            // 
            this.tb_email.AnimateReadOnly = false;
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_email.Depth = 0;
            this.tb_email.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_email.LeadingIcon = null;
            this.tb_email.Location = new System.Drawing.Point(335, 357);
            this.tb_email.MaxLength = 50;
            this.tb_email.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_email.Multiline = false;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(250, 50);
            this.tb_email.TabIndex = 16;
            this.tb_email.Text = "";
            this.tb_email.TrailingIcon = null;
            // 
            // tb_telNo
            // 
            this.tb_telNo.AnimateReadOnly = false;
            this.tb_telNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_telNo.Depth = 0;
            this.tb_telNo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_telNo.LeadingIcon = null;
            this.tb_telNo.Location = new System.Drawing.Point(335, 262);
            this.tb_telNo.MaxLength = 12;
            this.tb_telNo.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_telNo.Multiline = false;
            this.tb_telNo.Name = "tb_telNo";
            this.tb_telNo.Size = new System.Drawing.Size(250, 50);
            this.tb_telNo.TabIndex = 15;
            this.tb_telNo.Text = "";
            this.tb_telNo.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(153, 383);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(55, 24);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Email:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(153, 288);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(65, 24);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Tel.No:";
            // 
            // btn_profil
            // 
            this.btn_profil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_profil.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_profil.Depth = 0;
            this.btn_profil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_profil.HighEmphasis = true;
            this.btn_profil.Icon = null;
            this.btn_profil.Location = new System.Drawing.Point(14, 471);
            this.btn_profil.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_profil.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_profil.Name = "btn_profil";
            this.btn_profil.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_profil.Size = new System.Drawing.Size(752, 36);
            this.btn_profil.TabIndex = 12;
            this.btn_profil.Text = "K A Y D E T";
            this.btn_profil.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_profil.UseAccentColor = false;
            this.btn_profil.UseVisualStyleBackColor = true;
            this.btn_profil.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // tb_firstName
            // 
            this.tb_firstName.AnimateReadOnly = false;
            this.tb_firstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_firstName.Depth = 0;
            this.tb_firstName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_firstName.LeadingIcon = null;
            this.tb_firstName.Location = new System.Drawing.Point(335, 17);
            this.tb_firstName.MaxLength = 50;
            this.tb_firstName.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_firstName.Multiline = false;
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(250, 50);
            this.tb_firstName.TabIndex = 11;
            this.tb_firstName.Text = "";
            this.tb_firstName.TrailingIcon = null;
            // 
            // tb_tc
            // 
            this.tb_tc.AnimateReadOnly = false;
            this.tb_tc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_tc.Depth = 0;
            this.tb_tc.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_tc.LeadingIcon = null;
            this.tb_tc.Location = new System.Drawing.Point(335, 175);
            this.tb_tc.MaxLength = 50;
            this.tb_tc.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_tc.Multiline = false;
            this.tb_tc.Name = "tb_tc";
            this.tb_tc.Size = new System.Drawing.Size(250, 50);
            this.tb_tc.TabIndex = 10;
            this.tb_tc.Text = "";
            this.tb_tc.TrailingIcon = null;
            // 
            // tb_lastName
            // 
            this.tb_lastName.AnimateReadOnly = false;
            this.tb_lastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_lastName.Depth = 0;
            this.tb_lastName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_lastName.LeadingIcon = null;
            this.tb_lastName.Location = new System.Drawing.Point(335, 95);
            this.tb_lastName.MaxLength = 50;
            this.tb_lastName.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_lastName.Multiline = false;
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(250, 50);
            this.tb_lastName.TabIndex = 9;
            this.tb_lastName.Text = "";
            this.tb_lastName.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(153, 201);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(118, 24);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Tc Kimlik No:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(153, 121);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(61, 24);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "Soyad:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(153, 43);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(30, 24);
            this.materialLabel6.TabIndex = 6;
            this.materialLabel6.Text = "Ad:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialButton1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RAPOR";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(3, 488);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(780, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "görüntüle";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(774, 479);
            this.dataGridView1.TabIndex = 0;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.tabControl1);
            this.Name = "Profile";
            this.Text = "Profile";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton btn_profil;
        private MaterialSkin.Controls.MaterialTextBox tb_firstName;
        private MaterialSkin.Controls.MaterialTextBox tb_tc;
        private MaterialSkin.Controls.MaterialTextBox tb_lastName;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialTextBox tb_email;
        private MaterialSkin.Controls.MaterialTextBox tb_telNo;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}