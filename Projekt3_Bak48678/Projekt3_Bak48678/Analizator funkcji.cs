using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projekt3_Bak48678
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //ustalenie lokalizacji formularza
            this.Top = 40;
            this.Left = 70;
            //ustawienie koloru formularza 
            this.BackColor = Color.LightGray;
            //ustawienie parametrów wymiarów okna formularzowego
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.65F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.75F);
            this.SetAutoSizeMode(AutoSizeMode.GrowAndShrink);
            //zablokowanie możliwości zmiany parametrów okna formularzowego
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //ustawienie możliwości przewijania paskiem, jeśli zajdzie taka potrzeba
            this.AutoScroll = true;

        }
        //pobranie danych wejściowych-deklaracja metody
        bool kbPobranieDanychWejsciowych1(out float kbx, out float kbeps)
        {
            //ustalenie stanu początkowego wczytywanych danych
            kbx = 0.0F;
            kbeps = 0.0F;
            //sprawdzenie, czy użytkownik wpisał coś do kontrolki 
            if (string.IsNullOrEmpty(kbtxtX.Text))
            {//zapalenie kotrolki errorProvider jeśli pole było puste
                errorProvider1.SetError(kbtxtX, "ERROR Pole musi być wypełnione");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //konwersja na wartość wpisanej wartosci x
            if (!float.TryParse(kbtxtX.Text, out kbx))
            {
                //zapalenie kotrolki errorProvider jeśli wystąpił błąd
                errorProvider1.SetError(kbtxtX, "ERROR! Wystąpił niedozwolony znak w zapisie x");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //sprawdzenie warunku wejściowego dla x w ramach przedziałów zbieżności
            if (kbx <= 1 || kbx >= 2)
            {
                //zapalenie kotrolki errorProvider jeśli wystąpił błąd
                errorProvider1.SetError(kbtxtX, "ERROR! x musi należeć do przedziału zbieżności szeregu");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //sprawdzenie, czy użytkownik wpisał coś do kontrolki eps
            if (string.IsNullOrEmpty(kbtxtEps.Text))
            {//zapalenie kotrolki errorProvider jeśli pole było puste
                errorProvider1.SetError(kbtxtEps, "ERROR Pole musi być wypełnione");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //konwersja na wartość wpisanej wartosci eps
            if (!float.TryParse(kbtxtEps.Text, out kbeps))
            {
                //zapalenie kotrolki errorProvider jeśli wystąpił błąd
                errorProvider1.SetError(kbtxtEps, "ERROR! Wystąpił niedozwolony znak w zapisie Eps");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            if (kbeps <= 0 || kbeps >= 1)
            {
                //zapalenie kotrolki errorProvider jeśli wystąpił błąd
                errorProvider1.SetError(kbtxtEps, "ERROR! Musisz podac poprawna wartosc Eps");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            return true;
        }
        bool kbPobranieDanychWejsciowych2(out float kbXd, out float kbXg, out float kbH)
        {
            kbH = 0.0F;
            kbXg = 0.0F;
            kbXd = 0.0F;
            //sprawdzenie, czy użytkownik wpisał coś do kontrolki 
            if (string.IsNullOrEmpty(kbtxtXd.Text))
            {//zapalenie kotrolki errorProvider jeśli pole było puste
                errorProvider1.SetError(kbtxtXd, "ERROR Pole musi być wypełnione");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            if (!float.TryParse(kbtxtXd.Text, out kbXd))
            {
                //zapalenie kotrolki errorProvider jeśli wystąpił błąd
                errorProvider1.SetError(kbtxtXd, "ERROR! Wystąpił niedozwolony znak w zapisie dolnej granicy");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //sprawdzenie warunku wejściowego dla x w ramach przedziałów zbieżności
            if (kbXd <= 1 || kbXd >= 2)
            {
                //zapalenie kotrolki errorProvider jeśli wystąpił błąd
                errorProvider1.SetError(kbtxtXd, "ERROR! Xd musi należeć do przedziału zbieżności szeregu");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //sprawdzenie, czy użytkownik wpisał coś do kontrolki 
            if (string.IsNullOrEmpty(kbtxtXg.Text))
            {//zapalenie kotrolki errorProvider jeśli pole było puste
                errorProvider1.SetError(kbtxtXg, "ERROR Pole musi być wypełnione");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            if (!float.TryParse(kbtxtXg.Text, out kbXg))
            {
                //zapalenie kotrolki errorProvider jeśli wystąpił błąd
                errorProvider1.SetError(kbtxtXg, "ERROR! Wystąpił niedozwolony znak w zapisie górnej granicy");
                return false;
            }
            else
                errorProvider1.Dispose();
            //sprawdzenie warunku wejściowego dla x w ramach przedziałów zbieżności
            if (kbXg <= 1 || kbXg >= 2)
            {
                //zapalenie kotrolki errorProvider jeśli wystąpił błąd
                errorProvider1.SetError(kbtxtXg, "ERROR! Xg musi należeć do przedziału zbieżności szeregu");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            if (kbXd >= kbXg)
            {
                //zapalenie kotrolki errorProvider jeśli wystąpił błąd
                errorProvider1.SetError(kbtxtXg, "ERROR Górna granica musi być większa od dolnej");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //sprawdzenie, czy użytkownik wpisał coś do kontrolki 
            if (string.IsNullOrEmpty(kbtxtH.Text))
            {//zapalenie kotrolki errorProvider jeśli pole było puste
                errorProvider1.SetError(kbtxtH, "ERROR Pole musi być wypełnione");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //sprawdzenie poprawnosci zapisu H, czyli przyrostu zmian wartości x
            if (!float.TryParse(kbtxtH.Text, out kbH))
            {
                //zapalenie kotrolki errorProvider jeśli wystąpił błąd
                errorProvider1.SetError(kbtxtH, "ERROR! Wystąpił niedozwolony znak w zapisie H");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            /*sprawdzenie, czy H spełnia warunki wejściowe(musi być mniejsze
            niż połowa sumy skrajnych wartości przedziałow)*/
            if (kbH >= (kbXg + kbXg) / 2)
            //zapalenie kotrolki errorProvider jeśli wystąpił błąd
            {
                errorProvider1.SetError(kbtxtH, "ERROR! H musi być mniejsze niż połowa sumy granic szeregu");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //nie było błdu
            return true;
        }
        bool kbPobranieDanychWejsciowych3(out float kbDgc, out float kbGgc, out double kbeps1)
        {
            //deklaracje lokalne 
            kbDgc = 0.0F;
            kbGgc = 0.0F;
            kbeps1 = 0.0F;
            //sprawdzenie, czy użytkownik wpisał coś do kontrolki 
            if (string.IsNullOrEmpty(kbtxtDgc.Text))
            {//zapalenie kotrolki errorProvider jeśli pole było puste
                errorProvider1.SetError(kbtxtDgc, "ERROR Pole musi być wypełnione");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            if (!float.TryParse(kbtxtDgc.Text, out kbDgc))
            {
                //zapalenie kotrolki errorProvider jeśli wystąpił błąd
                errorProvider1.SetError(kbtxtDgc, "ERROR! Wystąpił niedozwolony znak w zapisie dolnej granicy całkowania");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            if (kbDgc <= 1 || kbDgc >= 2)
            {
                //zapalenie kotrolki errorProvider jeśli wystąpił błąd
                errorProvider1.SetError(kbtxtDgc, "ERROR! Dolna granica musi należeć do przedziału zbieżności szeregu");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //sprawdzenie, czy użytkownik wpisał coś do kontrolki 
            if (string.IsNullOrEmpty(kbtxtGgc.Text))
            {//zapalenie kotrolki errorProvider jeśli pole było puste
                errorProvider1.SetError(kbtxtGgc, "ERROR Pole musi być wypełnione");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            if (!float.TryParse(kbtxtGgc.Text, out kbGgc))
            {
                //zapalenie kotrolki errorProvider jeśli wystąpił błąd
                errorProvider1.SetError(kbtxtGgc, "ERROR! Wystąpił niedozwolony znak w zapisie górnej granicy całkowania");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            if (kbGgc <= 1 || kbGgc >= 2)
            {
                //zapalenie kotrolki errorProvider jeśli wystąpił błąd
                errorProvider1.SetError(kbtxtGgc, "ERROR! Górna granica musi należeć do przedziału zbieżności szeregu");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //sprawdzenie, czy użytkownik wpisał coś do kontrolki eps
            if (string.IsNullOrEmpty(kbtxtDokladnosc.Text))
            {//zapalenie kotrolki errorProvider jeśli pole było puste
                errorProvider1.SetError(kbtxtDokladnosc, "ERROR Pole musi być wypełnione");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            if (kbDgc >= kbGgc)
            {
                //zapalenie kotrolki errorProvider, jesli wystąpił błąd
                errorProvider1.SetError(kbtxtGgc, "ERROR! Górna granica musi być większa od dolnej!");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //konwersja na wartość wpisanej wartosci eps1
            if (!double.TryParse(kbtxtDokladnosc.Text, out kbeps1))
            {
                //zapalenie kotrolki errorProvider jeśli wystąpił błąd
                errorProvider1.SetError(kbtxtDokladnosc, "ERROR! Wystąpił niedozwolony znak w zapisie Eps");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            if (kbeps1 <= 0 || kbeps1 >= 1)
            {
                //zapalenie kotrolki errorProvider jeśli wystąpił błąd
                errorProvider1.SetError(kbtxtDokladnosc, "ERROR! Musisz podac poprawna wartosc Eps");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            if (kbcmbMetodaCalkowania.SelectedIndex < 0)
            {
                errorProvider1.SetError(kbcmbMetodaCalkowania, "ERROR! Musisz wybrać metodę całkowania");
                return false;
            }
            else
                errorProvider1.Dispose();
            return true;
        }
        void kbWartoscFunkcji(double kbX, out double kbWartosc)
        {
            kbWartosc = 0.0f;
            double kbn = 1.0f;
            if (kbX > 1 && kbX < 2)
            {
                kbWartosc = Math.Pow((kbX - 1), kbn) * Math.Sin(1 / Math.Sqrt(kbn));
            }


        }
        static void kbSumaSzeregu(double kbX, double kbeps1, out double kbSuma)
        {
            kbSuma = 0.0F;
            double kbw = 1.0F;
            int kbn = 1;
            do
            {
                //zwiększenie licznika n = n + 1
                kbn++;
                //obliczenie kolejnych wartosci
                kbw = Math.Pow((kbX - 1), kbn) * Math.Sin(1 / Math.Sqrt(kbn));
                //ustalenie sumy koncowej(jest to suma kolejnych wartosci)
                kbSuma = kbSuma + kbw;
            } while (Math.Abs(Math.Abs((kbSuma - kbw)) - kbSuma) > kbeps1);

        }
        private void kbbtnWartoscFunkcji_Click(object sender, EventArgs e)
        {
            //deklaracje dla przechowania danych
            float kbX, kbEps;
            int kbn;
            double kbSuma = 0.0f;
            //sprawdzenie poprawnosci danych wejsciowych
            if (!kbPobranieDanychWejsciowych1(out kbX, out kbEps))
            {
                errorProvider1.SetError(kbbtnWartoscFunkcji, "ERROR! Musisz wpisać dane");
            }
            else
            {
                errorProvider1.Dispose();
                double kbw;
                //początkowe wartości 
                //double kbSuma1 = 0.0F;
                kbSuma = 0.0F;
                //deklaracje lokalne dla obliczenia sumy szeregu
                kbw = 1.0F;
                kbn = 1;
                do
                {
                    //zwiększenie licznika n = n + 1
                    kbn++;
                    //obliczenie kolejnych wartosci
                    kbw = Math.Pow((kbX - 1), kbn) * Math.Sin(1 / Math.Sqrt(kbn));
                    //ustalenie sumy koncowej(jest to suma kolejnych wartosci)
                    kbSuma = kbSuma + kbw;
                } while (Math.Abs(Math.Abs((kbSuma - kbw)) - kbSuma) > kbEps);



                //pokazanie kontrolki tekstowej z wartością funkcji
                kbtxtWartoscFunkcji.Visible = true;
                //wpisanie wartości funckcji do kontrolki tekstowej
                kbtxtWartoscFunkcji.Text = string.Format("{0:0.000}", kbSuma);
                //ustawienie braku możlwości wpisywania danych do kontrolek x i eps
                kblblEps.Enabled = false;
                kbtxtEps.Enabled = false;
                kbtxtX.Enabled = false;
                kblblWartoscX.Enabled = false;
                kbbtnWartoscFunkcji.Enabled = false;
            }

        }

        private void kbgbGruboscLinii_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kbtxtWartoscFunkcji_TextChanged(object sender, EventArgs e)
        {

        }

        private void kblblH_Click(object sender, EventArgs e)
        {

        }

        private void kbtxtXd_TextChanged(object sender, EventArgs e)
        {

        }

        private void kblblWziernikTlaWykresu_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kbbtnTabela_Click(object sender, EventArgs e)
        {
            //deklaracje zmiennych dla przechowania danych 
            float kbXd;
            float kbX;
            float kbXg;
            float kbH;
            if (!kbPobranieDanychWejsciowych2(out kbXd, out kbXg, out kbH))
            {
                //zapalenie kontrolki errorProvider
                errorProvider1.SetError(kbbtnTabela, "ERROR! Musisz podać poprawne dane wejściowe");
                return;
            }
            else
            {
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
                kbdgvTabela.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //deklaracja lokalna dla zwiększenia dokładnosći obliczen 
                int kbi;
                //iteracyjne obliczenie wartosci 
                for (kbi = 0, kbX = kbXd; kbX <= kbXg; kbi++, kbX = kbXd + kbi * kbH)
                {
                    kbdgvTabela.Rows.Add();
                    //wywołanie funkcji liczącej wartosc
                    double kbWartosc;
                    kbWartoscFunkcji(kbX, out kbWartosc);
                    //wpisanie do pierwszej kolumny odpowiedniej wartosci x
                    kbdgvTabela.Rows[kbi].Cells[0].Value = kbX;
                    //wpisanie do drugiej kolumny odpowiedniej wartosci szeegu dla podanego x
                    kbdgvTabela.Rows[kbi].Cells[1].Value = string.Format("{0:0.000}", kbWartosc);
                    //zmiana koloru co drugiego wiersza dla zwiększenia przejrzystosci tabelki
                    if (kbi % 2 == 0)
                        kbdgvTabela.Rows[kbi].DefaultCellStyle.BackColor = Color.LightPink;
                    else
                        kbdgvTabela.Rows[kbi].DefaultCellStyle.BackColor = Color.Gray;
                    //wycentrowanie 
                    kbdgvTabela.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //ustalenie stanu aktywnosci dla odowiednich kontrolek
                    kbdgvTabela.Visible = true;
                    //ustalenie stanu braku aktywnosci dla odpowiednich kontrolek
                    kbpbSzereg.Visible = false;
                    kbbtnTabela.Enabled = false;
                    kbbtnWartoscFunkcji.Enabled = false;
                }


            }
        }

        private void kbchWykres_Click(object sender, EventArgs e)
        {


        }

        private void kbbtnWykres_Click(object sender, EventArgs e)
        {

            {
                //deklaracje zmiennych dla przechowania danych 
                float kbXd;
                float kbX;
                float kbXg;
                float kbH;
                if (!kbPobranieDanychWejsciowych2(out kbXd, out kbXg, out kbH))
                {
                    //zapalenie kontrolki errorProvider
                    errorProvider1.SetError(kbbtnWykres, "ERROR! Musisz podać poprawne dane wejściowe");
                    return;
                }
                else
                {
                    //zgaszenie kontrolki errorProvider
                    double kbWartosc;
                    errorProvider1.Dispose();
                    //odsłoniecie kontrolki chart
                    kbchWykres.Visible = true;
                    //zakrycie kontrolki DataGridView
                    kbdgvTabela.Visible = false;
                    //dodanie tytułu wykresu
                    kbchWykres.Titles.Add("Wykres zmian wartosci szeregu");
                    //wyczyszczenie serii wykresu
                    kbchWykres.Series.Clear();
                    //dodanie nowej serii do wykresu
                    kbchWykres.Series.Add("Seria 0");
                    //opisanie osi X
                    kbchWykres.ChartAreas[0].AxisX.Title = "Wartość x";
                    //opisanie osi Y
                    kbchWykres.ChartAreas[0].AxisY.Title = "Wartość szeregu";
                    //ustalenie stylu wykresu
                    kbchWykres.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    //ustalenie stylu linii wykresu
                    kbchWykres.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
                    //ustalenie widocznosci legendy
                    kbchWykres.Series[0].IsVisibleInLegend = true;
                    //ustalenie koloru linii wykresu
                    kbchWykres.Series[0].Color = Color.Black;
                    //ustalenie koloru tla wykresu
                    kbchWykres.BackColor = Color.Beige;
                    kbchWykres.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
                    //ustalenie grubosci linii wykresu
                    kbchWykres.Series[0].BorderWidth = 2;
                    //deklaracja lokalna dla zwiększenia dokładności wyniku
                    int kbi;
                    //iteracyjne obliczenie wartosci szeregu
                    for (kbi = 0, kbX = kbXd; kbX <= kbXg; kbi++, kbX = kbXd + kbi * kbH)
                    {

                        kbWartoscFunkcji(kbX, out kbWartosc);
                        kbchWykres.Series[0].Points.AddXY(kbX, kbWartosc);
                    }
                    //ustalenie stanu aktywności dla wybranych kontrolek           
                    kbbtnWykres.Enabled = true;
                    kbrdbLinieBezOpisu.Enabled = true;
                    kbrdbLinieZOpisem.Enabled = true;
                    trackBar1.Enabled = true;
                    kbcmbGruboscLinii.Enabled = true;
                    kbbtnKolorLiniiWykresu.Enabled = true;
                    kbbtnKolorTlaWykresu.Enabled = true;
                    kbbtnKreskowa.Enabled = true;
                    kbbtnKropkowa.Enabled = true;
                    //ustalenie stanu braku aktywnosci dla wybranych kontrolek
                    kbpbSzereg.Visible = false;
                    kbtxtXd.Enabled = false;
                    kbtxtXg.Enabled = false;
                    kbtxtH.Enabled = false;

                }
            }
        }
        static double kbCalkaMetodaProstokatow(float kbDgc, float kbGgc, double kbeps1, out int kbLicznikIteracji)
        {

            //deklaracje lokalne
            //szerokosc przedzialu
            float kbh;
            //calka dla i-tego przyblizenia
            double kbCi;
            //calka dla (i-1)-tego przyblizenia 
            double kbCi_1;
            //suma wartosci szeregu w podprzedzialach 
            double kbSuma;
            double kbSumaFx;
            //pierwsze przybliżenie wartości całki
            double kbX;
            kbSumaSzeregu((kbDgc + kbGgc / 2), kbeps1, out kbSuma);
            kbCi = (kbGgc - kbDgc) * kbSuma;
            kbLicznikIteracji = 1;
            //obliczenie kolejnych pol prostokątów pod wykresem
            do
            {
                kbCi_1 = kbCi;
                kbLicznikIteracji++;
                kbh = (kbGgc - kbDgc) / kbLicznikIteracji;
                kbX = kbDgc + kbh / 2;
                kbSumaFx = 0.0F;
                //obliczenie sumy pól pod wykresem
                for (int kbj = 1; kbj <= kbLicznikIteracji; kbj++)
                {
                    kbSumaSzeregu(kbX + kbj * kbh, kbeps1, out kbSuma);
                    kbSumaFx = kbSumaFx + kbSuma;
                }
                kbCi = kbh * kbSumaFx;
            } while (Math.Abs(kbCi - kbCi_1) > kbeps1);

            return kbCi;
        }
        static double kbCalkaMetodaTrapezow(float kbDgc, float kbGgc, double kbeps1, out int kbLicznikIteracji)
        {
            //deklaracje lokalne
            //szerokosc przedzialu
            float kbh;
            //calka dla i-tego przyblizenia
            double kbCi;
            //calka dla (i-1)-tego przyblizenia 
            double kbCi_1;
            //suma wartosci szeregu w podprzedzialach 
            double kbSumaDgc, kbSumaGgc, kbSuma;
            double kbSumaFx;
            //pierwsze przybliżenie wartości całki
            double kbX;
            kbh = kbGgc - kbDgc;
            kbSumaSzeregu(kbDgc, kbeps1, out kbSumaDgc);
            kbSumaSzeregu(kbGgc, kbeps1, out kbSumaGgc);
            double kbSumaFaFb = kbSumaDgc + kbSumaGgc;
            kbCi = kbh * kbSumaFaFb;
            kbLicznikIteracji = 1;
            //obliczenie kolejnych pól trapezów pod wykresem
            do
            {
                kbCi_1 = kbCi;
                kbLicznikIteracji++;
                kbh = (kbGgc - kbDgc) / kbLicznikIteracji;
                kbX = kbDgc + kbh / 2;
                kbSumaFx = 0.0F;
                //obliczenie sumy pól pod wykresem
                for (int kbj = 1; kbj < kbLicznikIteracji; kbj++)
                {
                    kbSumaSzeregu(kbDgc + kbj * kbh, kbeps1, out kbSuma);
                    kbSumaFx = kbSumaFx + kbSuma;
                }
                kbCi = kbh * (kbSumaFaFb + kbSumaFx);
            } while (Math.Abs(kbCi - kbCi_1) > kbeps1);

            return kbCi;
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //zamknięcie okna dialogowego
            Application.Exit();
        }

        private void kropkowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ustalenie stylu linii wykresu na kropkową 
            kbchWykres.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
        }

        private void kreskowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ustalenie stylu linii wykresu na kreskową 
            kbchWykres.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void kreskowokropkowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ustalenie stylu linii wykresu na kreskowo-kropkową
            kbchWykres.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.PointAndFigure;
        }

        private void ciaglaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ustalenie stylu linii wykresu na ciągłą
            kbchWykres.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //ustalenie grubości linii na 1
            kbchWykres.Series[0].BorderWidth = 1;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //ustalenie grubości linii na 2
            kbchWykres.Series[0].BorderWidth = 2;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //ustalenie grubości linii na 3
            kbchWykres.Series[0].BorderWidth = 3;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //ustalenie grubości linii na 4
            kbchWykres.Series[0].BorderWidth = 4;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            //ustalenie grubości linii na 5
            kbchWykres.Series[0].BorderWidth = 5;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            //ustalenie grubości linii na 6
            kbchWykres.Series[0].BorderWidth = 6;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            //ustalenie grubości linii na 7
            kbchWykres.Series[0].BorderWidth = 7;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            //ustalenie grubości linii na 8
            kbchWykres.Series[0].BorderWidth = 8;
        }

        private void kolorTłaWykresuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //deklaracja i utworzenie egzemplarza paletu kolorów 
            ColorDialog kbPaletaKolorów = new ColorDialog();
            //ustawienie aktualnego koloru tła
            kbPaletaKolorów.Color = kbchWykres.BackColor;
            //wyświetlenie palety kolorow i odczytanie wyboru używtkownika 
            if (kbPaletaKolorów.ShowDialog() == DialogResult.OK)
                //zmiana koloru serii danych chWykres.BackColor
                kbchWykres.BackColor = kbPaletaKolorów.Color;
            //ustawienie koloru wziernika tla wykresu
            kbtxtKolorTlaWykresu.BackColor = kbchWykres.BackColor;
        }

        private void kolorLiniiWykresuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //deklaracja i utworzenie egzemplarza paletu kolorów 
            ColorDialog kbPaletaKolorów = new ColorDialog();
            //ustawienie aktualnego koloru linii
            kbPaletaKolorów.Color = kbchWykres.Series[0].Color;
            //wyświetlenie palety kolorow i odczytanie wyboru używtkownika 
            if (kbPaletaKolorów.ShowDialog() == DialogResult.OK)
                //zmiana koloru serii danych chWykres.BackColor
                kbchWykres.Series[0].Color = kbPaletaKolorów.Color;
            //ustawienie koloru wziernika linii wykresu
            kbtxtKolorLinii.BackColor = kbchWykres.Series[0].Color;
        }

        private void kolorCzcionkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //deklaracja i utworzenie egzemplarza paletu kolorów 
            ColorDialog kbPaletaKolorów = new ColorDialog();
            //wyświetlenie palety kolorow i odczytanie wyboru używtkownika 
            if (kbPaletaKolorów.ShowDialog() == DialogResult.OK)
                //zmiana koloru czcionki
                this.ForeColor = kbPaletaKolorów.Color;
            //zmiana kolorow czczionki wszystkich kontrolek umieszczonych na formularzu
            foreach (Control Kontrolka in this.Controls)
                Kontrolka.ForeColor = kbPaletaKolorów.Color;
        }

        private void kbbtnResetuj_Click(object sender, EventArgs e)
        {
            //wyczyszczenie kontrolek
            Controls.Clear();
            //zainicjowanie formularza ponownie
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //odczytanie ustawionej grubosci linii w kontrolce TrackBar i przypisanie jej grubosci linii serii danych
            kbchWykres.Series[0].BorderWidth = trackBar1.Value;
            //uaktualnienie ustawienia grubosci linii w kontrolce cmb
            kbcmbGruboscLinii.SelectedIndex = trackBar1.Value;

        }

        private void krojPismaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //utworzenie nowego okna dialogowego dla czcionek 
            FontDialog kbOknoCzcionek = new FontDialog();
            //wyświetlenie okna czcionek i odczytanie wyboru używtkownika 
            if (kbOknoCzcionek.ShowDialog() == DialogResult.OK)
                this.Font = kbOknoCzcionek.Font;
            //zapisanie zmian we wszystkich kontrolkach
            foreach (Control Kontrolka in this.Controls)
                Kontrolka.Font = kbOknoCzcionek.Font;
        }

        private void rozmiarCzcionkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //utworzenie nowego okna dialogowego dla czcionek 
            FontDialog kbOknoCzcionek = new FontDialog();
            //wyświetlenie okna czcionek i odczytanie wyboru używtkownika 
            if (kbOknoCzcionek.ShowDialog() == DialogResult.OK)
                this.Font = kbOknoCzcionek.Font;
            //zapisanie zmian we wszystkich kontrolkach
            foreach (Control Kontrolka in this.Controls)
                Kontrolka.Font = kbOknoCzcionek.Font;
        }

        private void pogrubionaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Font = new Font(this.Font,
            this.Font.Style | FontStyle.Bold);
            //ustalenie czcionki pogrubionej we wszystkich kontrolkach
           foreach(Control Kontrolka in this.Controls)
                Kontrolka.Font = new Font(this.Font,
            this.Font.Style | FontStyle.Bold);
        }

        private void kursywaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Font = new Font(this.Font,
            this.Font.Style | FontStyle.Italic);
            //ustalenie czcionki podkrślona we wszystkich kontrolkach
            foreach (Control Kontrolka in this.Controls)
                Kontrolka.Font = new Font(this.Font,
            this.Font.Style | FontStyle.Italic);
        }

        private void pogrubionaIKursywaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Font = new Font(this.Font,
            this.Font.Style | FontStyle.Bold | FontStyle.Italic);
            //ustalenie czcionki pogrubionej i podkreślonej we wszystkich kontrolkach
            foreach (Control Kontrolka in this.Controls)
                Kontrolka.Font = new Font(this.Font,
            this.Font.Style | FontStyle.Bold | FontStyle.Italic);
        }

        private void kbrdbLinieBezOpisu_CheckedChanged(object sender, EventArgs e)
        {
            //sprawdzenie, czy wykres znajduje się na formularzu
            if (kbchWykres.Visible == true)
            {
                //podpisy osi-brak podpisu
                kbchWykres.ChartAreas[0].AxisX.Title = "";
                kbchWykres.ChartAreas[0].AxisY.Title = "";
            }
        }

        private void kbrdbLinieZOpisem_CheckedChanged(object sender, EventArgs e)
        {
            //sprawdzenie, czy wykres znajduje się na forularzu
            if (kbchWykres.Visible == true)
            {
                //podpisanie osi układu współrzędnych
                kbchWykres.ChartAreas[0].AxisX.Title = "Wartość x";
                kbchWykres.ChartAreas[0].AxisY.Title = "Wartość szeregu";
            }
        }

        private void kbbtnKolorLiniiWykresu_Click(object sender, EventArgs e)
        {
            //deklaracja i utworzenie egzemplarza paletu kolorów 
            ColorDialog kbPaletaKolorów = new ColorDialog();
            //ustawienie aktualnego koloru linii
            kbPaletaKolorów.Color = kbchWykres.Series[0].Color;
            //wyświetlenie palety kolorow i odczytanie wyboru używtkownika 
            if (kbPaletaKolorów.ShowDialog() == DialogResult.OK)
                kbchWykres.Series[0].Color = kbPaletaKolorów.Color;
            //ustawienie koloru wziernika linii wykresu
            kbtxtKolorLinii.BackColor = kbchWykres.Series[0].Color;
        }

        private void kbbtnKolorTlaWykresu_Click(object sender, EventArgs e)
        {
            //deklaracja i utworzenie egzemplarza paletu kolorów 
            ColorDialog kbPaletaKolorów = new ColorDialog();
            //ustawienie aktualnego koloru tła
            kbPaletaKolorów.Color = kbchWykres.BackColor;
            //wyświetlenie palety kolorow i odczytanie wyboru używtkownika 
            if (kbPaletaKolorów.ShowDialog() == DialogResult.OK)
                //zmiana koloru serii danych chWykres.BackColor
                kbchWykres.BackColor = kbPaletaKolorów.Color;
            //ustawienie koloru wziernika tla wykresu
            kbtxtKolorTlaWykresu.BackColor = kbchWykres.BackColor;
        }

        private void zapiszTablicęWPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sprawdzenie, czy tabelka znajduje się na formulazru 
            if (kbdgvTabela.Visible)
            {

            }
            //zapalenie kontrolki erroeProvider, gdy na formularzu nie znajduje się tabelka
            else
            {
                errorProvider1.SetError(kbbtnTabela, "ERROR! Aby zapisać tablicę w pliku musisz utworzyć tabelkę!");
                return;
            }
            errorProvider1.Dispose();
            SaveFileDialog kbOknoZapisuPliku = new SaveFileDialog();
            //nalozenie warunku na rozszerzenie pliku, w ktorym zapisane zostaną dane z tabelki
            kbOknoZapisuPliku.Filter = "txt files(*.txt)|*.txt|All Files(*.*)*.*|";
            kbOknoZapisuPliku.FilterIndex = 1;
            kbOknoZapisuPliku.RestoreDirectory = true;
            kbOknoZapisuPliku.InitialDirectory = "C:\\";
            kbOknoZapisuPliku.Title = "Zapisz dane z tabeli w pliku";
            if (kbOknoZapisuPliku.ShowDialog() == DialogResult.OK)
            {
                StreamWriter kbPlikZnakowy = new StreamWriter(kbOknoZapisuPliku.OpenFile());
                kbPlikZnakowy.WriteLine("\n\n\t\t\t\tWiersze danych kontrolki");
                kbPlikZnakowy.WriteLine("\n\t");
                for (int kbi = 0; kbi < kbdgvTabela.Rows.Count; kbi++)
                {
                    kbPlikZnakowy.Write(string.Format("\t {0,8}", kbdgvTabela.Rows[kbi].Cells[0].Value));
                    kbPlikZnakowy.WriteLine(string.Format("\t\t\t {0,8}", kbdgvTabela.Rows[kbi].Cells[1].Value));
                }
                kbdgvTabela.Rows.Clear();
                kbPlikZnakowy.Dispose();
                kbPlikZnakowy.Close();
            }

        }

        private void kbbtnObliczCalke_Click(object sender, EventArgs e)
        {
            //deklaracje lokalne dla przechowania danych 
            float kbDgc;
            float kbGgc;
            double kbeps1;
            if (!kbPobranieDanychWejsciowych3(out kbDgc, out kbGgc, out kbeps1))
            {
                //zapalenie kontrolki errorProvider
                errorProvider1.SetError(kbbtnObliczCalke, "ERROR! Musisz podać poprawne dane wejściowe");
                return;
            }
            else
            {
                //zgaszenie kontrolki errorProvider
                double kbWartosc;
                errorProvider1.Dispose();
                //odsloniecie kontrolki z obliczona calka
                kbtxtCalka.Visible = true;
                //obliczenie calki metoda prostokatow
                if (kbcmbMetodaCalkowania.SelectedIndex == 0)
                {
                    int kbLicznikIteracji;
                   kbWartosc= kbCalkaMetodaProstokatow(kbDgc, kbGgc, kbeps1, out kbLicznikIteracji);
                    kbtxtCalka.Text = string.Format("{0:0.000}", kbWartosc);
                }
                //obliczenie calki metoda trapezow
                if (kbcmbMetodaCalkowania.SelectedIndex == 1)
                {
                    int kbLicznikIteracji;
                    kbWartosc = kbCalkaMetodaTrapezow(kbDgc, kbGgc, kbeps1, out kbLicznikIteracji);
                    kbtxtCalka.Text = string.Format("{0:0.000}", kbWartosc);
                }
                kbbtnObliczCalke.Enabled = false;
                kbtxtDokladnosc.Enabled = false;
                kbtxtGgc.Enabled = false;
                kbtxtDgc.Enabled = false;
                kbcmbMetodaCalkowania.Enabled = false;
            }
        }

        private void kbbtnKreskowa_Click(object sender, EventArgs e)
        {
            kbchWykres.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void kbbtnKropkowa_Click(object sender, EventArgs e)
        {
                kbchWykres.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
        }
    }
}