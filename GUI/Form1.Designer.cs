namespace GUI
{
    partial class Form1
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
            this.lwPodcast = new System.Windows.Forms.ListView();
            this.ColumnURL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNamn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAvsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFrekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblURL = new System.Windows.Forms.Label();
            this.lblUppdateringsfrekvens = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.cbxUppdateringsfrekvens = new System.Windows.Forms.ComboBox();
            this.cbxKategori = new System.Windows.Forms.ComboBox();
            this.lbxPodcastAvsnitt = new System.Windows.Forms.ListBox();
            this.lbxKategorier = new System.Windows.Forms.ListBox();
            this.lblKategorier = new System.Windows.Forms.Label();
            this.btnSparaAvsnitt = new System.Windows.Forms.Button();
            this.btnTaBortAvsnitt = new System.Windows.Forms.Button();
            this.tbxKategorier = new System.Windows.Forms.TextBox();
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.btnSparaKategori = new System.Windows.Forms.Button();
            this.lblAvsnittBeksrivning = new System.Windows.Forms.Label();
            this.tbxAvsnittBeskrivning = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lwPodcast
            // 
            this.lwPodcast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnURL,
            this.columnNamn,
            this.columnAvsnitt,
            this.columnFrekvens,
            this.columnKategori});
            this.lwPodcast.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwPodcast.GridLines = true;
            this.lwPodcast.HideSelection = false;
            this.lwPodcast.HoverSelection = true;
            this.lwPodcast.Location = new System.Drawing.Point(8, 11);
            this.lwPodcast.Margin = new System.Windows.Forms.Padding(2);
            this.lwPodcast.Name = "lwPodcast";
            this.lwPodcast.Size = new System.Drawing.Size(589, 216);
            this.lwPodcast.TabIndex = 0;
            this.lwPodcast.UseCompatibleStateImageBehavior = false;
            this.lwPodcast.View = System.Windows.Forms.View.Details;
            this.lwPodcast.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ColumnURL
            // 
            this.ColumnURL.Text = "URL";
            this.ColumnURL.Width = 86;
            // 
            // columnNamn
            // 
            this.columnNamn.Text = "Namn";
            this.columnNamn.Width = 185;
            // 
            // columnAvsnitt
            // 
            this.columnAvsnitt.Text = "Avsnitt";
            this.columnAvsnitt.Width = 71;
            // 
            // columnFrekvens
            // 
            this.columnFrekvens.Text = "Frekvens";
            this.columnFrekvens.Width = 103;
            // 
            // columnKategori
            // 
            this.columnKategori.Text = "Kategori";
            this.columnKategori.Width = 141;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(6, 238);
            this.lblURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(45, 17);
            this.lblURL.TabIndex = 1;
            this.lblURL.Text = "URL:";
            this.lblURL.Click += new System.EventHandler(this.lblURL_Click);
            // 
            // lblUppdateringsfrekvens
            // 
            this.lblUppdateringsfrekvens.AutoSize = true;
            this.lblUppdateringsfrekvens.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUppdateringsfrekvens.Location = new System.Drawing.Point(268, 238);
            this.lblUppdateringsfrekvens.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUppdateringsfrekvens.Name = "lblUppdateringsfrekvens";
            this.lblUppdateringsfrekvens.Size = new System.Drawing.Size(185, 17);
            this.lblUppdateringsfrekvens.TabIndex = 2;
            this.lblUppdateringsfrekvens.Text = "Uppdateringsfrekvens:";
            this.lblUppdateringsfrekvens.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori.Location = new System.Drawing.Point(456, 238);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(80, 17);
            this.lblKategori.TabIndex = 3;
            this.lblKategori.Text = "Kategori:";
            this.lblKategori.Click += new System.EventHandler(this.lblKategori_Click);
            // 
            // tbURL
            // 
            this.tbURL.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbURL.Location = new System.Drawing.Point(9, 265);
            this.tbURL.Margin = new System.Windows.Forms.Padding(2);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(245, 24);
            this.tbURL.TabIndex = 4;
            this.tbURL.Text = "https://...";
            this.tbURL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbURL_MouseClick);
            this.tbURL.TextChanged += new System.EventHandler(this.tbURL_TextChanged);
            // 
            // cbxUppdateringsfrekvens
            // 
            this.cbxUppdateringsfrekvens.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUppdateringsfrekvens.FormattingEnabled = true;
            this.cbxUppdateringsfrekvens.Items.AddRange(new object[] {
            "Var 5:e minut",
            "Var 10:e minut",
            "Var 15:e minut",
            "Var 20:e minut"});
            this.cbxUppdateringsfrekvens.Location = new System.Drawing.Point(272, 265);
            this.cbxUppdateringsfrekvens.Margin = new System.Windows.Forms.Padding(2);
            this.cbxUppdateringsfrekvens.Name = "cbxUppdateringsfrekvens";
            this.cbxUppdateringsfrekvens.Size = new System.Drawing.Size(167, 25);
            this.cbxUppdateringsfrekvens.TabIndex = 5;
            this.cbxUppdateringsfrekvens.Text = "Välj en frekvens";
            this.cbxUppdateringsfrekvens.SelectedIndexChanged += new System.EventHandler(this.cbxUppdateringsfrekvens_SelectedIndexChanged);
            // 
            // cbxKategori
            // 
            this.cbxKategori.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKategori.FormattingEnabled = true;
            this.cbxKategori.Location = new System.Drawing.Point(459, 265);
            this.cbxKategori.Margin = new System.Windows.Forms.Padding(2);
            this.cbxKategori.Name = "cbxKategori";
            this.cbxKategori.Size = new System.Drawing.Size(139, 25);
            this.cbxKategori.TabIndex = 6;
            this.cbxKategori.Text = "Välj en kategori";
            this.cbxKategori.SelectedIndexChanged += new System.EventHandler(this.cbxKategori_SelectedIndexChanged);
            // 
            // lbxPodcastAvsnitt
            // 
            this.lbxPodcastAvsnitt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPodcastAvsnitt.FormattingEnabled = true;
            this.lbxPodcastAvsnitt.ItemHeight = 17;
            this.lbxPodcastAvsnitt.Location = new System.Drawing.Point(9, 389);
            this.lbxPodcastAvsnitt.Margin = new System.Windows.Forms.Padding(2);
            this.lbxPodcastAvsnitt.Name = "lbxPodcastAvsnitt";
            this.lbxPodcastAvsnitt.Size = new System.Drawing.Size(589, 259);
            this.lbxPodcastAvsnitt.TabIndex = 8;
            this.lbxPodcastAvsnitt.SelectedIndexChanged += new System.EventHandler(this.lbxPodcastAvsnitt_SelectedIndexChanged);
            // 
            // lbxKategorier
            // 
            this.lbxKategorier.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxKategorier.FormattingEnabled = true;
            this.lbxKategorier.ItemHeight = 17;
            this.lbxKategorier.Location = new System.Drawing.Point(689, 43);
            this.lbxKategorier.Margin = new System.Windows.Forms.Padding(2);
            this.lbxKategorier.Name = "lbxKategorier";
            this.lbxKategorier.Size = new System.Drawing.Size(381, 174);
            this.lbxKategorier.TabIndex = 9;
            this.lbxKategorier.SelectedIndexChanged += new System.EventHandler(this.lbxKategorier_SelectedIndexChanged);
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorier.ForeColor = System.Drawing.Color.Black;
            this.lblKategorier.Location = new System.Drawing.Point(686, 10);
            this.lblKategorier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(96, 17);
            this.lblKategorier.TabIndex = 10;
            this.lblKategorier.Text = "Kategorier:";
            // 
            // btnSparaAvsnitt
            // 
            this.btnSparaAvsnitt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSparaAvsnitt.Location = new System.Drawing.Point(272, 322);
            this.btnSparaAvsnitt.Margin = new System.Windows.Forms.Padding(2);
            this.btnSparaAvsnitt.Name = "btnSparaAvsnitt";
            this.btnSparaAvsnitt.Size = new System.Drawing.Size(83, 28);
            this.btnSparaAvsnitt.TabIndex = 12;
            this.btnSparaAvsnitt.Text = "Spara";
            this.btnSparaAvsnitt.UseVisualStyleBackColor = true;
            this.btnSparaAvsnitt.Click += new System.EventHandler(this.btnSparaAvsnitt_Click);
            // 
            // btnTaBortAvsnitt
            // 
            this.btnTaBortAvsnitt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaBortAvsnitt.Location = new System.Drawing.Point(377, 322);
            this.btnTaBortAvsnitt.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaBortAvsnitt.Name = "btnTaBortAvsnitt";
            this.btnTaBortAvsnitt.Size = new System.Drawing.Size(94, 28);
            this.btnTaBortAvsnitt.TabIndex = 13;
            this.btnTaBortAvsnitt.Text = "Ta bort";
            this.btnTaBortAvsnitt.UseVisualStyleBackColor = true;
            this.btnTaBortAvsnitt.Click += new System.EventHandler(this.btnTaBortAvsnitt_Click);
            // 
            // tbxKategorier
            // 
            this.tbxKategorier.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxKategorier.Location = new System.Drawing.Point(688, 250);
            this.tbxKategorier.Margin = new System.Windows.Forms.Padding(2);
            this.tbxKategorier.Name = "tbxKategorier";
            this.tbxKategorier.Size = new System.Drawing.Size(381, 24);
            this.tbxKategorier.TabIndex = 14;
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaBortKategori.Location = new System.Drawing.Point(975, 294);
            this.btnTaBortKategori.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(94, 28);
            this.btnTaBortKategori.TabIndex = 17;
            this.btnTaBortKategori.Text = "Ta bort";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            this.btnTaBortKategori.Click += new System.EventHandler(this.btnTaBortKategori_Click);
            // 
            // btnSparaKategori
            // 
            this.btnSparaKategori.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSparaKategori.Location = new System.Drawing.Point(833, 294);
            this.btnSparaKategori.Margin = new System.Windows.Forms.Padding(2);
            this.btnSparaKategori.Name = "btnSparaKategori";
            this.btnSparaKategori.Size = new System.Drawing.Size(83, 28);
            this.btnSparaKategori.TabIndex = 16;
            this.btnSparaKategori.Text = "Spara";
            this.btnSparaKategori.UseVisualStyleBackColor = true;
            this.btnSparaKategori.Click += new System.EventHandler(this.btnSparaKategori_Click);
            // 
            // lblAvsnittBeksrivning
            // 
            this.lblAvsnittBeksrivning.AutoSize = true;
            this.lblAvsnittBeksrivning.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvsnittBeksrivning.Location = new System.Drawing.Point(686, 358);
            this.lblAvsnittBeksrivning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvsnittBeksrivning.Name = "lblAvsnittBeksrivning";
            this.lblAvsnittBeksrivning.Size = new System.Drawing.Size(62, 17);
            this.lblAvsnittBeksrivning.TabIndex = 18;
            this.lblAvsnittBeksrivning.Text = "Avsnitt";
            // 
            // tbxAvsnittBeskrivning
            // 
            this.tbxAvsnittBeskrivning.BackColor = System.Drawing.SystemColors.Control;
            this.tbxAvsnittBeskrivning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxAvsnittBeskrivning.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAvsnittBeskrivning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tbxAvsnittBeskrivning.Location = new System.Drawing.Point(682, 389);
            this.tbxAvsnittBeskrivning.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAvsnittBeskrivning.Multiline = true;
            this.tbxAvsnittBeskrivning.Name = "tbxAvsnittBeskrivning";
            this.tbxAvsnittBeskrivning.ReadOnly = true;
            this.tbxAvsnittBeskrivning.Size = new System.Drawing.Size(388, 263);
            this.tbxAvsnittBeskrivning.TabIndex = 19;
            this.tbxAvsnittBeskrivning.Text = "Exempel beskrivning utav a podcast avsnittet...";
            this.tbxAvsnittBeskrivning.TextChanged += new System.EventHandler(this.tbxAvsnittBeskrivning_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(9, 322);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(245, 24);
            this.tbName.TabIndex = 20;
            this.tbName.Text = "Podcast Titel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 300);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Namn:";
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(689, 294);
            this.btnSort.Margin = new System.Windows.Forms.Padding(2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(83, 28);
            this.btnSort.TabIndex = 22;
            this.btnSort.Text = "Sortera";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(515, 322);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 28);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 665);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbxAvsnittBeskrivning);
            this.Controls.Add(this.lblAvsnittBeksrivning);
            this.Controls.Add(this.btnTaBortKategori);
            this.Controls.Add(this.btnSparaKategori);
            this.Controls.Add(this.tbxKategorier);
            this.Controls.Add(this.btnTaBortAvsnitt);
            this.Controls.Add(this.btnSparaAvsnitt);
            this.Controls.Add(this.lblKategorier);
            this.Controls.Add(this.lbxKategorier);
            this.Controls.Add(this.lbxPodcastAvsnitt);
            this.Controls.Add(this.cbxKategori);
            this.Controls.Add(this.cbxUppdateringsfrekvens);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblUppdateringsfrekvens);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.lwPodcast);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lwPodcast;
        private System.Windows.Forms.ColumnHeader columnAvsnitt;
        private System.Windows.Forms.ColumnHeader columnNamn;
        private System.Windows.Forms.ColumnHeader columnFrekvens;
        private System.Windows.Forms.ColumnHeader columnKategori;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblUppdateringsfrekvens;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.ComboBox cbxUppdateringsfrekvens;
        private System.Windows.Forms.ComboBox cbxKategori;
        private System.Windows.Forms.ListBox lbxPodcastAvsnitt;
        private System.Windows.Forms.ListBox lbxKategorier;
        private System.Windows.Forms.Label lblKategorier;
        private System.Windows.Forms.Button btnSparaAvsnitt;
        private System.Windows.Forms.Button btnTaBortAvsnitt;
        private System.Windows.Forms.TextBox tbxKategorier;
        private System.Windows.Forms.Button btnTaBortKategori;
        private System.Windows.Forms.Button btnSparaKategori;
        private System.Windows.Forms.Label lblAvsnittBeksrivning;
        private System.Windows.Forms.TextBox tbxAvsnittBeskrivning;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader ColumnURL;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnRefresh;
    }
}

