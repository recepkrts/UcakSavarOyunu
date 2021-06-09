﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakSavar.Library.Abstract;

namespace UcakSavar.Library.Concrete
{
    internal class Mermi: Cisim
    {
        public Mermi(Size hareketAlaniBoyutlari, int namluOrtasiX): base(hareketAlaniBoyutlari)
        {
            BaslangicKonumunuAyarla(namluOrtasiX);
            HareketMesafesi = (int)(Height * 1.5);
        }

        private void BaslangicKonumunuAyarla(int namluOrtasiX)
        {
            Bottom = HareketAlaniBoyutlari.Height;
            Center = namluOrtasiX;
        }
    }
}
