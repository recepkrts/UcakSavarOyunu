using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakSavar.Library.Interface;
using System.Windows.Forms;
using System.Drawing;
using UcakSavar.Library.Enum;

namespace UcakSavar.Library.Concrete
{
    public class Oyun: IOyun
    {
        #region Alanlar
        
        private readonly Timer _gecenSureTimer = new Timer { Interval = 1000 };
        private readonly Timer _hareketTimer = new Timer { Interval = 100 };
        private readonly Timer _ucakOlusturmaTimer = new Timer { Interval = 2000 };
        private TimeSpan _gecenSure;
        private readonly Panel _ucakSavarPanel;
        private UcakSavar _ucakSavar;
        private readonly Panel _savasAlaniPanel;
        private readonly List<Mermi> _mermiler = new List<Mermi>();
        private readonly List<Ucak> _ucaklar = new List<Ucak>();


        #endregion

        #region Olaylar

        public event EventHandler GecenSureDegisti;

        #endregion

        #region Özellikler

        public bool DevamEdiyorMu { get; private set; }

        public TimeSpan GecenSure 
        {
            get { return _gecenSure; }

            private set
            {
                _gecenSure = value;

                GecenSureDegisti.Invoke(this, EventArgs.Empty);
            }
        }

        #endregion

        #region Metodlar  

        public Oyun(Panel ucakSavarPanel, Panel savasAlaniPanel)
        {
            _ucakSavarPanel = ucakSavarPanel;
            _savasAlaniPanel = savasAlaniPanel;
            _gecenSureTimer.Tick += GecenSureTimer_Tick;
            _hareketTimer.Tick += HareketTimer_Tick;
            _ucakOlusturmaTimer.Tick += UcakOlusturmaTimer_Tick;
        }

        private void GecenSureTimer_Tick(object sender, EventArgs e)
        {
            GecenSure += TimeSpan.FromSeconds(1);
        }

        private void HareketTimer_Tick(object sender, EventArgs e)
        {
            MermileriHareketEttir();
            UcaklarıHareketEttir();
            VurulanUcaklariSil();
        }

        private void VurulanUcaklariSil()
        {
            for (int i = _ucaklar.Count-1; i >=0; i--)
            {
                var ucak = _ucaklar[i];
                var vuranMermi = ucak.VurulduMu(_mermiler);
                if (vuranMermi == null) continue;

                _ucaklar.Remove(ucak);
                _mermiler.Remove(vuranMermi);
                _savasAlaniPanel.Controls.Remove(ucak);
                _savasAlaniPanel.Controls.Remove(vuranMermi);
            }
        }

        private void UcaklarıHareketEttir()
        {
            for (int i = _ucaklar.Count-1; i >=0; i--)//silme işlmei için sondan başlıyoruz bu sayede liste hata vermiyor...
            {
                var ucak = _ucaklar[i];
                var carptiMi = ucak.HareketEttir(Yon.Saga);
                if (carptiMi)
                {            
                    _ucaklar.Remove(ucak);
                    _savasAlaniPanel.Controls.Remove(ucak);
                    Bitir();
                    break;                  
                }   
            }       
        }

        private void UcakOlusturmaTimer_Tick(object sender, EventArgs e)
        {
            UcakOlustur();
        }

        private void MermileriHareketEttir()
        {
            for (int i = _mermiler.Count-1; i >= 0 ; i--)
            {
                var mermi = _mermiler[i];
                var carptiMi = mermi.HareketEttir(Yon.Yukari);
                if (carptiMi)
                {
                    _mermiler.Remove(mermi);
                    _savasAlaniPanel.Controls.Remove(mermi);
                }
            }
        }

        public void Baslat()
        {
            if (DevamEdiyorMu) return;

            DevamEdiyorMu = true;
            ZamanlayicilariBaslat();
            UcakSavasOluştur();
            UcakOlustur();
        }

        private void UcakOlustur()
        {
            var ucak = new Ucak(_savasAlaniPanel.Size);
            _ucaklar.Add(ucak);
            _savasAlaniPanel.Controls.Add(ucak);
        }   

        private void UcakSavasOluştur()
        {
           _ucakSavar = new UcakSavar(_ucakSavarPanel.Width, _ucakSavarPanel.Size);
           _ucakSavarPanel.Controls.Add(_ucakSavar);
        }

        private void Bitir()
        {
            if (!DevamEdiyorMu) return;

            DevamEdiyorMu = false;
            ZamanlayicilariDurdur();
        }

        private void ZamanlayicilariBaslat()
        {
            _gecenSureTimer.Start();
            _hareketTimer.Start();
            _ucakOlusturmaTimer.Start();
        }

        private void ZamanlayicilariDurdur()
        {
            _gecenSureTimer.Stop();
            _hareketTimer.Stop();
            _ucakOlusturmaTimer.Stop();
        }

        public void AtesEt()
        {
            if (!DevamEdiyorMu) return;
            var mermi = new Mermi(_savasAlaniPanel.Size, _ucakSavar.Center);
            _mermiler.Add(mermi);
            _savasAlaniPanel.Controls.Add(mermi);
        }

        public void UcakSavariHareketEttir(Yon yon)
        {
            if (!DevamEdiyorMu) return;

            _ucakSavar.HareketEttir(yon);
        }
        #endregion
    }
}