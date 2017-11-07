using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;


namespace PuzzleGlisant.Model
{
    public class Puzzle
    {
        private PictureBox[,] stareCurenta3x3;
        private PictureBox[,] stareCurenta4x4;
        private PictureBox[,] stareCurenta5x5;
        private PictureBox[,] stareCurenta6x6;
        private List<List<PictureBox>> listPicturebox;

        public Puzzle(List<PictureBox> pic3x3, List<PictureBox> pic4x4, List<PictureBox> pic5x5, List<PictureBox> pic6x6)
        {
            stareCurenta3x3 = new PictureBox[3, 3];
            stareCurenta4x4 = new PictureBox[4, 4];
            stareCurenta5x5 = new PictureBox[5, 5];
            stareCurenta6x6 = new PictureBox[6, 6];
            listPicturebox = new List<List<PictureBox>>();

            listPicturebox.Add(pic3x3);
            listPicturebox.Add(pic4x4);
            listPicturebox.Add(pic5x5);
            listPicturebox.Add(pic6x6);

            int index = 0;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    stareCurenta3x3[i, j] = pic3x3[index];
                    index++;
                }

            index = 0;

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    stareCurenta4x4[i, j] = pic4x4[index];
                    index++;
                }

            index = 0;

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    stareCurenta5x5[i, j] = pic5x5[index];
                    index++;
                }

            index = 0;

            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                {
                    stareCurenta6x6[i, j] = pic6x6[index];
                    index++;
                }
        }

        public PictureBox[,] this[int index]
        {
            get
            {
                switch (index)
                {
                    case 3: return stareCurenta3x3;
                    case 4: return stareCurenta4x4;
                    case 5: return stareCurenta5x5;
                    case 6: return stareCurenta6x6;
                }
                return null;
            }
            set
            {
                switch (index)
                {
                    case 3: stareCurenta3x3 = value; break;
                    case 4: stareCurenta4x4 = value; break;
                    case 5: stareCurenta5x5 = value; break;
                    case 6: stareCurenta6x6 = value; break;
                }
            }
        }

        public void miscaLaDreapta(PictureBox pic, int dificultate)
        {
            int lungime = dificultate + 2;  // ex: dificultate 3 = puzzle 5x5, deci lungime = 3+2 = 5
            bool done = false;
            PictureBox temp;

            for (int i = 0; i < lungime; i++)
            {
                for (int j = 0; j < lungime; j++)
                {
                    switch (dificultate)
                    {
                        case 1:
                            if (stareCurenta3x3[i, j] == pic)
                            {
                                temp = stareCurenta3x3[i, j];
                                stareCurenta3x3[i, j] = stareCurenta3x3[i, j + 1];
                                stareCurenta3x3[i, j + 1] = temp;
                                done = true;
                            }
                            break;
                        case 2:
                            if (stareCurenta4x4[i, j] == pic)
                            {
                                temp = stareCurenta4x4[i, j];
                                stareCurenta4x4[i, j] = stareCurenta4x4[i, j + 1];
                                stareCurenta4x4[i, j + 1] = temp;
                                done = true;
                            }
                            break;

                        case 3:
                            if (stareCurenta5x5[i, j] == pic)
                            {
                                temp = stareCurenta5x5[i, j];
                                stareCurenta5x5[i, j] = stareCurenta5x5[i, j + 1];
                                stareCurenta5x5[i, j + 1] = temp;
                                done = true;
                            }
                            break;

                        case 4:
                            if (stareCurenta6x6[i, j] == pic)
                            {
                                temp = stareCurenta6x6[i, j];
                                stareCurenta6x6[i, j] = stareCurenta6x6[i, j + 1];
                                stareCurenta6x6[i, j + 1] = temp;
                                done = true;
                            }
                            break;
                    }
                    if (done)
                        break;
                }
                if (done)
                    break;
            }
        }

        public void miscaLaStanga(PictureBox pic, int dificultate)
        {
            int lungime = dificultate + 2;  // ex: dificultate 3 = puzzle 5x5, deci lungime = 3+2 = 5
            bool done = false;
            PictureBox temp;

            for (int i = 0; i < lungime; i++)
            {
                for (int j = 0; j < lungime; j++)
                {
                    switch (dificultate)
                    {
                        case 1:
                            if (stareCurenta3x3[i, j] == pic)
                            {
                                temp = stareCurenta3x3[i, j];
                                stareCurenta3x3[i, j] = stareCurenta3x3[i, j - 1];
                                stareCurenta3x3[i, j - 1] = temp;
                                done = true;
                            }
                            break;
                        case 2:
                            if (stareCurenta4x4[i, j] == pic)
                            {
                                temp = stareCurenta4x4[i, j];
                                stareCurenta4x4[i, j] = stareCurenta4x4[i, j - 1];
                                stareCurenta4x4[i, j - 1] = temp;
                                done = true;
                            }
                            break;

                        case 3:
                            if (stareCurenta5x5[i, j] == pic)
                            {
                                temp = stareCurenta5x5[i, j];
                                stareCurenta5x5[i, j] = stareCurenta5x5[i, j - 1];
                                stareCurenta5x5[i, j - 1] = temp;
                                done = true;
                            }
                            break;

                        case 4:
                            if (stareCurenta6x6[i, j] == pic)
                            {
                                temp = stareCurenta6x6[i, j];
                                stareCurenta6x6[i, j] = stareCurenta6x6[i, j - 1];
                                stareCurenta6x6[i, j - 1] = temp;
                                done = true;
                            }
                            break;
                    }
                    if (done)
                        break;
                }
                if (done)
                    break;
            }
        }

        public void miscaInSus(PictureBox pic, int dificultate)
        {
            int lungime = dificultate + 2;  // ex: dificultate 3 = puzzle 5x5, deci lungime = 3+2 = 5
            bool done = false;
            PictureBox temp;

            for (int i = 0; i < lungime; i++)
            {
                for (int j = 0; j < lungime; j++)
                {
                    switch (dificultate)
                    {
                        case 1:
                            if (stareCurenta3x3[i, j] == pic)
                            {
                                temp = stareCurenta3x3[i, j];
                                stareCurenta3x3[i, j] = stareCurenta3x3[i - 1, j];
                                stareCurenta3x3[i - 1, j] = temp;
                                done = true;
                            }
                            break;
                        case 2:
                            if (stareCurenta4x4[i, j] == pic)
                            {
                                temp = stareCurenta4x4[i, j];
                                stareCurenta4x4[i, j] = stareCurenta4x4[i - 1, j];
                                stareCurenta4x4[i - 1, j] = temp;
                                done = true;
                            }
                            break;

                        case 3:
                            if (stareCurenta5x5[i, j] == pic)
                            {
                                temp = stareCurenta5x5[i, j];
                                stareCurenta5x5[i, j] = stareCurenta5x5[i - 1, j];
                                stareCurenta5x5[i - 1, j] = temp;
                                done = true;
                            }
                            break;

                        case 4:
                            if (stareCurenta6x6[i, j] == pic)
                            {
                                temp = stareCurenta6x6[i, j];
                                stareCurenta6x6[i, j] = stareCurenta6x6[i - 1, j];
                                stareCurenta6x6[i - 1, j] = temp;
                                done = true;
                            }
                            break;
                    }

                    if (done)
                        break;
                }

                if (done)
                    break;
            }
        }

        public void miscaInJos(PictureBox pic, int dificultate)
        {
            int lungime = dificultate + 2;  // ex: dificultate 3 = puzzle 5x5, deci lungime = 3+2 = 5
            bool done = false;
            PictureBox temp;

            for (int i = 0; i < lungime; i++)
            {
                for (int j = 0; j < lungime; j++)
                {
                    switch (dificultate)
                    {
                        case 1:
                            if (stareCurenta3x3[i, j] == pic)
                            {
                                temp = stareCurenta3x3[i, j];
                                stareCurenta3x3[i, j] = stareCurenta3x3[i + 1, j];
                                stareCurenta3x3[i + 1, j] = temp;
                                done = true;
                            }
                            break;
                        case 2:
                            if (stareCurenta4x4[i, j] == pic)
                            {
                                temp = stareCurenta4x4[i, j];
                                stareCurenta4x4[i, j] = stareCurenta4x4[i + 1, j];
                                stareCurenta4x4[i + 1, j] = temp;
                                done = true;
                            }
                            break;

                        case 3:
                            if (stareCurenta5x5[i, j] == pic)
                            {
                                temp = stareCurenta5x5[i, j];
                                stareCurenta5x5[i, j] = stareCurenta5x5[i + 1, j];
                                stareCurenta5x5[i + 1, j] = temp;
                                done = true;
                            }
                            break;

                        case 4:
                            if (stareCurenta6x6[i, j] == pic)
                            {
                                temp = stareCurenta6x6[i, j];
                                stareCurenta6x6[i, j] = stareCurenta6x6[i + 1, j];
                                stareCurenta6x6[i + 1, j] = temp;
                                done = true;
                            }
                            break;
                    }

                    if (done)
                        break;
                }

                if (done)
                    break;
            }
        }

        public int getEmptyIJ(int tipPuzzle, int tipCoordonata)
        {
            ///<summary>
            ///<para>tipPuzzle = (3,4,5,6)
            ///<para>tipCoordonata = (1=i,2=j)</para>
            ///</summary>

          for(int i =0;i<tipPuzzle;i++)
              for(int j =0;j<tipPuzzle;j++)
                  switch (tipPuzzle)
                  {
                      case 3:
                          if (stareCurenta3x3[i, j].Name == "picEasy9")
                              if (tipCoordonata == 1)
                                  return i;
                              else
                                  return j;
                          break;

                      case 4:
                          if (stareCurenta4x4[i, j].Name == "picMedium16")
                              if (tipCoordonata == 1)
                                  return i;
                              else 
                                  return j;
                          break;

                      case 5:
                          if (stareCurenta5x5[i, j].Name == "picHard25")
                              if (tipCoordonata == 1)
                                  return i;
                              else
                                  return j;
                          break;

                      case 6:
                          if (stareCurenta6x6[i, j].Name == "picInsane36")
                              if (tipCoordonata == 1)
                                  return i;
                              else
                                  return j;
                          break;
                  }

          return 0;
        }

        public PictureBox getPicNearEmpty(string locatie, int dificultate)
        {
            for (int i = 0; i < dificultate+2; i++)
                for (int j = 0; j < dificultate+2; j++)
                    switch (dificultate)
                    {
                        case 1:
                            if (stareCurenta3x3[i, j].Name == "picEasy9")
                                switch (locatie)
                                {
                                    case "stanga":
                                        if (j > 0)
                                            return stareCurenta3x3[i, j - 1];
                                        else
                                            return null;
                                    case "dreapta":
                                        if (j < 2)
                                            return stareCurenta3x3[i, j + 1];
                                        else
                                            return null;
                                    case "sus":
                                        if (i > 0)
                                            return stareCurenta3x3[i - 1, j];
                                        else
                                            return null;
                                    case "jos":
                                        if (i < 2)
                                            return stareCurenta3x3[i + 1, j];
                                        else
                                            return null;
                                }
                            break;

                        case 2:
                            if (stareCurenta4x4[i, j].Name == "picMedium16")
                                switch (locatie)
                                {
                                    case "stanga":
                                        if (j > 0)
                                            return stareCurenta4x4[i, j - 1];
                                        else
                                            return null;
                                    case "dreapta":
                                        if (j < 3)
                                            return stareCurenta4x4[i, j + 1];
                                        else
                                            return null;
                                    case "sus":
                                        if (i > 0)
                                            return stareCurenta4x4[i - 1, j];
                                        else
                                            return null;
                                    case "jos":
                                        if (i < 3)
                                            return stareCurenta4x4[i + 1, j];
                                        else
                                            return null;
                                }
                            break;

                        case 3:
                            if (stareCurenta5x5[i, j].Name == "picHard25")
                                switch (locatie)
                                {
                                    case "stanga":
                                        if (j > 0)
                                            return stareCurenta5x5[i, j - 1];
                                        else
                                            return null;
                                    case "dreapta":
                                        if (j < 4)
                                            return stareCurenta5x5[i, j + 1];
                                        else
                                            return null;
                                    case "sus":
                                        if (i > 0)
                                            return stareCurenta5x5[i - 1, j];
                                        else
                                            return null;
                                    case "jos":
                                        if (i < 4)
                                            return stareCurenta5x5[i + 1, j];
                                        else
                                            return null;
                                }
                            break;

                        case 4:
                            if (stareCurenta6x6[i, j].Name == "picInsane36")
                                switch (locatie)
                                {
                                    case "stanga":
                                        if (j > 0)
                                            return stareCurenta6x6[i, j - 1];
                                        else
                                            return null;
                                    case "dreapta":
                                        if (j < 5)
                                            return stareCurenta6x6[i, j + 1];
                                        else
                                            return null;
                                    case "sus":
                                        if (i > 0)
                                            return stareCurenta6x6[i - 1, j];
                                        else
                                            return null;
                                    case "jos":
                                        if (i < 5)
                                            return stareCurenta6x6[i + 1, j];
                                        else
                                            return null;
                                }
                            break;
                    }

            return null;
        }

        public void reset(int dificultate)
        {
            int index = 0;
            switch (dificultate)
            {
                case 1:
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                        {
                            stareCurenta3x3[i, j] = listPicturebox[0][index];
                            index++;
                        } 
                        break;
                case 2: 
                    for (int i = 0; i < 4; i++)
                        for (int j = 0; j < 4; j++)
                        {
                            stareCurenta4x4[i, j] = listPicturebox[1][index];
                            index++;
                        } 
                        break;
                case 3: 
                    for (int i = 0; i < 5; i++)
                        for (int j = 0; j < 5; j++)
                        {
                            stareCurenta5x5[i, j] = listPicturebox[2][index];
                            index++;
                        } 
                        break;
                case 4: 
                    for (int i = 0; i < 6; i++)
                        for (int j = 0; j < 6; j++)
                        {
                            stareCurenta6x6[i, j] = listPicturebox[3][index];
                            index++;
                        } 
                        break;
            }
        }

        public bool isFinal(int tipPuzzle)
        {
            int index = 0;
            switch (tipPuzzle)
            {
                case 3:
               for(int i =0;i<3;i++)
                   for (int j = 0; j < 3; j++)
                   {
                       if (stareCurenta3x3[i, j].Name != listPicturebox[0][index].Name)
                           return false;
                       index++;
                   }
                    break;
                case 4:
                    for (int i = 0; i < 4; i++)
                        for (int j = 0; j < 4; j++)
                        {
                            if (stareCurenta4x4[i, j].Name != listPicturebox[1][index].Name)
                                return false;
                            index++;
                        }
                    break;
                case 5:
                    for (int i = 0; i < 5; i++)
                        for (int j = 0; j < 5; j++)
                        {
                            if (stareCurenta5x5[i, j].Name != listPicturebox[2][index].Name)
                                return false;
                            index++;
                        }
                    break;
                case 6:
                    for (int i = 0; i < 6; i++)
                        for (int j = 0; j < 6; j++)
                        {
                            if (stareCurenta6x6[i, j].Name != listPicturebox[3][index].Name)
                                return false;
                            index++;
                        }
                    break;
            }
            return true;
        }
    }
}
