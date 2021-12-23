using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urunIslemleri
{
    class urun
    {
        // class eklendi
        public string urunNo, urunCesit, kategori;
        public int fiyat, stok,para;

        public int bakiye()
        {
            para = para +fiyat ;
            stok = stok--;
            return stok;
        }



    }
}
