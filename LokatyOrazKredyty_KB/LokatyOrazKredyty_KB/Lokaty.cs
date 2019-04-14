using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LokatyOrazKredyty_KB
{
    public partial class Lokaty : Form
    {
        public Lokaty()
        {
            InitializeComponent();
            //ustalenie lokalizacji i rozmiwrów formularza 
            this.Left = 20;
            this.Top = 20;
            this.Width =(int)(Screen.PrimaryScreen.Bounds.Width * 0.70F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.70F);
            this.StartPosition = FormStartPosition.Manual;
            //blokada możliwości zmiany rozmiaru formularza techniką przeciągania krawędzi
            this.SetAutoSizeMode(AutoSizeMode.GrowAndShrink);
            //blokada przycisków minimalizacji i mkasymalizacji 
            this.MaximizeBox = false; this.MinimizeBox = false;
            //dodanie pasków przewijania, gdy formularz będzie "duży"
            this.AutoScroll = false;

            //ustawienie domyslnej stopy prcentowej
            cmbStopaProcentowa.SelectedIndex = 0;
        }
        //deklaracje pomocniczych metod
       
        
        bool PobranieDanychWejsciowych(out float K, out int n, out float p, out int m)
        {
            //pomocnicze ustawienie wartości domyślnych dla parametrów wejściowych(konieczne ze względu na użycie-zastosowanie kontrolki errorProvider)
            K = 0.0F; n = 0; p = 0.0F; m = 0;
            //pobranie wysokości lokaty K
            if (string.IsNullOrEmpty(txtK.Text))
            {
                //pole edycyjne kontrolki txtK było puste
                errorProvider1.SetError(txtK, "ERROR musisz podać wysokość lokaty K");
                return false;

            }
            else
                errorProvider1.Dispose();
            //konwersja znakowo podanej wysokosci lokaty K na wartość
            if(!float.TryParse(txtK.Text, out K))
              {
                //pole edycyjne kontrolki txtK było puste
                errorProvider1.SetError(txtK, "ERROR musisz podać wysokość lokaty K");
                return false;

            }
            else
                errorProvider1.Dispose();
            if (K < 100)
            {
                //pole edycyjne kontrolki txtK było źle uzupełnione
                errorProvider1.SetError(txtK, "ERROR wysokość lokaty K musi spełniać warunek wejściowy");
                return false;

            }
            else
                errorProvider1.Dispose();

            //odczytanie częstości kapitalizacji odsetek 
            //ustawienie m dla nieustalonej czestosci kapitalizacji odsetek
            m = -1;
            //sprawdzenie ustawień kontrolek radiobutton, które zostały umieszczone w gb
            foreach (RadioButton Kontrolka in gbCzestoscKapitalizacji.Controls)
            {
                //sprawdzenie kontrolki rb 
                if (Kontrolka.Checked)
                {switch(Kontrolka.Name)
                    {
                        case "rdbRazWRoku": m = 1;
                            break;
                        case "rdbCoPolRoku": m = 2;
                            break;
                        case "rdbCoKwartal": m = 4;
                            break;
                        case "rdbCoMiesiac": m = 12;
                            break;
                    }//switch
                }//if
            }//foreach
            //sprawdzenie, czy ustalono częstosc kapitalizacji
            if (m == -1)
            {
                errorProvider1.SetError(gbCzestoscKapitalizacji, "ERROR musisz ustalić częstość kapitalizacji odsetek");
                return false;
            }
            else
                errorProvider1.Dispose();

            //pobranie rocznej stopy procentowej 
            //sprawdzenie, czy użytkownik wybrał roczną stopę procentową
            if (cmbStopaProcentowa.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbStopaProcentowa, "ERROR musisz wybrać roczną stopę procentową ");
                return false;
            }
            else
                errorProvider1.Dispose();
            //pobranie wybranej stopy procentowej
            string StopaRoczna = cmbStopaProcentowa.SelectedItem.ToString();
            //wycięcie znaku procenta
            StopaRoczna = StopaRoczna.Substring(0, StopaRoczna.Length - 1);
            //kowersja na wartosc liczbowa 
            if (!float.TryParse(StopaRoczna, out p))
            {
                errorProvider1.SetError(cmbStopaProcentowa, "ERROR wystąpił błąd w zapisie rocznej stopy procentowej");
                return false;
            }
            else
                errorProvider1.Dispose();
            //konwersja liczbowej stopy procentowej na liczbę rzeczywista 
            p = p / 100F;
            //pobranie liczby lat lokaty 
            if (string.IsNullOrEmpty(txtN.Text))
            {
                errorProvider1.SetError(txtN, "ERROR musisz podac liczbe lat lokaty n");
                return false;

            }
            else
                errorProvider1.Dispose();
            //konwersja na wartosc 
            if(!int.TryParse(txtN.Text, out n))
            {
                errorProvider1.SetError(txtN, "ERROR w zapisie liczby lat lokaty n wystąpił niedozwolony znak");
                return false;

            }
            else
                errorProvider1.Dispose();
            // n > 0
            if (n <=0 )
            {
                errorProvider1.SetError(txtN, "ERROR liczba lat lokaty n musi spełniać warunek");
                return false;

            }
            else
                errorProvider1.Dispose();

            return true; //nie było błędu
        }









        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbStopaProcentowa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdbCoKwartal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnObliczeniePrzyszlegoStanuKonta_Click(object sender, EventArgs e)
        {//deklaracje dla przechowania pobranych danych wejsciowych
            float K, p;
            int n, m;
            if (!PobranieDanychWejsciowych(out K, out n, out p, out m))
                {
                //został wykryty bład
                errorProvider1.SetError(btnObliczeniePrzyszlegoStanuKonta, "ERROR musisz podać wysokość lokaty K");
                return;

            }
            //obliczenie stanu konta
            float Knm = K * (float)Math.Pow(1 + p / m, n * m);
            //wizualizacja wyniku obliczen
            txtPrzyszlyStanKonta.Text = string.Format("{0:0.000}", Knm);
            //odsloniecie kontrolek
            lblPrzyszlyStanKonta.Visible = true;
            txtPrzyszlyStanKonta.Visible = true;
            //ustawianie stanu aktywnosci dla kontrolek z danymi wejsciowymi
            txtK.Enabled = false;
            txtN.Enabled = false;
            cmbStopaProcentowa.Enabled = false;
            gbCzestoscKapitalizacji.Enabled = false;
            btnObliczeniePrzyszlegoStanuKonta.Enabled = false;
        }

        private void txtK_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //deklaracja metody rozliczenia lokaty kapitałowej
        void TabelaryczneRozliczenieLokaty(float k, float p, int n, int m, out float [,] TRL)
        {
            //utworzenie egzemplarza tablicy TRL 
            TRL = new float[n * m + 1, 3];
            //ustawienie stanu początkowego dla rozliczenia lokaty
            float Spi = 0.0F;
            float Oi = 0.0F;
            float Ski = k;
            //wypełnienie tablicy TRL wartościami wynikającymi z rozliczenia lokaty kapitałowej 
            for (int i = 0; i < TRL.GetLength(0); i++)
            {
                TRL[i, 0] = Spi;
                TRL[i, 1] = Oi;
                TRL[i, 2] = Ski;
                //wyznaczenie wartości zmiennych spi, oi, ski dla kolejnego okresu lokaty
                Spi = Ski;
                Oi = Spi * p / n;
                Ski = Spi + Oi;
            }

        }
        private void btnTabela_Click(object sender, EventArgs e)
        {
            //deklaracje zmiennych dla przechowania pobranych danych wejściowych
            float K, p;
            int n, m;
            if (!PobranieDanychWejsciowych(out K, out n, out p, out m)) 
            //byl blad
            { errorProvider1.SetError(btnTabela, "ERROR wystapił błąd podczas pobierania danych");
                return;
            } 
                  
        else 
            { errorProvider1.Dispose();
                float[,] TRL;
                TabelaryczneRozliczenieLokaty(K, p, m, n, out TRL);
                //przepisanie danych z tablicy TRL
              
                dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //przepisanie danych z tablicy
                for (int i = 0; i < TRL.GetLength(0); i++)
                {
                    dataGridView1.Rows.Add();
                    //wypisanie danych do utowrzonego wiersza w kontrolce dgv
                    dataGridView1.Rows[i].Cells[0].Value = i;
                    dataGridView1.Rows[i].Cells[1].Value = string.Format("{0:0.000}", TRL[i, 0]);
                    dataGridView1.Rows[i].Cells[2].Value = string.Format("{0:0.000}", TRL[i, 1]);
                    dataGridView1.Rows[i].Cells[3].Value = string.Format("{0:0.000}", TRL[i, 1]);
                    //odroznienie kolorami tla wierszy parzystych
                    if (i % 2 == 0)
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                    else
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.NavajoWhite;
                    //wycentrowanie 
                    dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //odsloniecie kontrolki
                    dataGridView1.Visible = true;
                    //brak aktywnosci ../....
                    btnTabela.Enabled = false;
                
                }

            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnWykres_Click(object sender, EventArgs e)
        {
            {
                //deklaracje zmiennych dla przechowania pobranych danych wejściowych
                float K, p;
                int n, m;
                if (!PobranieDanychWejsciowych(out K, out n, out p, out m))
                //byl blad
                {
                    errorProvider1.SetError(btnWykres, "ERROR wystapił błąd podczas pobierania danych");
                    return;
                }

                else
                {
                    errorProvider1.Dispose();
                    float[,] TRL;
                    TabelaryczneRozliczenieLokaty(K, p, m, n, out TRL);
                    //odsloniecie chart
                    chWykres.Visible = true;
                    //ukrycie dgv
                    dataGridView1.Visible = false;
                    //tytuł
                    chWykres.Titles.Add("Wykres zmiany stanu konta w pełnym okresie lokaty");
                    //wyczyszczenie poprzednich danych
                    chWykres.Series.Clear();
                    //dodanie nowej serii
                    chWykres.Series.Add("Seria 0");
                    //ustalenie osi x i y
                    chWykres.ChartAreas[0].AxisX.Title = "Numery okresów" + "\nlokaty";
                    chWykres.ChartAreas[0].AxisY.Title = "Wyskość stanu konta";
                    //ustawienie widocznosci legendy wykresu
                    chWykres.Series[0].IsVisibleInLegend = true;
                    
                    //ustalenie nazwy serii danych
                    chWykres.Series[0].Name = "Wykres stanu konta Knm";
                    //ustalenie typu wykresu
                    chWykres.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;                   
                    //ustalenie koloru linii
                    chWykres.Series[0].Color = Color.LightPink;
                    //ustalenie koloru tła wykresu
                    chWykres.BackColor = Color.LightPink;
                    //2 tlo
                    chWykres.ChartAreas["ChartArea1"].BackColor = Color.MintCream;
                    //styl linii
                    chWykres.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
                    //ustalenie grubosci linii
                    chWykres.Series[0].BorderWidth = 1;
                    //przepisanie danych z tablicy 
                    for (int i =0; i <TRL.GetLength(0); i++)
                    {
                        chWykres.Series[0].Points.AddXY(i, TRL[i, 2]);

                    }
                    //ustawienie stanu braku aktywnosci dla przycisku polecen
                    btnWykres.Enabled = false;
                    btnTabela.Enabled = false;
                    //odrycie kontrolek ustawiania grubosci linii
                    lblGruboscLinii.Visible = true;
                    suGruboscLinii.Visible = true;
                    cmbGruboscLinii.Visible = true;


                }
           }
         }

        private void zamkniecieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //zamkniecie wszystkich formularzy i plikow, z których program korzystał 
        }

        private void kolorWykresuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //deklaracja i utworzenie egzemplarza paletu kolorów 
            ColorDialog PaletaKolorów = new ColorDialog();
            //ustawienie aktualnego koloru wykresu 
            PaletaKolorów.Color = chWykres.Series[0].Color;
            //wyświetlenie palety kolorow i odczytanie wyboru używtkownika 
            if (PaletaKolorów.ShowDialog() == DialogResult.OK)
                //zmiana koloru serii danych chWykres.Series[0]
                chWykres.Series[0].Color = PaletaKolorów.Color;
        }

        private void kolorTłaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //deklaracja i utworzenie egzemplarza paletu kolorów 
            ColorDialog PaletaKolorów = new ColorDialog();
            //ustawienie aktualnego koloru tła
            PaletaKolorów.Color = chWykres.BackColor;
            //wyświetlenie palety kolorow i odczytanie wyboru używtkownika 
            if (PaletaKolorów.ShowDialog() == DialogResult.OK)
                //zmiana koloru serii danych chWykres.BackColor
                chWykres.BackColor = PaletaKolorów.Color;
        }

        private void wykresLiniowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chWykres.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void wykresKolumnowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chWykres.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        private void wykresSłupkowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chWykres.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
        }

        private void wykresPunktowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chWykres.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
        }

        private void wykresPiramidowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chWykres.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
        }

        private void liniaKreskowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sprawdzenie, czy typ wykresu jest liniowy
            if (chWykres.Series[0].ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line)
                chWykres.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
        }

        private void liniaKropkowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sprawdzenie, czy typ wykresu jest liniowy
            if (chWykres.Series[0].ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line)
                chWykres.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
        }

        private void liniaKreskowokropkowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sprawdzenie, czy typ wykresu jest liniowy
            if (chWykres.Series[0].ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line)
                chWykres.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
        }

        private void liniaCiaglaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sprawdzenie, czy typ wykresu jest liniowy
            if (chWykres.Series[0].ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line)
                chWykres.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
        }

        private void suGruboscLinii_Scroll(object sender, EventArgs e)
        {
            //odczytanie ustawionej grubosci linii w kontrolce TrackBar i przypisanie jej grubosci linii serii danych
            chWykres.Series[0].BorderWidth = suGruboscLinii.Value;
            //uaktualnienie ustawienia grubosci linii w kontrolce cmb
            cmbGruboscLinii.SelectedIndex = suGruboscLinii.Value;
        }

        private void kolorTłaFormularzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //deklaracja i utworzenie egzemplarza paletu kolorów 
            ColorDialog PaletaKolorów = new ColorDialog();
            //ustawienie aktualnego koloru tła
            PaletaKolorów.Color = this.BackColor;
            //wyświetlenie palety kolorow i odczytanie wyboru używtkownika 
            if (PaletaKolorów.ShowDialog() == DialogResult.OK)
                //zmiana koloru tła formularza
                this.BackColor = PaletaKolorów.Color;
        }

        private void kolorCzcionkiKontrolekFormularzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //deklaracja i utworzenie egzemplarza paletu kolorów 
            ColorDialog PaletaKolorów = new ColorDialog();
            //ustawienie aktualnego koloru tła
            PaletaKolorów.Color = chWykres.BackColor;
            //wyświetlenie palety kolorow i odczytanie wyboru używtkownika 
            if (PaletaKolorów.ShowDialog() == DialogResult.OK)
            {   //zmiana koloru czcionki
                this.ForeColor = PaletaKolorów.Color;
                //zmiana kolorow wszystkich kontrolek umieszczonych na formularzu
                foreach (Control Kontrolka in this.Controls)
                    Kontrolka.ForeColor = PaletaKolorów.Color;

            }
        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            //odszukanie formularza pulpit startowy w OpenForms
            foreach (Form Formularz in Application.OpenForms)
            {
                //sprawdzenie, czy zmienna formularz ma referencje do formularza
                if (Formularz.Name == "PulpitStartowy")
                {
                    //ustawienie nowej lokalizacji , jeśli zachodzi taka potrzeba
                    Formularz.Location = new Point(200, 200);
                    //ukrycie aktualnie aktywnego formularza
                    this.Hide();
                    //odsloniecie formularza pulpit startowy 
                    Formularz.Show();
                    return;
                } 
            }
            //tutaj bedziemy, gdy formularz nie zostal znaleziony, a to moze oznaczac, ze zostal przypadkowo skasowany
            //utworzenie nowego egzemplarza formularza 
            PulpitStartowy EgzPulpitStartowy = new PulpitStartowy();
            EgzPulpitStartowy.Location = new Point(50, 50);
            this.Hide();
            EgzPulpitStartowy.Show();

        }
    }
}
