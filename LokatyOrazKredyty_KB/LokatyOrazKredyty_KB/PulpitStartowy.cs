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
    public partial class PulpitStartowy : Form
    {
        public PulpitStartowy()
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

        private void btnLokaty_Click(object sender, EventArgs e)
        {
            //utworzenie egzemplarza formularza lokaty
            Lokaty EgzLokaty = new Lokaty();
            // Form EgzLokaty = new Lokaty();
            //lokalizacja formularza Lokaty
            EgzLokaty.Location = new Point(30, 50);
            //ukrycie aktualnie aktywnego formularza 
            this.Hide();
            //aktywowanie nowego formularza 
            EgzLokaty.Show();

        }

        private void btnKredyty_Click(object sender, EventArgs e)
        {
            //utworzenie egzemplarza formularza lokaty
            Kredyty EgzKredyty = new Kredyty();
            // Form EgzLokaty = new Lokaty();
            //lokalizacja formularza Lokaty
            EgzKredyty.Location = new Point(100, 100);
            //ukrycie aktualnie aktywnego formularza 
            this.Hide();
            //aktywowanie nowego formularza 
            EgzKredyty.Show();
        }
    }
}
