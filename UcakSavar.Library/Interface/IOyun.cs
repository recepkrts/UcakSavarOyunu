using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakSavar.Library.Enum;


namespace UcakSavar.Library.Interface
{
    internal interface IOyun
    {
        event EventHandler GecenSureDegisti;

        bool DevamEdiyorMu { get; }
        TimeSpan GecenSure { get; }

        void Baslat();
        void AtesEt();
        void UcakSavariHareketEttir(Yon yon);

    }
}
