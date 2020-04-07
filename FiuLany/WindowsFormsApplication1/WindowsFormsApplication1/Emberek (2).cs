using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Emberek
    {
        public string Nev { get; set; }
        public int Kor { get; set; }
        public string Neme { get; set; }
        public int Munka { get; set; }

        public Emberek(string nev, int kor, string neme, int munka)
        {
            this.Nev = nev;
            this.Kor = kor;
            this.Neme = neme;
            this.Munka= munka;
        }

    }
}
