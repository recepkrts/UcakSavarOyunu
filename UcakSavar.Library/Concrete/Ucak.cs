﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakSavar.Library.Abstract;

namespace UcakSavar.Library.Concrete
{
    internal class Ucak: Cisim
    {
        private static readonly Random Random = new Random();

        public Ucak(Size hareketAlaniBoyutlari): base(hareketAlaniBoyutlari)
        {
            HareketMesafesi = (int)(Height * 0.1);
            Top = Random.Next(HareketAlaniBoyutlari.Height-Height+1);
        }

        public Mermi VurulduMu(List<Mermi> mermiler)
        {
            foreach (var mermi in mermiler)
            {
                var vurulduMu = mermi.Top < Bottom && mermi.Right > Left && mermi.Left < Right;
                if (vurulduMu) return mermi;    
            }
            return null;
        }
    }
}
