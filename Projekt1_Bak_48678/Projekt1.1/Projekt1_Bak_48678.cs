using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Projekt1._1
{
    public partial class Projekt1 : Form
    {   //deklaracje stałej
        const int kbMargines = 20;
        int kbPromienKulki = 10;
        const float kbPrzyrost = 0.05F;
        //deklaracje zmiennych
        int kbXMax, kbYMax;
        int kbXs, kbYs;
        //deklaracja zmiennej graficznej 'Rysownica'
        Graphics kbRysownica;
        //deklaracja pióra
        Pen kbPioroXY, kbPioroSzereg;
        SolidBrush kbPedzelKulka;
        //deklaracja zmiennych wykorzystywanych przy skalowaniu osi
        float kbWspolczynnikSkaliX, kbWspolczynnikSkaliY;
        int kbIndeksPunktow;
        //deklaracja tablicy z punktami
        Point[] kbPunktyNaSzeregu;
        //deklaracja zmiennej odpowiadającej za indeks kulek
        int kbIdekxPolozeniaKulek;
        //utworzenie generatora liczb losowych dla zmiany atrybutow szeregu
        Random kbrnd = new Random();

        private void kb_timer_Tick(object sender, EventArgs e)
        {
            if (kbIdekxPolozeniaKulek < kbPrzeliczanieWspolrzednych.kbIloscPunktow(kbPrzyrost) - 2)
                kbIdekxPolozeniaKulek++;
            else
                kbIdekxPolozeniaKulek = 0;
            //odświerzenie powierzchni graficznej (formularza)
            this.Refresh();
        }

        private void kb_btnZmienKolorSzeregu_Click(object sender, EventArgs e)
        {
            ColorDialog kbPaletaKolorow = new ColorDialog();
            kbPaletaKolorow.Color = kbPioroSzereg.Color;
            if (kbPaletaKolorow.ShowDialog() == DialogResult.OK)
                kbPioroSzereg.Color = kbPaletaKolorow.Color;
        }

        private void kb_btnZmienKolorKulki_Click(object sender, EventArgs e)
        {
            ColorDialog kbPaletaKolorow = new ColorDialog();
            kbPaletaKolorow.Color = kbPedzelKulka.Color;
            if (kbPaletaKolorow.ShowDialog() == DialogResult.OK)
                kbPedzelKulka.Color = kbPaletaKolorow.Color;
        }

        private void kb_trbGruboscLinii_Scroll(object sender, EventArgs e)
        {
            kbPioroSzereg.Width = kb_trbGruboscLinii.Value;
        }

        private void kb_trbPromienKulki_Scroll(object sender, EventArgs e)
        {
            kbPromienKulki = kb_trbPromienKulki.Value;
        }

        private void kb_trbPredkoscKulki_Scroll(object sender, EventArgs e)
        {
            kb_timer.Interval = kb_trbPromienKulki.Value;
        }

        private void kb_btnKolorUkladu_Click(object sender, EventArgs e)
        {
            ColorDialog kbPaletaKolorow = new ColorDialog();
            kbPaletaKolorow.Color = kbPioroXY.Color;
            if (kbPaletaKolorow.ShowDialog() == DialogResult.OK)
                kbPioroXY.Color = kbPaletaKolorow.Color;
        }

        private void kb_btnKolorFormularza_Click(object sender, EventArgs e)
        {
            ColorDialog kbPaletaKolorow = new ColorDialog();
            kbPaletaKolorow.Color = this.BackColor;
            if (kbPaletaKolorow.ShowDialog() == DialogResult.OK)
                this.BackColor = kbPaletaKolorow.Color;
        }

        private void Projekt1_Load(object sender, EventArgs e)
        {
            //lokalizacja kontrolek na formularzu
            kb_lblZmianaAtrybutów.Location = new Point((int)kbRysownica.VisibleClipBounds.Width /3 ,2*kbMargines -10 );
            kb_btnKolorFormularza.Location = new Point((int)kbRysownica.VisibleClipBounds.Width / 8,
                (int)kbRysownica.VisibleClipBounds.Height / 2 + 4* kbMargines );
            kb_btnKolorUkladu.Location = new Point(kb_btnKolorFormularza.Location.X + (int)kbRysownica.VisibleClipBounds.Width / 6,
                kb_btnKolorFormularza.Location.Y);
            kb_btnZmienKolorKulki.Location = new Point(kb_btnKolorUkladu.Location.X + (int)kbRysownica.VisibleClipBounds.Width / 6,
                kb_btnKolorFormularza.Location.Y);
            kb_btnZmienKolorSzeregu.Location = new Point(kb_btnZmienKolorKulki.Location.X + (int)kbRysownica.VisibleClipBounds.Width / 6,
                kb_btnKolorFormularza.Location.Y);
            kb_btnLosujKolor.Location = new Point(kb_btnZmienKolorKulki.Location.X + (int)kbRysownica.VisibleClipBounds.Width / 6,
                kb_btnKolorFormularza.Location.Y);
            kb_btnZmienKolorSzeregu.Location = new Point(kb_btnLosujKolor.Location.X + (int)kbRysownica.VisibleClipBounds.Width / 6,
                kb_btnKolorFormularza.Location.Y);
            kb_lblZmienGrubscLinii.Location = new Point((int)kbRysownica.VisibleClipBounds.Width / 6,
                kb_lblZmianaAtrybutów.Location.Y + 2*kbMargines);
            kb_lblZmienPromienKulki.Location = new Point((int)kbRysownica.VisibleClipBounds.Width / 5 + kb_lblZmienGrubscLinii.Width,
                kb_lblZmienGrubscLinii.Location.Y);
            kb_lblPredkoscKulki.Location = new Point((int)kbRysownica.VisibleClipBounds.Width / 5 + 2*kb_lblZmienGrubscLinii.Width,
                kb_lblZmienPromienKulki.Location.Y);
            kb_trbGruboscLinii.Location = new Point(kb_lblZmienGrubscLinii.Location.X,
                kb_lblZmienGrubscLinii.Location.Y + kbMargines);
            kb_trbPromienKulki.Location = new Point(kb_lblZmienPromienKulki.Location.X,
                kb_lblZmienPromienKulki.Location.Y + kbMargines);
            kb_trbPredkoscKulki.Location = new Point(kb_lblPredkoscKulki.Location.X,
                kb_lblPredkoscKulki.Location.Y + kbMargines);
            kb_btnZatrzymajKulke.Location = new Point(kb_btnKolorUkladu.Location.X, 
                kb_btnKolorUkladu.Location.Y+ kbMargines + kb_btnKolorUkladu.Height);
            kb_btnWznowRuchKulki.Location = new Point(kb_btnZmienKolorKulki.Location.X,
                kb_btnZatrzymajKulke.Location.Y);
        }

        private void ciaglaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kbPioroSzereg.DashStyle = DashStyle.Solid;
        }

        private void kropkowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kbPioroSzereg.DashStyle = DashStyle.Dot;
        }

        private void kropkowokreskowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kbPioroSzereg.DashStyle = DashStyle.DashDotDot;
        }

        private void kreskowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kbPioroXY.DashStyle = DashStyle.Solid;
        }

        private void kropkowaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kbPioroXY.DashStyle = DashStyle.Dot;
        }

        private void kreskowokropkowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kbPioroXY.DashStyle = DashStyle.DashDotDot;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            kbPromienKulki = 10;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            kbPromienKulki = 11;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            kbPromienKulki = 12;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            kbPromienKulki = 13;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            kbPromienKulki = 14;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            kbPromienKulki = 15;
        }

        private void kb_btnLosujKolor_Click(object sender, EventArgs e)
        {
            kbPioroSzereg.Color = Color.FromArgb(kbrnd.Next(0, 255),
                kbrnd.Next(0, 255), kbrnd.Next(0, 255));
        }

        private void kb_btnZatrzymajKulke_Click(object sender, EventArgs e)
        {
            kb_timer.Enabled = false;
            kb_trbPredkoscKulki.Enabled = false;
        }

        private void kb_btnWznowRuchKulki_Click(object sender, EventArgs e)
        {
            kb_timer.Enabled = true;
            kb_trbPredkoscKulki.Enabled = true;
        }

        private void Projekt1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            //utworzenie okna dialogowego zamknięcia fotmularza
            DialogResult kb_OknoDialogowe = MessageBox.Show("Czy na pewno chcesz zamknąć formularz?", this.Text,
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //zamkniecie formularza, gdy uzytkownik wybral odpowiednia opcje
            if (kb_OknoDialogowe != DialogResult.Yes)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void Projekt1_Paint_1(object sender, PaintEventArgs e)
        {
            //wykreślenie osi x i y 
            kbRysownica.DrawLine(kbPioroXY, 
                kbMargines / 2, kbYs, kbXMax, kbYs);
            kbRysownica.DrawLine(kbPioroXY,
                kbMargines, kbYMax - 2 * kbMargines,
                kbMargines, kbMargines);
            //wyrysowanie szeregu
            kbRysownica.DrawCurve(kbPioroSzereg, kbPunktyNaSzeregu);
            //wykreślenie kulek w nowym położeniu
            kbRysownica.FillEllipse(kbPedzelKulka,
                kbPunktyNaSzeregu[kbIdekxPolozeniaKulek].X - kbPromienKulki,
                kbPunktyNaSzeregu[kbIdekxPolozeniaKulek].Y - kbPromienKulki, 
                2 * kbPromienKulki, 2 * kbPromienKulki);
            //utworzenie pędzla do opisu linii układu współrzędnych
            SolidBrush kbPedzelOpisuOsi = new SolidBrush(Color.Black);
            //ustalenie czcionki opisu osi
            Font kbCzcionkaOpisu = new Font("Times New Roman",10,  FontStyle.Bold);
            //wycznaczenie rozmiaru dla opisu osi X 
            SizeF kbRozmiarPowierzchniOpisuX = kbRysownica.MeasureString("X", kbCzcionkaOpisu);
            //ustalenie odstępu 
            Point kbOdstepOdOsi = new Point(10, 10);
            //lokaziacja opisu osi X 
            PointF kbLokalizacjaOpisuOsiX = new PointF(kbRysownica.VisibleClipBounds.Width - kbRozmiarPowierzchniOpisuX.Width - kbOdstepOdOsi.X,
                kbRysownica.VisibleClipBounds.Height/2 - kbRozmiarPowierzchniOpisuX.Height - kbOdstepOdOsi.Y);
            //wyrysowanie opisu osi x
            kbRysownica.DrawString("X", kbCzcionkaOpisu, kbPedzelOpisuOsi, kbLokalizacjaOpisuOsiX);
            //wyznaczenie rozmiaru opisu osi Y
            SizeF kbRozmiarPowierzchniOpisuY = kbRysownica.MeasureString("Y", kbCzcionkaOpisu);
            //lokalizacja opisu osi Y
            PointF kbLokalizacjaOpisuOsiY = new PointF(2*kbMargines, 2*kbMargines - kbOdstepOdOsi.Y);
            //wyrysowanie opisu osi X
            kbRysownica.DrawString("Y", kbCzcionkaOpisu, kbPedzelOpisuOsi, kbLokalizacjaOpisuOsiY);

        }
        //deklaracja klasy statycznej dla przeliczania wspoólzędnych
        static class kbPrzeliczanieWspolrzednych
        {   
       //deklaracje zmiennych statycznych
            static float kbPodzialkaX = 2;
            static float kbPodzialkaY = 4 * kbPodzialkaX;
            //deklaracja metod statycznych
            static public int kbSrodek(int kbWspolrzedna)
            {
                return (kbWspolrzedna + kbMargines) / 2;
            }
            static public float kbWspolczynnikSkaliX(int kbMaxWspolrzedna)
            {
                return (kbPodzialkaX / (kbMaxWspolrzedna - kbMargines));
            }
            static public float kbWspolczynnikSkaliY(int kbMaxWspolrzedna)
            {
                return (kbPodzialkaY / (kbMaxWspolrzedna - kbMargines));
            }
            static public double kbWartoscSzeregu(float kbX)
            {
                int kbn = 1;
                float eps = 0.001F;
                double suma = 0, kbw = 1.0F;
                do
                {
                    kbw = Math.Pow(kbX - 1, kbn) * Math.Sin(1 / Math.Sqrt(kbn));
                    suma = suma + kbw;
                    kbn++;
                } while (Math.Abs(Math.Abs(suma - (suma-kbw)))>eps);
                return suma;
            }
            static public double kbWartoscY(int kbn, float kbPrzyrost, float kbWspolczynnikSkaliY)
            {
                return kbWartoscSzeregu(0 + (kbn * kbPrzyrost)) / kbWspolczynnikSkaliY;
            }
            static public int kbIloscPunktow(float kbPrzyrost)
            {
                return (int)(2 / kbPrzyrost);
            }
            static public int kbPrzyrostPikseli(float kbWspolczynnikSkaliX, float kbPrzyrost)
            {
                return (int)(kbPrzyrost / kbWspolczynnikSkaliX);
            }
        }

        public Projekt1()
        {
            InitializeComponent();
            //ustalanie rozmiarow formularza wzgledem ekranu glownego
            this.Location = new Point(15, 20);
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.7F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.7F);
            //ustalenie lokalizacji formularza na ekranie
            this.StartPosition = FormStartPosition.CenterScreen;
            //zablokowanie zmiany rozmiaru formularza przez przeciągnięcie krawędzi
            this.SetAutoSizeMode(System.Windows.Forms.AutoSizeMode.GrowAndShrink);
            //utworzenie egzemplarza rysownicy
            kbRysownica = this.CreateGraphics();
            //utworzenie egzemplarza pióra osi x i y oraz pióra szeregu
            kbPioroSzereg = new Pen(Color.Red, 1F);
            kbPioroXY = new Pen(Color.Black, 2F);
            kbPedzelKulka = new SolidBrush(Color.Black);
            //ustalenie stylu pióra osi x i y
            kbPioroXY.DashStyle = DashStyle.Solid;
            kbPioroXY.StartCap = LineCap.Flat;
            AdjustableArrowCap kbNowyGrotStrzalki = new AdjustableArrowCap(8, 12);
            kbPioroXY.CustomEndCap = kbNowyGrotStrzalki;
            //ustalenie rozmiarow powierzchni graficznej
            kbXMax = this.Width - kbMargines; 
            kbYMax = this.Height - kbMargines; 
            //ustalenie środka układu współrzędnych
            kbXs = kbPrzeliczanieWspolrzednych.kbSrodek(kbXMax); 
            kbYs = kbPrzeliczanieWspolrzednych.kbSrodek(kbYMax); 
            //wyznaczenie wartości współczynników skalowania dla osi x i y
            kbWspolczynnikSkaliX = kbPrzeliczanieWspolrzednych.kbWspolczynnikSkaliX(kbXMax);
            kbWspolczynnikSkaliY = kbPrzeliczanieWspolrzednych.kbWspolczynnikSkaliY(kbYMax);
            //przygotowanie zmiennych
            kbIdekxPolozeniaKulek = 0;
            int kbJednostki = kbMargines;
            int kbn = 1;

            //utworzenie egzemplarza tablic dla punktów na szeregu
            kbPunktyNaSzeregu = new Point[kbPrzeliczanieWspolrzednych.kbIloscPunktow(kbPrzyrost) - 1];

            for (kbIndeksPunktow = 1;
                kbIndeksPunktow < kbPrzeliczanieWspolrzednych.kbIloscPunktow(kbPrzyrost);
                kbJednostki = kbJednostki + kbPrzeliczanieWspolrzednych.kbPrzyrostPikseli(kbWspolczynnikSkaliX, kbPrzyrost))
            {
                //nowy punkt w tablicy
                kbPunktyNaSzeregu[kbIndeksPunktow - 1] = new Point((int)kbJednostki,
                    kbYs - (int)kbPrzeliczanieWspolrzednych.kbWartoscY(kbn, kbPrzyrost, kbWspolczynnikSkaliY));
                //przejście do następnego punktu
                kbIndeksPunktow++;
                kbn++;
            }
            
            //ustawienie interwału dla zegara 
            kb_timer.Interval = 200;
            kb_timer.Enabled = true;
        }
    }
}
