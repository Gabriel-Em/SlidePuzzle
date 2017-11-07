using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace PuzzleGlisant.Controller
{
    public class Controller
    {
        private Model.Puzzle Puzzle;
        private Model.SetariData Setari;
        private Model.ScoruriData Scoruri;

        public Controller(List<PictureBox> pic3x3, List<PictureBox> pic4x4, List<PictureBox> pic5x5, List<PictureBox> pic6x6)
        {
            Setari = new Model.SetariData();
            Puzzle = new Model.Puzzle(pic3x3, pic4x4, pic5x5, pic6x6);
            Scoruri = new Model.ScoruriData();
        }

        public int getDificultate()
        {
            return Setari.Dificultate;
        }

        public void setDificultate(int dificultate)
        {
            Setari.Dificultate = dificultate;
        }

        public bool getImageNumbers()
        {
            return Setari.ImageNumbers;
        }

        public void setImageNumbers(bool imgNumber)
        {
            Setari.ImageNumbers = imgNumber;
        }

        public Image getImage()
        {
            return Setari.Imagine;
        }

        public void setImage(Image img)
        {
            Setari.Imagine = img;
        }

        public string getNume()
        {
            return Setari.Nume;
        }

        public void setNume(string nume)
        {
            Setari.Nume = nume;
        }

        public void addScor(Model.Scor scor)
        {
            Scoruri.addScor(Setari.Dificultate + 2, scor);
        }

        public void scrieAllInFisier()
        {
            Scoruri.scrieAllInFisier();
        }
        public List<int> Amesteca()
        {
            bool[] valid;                   // valid[0] = stanga, valid[1] = dreapta, valid[2] = sus, valid[3] = jos
            List<int> miscari;              // 0 = stanga, 1 = dreapta, 2 = sus, 3 = jos
            List<PictureBox[,]> stariInitiale;  // starile initiale ale puzzle-urilor inainte de a le amesteca
            Random rand = new Random();     // generatorul de numere random
            int miscare, puzzle, nrMiscari,MAXMISC; // miscare = miscarea pe care o generam, puzzle = tipul de puzzle, nrMiscari = numarul de miscari generate
            
            valid = new bool[4];
            miscari = new List<int>();
            puzzle = Setari.Dificultate + 2;    // ex: dificultate = 1 deci puzzle = 3x3
            nrMiscari = 0;
            miscari.Add(-1);                    // adaugam o miscare care nu reprezinta nimic pentru a putea face verificarea miscarii precedente in urma adaugarii primei miscari
            MAXMISC = 0;
            stariInitiale = new List<PictureBox[,]>() { (PictureBox[,])Puzzle[3].Clone(), (PictureBox[,])Puzzle[4].Clone(), (PictureBox[,])Puzzle[5].Clone(), (PictureBox[,])Puzzle[6].Clone() };

            switch (Setari.Dificultate)
            {
                case 1: MAXMISC = 30; break;
                case 2: MAXMISC = 45; break;
                case 3: MAXMISC = 60; break;
                case 4: MAXMISC = 70; break;
            }
            while (nrMiscari !=MAXMISC)
            {
                for (int i = 0; i < 4; i++)             // setam validitatea miscarilor pe true urmand sa setam miscarile nevalide pe false
                    valid[i] = true;

                if (Puzzle.getEmptyIJ(puzzle, 1) == 0) // daca patratul gol e pe linia de sus nu putem sa venim cu o piesa in jos
                    valid[3] = false;
                if (Puzzle.getEmptyIJ(puzzle, 1) == puzzle - 1) // linia jos, piesa in sus
                    valid[2] = false;
                if (Puzzle.getEmptyIJ(puzzle, 2) == 0) // coloana stanga, piesa in dreapta
                    valid[1] = false;
                if (Puzzle.getEmptyIJ(puzzle, 2) == puzzle - 1) // coloana dreapta, piesa in stanga
                    valid[0] = false;
                
                                                                // nu vrem ca algoritmul de amestecare sa mute patratul gol unde era cu o miscare in urma asa ca setam opusul ultimei miscari ca o miscare nevalida
                if (miscari[miscari.Count()-1] == 0)
                    valid[1] = false;
                if (miscari[miscari.Count() - 1] == 1)
                    valid[0] = false;
                if (miscari[miscari.Count() - 1] == 2)
                    valid[3] = false;
                if (miscari[miscari.Count() - 1] == 3)
                    valid[2] = false;

                do
                    miscare = rand.Next(1, 100) % 4;    
                while (!valid[miscare]);    // generam miscari pana cand am generat o miscare valida

                switch (miscare)        // efectuam miscarea in memorie
                {
                    case 0: Puzzle.miscaLaStanga(Puzzle.getPicNearEmpty("dreapta", Setari.Dificultate), Setari.Dificultate); break;
                    case 1: Puzzle.miscaLaDreapta(Puzzle.getPicNearEmpty("stanga", Setari.Dificultate), Setari.Dificultate); break;
                    case 2: Puzzle.miscaInSus(Puzzle.getPicNearEmpty("jos", Setari.Dificultate), Setari.Dificultate); break;
                    case 3: Puzzle.miscaInJos(Puzzle.getPicNearEmpty("sus", Setari.Dificultate), Setari.Dificultate); break;
                }

                miscari.Add(miscare);   // adaugam miscarea la lista miscarilor

                nrMiscari++;
            }

            miscari.RemoveAt(0);    // eliminam miscarea care nu reprezinta nimic adaugata la inceput

            Puzzle[3] = stariInitiale[0];
            Puzzle[4] = stariInitiale[1];
            Puzzle[5] = stariInitiale[2];
            Puzzle[6] = stariInitiale[3];
            
            return miscari;
        }

        public PictureBox getPicNearEmpty(string locatie)   // returneaza pictureboxul de langa patratul gol in functie de parametrul locatie ex: locatie = "dreapta" => se returneaza pictureboxul din dreapta patratului gol
        {
            return Puzzle.getPicNearEmpty(locatie, Setari.Dificultate);
        }

        public void efectuazaMiscare(int miscare)
        {
             switch (miscare)        // efectuam miscarea in memorie
                {
                    case 0: Puzzle.miscaLaStanga(Puzzle.getPicNearEmpty("dreapta", Setari.Dificultate),Setari.Dificultate); break;
                    case 1: Puzzle.miscaLaDreapta(Puzzle.getPicNearEmpty("stanga", Setari.Dificultate), Setari.Dificultate); break;
                    case 2: Puzzle.miscaInSus(Puzzle.getPicNearEmpty("jos", Setari.Dificultate), Setari.Dificultate); break;
                    case 3: Puzzle.miscaInJos(Puzzle.getPicNearEmpty("sus", Setari.Dificultate), Setari.Dificultate); break;
                }
        }

        public void reset()
        {
            Puzzle.reset(Setari.Dificultate);
        }

        public int getMiscare(PictureBox pic)
        {
            if (pic == getPicNearEmpty("dreapta"))
                return 0;

            if (pic == getPicNearEmpty("stanga"))
                return 1;

            if (pic == getPicNearEmpty("jos"))
                return 2;

            if (pic == getPicNearEmpty("sus"))
                return 3;

            return -1;
        }

        public void deschideSetari(UI ui)
        {
            Setari setari_ = new Setari(ui, this);
            setari_.ShowDialog();
        }

        public void deschideScoruri(UI ui)
        {
            View.Scoruri scoruri = new View.Scoruri(ui,this);
            scoruri.ShowDialog();
        }

        public bool isFinal()
        {
            return Puzzle.isFinal(Setari.Dificultate + 2);
        }

        public Image getImagineFromImaginiData(int i)
        {
            return Setari.ImgData[i];
        }

        public int getImagineIndex()
        {
            return Setari.getImageIndex();
        }

        public List<Model.Scor> getScoruri(int puzzle)
        {
            switch (puzzle)
            {
                case 3: return Scoruri[3];
                case 4: return Scoruri[4];
                case 5: return Scoruri[5];
                case 6: return Scoruri[6];
            }
            return null;
        }

        public void resetScor(int puzzle)
        {
            Scoruri.scoruriClear(puzzle);
        }
    }
}
