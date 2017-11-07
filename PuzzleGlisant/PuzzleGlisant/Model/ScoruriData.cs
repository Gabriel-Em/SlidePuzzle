using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace PuzzleGlisant.Model
{
    public class ScoruriData
    {
        private List<Scor> Scoruri3x3;
        private List<Scor> Scoruri4x4;
        private List<Scor> Scoruri5x5;
        private List<Scor> Scoruri6x6;

        public ScoruriData()
        {
            Scoruri3x3 = new List<Scor>();
            Scoruri4x4 = new List<Scor>();
            Scoruri5x5 = new List<Scor>();
            Scoruri6x6 = new List<Scor>();

            bool[] existaFisiere = new bool[4] { false, false, false, false };
            List<string> scoruri;
            string fisier = string.Empty;
            string[] linie;

            if (File.Exists(@".\Scoruri\3x3.txt"))
            {
                existaFisiere[0] = true;
                fisier = File.ReadAllText(@".\Scoruri\3x3.txt");

                if (fisier != "")
                {
                    scoruri = fisier.Split('\n').ToList<string>();

                    for (int i = 0; i < scoruri.Count; i++)
                    {
                        linie = scoruri[i].Split('|');
                        if (linie.Length == 3)
                        {
                            Scor sc = new Scor(linie[0], Int32.Parse(linie[1]), linie[2]);
                            Scoruri3x3.Add(sc);
                        }
                    }
                }

            }

            if (File.Exists(@".\Scoruri\4x4.txt"))
            {
                existaFisiere[1] = true;
                fisier = File.ReadAllText(@".\Scoruri\4x4.txt");

                if (fisier != "")
                {
                    scoruri = fisier.Split('\n').ToList<string>();

                    for (int i = 0; i < scoruri.Count; i++)
                    {
                        linie = scoruri[i].Split('|');
                        if (linie.Length == 3)
                        {
                            Scor sc = new Scor(linie[0], Int32.Parse(linie[1]), linie[2]);
                            Scoruri4x4.Add(sc);
                        }
                    }
                }
            }

            if (File.Exists(@".\Scoruri\5x5.txt"))
            {
                existaFisiere[2] = true;
                fisier = File.ReadAllText(@".\Scoruri\5x5.txt");
                if (fisier != "")
                {
                    scoruri = fisier.Split('\n').ToList<string>();

                    for (int i = 0; i < scoruri.Count; i++)
                    {
                        linie = scoruri[i].Split('|');
                        if (linie.Length == 3)
                        {
                            Scor sc = new Scor(linie[0], Int32.Parse(linie[1]), linie[2]);
                            Scoruri5x5.Add(sc);
                        }
                    }
                }
            }

            if (File.Exists(@".\Scoruri\6x6.txt"))
            {
                existaFisiere[3] = true;
                fisier = File.ReadAllText(@".\Scoruri\6x6.txt");

                if (fisier != "")
                {
                    scoruri = fisier.Split('\n').ToList<string>();

                    for (int i = 0; i < scoruri.Count; i++)
                    {
                        linie = scoruri[i].Split('|');
                        if (linie.Length == 3)
                        {
                            Scor sc = new Scor(linie[0], Int32.Parse(linie[1]), linie[2]);
                            Scoruri6x6.Add(sc);
                        }
                    }
                }
            }

            string mesaj = string.Empty;
            int erori = 0;

            for (int i = 0; i < 4; i++)
                if (!existaFisiere[i])
                    erori++;


            if (erori == 1)
            {
                mesaj = "Eroare: Fisierul ";
                for (int i = 0; i < 4; i++)
                    if (!existaFisiere[i])
                        switch (i)
                        {
                            case 0: mesaj += "3x3.text "; break;
                            case 1: mesaj += "4x4.text "; break;
                            case 2: mesaj += "5x5.text "; break;
                            case 3: mesaj += "6x6.text "; break;
                        }
                mesaj += " nu a fost gasit! Scorurile asociate cu acest fisier nu au putut fi incarcate.";
            }
            else
                if (erori > 1)
                {
                    mesaj = "Eroare: Fisierele: ";

                    for (int i = 0; i < 4; i++)
                        if (!existaFisiere[i])
                            switch (i)
                            {
                                case 0: mesaj += "3x3.text, "; break;
                                case 1: mesaj += "4x4.text, "; break;
                                case 2: mesaj += "5x5.text, "; break;
                                case 3: mesaj += "6x6.text, "; break;
                            }
                    mesaj = mesaj.Remove(mesaj.Length - 2);
                    mesaj += " nu au putut fi gasite! Scorurile asociate cu aceste fisiere nu au putut fi incarcate.";
                }

            if (erori > 0)
                MessageBox.Show(mesaj);
        }

        public List<Scor> this[int puzzle]
        {
            get
            {
                switch (puzzle)
                {
                    case 3: return Scoruri3x3;
                    case 4: return Scoruri4x4;
                    case 5: return Scoruri5x5;
                    case 6: return Scoruri6x6;
                }

                return null;
            }
        }

        public void addScor(int puzzle, Scor scor)
        {
            switch (puzzle)
            {
                case 3: Scoruri3x3.Add(scor); break;
                case 4: Scoruri4x4.Add(scor); break;
                case 5: Scoruri5x5.Add(scor); break;
                case 6: Scoruri6x6.Add(scor); break;
            }

            scrieScorInFisier(puzzle, scor);
        }

        private void scrieScorInFisier(int puzzle, Scor scor)
        {
            StreamWriter file = null;
            string path = string.Empty;
            switch (puzzle)
            {
                case 3: path = @".\Scoruri\3x3.txt"; break;
                case 4: path = @".\Scoruri\4x4.txt"; break;
                case 5: path = @".\Scoruri\5x5.txt"; break;
                case 6: path = @".\Scoruri\6x6.txt"; break;
            }

            string linie = scor.Nume + "|" + scor.NrMiscari + "|" + scor.Timp + "\n";

            if (!Directory.Exists(@".\Scoruri"))
                Directory.CreateDirectory(@".\Scoruri");

            if (!File.Exists(path))
                using (file = File.CreateText(path))
                {
                    file.WriteLine(linie);
                }
            else
                using (file = File.AppendText(path))
                {
                    file.WriteLine(linie);
                }
        }

        public void scrieAllInFisier()
        {
            StreamWriter file = null;
            string path = string.Empty;
            string linie = string.Empty;

            if (!Directory.Exists(@".\Scoruri"))
                Directory.CreateDirectory(@".\Scoruri");

            file = new StreamWriter(@".\Scoruri\3x3.txt");

            for (int i = 0; i < Scoruri3x3.Count; i++)
            {
                linie = Scoruri3x3[i].Nume + "|" + Scoruri3x3[i].NrMiscari + "|" + Scoruri3x3[i].Timp + "\n";
                file.WriteLine(linie);
            }
            file.Close();

            file = new StreamWriter(@".\Scoruri\4x4.txt");

            for (int i = 0; i < Scoruri4x4.Count; i++)
            {
                linie = Scoruri4x4[i].Nume + "|" + Scoruri4x4[i].NrMiscari + "|" + Scoruri4x4[i].Timp + "\n";
                file.WriteLine(linie);
            }
            file.Close();

            file = new StreamWriter(@".\Scoruri\5x5.txt");

            for (int i = 0; i < Scoruri5x5.Count; i++)
            {
                linie = Scoruri5x5[i].Nume + "|" + Scoruri5x5[i].NrMiscari + "|" + Scoruri5x5[i].Timp + "\n";
                file.WriteLine(linie);
            }
            file.Close();

            file = new StreamWriter(@".\Scoruri\6x6.txt");

            for (int i = 0; i < Scoruri6x6.Count; i++)
            {
                linie = Scoruri6x6[i].Nume + "|" + Scoruri6x6[i].NrMiscari + "|" + Scoruri6x6[i].Timp + "\n";
                file.WriteLine(linie);
            }
            file.Close();
        }

        public void scoruriClear(int puzzle)
        {
            switch (puzzle)
            {
                case 3: Scoruri3x3.Clear(); break;
                case 4: Scoruri4x4.Clear(); break;
                case 5: Scoruri5x5.Clear(); break;
                case 6: Scoruri6x6.Clear(); break;
            }
        }
    }
}
