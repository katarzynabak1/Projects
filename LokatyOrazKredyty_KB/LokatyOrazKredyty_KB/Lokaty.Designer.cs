namespace LokatyOrazKredyty_KB
{
    partial class Lokaty
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStopaProcentowa = new System.Windows.Forms.ComboBox();
            this.gbCzestoscKapitalizacji = new System.Windows.Forms.GroupBox();
            this.rdbCoMiesiac = new System.Windows.Forms.RadioButton();
            this.rdbCoKwartal = new System.Windows.Forms.RadioButton();
            this.rdbCoPolRoku = new System.Windows.Forms.RadioButton();
            this.rdbRazWRoku = new System.Windows.Forms.RadioButton();
            this.btnObliczeniePrzyszlegoStanuKonta = new System.Windows.Forms.Button();
            this.lblPrzyszlyStanKonta = new System.Windows.Forms.Label();
            this.txtPrzyszlyStanKonta = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnTabela = new System.Windows.Forms.Button();
            this.btnWykres = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chWykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wyjścieZProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamkniecieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapisanieWPlikuTabeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koloryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorTłaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorTłaFormularzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorCzcionkiKontrolekFormularzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykresLiniowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykresKolumnowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykresSłupkowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykresPunktowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wykresPiramidowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stylLiniiWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liniaKreskowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liniaKropkowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liniaKreskowokropkowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liniaCiaglaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGruboscLinii = new System.Windows.Forms.Label();
            this.suGruboscLinii = new System.Windows.Forms.TrackBar();
            this.cmbGruboscLinii = new System.Windows.Forms.ComboBox();
            this.btnPowrot = new System.Windows.Forms.Button();
            this.gbCzestoscKapitalizacji.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chWykres)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suGruboscLinii)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(108, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rozliczenie lokat kapitałowych dla podanych danych \r\nwejściowych : K, n, p, m";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(73, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wysokość lokaty kapitałowej";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(77, 239);
            this.txtK.Name = "txtK";
            this.txtK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtK.Size = new System.Drawing.Size(289, 26);
            this.txtK.TabIndex = 2;
            this.txtK.TextChanged += new System.EventHandler(this.txtK_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(82, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Liczba lat lokaty n";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(77, 340);
            this.txtN.Name = "txtN";
            this.txtN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtN.Size = new System.Drawing.Size(289, 26);
            this.txtN.TabIndex = 4;
            this.txtN.TextChanged += new System.EventHandler(this.txtN_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(73, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Roczna stopa procentowa p";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbStopaProcentowa
            // 
            this.cmbStopaProcentowa.AutoCompleteCustomSource.AddRange(new string[] {
            "2,1%",
            "2,3%",
            "2,5%",
            "2,7%",
            "2,9%",
            "3,1%",
            "3,3%"});
            this.cmbStopaProcentowa.FormattingEnabled = true;
            this.cmbStopaProcentowa.Items.AddRange(new object[] {
            "2,1%",
            "2,3%",
            "2,5%",
            "2,7%",
            "2,9%",
            "3,1%",
            "3,3%"});
            this.cmbStopaProcentowa.Location = new System.Drawing.Point(77, 423);
            this.cmbStopaProcentowa.Name = "cmbStopaProcentowa";
            this.cmbStopaProcentowa.Size = new System.Drawing.Size(289, 28);
            this.cmbStopaProcentowa.TabIndex = 6;
            this.cmbStopaProcentowa.Text = "Wybierz roczną stopę procentową";
            this.cmbStopaProcentowa.SelectedIndexChanged += new System.EventHandler(this.cmbStopaProcentowa_SelectedIndexChanged);
            // 
            // gbCzestoscKapitalizacji
            // 
            this.gbCzestoscKapitalizacji.Controls.Add(this.rdbCoMiesiac);
            this.gbCzestoscKapitalizacji.Controls.Add(this.rdbCoKwartal);
            this.gbCzestoscKapitalizacji.Controls.Add(this.rdbCoPolRoku);
            this.gbCzestoscKapitalizacji.Controls.Add(this.rdbRazWRoku);
            this.gbCzestoscKapitalizacji.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbCzestoscKapitalizacji.Location = new System.Drawing.Point(77, 485);
            this.gbCzestoscKapitalizacji.Name = "gbCzestoscKapitalizacji";
            this.gbCzestoscKapitalizacji.Size = new System.Drawing.Size(289, 175);
            this.gbCzestoscKapitalizacji.TabIndex = 7;
            this.gbCzestoscKapitalizacji.TabStop = false;
            this.gbCzestoscKapitalizacji.Text = "Częstość kapitalizacji odsetek";
            // 
            // rdbCoMiesiac
            // 
            this.rdbCoMiesiac.AutoSize = true;
            this.rdbCoMiesiac.Location = new System.Drawing.Point(28, 121);
            this.rdbCoMiesiac.Name = "rdbCoMiesiac";
            this.rdbCoMiesiac.Size = new System.Drawing.Size(124, 26);
            this.rdbCoMiesiac.TabIndex = 3;
            this.rdbCoMiesiac.TabStop = true;
            this.rdbCoMiesiac.Text = "Co miesiąc";
            this.rdbCoMiesiac.UseVisualStyleBackColor = true;
            // 
            // rdbCoKwartal
            // 
            this.rdbCoKwartal.AutoSize = true;
            this.rdbCoKwartal.Location = new System.Drawing.Point(28, 94);
            this.rdbCoKwartal.Name = "rdbCoKwartal";
            this.rdbCoKwartal.Size = new System.Drawing.Size(123, 26);
            this.rdbCoKwartal.TabIndex = 2;
            this.rdbCoKwartal.TabStop = true;
            this.rdbCoKwartal.Text = "Co kwartał";
            this.rdbCoKwartal.UseVisualStyleBackColor = true;
            this.rdbCoKwartal.CheckedChanged += new System.EventHandler(this.rdbCoKwartal_CheckedChanged);
            // 
            // rdbCoPolRoku
            // 
            this.rdbCoPolRoku.AutoSize = true;
            this.rdbCoPolRoku.Location = new System.Drawing.Point(28, 62);
            this.rdbCoPolRoku.Name = "rdbCoPolRoku";
            this.rdbCoPolRoku.Size = new System.Drawing.Size(129, 26);
            this.rdbCoPolRoku.TabIndex = 1;
            this.rdbCoPolRoku.TabStop = true;
            this.rdbCoPolRoku.Text = "Co pół roku";
            this.rdbCoPolRoku.UseVisualStyleBackColor = true;
            // 
            // rdbRazWRoku
            // 
            this.rdbRazWRoku.AutoSize = true;
            this.rdbRazWRoku.Checked = true;
            this.rdbRazWRoku.Location = new System.Drawing.Point(28, 29);
            this.rdbRazWRoku.Name = "rdbRazWRoku";
            this.rdbRazWRoku.Size = new System.Drawing.Size(125, 26);
            this.rdbRazWRoku.TabIndex = 0;
            this.rdbRazWRoku.TabStop = true;
            this.rdbRazWRoku.Text = "Raz w roku";
            this.rdbRazWRoku.UseVisualStyleBackColor = true;
            // 
            // btnObliczeniePrzyszlegoStanuKonta
            // 
            this.btnObliczeniePrzyszlegoStanuKonta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObliczeniePrzyszlegoStanuKonta.Location = new System.Drawing.Point(1035, 190);
            this.btnObliczeniePrzyszlegoStanuKonta.Name = "btnObliczeniePrzyszlegoStanuKonta";
            this.btnObliczeniePrzyszlegoStanuKonta.Size = new System.Drawing.Size(180, 129);
            this.btnObliczeniePrzyszlegoStanuKonta.TabIndex = 8;
            this.btnObliczeniePrzyszlegoStanuKonta.Text = "Oblicz przyszły \r\nstan konta Knm\r\n";
            this.btnObliczeniePrzyszlegoStanuKonta.UseVisualStyleBackColor = true;
            this.btnObliczeniePrzyszlegoStanuKonta.Click += new System.EventHandler(this.btnObliczeniePrzyszlegoStanuKonta_Click);
            // 
            // lblPrzyszlyStanKonta
            // 
            this.lblPrzyszlyStanKonta.AutoSize = true;
            this.lblPrzyszlyStanKonta.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrzyszlyStanKonta.Location = new System.Drawing.Point(1035, 340);
            this.lblPrzyszlyStanKonta.Name = "lblPrzyszlyStanKonta";
            this.lblPrzyszlyStanKonta.Size = new System.Drawing.Size(159, 22);
            this.lblPrzyszlyStanKonta.TabIndex = 9;
            this.lblPrzyszlyStanKonta.Text = "Przyszły stan konta";
            this.lblPrzyszlyStanKonta.Visible = false;
            // 
            // txtPrzyszlyStanKonta
            // 
            this.txtPrzyszlyStanKonta.Location = new System.Drawing.Point(1035, 365);
            this.txtPrzyszlyStanKonta.Name = "txtPrzyszlyStanKonta";
            this.txtPrzyszlyStanKonta.ReadOnly = true;
            this.txtPrzyszlyStanKonta.Size = new System.Drawing.Size(170, 26);
            this.txtPrzyszlyStanKonta.TabIndex = 10;
            this.txtPrzyszlyStanKonta.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnTabela
            // 
            this.btnTabela.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTabela.Location = new System.Drawing.Point(1020, 413);
            this.btnTabela.Name = "btnTabela";
            this.btnTabela.Size = new System.Drawing.Size(195, 107);
            this.btnTabela.TabIndex = 11;
            this.btnTabela.Text = "Wizualizacja tabelaryczna\r\nzmian stanu konta\r\n";
            this.btnTabela.UseVisualStyleBackColor = true;
            this.btnTabela.Click += new System.EventHandler(this.btnTabela_Click);
            // 
            // btnWykres
            // 
            this.btnWykres.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWykres.Location = new System.Drawing.Point(1020, 536);
            this.btnWykres.Name = "btnWykres";
            this.btnWykres.Size = new System.Drawing.Size(195, 96);
            this.btnWykres.TabIndex = 12;
            this.btnWykres.Text = "Wykres zmian \r\nstanu konta\r\n";
            this.btnWykres.UseVisualStyleBackColor = true;
            this.btnWykres.Click += new System.EventHandler(this.btnWykres_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(442, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(454, 393);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numer okresu lokaty";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Stan konta na początku ";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Odsteki za dany okres";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Stan konta na koniec ";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // chWykres
            // 
            chartArea3.Name = "ChartArea1";
            this.chWykres.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chWykres.Legends.Add(legend3);
            this.chWykres.Location = new System.Drawing.Point(386, 194);
            this.chWykres.Name = "chWykres";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chWykres.Series.Add(series3);
            this.chWykres.Size = new System.Drawing.Size(586, 366);
            this.chWykres.TabIndex = 14;
            this.chWykres.Text = "Wykres";
            this.chWykres.Visible = false;
            this.chWykres.Click += new System.EventHandler(this.chart1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyjścieZProgramuToolStripMenuItem,
            this.koloryToolStripMenuItem,
            this.typWykresuToolStripMenuItem,
            this.stylLiniiWykresuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(552, 33);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wyjścieZProgramuToolStripMenuItem
            // 
            this.wyjścieZProgramuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamkniecieToolStripMenuItem,
            this.zapisanieWPlikuTabeliToolStripMenuItem});
            this.wyjścieZProgramuToolStripMenuItem.Name = "wyjścieZProgramuToolStripMenuItem";
            this.wyjścieZProgramuToolStripMenuItem.Size = new System.Drawing.Size(196, 29);
            this.wyjścieZProgramuToolStripMenuItem.Text = "Wyjście z programu   ";
            // 
            // zamkniecieToolStripMenuItem
            // 
            this.zamkniecieToolStripMenuItem.Name = "zamkniecieToolStripMenuItem";
            this.zamkniecieToolStripMenuItem.Size = new System.Drawing.Size(282, 30);
            this.zamkniecieToolStripMenuItem.Text = "zamkniecie  \\ ";
            this.zamkniecieToolStripMenuItem.Click += new System.EventHandler(this.zamkniecieToolStripMenuItem_Click);
            // 
            // zapisanieWPlikuTabeliToolStripMenuItem
            // 
            this.zapisanieWPlikuTabeliToolStripMenuItem.Name = "zapisanieWPlikuTabeliToolStripMenuItem";
            this.zapisanieWPlikuTabeliToolStripMenuItem.Size = new System.Drawing.Size(282, 30);
            this.zapisanieWPlikuTabeliToolStripMenuItem.Text = "zapisanie w pliku tabeli ";
            // 
            // koloryToolStripMenuItem
            // 
            this.koloryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolorWykresuToolStripMenuItem,
            this.kolorTłaToolStripMenuItem,
            this.kolorTłaFormularzaToolStripMenuItem,
            this.kolorCzcionkiKontrolekFormularzaToolStripMenuItem});
            this.koloryToolStripMenuItem.Name = "koloryToolStripMenuItem";
            this.koloryToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.koloryToolStripMenuItem.Text = "Kolory";
            // 
            // kolorWykresuToolStripMenuItem
            // 
            this.kolorWykresuToolStripMenuItem.Name = "kolorWykresuToolStripMenuItem";
            this.kolorWykresuToolStripMenuItem.Size = new System.Drawing.Size(375, 30);
            this.kolorWykresuToolStripMenuItem.Text = "Kolor wykresu";
            this.kolorWykresuToolStripMenuItem.Click += new System.EventHandler(this.kolorWykresuToolStripMenuItem_Click);
            // 
            // kolorTłaToolStripMenuItem
            // 
            this.kolorTłaToolStripMenuItem.Name = "kolorTłaToolStripMenuItem";
            this.kolorTłaToolStripMenuItem.Size = new System.Drawing.Size(375, 30);
            this.kolorTłaToolStripMenuItem.Text = "Kolor tła";
            this.kolorTłaToolStripMenuItem.Click += new System.EventHandler(this.kolorTłaToolStripMenuItem_Click);
            // 
            // kolorTłaFormularzaToolStripMenuItem
            // 
            this.kolorTłaFormularzaToolStripMenuItem.Name = "kolorTłaFormularzaToolStripMenuItem";
            this.kolorTłaFormularzaToolStripMenuItem.Size = new System.Drawing.Size(375, 30);
            this.kolorTłaFormularzaToolStripMenuItem.Text = "Kolor tła formularza";
            this.kolorTłaFormularzaToolStripMenuItem.Click += new System.EventHandler(this.kolorTłaFormularzaToolStripMenuItem_Click);
            // 
            // kolorCzcionkiKontrolekFormularzaToolStripMenuItem
            // 
            this.kolorCzcionkiKontrolekFormularzaToolStripMenuItem.Name = "kolorCzcionkiKontrolekFormularzaToolStripMenuItem";
            this.kolorCzcionkiKontrolekFormularzaToolStripMenuItem.Size = new System.Drawing.Size(375, 30);
            this.kolorCzcionkiKontrolekFormularzaToolStripMenuItem.Text = "Kolor czcionki kontrolek formularza";
            this.kolorCzcionkiKontrolekFormularzaToolStripMenuItem.Click += new System.EventHandler(this.kolorCzcionkiKontrolekFormularzaToolStripMenuItem_Click);
            // 
            // typWykresuToolStripMenuItem
            // 
            this.typWykresuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wykresLiniowyToolStripMenuItem,
            this.wykresKolumnowyToolStripMenuItem,
            this.wykresSłupkowyToolStripMenuItem,
            this.wykresPunktowyToolStripMenuItem,
            this.wykresPiramidowyToolStripMenuItem});
            this.typWykresuToolStripMenuItem.Name = "typWykresuToolStripMenuItem";
            this.typWykresuToolStripMenuItem.Size = new System.Drawing.Size(121, 29);
            this.typWykresuToolStripMenuItem.Text = "Typ wykresu";
            // 
            // wykresLiniowyToolStripMenuItem
            // 
            this.wykresLiniowyToolStripMenuItem.Name = "wykresLiniowyToolStripMenuItem";
            this.wykresLiniowyToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.wykresLiniowyToolStripMenuItem.Text = "Wykres liniowy";
            this.wykresLiniowyToolStripMenuItem.Click += new System.EventHandler(this.wykresLiniowyToolStripMenuItem_Click);
            // 
            // wykresKolumnowyToolStripMenuItem
            // 
            this.wykresKolumnowyToolStripMenuItem.Name = "wykresKolumnowyToolStripMenuItem";
            this.wykresKolumnowyToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.wykresKolumnowyToolStripMenuItem.Text = "Wykres kolumnowy";
            this.wykresKolumnowyToolStripMenuItem.Click += new System.EventHandler(this.wykresKolumnowyToolStripMenuItem_Click);
            // 
            // wykresSłupkowyToolStripMenuItem
            // 
            this.wykresSłupkowyToolStripMenuItem.Name = "wykresSłupkowyToolStripMenuItem";
            this.wykresSłupkowyToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.wykresSłupkowyToolStripMenuItem.Text = "Wykres słupkowy ";
            this.wykresSłupkowyToolStripMenuItem.Click += new System.EventHandler(this.wykresSłupkowyToolStripMenuItem_Click);
            // 
            // wykresPunktowyToolStripMenuItem
            // 
            this.wykresPunktowyToolStripMenuItem.Name = "wykresPunktowyToolStripMenuItem";
            this.wykresPunktowyToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.wykresPunktowyToolStripMenuItem.Text = "Wykres punktowy";
            this.wykresPunktowyToolStripMenuItem.Click += new System.EventHandler(this.wykresPunktowyToolStripMenuItem_Click);
            // 
            // wykresPiramidowyToolStripMenuItem
            // 
            this.wykresPiramidowyToolStripMenuItem.Name = "wykresPiramidowyToolStripMenuItem";
            this.wykresPiramidowyToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.wykresPiramidowyToolStripMenuItem.Text = "Wykres piramidowy";
            this.wykresPiramidowyToolStripMenuItem.Click += new System.EventHandler(this.wykresPiramidowyToolStripMenuItem_Click);
            // 
            // stylLiniiWykresuToolStripMenuItem
            // 
            this.stylLiniiWykresuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liniaKreskowaToolStripMenuItem,
            this.liniaKropkowaToolStripMenuItem,
            this.liniaKreskowokropkowaToolStripMenuItem,
            this.liniaCiaglaToolStripMenuItem});
            this.stylLiniiWykresuToolStripMenuItem.Name = "stylLiniiWykresuToolStripMenuItem";
            this.stylLiniiWykresuToolStripMenuItem.Size = new System.Drawing.Size(152, 29);
            this.stylLiniiWykresuToolStripMenuItem.Text = "Styl linii wykresu";
            // 
            // liniaKreskowaToolStripMenuItem
            // 
            this.liniaKreskowaToolStripMenuItem.Name = "liniaKreskowaToolStripMenuItem";
            this.liniaKreskowaToolStripMenuItem.Size = new System.Drawing.Size(298, 30);
            this.liniaKreskowaToolStripMenuItem.Text = "Linia kreskowa";
            this.liniaKreskowaToolStripMenuItem.Click += new System.EventHandler(this.liniaKreskowaToolStripMenuItem_Click);
            // 
            // liniaKropkowaToolStripMenuItem
            // 
            this.liniaKropkowaToolStripMenuItem.Name = "liniaKropkowaToolStripMenuItem";
            this.liniaKropkowaToolStripMenuItem.Size = new System.Drawing.Size(298, 30);
            this.liniaKropkowaToolStripMenuItem.Text = "Linia kropkowa";
            this.liniaKropkowaToolStripMenuItem.Click += new System.EventHandler(this.liniaKropkowaToolStripMenuItem_Click);
            // 
            // liniaKreskowokropkowaToolStripMenuItem
            // 
            this.liniaKreskowokropkowaToolStripMenuItem.Name = "liniaKreskowokropkowaToolStripMenuItem";
            this.liniaKreskowokropkowaToolStripMenuItem.Size = new System.Drawing.Size(298, 30);
            this.liniaKreskowokropkowaToolStripMenuItem.Text = "Linia kreskowo-kropkowa";
            this.liniaKreskowokropkowaToolStripMenuItem.Click += new System.EventHandler(this.liniaKreskowokropkowaToolStripMenuItem_Click);
            // 
            // liniaCiaglaToolStripMenuItem
            // 
            this.liniaCiaglaToolStripMenuItem.Name = "liniaCiaglaToolStripMenuItem";
            this.liniaCiaglaToolStripMenuItem.Size = new System.Drawing.Size(298, 30);
            this.liniaCiaglaToolStripMenuItem.Text = "Linia ciagla";
            this.liniaCiaglaToolStripMenuItem.Click += new System.EventHandler(this.liniaCiaglaToolStripMenuItem_Click);
            // 
            // lblGruboscLinii
            // 
            this.lblGruboscLinii.AutoSize = true;
            this.lblGruboscLinii.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGruboscLinii.Location = new System.Drawing.Point(871, 53);
            this.lblGruboscLinii.Name = "lblGruboscLinii";
            this.lblGruboscLinii.Size = new System.Drawing.Size(195, 27);
            this.lblGruboscLinii.TabIndex = 16;
            this.lblGruboscLinii.Text = "Ustaw grubość linii";
            this.lblGruboscLinii.Visible = false;
            // 
            // suGruboscLinii
            // 
            this.suGruboscLinii.Location = new System.Drawing.Point(871, 83);
            this.suGruboscLinii.Maximum = 15;
            this.suGruboscLinii.Name = "suGruboscLinii";
            this.suGruboscLinii.Size = new System.Drawing.Size(190, 69);
            this.suGruboscLinii.TabIndex = 17;
            this.suGruboscLinii.Value = 1;
            this.suGruboscLinii.Visible = false;
            this.suGruboscLinii.Scroll += new System.EventHandler(this.suGruboscLinii_Scroll);
            // 
            // cmbGruboscLinii
            // 
            this.cmbGruboscLinii.FormattingEnabled = true;
            this.cmbGruboscLinii.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmbGruboscLinii.Location = new System.Drawing.Point(1111, 83);
            this.cmbGruboscLinii.Name = "cmbGruboscLinii";
            this.cmbGruboscLinii.Size = new System.Drawing.Size(121, 28);
            this.cmbGruboscLinii.TabIndex = 18;
            this.cmbGruboscLinii.Text = "Wybierz grubosc linii";
            this.cmbGruboscLinii.Visible = false;
            // 
            // btnPowrot
            // 
            this.btnPowrot.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPowrot.Location = new System.Drawing.Point(511, 581);
            this.btnPowrot.Name = "btnPowrot";
            this.btnPowrot.Size = new System.Drawing.Size(236, 66);
            this.btnPowrot.TabIndex = 19;
            this.btnPowrot.Text = "Powrót do \r\npulpitu startowego";
            this.btnPowrot.UseVisualStyleBackColor = true;
            this.btnPowrot.Click += new System.EventHandler(this.btnPowrot_Click);
            // 
            // Lokaty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 678);
            this.Controls.Add(this.btnPowrot);
            this.Controls.Add(this.cmbGruboscLinii);
            this.Controls.Add(this.suGruboscLinii);
            this.Controls.Add(this.lblGruboscLinii);
            this.Controls.Add(this.chWykres);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnWykres);
            this.Controls.Add(this.btnTabela);
            this.Controls.Add(this.txtPrzyszlyStanKonta);
            this.Controls.Add(this.lblPrzyszlyStanKonta);
            this.Controls.Add(this.btnObliczeniePrzyszlegoStanuKonta);
            this.Controls.Add(this.gbCzestoscKapitalizacji);
            this.Controls.Add(this.cmbStopaProcentowa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Lokaty";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Rozliczenie lokat kapitałowych";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCzestoscKapitalizacji.ResumeLayout(false);
            this.gbCzestoscKapitalizacji.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chWykres)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suGruboscLinii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbStopaProcentowa;
        private System.Windows.Forms.GroupBox gbCzestoscKapitalizacji;
        private System.Windows.Forms.RadioButton rdbCoKwartal;
        private System.Windows.Forms.RadioButton rdbCoPolRoku;
        private System.Windows.Forms.RadioButton rdbRazWRoku;
        private System.Windows.Forms.RadioButton rdbCoMiesiac;
        private System.Windows.Forms.Button btnObliczeniePrzyszlegoStanuKonta;
        private System.Windows.Forms.Label lblPrzyszlyStanKonta;
        private System.Windows.Forms.TextBox txtPrzyszlyStanKonta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnTabela;
        private System.Windows.Forms.Button btnWykres;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chWykres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wyjścieZProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamkniecieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapisanieWPlikuTabeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koloryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorTłaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorTłaFormularzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorCzcionkiKontrolekFormularzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wykresLiniowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wykresKolumnowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wykresSłupkowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wykresPunktowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wykresPiramidowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stylLiniiWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liniaKreskowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liniaKropkowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liniaKreskowokropkowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liniaCiaglaToolStripMenuItem;
        private System.Windows.Forms.Label lblGruboscLinii;
        private System.Windows.Forms.TrackBar suGruboscLinii;
        private System.Windows.Forms.ComboBox cmbGruboscLinii;
        private System.Windows.Forms.Button btnPowrot;
    }
}

