using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakSavar.Library.Enum;

namespace UcakSavar.Library.Interface
{
    internal interface IHareketEden
    {
        Size HareketAlaniBoyutlari { get; }

        int HareketMesafesi { get; }

        /// <summary>
        /// Cismi İstenilen Yönde Hareket Ettirir.
        /// </summary>
        /// <param name="yon">Hangi Yöne Hareket Edileceği</param>
        /// <returns>Cisim Duvara Çarparsa True Döndürür.</returns>
        bool HareketEttir(Yon yon);
    }
}
