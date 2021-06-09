using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UcakSavar.Library.Concrete;
using UcakSavar.Library.Enum;

namespace UcakSavarOyunu.Desktop
{
    public partial class AnaForm : Form
    {
        private readonly Oyun _oyun;


        public AnaForm()
        {
            InitializeComponent();

            _oyun = new Oyun(panelUcakSavar,panelSavasAlani);
            _oyun.GecenSureDegisti += Oyun_GecenSureDegisti;
        }

        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _oyun.Baslat();
                    break;
                case Keys.Right:
                    _oyun.UcakSavariHareketEttir(Yon.Saga);
                    break;
                case Keys.Left:
                    _oyun.UcakSavariHareketEttir(Yon.Sola);
                    break;
                case Keys.Space:
                    _oyun.AtesEt();
                    break;
            }
        }
        private void Oyun_GecenSureDegisti(object sender, EventArgs e)
        {
            //labelSure.Text = _oyun.GecenSure.Minutes + ":" + _oyun.GecenSure.Seconds.ToString("D2");
            labelSure.Text = _oyun.GecenSure.ToString(@"m\:ss");
        }
    }
}
