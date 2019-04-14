namespace Projekt1._1
{
    partial class Projekt1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kb_timer = new System.Windows.Forms.Timer(this.components);
            this.kb_lblZmianaAtrybutów = new System.Windows.Forms.Label();
            this.kb_btnZmienKolorSzeregu = new System.Windows.Forms.Button();
            this.kb_btnZmienKolorKulki = new System.Windows.Forms.Button();
            this.kb_lblZmienGrubscLinii = new System.Windows.Forms.Label();
            this.kb_lblZmienPromienKulki = new System.Windows.Forms.Label();
            this.kb_lblPredkoscKulki = new System.Windows.Forms.Label();
            this.kb_trbGruboscLinii = new System.Windows.Forms.TrackBar();
            this.kb_trbPredkoscKulki = new System.Windows.Forms.TrackBar();
            this.kb_trbPromienKulki = new System.Windows.Forms.TrackBar();
            this.kb_btnKolorUkladu = new System.Windows.Forms.Button();
            this.kb_btnKolorFormularza = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zmieńStylLiniiSzereguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciaglaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kropkowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kropkowokreskowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńStylLiniiWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreskowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kropkowaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kreskowokropkowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmienPromienKulkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.kb_btnLosujKolor = new System.Windows.Forms.Button();
            this.kb_btnZatrzymajKulke = new System.Windows.Forms.Button();
            this.kb_btnWznowRuchKulki = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kb_trbGruboscLinii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kb_trbPredkoscKulki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kb_trbPromienKulki)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kb_timer
            // 
            this.kb_timer.Tick += new System.EventHandler(this.kb_timer_Tick);
            // 
            // kb_lblZmianaAtrybutów
            // 
            this.kb_lblZmianaAtrybutów.AutoSize = true;
            this.kb_lblZmianaAtrybutów.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kb_lblZmianaAtrybutów.Location = new System.Drawing.Point(56, 19);
            this.kb_lblZmianaAtrybutów.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kb_lblZmianaAtrybutów.Name = "kb_lblZmianaAtrybutów";
            this.kb_lblZmianaAtrybutów.Size = new System.Drawing.Size(409, 28);
            this.kb_lblZmianaAtrybutów.TabIndex = 0;
            this.kb_lblZmianaAtrybutów.Text = "Zmiana atrybutów elementów programu";
            // 
            // kb_btnZmienKolorSzeregu
            // 
            this.kb_btnZmienKolorSzeregu.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kb_btnZmienKolorSzeregu.Location = new System.Drawing.Point(268, 420);
            this.kb_btnZmienKolorSzeregu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kb_btnZmienKolorSzeregu.Name = "kb_btnZmienKolorSzeregu";
            this.kb_btnZmienKolorSzeregu.Size = new System.Drawing.Size(158, 136);
            this.kb_btnZmienKolorSzeregu.TabIndex = 1;
            this.kb_btnZmienKolorSzeregu.Text = "Zmień kolor \r\nlinii szeregu";
            this.kb_btnZmienKolorSzeregu.UseVisualStyleBackColor = true;
            this.kb_btnZmienKolorSzeregu.Click += new System.EventHandler(this.kb_btnZmienKolorSzeregu_Click);
            // 
            // kb_btnZmienKolorKulki
            // 
            this.kb_btnZmienKolorKulki.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kb_btnZmienKolorKulki.Location = new System.Drawing.Point(456, 420);
            this.kb_btnZmienKolorKulki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kb_btnZmienKolorKulki.Name = "kb_btnZmienKolorKulki";
            this.kb_btnZmienKolorKulki.Size = new System.Drawing.Size(158, 136);
            this.kb_btnZmienKolorKulki.TabIndex = 2;
            this.kb_btnZmienKolorKulki.Text = "Zmień kolor\r\nkulki";
            this.kb_btnZmienKolorKulki.UseVisualStyleBackColor = true;
            this.kb_btnZmienKolorKulki.Click += new System.EventHandler(this.kb_btnZmienKolorKulki_Click);
            // 
            // kb_lblZmienGrubscLinii
            // 
            this.kb_lblZmienGrubscLinii.AutoSize = true;
            this.kb_lblZmienGrubscLinii.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kb_lblZmienGrubscLinii.Location = new System.Drawing.Point(250, 64);
            this.kb_lblZmienGrubscLinii.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kb_lblZmienGrubscLinii.Name = "kb_lblZmienGrubscLinii";
            this.kb_lblZmienGrubscLinii.Size = new System.Drawing.Size(228, 22);
            this.kb_lblZmienGrubscLinii.TabIndex = 3;
            this.kb_lblZmienGrubscLinii.Text = "Zmień grubość linii szeregu";
            // 
            // kb_lblZmienPromienKulki
            // 
            this.kb_lblZmienPromienKulki.AutoSize = true;
            this.kb_lblZmienPromienKulki.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kb_lblZmienPromienKulki.Location = new System.Drawing.Point(526, 64);
            this.kb_lblZmienPromienKulki.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kb_lblZmienPromienKulki.Name = "kb_lblZmienPromienKulki";
            this.kb_lblZmienPromienKulki.Size = new System.Drawing.Size(173, 22);
            this.kb_lblZmienPromienKulki.TabIndex = 4;
            this.kb_lblZmienPromienKulki.Text = "Zmień promień kulki";
            // 
            // kb_lblPredkoscKulki
            // 
            this.kb_lblPredkoscKulki.AutoSize = true;
            this.kb_lblPredkoscKulki.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kb_lblPredkoscKulki.Location = new System.Drawing.Point(766, 64);
            this.kb_lblPredkoscKulki.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kb_lblPredkoscKulki.Name = "kb_lblPredkoscKulki";
            this.kb_lblPredkoscKulki.Size = new System.Drawing.Size(180, 22);
            this.kb_lblPredkoscKulki.TabIndex = 5;
            this.kb_lblPredkoscKulki.Text = "Zmień prędkość kulki";
            // 
            // kb_trbGruboscLinii
            // 
            this.kb_trbGruboscLinii.Location = new System.Drawing.Point(254, 101);
            this.kb_trbGruboscLinii.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kb_trbGruboscLinii.Name = "kb_trbGruboscLinii";
            this.kb_trbGruboscLinii.Size = new System.Drawing.Size(216, 69);
            this.kb_trbGruboscLinii.TabIndex = 6;
            this.kb_trbGruboscLinii.Scroll += new System.EventHandler(this.kb_trbGruboscLinii_Scroll);
            // 
            // kb_trbPredkoscKulki
            // 
            this.kb_trbPredkoscKulki.Location = new System.Drawing.Point(770, 101);
            this.kb_trbPredkoscKulki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kb_trbPredkoscKulki.Maximum = 200;
            this.kb_trbPredkoscKulki.Minimum = 50;
            this.kb_trbPredkoscKulki.Name = "kb_trbPredkoscKulki";
            this.kb_trbPredkoscKulki.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kb_trbPredkoscKulki.Size = new System.Drawing.Size(172, 69);
            this.kb_trbPredkoscKulki.SmallChange = 10;
            this.kb_trbPredkoscKulki.TabIndex = 2;
            this.kb_trbPredkoscKulki.Value = 50;
            this.kb_trbPredkoscKulki.Scroll += new System.EventHandler(this.kb_trbPredkoscKulki_Scroll);
            // 
            // kb_trbPromienKulki
            // 
            this.kb_trbPromienKulki.Location = new System.Drawing.Point(530, 101);
            this.kb_trbPromienKulki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kb_trbPromienKulki.Maximum = 15;
            this.kb_trbPromienKulki.Minimum = 9;
            this.kb_trbPromienKulki.Name = "kb_trbPromienKulki";
            this.kb_trbPromienKulki.Size = new System.Drawing.Size(165, 69);
            this.kb_trbPromienKulki.TabIndex = 8;
            this.kb_trbPromienKulki.Value = 9;
            this.kb_trbPromienKulki.Scroll += new System.EventHandler(this.kb_trbPromienKulki_Scroll);
            // 
            // kb_btnKolorUkladu
            // 
            this.kb_btnKolorUkladu.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kb_btnKolorUkladu.Location = new System.Drawing.Point(65, 456);
            this.kb_btnKolorUkladu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kb_btnKolorUkladu.Name = "kb_btnKolorUkladu";
            this.kb_btnKolorUkladu.Size = new System.Drawing.Size(158, 136);
            this.kb_btnKolorUkladu.TabIndex = 9;
            this.kb_btnKolorUkladu.Text = "Zmień kolor \r\nlinii układu współrzędnych";
            this.kb_btnKolorUkladu.UseVisualStyleBackColor = true;
            this.kb_btnKolorUkladu.Click += new System.EventHandler(this.kb_btnKolorUkladu_Click);
            // 
            // kb_btnKolorFormularza
            // 
            this.kb_btnKolorFormularza.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kb_btnKolorFormularza.Location = new System.Drawing.Point(663, 456);
            this.kb_btnKolorFormularza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kb_btnKolorFormularza.Name = "kb_btnKolorFormularza";
            this.kb_btnKolorFormularza.Size = new System.Drawing.Size(158, 136);
            this.kb_btnKolorFormularza.TabIndex = 10;
            this.kb_btnKolorFormularza.Text = "Zmień kolor \r\nformularza";
            this.kb_btnKolorFormularza.UseVisualStyleBackColor = true;
            this.kb_btnKolorFormularza.Click += new System.EventHandler(this.kb_btnKolorFormularza_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zmieńStylLiniiSzereguToolStripMenuItem,
            this.zmieńStylLiniiWykresuToolStripMenuItem,
            this.zmienPromienKulkiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1165, 31);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zmieńStylLiniiSzereguToolStripMenuItem
            // 
            this.zmieńStylLiniiSzereguToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ciaglaToolStripMenuItem,
            this.kropkowaToolStripMenuItem,
            this.kropkowokreskowaToolStripMenuItem});
            this.zmieńStylLiniiSzereguToolStripMenuItem.Name = "zmieńStylLiniiSzereguToolStripMenuItem";
            this.zmieńStylLiniiSzereguToolStripMenuItem.Size = new System.Drawing.Size(202, 29);
            this.zmieńStylLiniiSzereguToolStripMenuItem.Text = "Zmień styl linii szeregu";
            // 
            // ciaglaToolStripMenuItem
            // 
            this.ciaglaToolStripMenuItem.Name = "ciaglaToolStripMenuItem";
            this.ciaglaToolStripMenuItem.Size = new System.Drawing.Size(259, 30);
            this.ciaglaToolStripMenuItem.Text = "Kreskowa";
            this.ciaglaToolStripMenuItem.Click += new System.EventHandler(this.ciaglaToolStripMenuItem_Click);
            // 
            // kropkowaToolStripMenuItem
            // 
            this.kropkowaToolStripMenuItem.Name = "kropkowaToolStripMenuItem";
            this.kropkowaToolStripMenuItem.Size = new System.Drawing.Size(259, 30);
            this.kropkowaToolStripMenuItem.Text = "Kropkowa";
            this.kropkowaToolStripMenuItem.Click += new System.EventHandler(this.kropkowaToolStripMenuItem_Click);
            // 
            // kropkowokreskowaToolStripMenuItem
            // 
            this.kropkowokreskowaToolStripMenuItem.Name = "kropkowokreskowaToolStripMenuItem";
            this.kropkowokreskowaToolStripMenuItem.Size = new System.Drawing.Size(259, 30);
            this.kropkowokreskowaToolStripMenuItem.Text = "Kropkowo-kreskowa";
            this.kropkowokreskowaToolStripMenuItem.Click += new System.EventHandler(this.kropkowokreskowaToolStripMenuItem_Click);
            // 
            // zmieńStylLiniiWykresuToolStripMenuItem
            // 
            this.zmieńStylLiniiWykresuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreskowaToolStripMenuItem,
            this.kropkowaToolStripMenuItem1,
            this.kreskowokropkowaToolStripMenuItem});
            this.zmieńStylLiniiWykresuToolStripMenuItem.Name = "zmieńStylLiniiWykresuToolStripMenuItem";
            this.zmieńStylLiniiWykresuToolStripMenuItem.Size = new System.Drawing.Size(205, 29);
            this.zmieńStylLiniiWykresuToolStripMenuItem.Text = "Zmień styl linii wykresu";
            // 
            // kreskowaToolStripMenuItem
            // 
            this.kreskowaToolStripMenuItem.Name = "kreskowaToolStripMenuItem";
            this.kreskowaToolStripMenuItem.Size = new System.Drawing.Size(259, 30);
            this.kreskowaToolStripMenuItem.Text = "Kreskowa";
            this.kreskowaToolStripMenuItem.Click += new System.EventHandler(this.kreskowaToolStripMenuItem_Click);
            // 
            // kropkowaToolStripMenuItem1
            // 
            this.kropkowaToolStripMenuItem1.Name = "kropkowaToolStripMenuItem1";
            this.kropkowaToolStripMenuItem1.Size = new System.Drawing.Size(259, 30);
            this.kropkowaToolStripMenuItem1.Text = "Kropkowa";
            this.kropkowaToolStripMenuItem1.Click += new System.EventHandler(this.kropkowaToolStripMenuItem1_Click);
            // 
            // kreskowokropkowaToolStripMenuItem
            // 
            this.kreskowokropkowaToolStripMenuItem.Name = "kreskowokropkowaToolStripMenuItem";
            this.kreskowokropkowaToolStripMenuItem.Size = new System.Drawing.Size(259, 30);
            this.kreskowokropkowaToolStripMenuItem.Text = "Kreskowo-kropkowa";
            this.kreskowokropkowaToolStripMenuItem.Click += new System.EventHandler(this.kreskowokropkowaToolStripMenuItem_Click);
            // 
            // zmienPromienKulkiToolStripMenuItem
            // 
            this.zmienPromienKulkiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.zmienPromienKulkiToolStripMenuItem.Name = "zmienPromienKulkiToolStripMenuItem";
            this.zmienPromienKulkiToolStripMenuItem.Size = new System.Drawing.Size(186, 29);
            this.zmienPromienKulkiToolStripMenuItem.Text = "Zmien promien kulki";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(116, 30);
            this.toolStripMenuItem2.Text = "10";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(116, 30);
            this.toolStripMenuItem3.Text = "11";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(116, 30);
            this.toolStripMenuItem4.Text = "12";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(116, 30);
            this.toolStripMenuItem5.Text = "13";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(116, 30);
            this.toolStripMenuItem6.Text = "14";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(116, 30);
            this.toolStripMenuItem7.Text = "15";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // kb_btnLosujKolor
            // 
            this.kb_btnLosujKolor.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kb_btnLosujKolor.Location = new System.Drawing.Point(861, 456);
            this.kb_btnLosujKolor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kb_btnLosujKolor.Name = "kb_btnLosujKolor";
            this.kb_btnLosujKolor.Size = new System.Drawing.Size(158, 136);
            this.kb_btnLosujKolor.TabIndex = 12;
            this.kb_btnLosujKolor.Text = "Losuj kolor \r\nwykresu";
            this.kb_btnLosujKolor.UseVisualStyleBackColor = true;
            this.kb_btnLosujKolor.Click += new System.EventHandler(this.kb_btnLosujKolor_Click);
            // 
            // kb_btnZatrzymajKulke
            // 
            this.kb_btnZatrzymajKulke.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kb_btnZatrzymajKulke.Location = new System.Drawing.Point(268, 579);
            this.kb_btnZatrzymajKulke.Name = "kb_btnZatrzymajKulke";
            this.kb_btnZatrzymajKulke.Size = new System.Drawing.Size(172, 61);
            this.kb_btnZatrzymajKulke.TabIndex = 13;
            this.kb_btnZatrzymajKulke.Text = "Zatrzymaj kulkę";
            this.kb_btnZatrzymajKulke.UseVisualStyleBackColor = true;
            this.kb_btnZatrzymajKulke.Click += new System.EventHandler(this.kb_btnZatrzymajKulke_Click);
            // 
            // kb_btnWznowRuchKulki
            // 
            this.kb_btnWznowRuchKulki.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kb_btnWznowRuchKulki.Location = new System.Drawing.Point(456, 579);
            this.kb_btnWznowRuchKulki.Name = "kb_btnWznowRuchKulki";
            this.kb_btnWznowRuchKulki.Size = new System.Drawing.Size(202, 61);
            this.kb_btnWznowRuchKulki.TabIndex = 14;
            this.kb_btnWznowRuchKulki.Text = "Wznów ruch kulki";
            this.kb_btnWznowRuchKulki.UseVisualStyleBackColor = true;
            this.kb_btnWznowRuchKulki.Click += new System.EventHandler(this.kb_btnWznowRuchKulki_Click);
            // 
            // Projekt1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 673);
            this.Controls.Add(this.kb_btnWznowRuchKulki);
            this.Controls.Add(this.kb_btnZatrzymajKulke);
            this.Controls.Add(this.kb_btnLosujKolor);
            this.Controls.Add(this.kb_btnKolorFormularza);
            this.Controls.Add(this.kb_btnKolorUkladu);
            this.Controls.Add(this.kb_trbPredkoscKulki);
            this.Controls.Add(this.kb_trbPromienKulki);
            this.Controls.Add(this.kb_trbGruboscLinii);
            this.Controls.Add(this.kb_lblPredkoscKulki);
            this.Controls.Add(this.kb_lblZmienPromienKulki);
            this.Controls.Add(this.kb_lblZmienGrubscLinii);
            this.Controls.Add(this.kb_btnZmienKolorKulki);
            this.Controls.Add(this.kb_btnZmienKolorSzeregu);
            this.Controls.Add(this.kb_lblZmianaAtrybutów);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Projekt1";
            this.Text = "Animacja kulki po torze szeregu ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Projekt1_FormClosing_1);
            this.Load += new System.EventHandler(this.Projekt1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Projekt1_Paint_1);
            ((System.ComponentModel.ISupportInitialize)(this.kb_trbGruboscLinii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kb_trbPredkoscKulki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kb_trbPromienKulki)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label kb_lblZmianaAtrybutów;
        private System.Windows.Forms.Button kb_btnZmienKolorSzeregu;
        private System.Windows.Forms.Button kb_btnZmienKolorKulki;
        private System.Windows.Forms.Label kb_lblZmienGrubscLinii;
        private System.Windows.Forms.Label kb_lblZmienPromienKulki;
        private System.Windows.Forms.Label kb_lblPredkoscKulki;
        private System.Windows.Forms.TrackBar kb_trbGruboscLinii;
        private System.Windows.Forms.TrackBar kb_trbPredkoscKulki;
        private System.Windows.Forms.TrackBar kb_trbPromienKulki;
        private System.Windows.Forms.Timer kb_timer;
        private System.Windows.Forms.Button kb_btnKolorUkladu;
        private System.Windows.Forms.Button kb_btnKolorFormularza;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zmieńStylLiniiSzereguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciaglaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kropkowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kropkowokreskowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńStylLiniiWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreskowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kropkowaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kreskowokropkowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmienPromienKulkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.Button kb_btnLosujKolor;
        private System.Windows.Forms.Button kb_btnZatrzymajKulke;
        private System.Windows.Forms.Button kb_btnWznowRuchKulki;
    }
}

