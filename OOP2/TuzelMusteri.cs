using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Corporate (ing) : tüzel
    //Inheritance : Tuzel Müsteri class'ı Musteri'den miras alındı.
    class TuzelMusteri : Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
 