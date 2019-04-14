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
    public partial class Kredyty : Form
    {
        public Kredyty()
        {
            InitializeComponent();
            this.Left = 20;
            this.Top = 20;
            this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.70F);
            this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.70F);
            this.StartPosition = FormStartPosition.Manual;
            //blokada możliwości zmiany rozmiaru formularza techniką przeciągania krawędzi
            this.SetAutoSizeMode(AutoSizeMode.GrowAndShrink);
            //blokada przycisków minimalizacji i mkasymalizacji 
            this.MaximizeBox = false; this.MinimizeBox = false;
            //dodanie pasków przewijania, gdy formularz będzie "duży"
            this.AutoScroll = false;
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

        bool[] StanTablPage = { true, false, false };
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //identyfikacja źródla zdarzenia selecting
            if (e.TabPage == tabControl1.TabPages[0])
                //sprawdzenie czy ta zakladka moze byc zakladka aktywna
                if (StanTablPage[0])
                    e.Cancel = false; //zakladka ma byc aktywna
                else
                    e.Cancel = true;
            else
                 if (e.TabPage == tabControl1.TabPages[1])
                //sprawdzenie czy ta zakladka moze byc zakladka aktywna
                if (StanTablPage[1])
                    e.Cancel = false; //zakladka ma byc aktywna
                else
                    e.Cancel = true;
            else
                 if (e.TabPage == tabControl1.TabPages[2])
                //sprawdzenie czy ta zakladka moze byc zakladka aktywna
                if (StanTablPage[2])
                    e.Cancel = false; //zakladka ma byc aktywna
                else
                    e.Cancel = true;
        }

        private void btnTabelarycznaSplata_Click(object sender, EventArgs e)
        {
            //utworzenie tabelarycznego zestawienia splaty kredytu na drugiej zakladce
            //umozliwienie aktywowania drugiej zakladki przez użytkownika
            StanTablPage[1] = true;
        }
    }
}
