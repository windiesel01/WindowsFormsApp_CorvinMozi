using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp_CorvinMozi
{
    internal class Terem
    {
        string nev;
        int sorok;
        int szekek;
        char[,] ulesek;
        Image nevadokep;

        public Terem(string nev, int sorok, int szekek, char[,] ulesek, Image nevadokep)
        {
            Nev = nev;
            Sorok = sorok;
            Szekek = szekek;
            Ulesek = ulesek;
            Nevadokep = nevadokep;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Sorok { get => sorok; set => sorok = value; }
        public int Szekek { get => szekek; set => szekek = value; }
        public char[,] Ulesek { get => ulesek; set => ulesek = value; }
        public Image Nevadokep { get => nevadokep; set => nevadokep = value; }
    }
}
