using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PuzzleGlisant.Model
{
    public class SetariData
    {
        private int dificultate;   // 1 = easy, 2 = medium, 3 = hard, 4 = insane
        private Image imagine;     // imaginea curenta folosita de catre puzzle
        private bool imageNumbers;  // daca puzzle-ul este setat pe imagine cu numere sau imagine peisaj
        private ImaginiData imgData;
        private string nume;

        public SetariData()
        {
            dificultate = 2;
            imageNumbers = true;
            imgData = new ImaginiData();
            imagine = imgData[6];
            nume = string.Empty;
        }

        public ImaginiData ImgData
        {
            get
            {
                return imgData;
            }
        }
        public bool ImageNumbers
        {
            get
            {
                return imageNumbers;
            }
            set
            {
                imageNumbers = value;
            }
        }
        public int Dificultate
        {
            get
            {
                return dificultate;
            }
            set
            {
                dificultate = value;
            }
        }

        public Image Imagine
        {
            get
            {
                return imagine;
            }
            set
            {
                imagine = value;
            }
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
        public int getImageIndex()
        {
            return imgData.getImageIndex(imagine);
        }
    }
}
