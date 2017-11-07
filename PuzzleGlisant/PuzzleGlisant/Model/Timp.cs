using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuzzleGlisant.Model
{
    public class Timp
    {
        private int minute;
        private int secunde;
        private int milisecunde;

        public Timp(int _minute, int _secunde, int _milisecunde)
        {
            minute = _minute;
            secunde =  _secunde;
            milisecunde = _milisecunde;
        }

        public Timp(string timp)
        {
            string[] data = timp.Split(':');
            minute = Int32.Parse(data[0]);
            secunde = Int32.Parse(data[1]);
            milisecunde = Int32.Parse(data[2]);
        }

        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                minute = value;
            }
        }

        public int Secunde
        {
            get
            {
                return secunde;
            }
            set
            {
                secunde = value;
            }
        }

        public int Milisecunde
        {
            get
            {
                return milisecunde;
            }
            set
            {
                milisecunde = value;
            }
        }

        public string toString()
        {
            string timp;
            string data;

            timp = string.Empty;
            data = string.Empty;

            data = minute.ToString();

            if (data.Length == 1)
                data = "0" + data;

            timp += data +":";

            data = secunde.ToString();

            if (data.Length == 1)
                data = "0" + data;

            timp += data + ":";

            data = milisecunde.ToString();

            if (data.Length == 1)
                data = "0" + data;

            timp += data;

            return timp;
        }
    }
}
