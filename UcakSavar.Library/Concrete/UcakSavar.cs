using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UcakSavar.Library.Abstract;

namespace UcakSavar.Library.Concrete
{
    internal class UcakSavar: Cisim
    {
        public UcakSavar(int panelGenisligi,Size hareketAlaniBoyutlari): base(hareketAlaniBoyutlari)
        {
            Center = panelGenisligi / 2;
            HareketMesafesi = Width;
        }
    }
}
