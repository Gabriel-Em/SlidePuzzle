using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuzzleGlisant.Model
{
    public class Scor
    {
        private string nume;
        private int nrMiscari;
        private Timp timp;

        public Scor(string _Nume, int _NrMiscari, string _Timp)
        {
            nume = _Nume;
            nrMiscari = _NrMiscari;
            timp = new Timp(_Timp);
        }

        public string Nume
        {
            get
            {
                return nume;
            }
            set
            {
                nume = value;
            }
        }

        public int NrMiscari
        {
            get
            {
                return nrMiscari;
            }
            set
            {
                nrMiscari = value;
            }
        }

        public string Timp
        {
            get
            {
                return timp.toString();
            }
            set
            {
                timp = new Model.Timp(value);
            }
        }
    }
}
