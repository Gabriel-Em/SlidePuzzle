using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PuzzleGlisant.Model
{
    public class ImaginiData
    {

        private List<Image> Imagini;

        public ImaginiData()
        {
            Imagini = new List<Image>() {
                PuzzleGlisant.Properties.Resources.Earth,
                PuzzleGlisant.Properties.Resources.SportsCar,
                PuzzleGlisant.Properties.Resources.Dices,
                PuzzleGlisant.Properties.Resources.Pyramids,
                PuzzleGlisant.Properties.Resources.Tiger,
                PuzzleGlisant.Properties.Resources.Numbers3x3,
                PuzzleGlisant.Properties.Resources.Numbers4x4,
                PuzzleGlisant.Properties.Resources.Numbers5x5,
                PuzzleGlisant.Properties.Resources.Numbers6x6};
        }

        public Image this[int index]
        {
            get
            {
                return Imagini[index];
            }
        }

        public int getImageIndex(Image img)
        {
            for (int i = 0; i < Imagini.Count(); i++)
                if (Imagini[i] == img)
                    return i;

            return -1;
        }
    }
}
