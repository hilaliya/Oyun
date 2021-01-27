using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    class Oyuncu 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public long TC { get; set; }
        public int Dogum { get; set; }
        public string Mail { get; set; }
        public string Kartno { get; set; }
        public int Bakiye;
        public int Seviye = 0;
        public int Puan = 0;
    }
}
