using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;

namespace PuzzleGlisant
{
    public partial class UI : Form
    {
        private Controller.Controller controller;
        private PictureBox toAnimate;   // picturebox-ul care trebuie folosit de catre timer-ul responsabil cu animatia de miscare
        private List<int> Miscari;      // lista miscarilor folosite la animatia amestecarii
        private int animationCounter;   // picturebox-urile se misca intr-o directie cu pixeli pixeli odata la 10 milisecunde de animationCounterLimit ori
        private int pixeli;             // numarul de pixeli cu care-si schimba locatia picturebox-ul toAnimate (in functie de dificultate)
        private int animationCounterLimit; // numarul de location changes pe care il suporta picturebox-ul toAnimate in functie de dificultate;
        private Stopwatch objStopWatch;     // timerul jocului
        private bool gameState;         // true daca jocul e in desfasurare, false altfel
        int nrMiscari;                  // numarul de miscari facute in timpul rezolvarii puzzle-ului

        public UI()
        {
            InitializeComponent();

            CenterToScreen();

            toAnimate = new PictureBox();
            Miscari = new List<int>();
            objStopWatch = new Stopwatch();
            gameState = false;
            nrMiscari = 0;

            controller = new Controller.Controller(
                new List<PictureBox>() { picEasy1, picEasy2, picEasy3, picEasy4, picEasy5, picEasy6, picEasy7, picEasy8, picEasy9 },
                new List<PictureBox>() { picMedium1, picMedium2, picMedium3, picMedium4, picMedium5, picMedium6, picMedium7, picMedium8, picMedium9, picMedium10, picMedium11, picMedium12, picMedium13, picMedium14, picMedium15, picMedium16 },
                new List<PictureBox>() { picHard1, picHard2, picHard3, picHard4, picHard5, picHard6, picHard7, picHard8, picHard9, picHard10, picHard11, picHard12, picHard13, picHard14, picHard15, picHard16, picHard17, picHard18, picHard19, picHard20, picHard21, picHard22, picHard23, picHard24, picHard25 },
                new List<PictureBox>() { picInsane1, picInsane2, picInsane3, picInsane4, picInsane5, picInsane6, picInsane7, picInsane8, picInsane9, picInsane10, picInsane11, picInsane12, picInsane13, picInsane14, picInsane15, picInsane16, picInsane17, picInsane18, picInsane19, picInsane20, picInsane21, picInsane22, picInsane23, picInsane24, picInsane25, picInsane26, picInsane27, picInsane28, picInsane29, picInsane30, picInsane31, picInsane32, picInsane33, picInsane34, picInsane35, picInsane36 });

            setImageToTiles(controller.getImage());
            setPreview(controller.getImage());
        }

        private static Image cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
            return (Image)(bmpCrop);
        }

        private void setImageToTiles(Image pic)
        {
            switch (controller.getDificultate())
            {
                case 1:
                    picEasy1.BackgroundImage = cropImage(pic, new Rectangle(1, 1, 178, 178));
                    picEasy2.BackgroundImage = cropImage(pic, new Rectangle(181, 1, 178, 178));
                    picEasy3.BackgroundImage = cropImage(pic, new Rectangle(361, 1, 178, 178));

                    picEasy4.BackgroundImage = cropImage(pic, new Rectangle(1, 181, 178, 178));
                    picEasy5.BackgroundImage = cropImage(pic, new Rectangle(181, 181, 178, 178));
                    picEasy6.BackgroundImage = cropImage(pic, new Rectangle(361, 181, 178, 178));

                    picEasy7.BackgroundImage = cropImage(pic, new Rectangle(1, 361, 178, 178));
                    picEasy8.BackgroundImage = cropImage(pic, new Rectangle(181, 361, 178, 178));
                    picEasy9.BackgroundImage = cropImage(pic, new Rectangle(361, 361, 178, 178));
                    break;
                case 2:
                    picMedium1.BackgroundImage = cropImage(pic, new Rectangle(1, 1, 133, 133));
                    picMedium2.BackgroundImage = cropImage(pic, new Rectangle(136, 1, 133, 133));
                    picMedium3.BackgroundImage = cropImage(pic, new Rectangle(271, 1, 133, 133));
                    picMedium4.BackgroundImage = cropImage(pic, new Rectangle(406, 1, 133, 133));

                    picMedium5.BackgroundImage = cropImage(pic, new Rectangle(1, 136, 133, 133));
                    picMedium6.BackgroundImage = cropImage(pic, new Rectangle(136, 136, 133, 133));
                    picMedium7.BackgroundImage = cropImage(pic, new Rectangle(271, 136, 133, 133));
                    picMedium8.BackgroundImage = cropImage(pic, new Rectangle(406, 136, 133, 133));

                    picMedium9.BackgroundImage = cropImage(pic, new Rectangle(1, 271, 133, 133));
                    picMedium10.BackgroundImage = cropImage(pic, new Rectangle(136, 271, 133, 133));
                    picMedium11.BackgroundImage = cropImage(pic, new Rectangle(271, 271, 133, 133));
                    picMedium12.BackgroundImage = cropImage(pic, new Rectangle(406, 271, 133, 133));

                    picMedium13.BackgroundImage = cropImage(pic, new Rectangle(1, 406, 133, 133));
                    picMedium14.BackgroundImage = cropImage(pic, new Rectangle(136, 406, 133, 133));
                    picMedium15.BackgroundImage = cropImage(pic, new Rectangle(271, 406, 133, 133));
                    picMedium16.BackgroundImage = cropImage(pic, new Rectangle(406, 406, 133, 133));
                    break;
                case 3:
                    picHard1.BackgroundImage = cropImage(pic, new Rectangle(1, 1, 106, 106));
                    picHard2.BackgroundImage = cropImage(pic, new Rectangle(109, 1, 106, 106));
                    picHard3.BackgroundImage = cropImage(pic, new Rectangle(217, 1, 106, 106));
                    picHard4.BackgroundImage = cropImage(pic, new Rectangle(325, 1, 106, 106));
                    picHard5.BackgroundImage = cropImage(pic, new Rectangle(433, 1, 106, 106));

                    picHard6.BackgroundImage = cropImage(pic, new Rectangle(1, 109, 106, 106));
                    picHard7.BackgroundImage = cropImage(pic, new Rectangle(109, 109, 106, 106));
                    picHard8.BackgroundImage = cropImage(pic, new Rectangle(217, 109, 106, 106));
                    picHard9.BackgroundImage = cropImage(pic, new Rectangle(325, 109, 106, 106));
                    picHard10.BackgroundImage = cropImage(pic, new Rectangle(433, 109, 106, 106));

                    picHard11.BackgroundImage = cropImage(pic, new Rectangle(1, 217, 106, 106));
                    picHard12.BackgroundImage = cropImage(pic, new Rectangle(109, 217, 106, 106));
                    picHard13.BackgroundImage = cropImage(pic, new Rectangle(217, 217, 106, 106));
                    picHard14.BackgroundImage = cropImage(pic, new Rectangle(325, 217, 106, 106));
                    picHard15.BackgroundImage = cropImage(pic, new Rectangle(433, 217, 106, 106));

                    picHard16.BackgroundImage = cropImage(pic, new Rectangle(1, 325, 106, 106));
                    picHard17.BackgroundImage = cropImage(pic, new Rectangle(109, 325, 106, 106));
                    picHard18.BackgroundImage = cropImage(pic, new Rectangle(217, 325, 106, 106));
                    picHard19.BackgroundImage = cropImage(pic, new Rectangle(325, 325, 106, 106));
                    picHard20.BackgroundImage = cropImage(pic, new Rectangle(433, 325, 106, 106));

                    picHard21.BackgroundImage = cropImage(pic, new Rectangle(1, 433, 106, 106));
                    picHard22.BackgroundImage = cropImage(pic, new Rectangle(109, 433, 106, 106));
                    picHard23.BackgroundImage = cropImage(pic, new Rectangle(217, 433, 106, 106));
                    picHard24.BackgroundImage = cropImage(pic, new Rectangle(325, 433, 106, 106));
                    picHard25.BackgroundImage = cropImage(pic, new Rectangle(433, 433, 106, 106));
                    break;
                case 4:
                          picInsane1.BackgroundImage = cropImage(pic, new Rectangle(1, 1, 88, 88));
                          picInsane2.BackgroundImage = cropImage(pic, new Rectangle(91, 1, 88, 88));
                          picInsane3.BackgroundImage = cropImage(pic, new Rectangle(181, 1, 88, 88));
                          picInsane4.BackgroundImage = cropImage(pic, new Rectangle(271, 1, 88, 88));
                          picInsane5.BackgroundImage = cropImage(pic, new Rectangle(361, 1, 88, 88));
                          picInsane6.BackgroundImage = cropImage(pic, new Rectangle(451, 1, 88, 88));

                          picInsane7.BackgroundImage = cropImage(pic, new Rectangle(1, 91, 88, 88));
                          picInsane8.BackgroundImage = cropImage(pic, new Rectangle(91, 91, 88, 88));
                          picInsane9.BackgroundImage = cropImage(pic, new Rectangle(181, 91, 88, 88));
                          picInsane10.BackgroundImage = cropImage(pic, new Rectangle(271, 91, 88, 88));
                          picInsane11.BackgroundImage = cropImage(pic, new Rectangle(361, 91, 88, 88));
                          picInsane12.BackgroundImage = cropImage(pic, new Rectangle(451, 91, 88, 88));

                          picInsane13.BackgroundImage = cropImage(pic, new Rectangle(1, 181, 88, 88));
                          picInsane14.BackgroundImage = cropImage(pic, new Rectangle(91, 181, 88, 88));
                          picInsane15.BackgroundImage = cropImage(pic, new Rectangle(181, 181, 88, 88));
                          picInsane16.BackgroundImage = cropImage(pic, new Rectangle(271, 181, 88, 88));
                          picInsane17.BackgroundImage = cropImage(pic, new Rectangle(361, 181, 88, 88));
                          picInsane18.BackgroundImage = cropImage(pic, new Rectangle(451, 181, 88, 88));

                          picInsane19.BackgroundImage = cropImage(pic, new Rectangle(1, 271, 88, 88));
                          picInsane20.BackgroundImage = cropImage(pic, new Rectangle(91, 271, 88, 88));
                          picInsane21.BackgroundImage = cropImage(pic, new Rectangle(181, 271, 88, 88));
                          picInsane22.BackgroundImage = cropImage(pic, new Rectangle(271, 271, 88, 88));
                          picInsane23.BackgroundImage = cropImage(pic, new Rectangle(361, 271, 88, 88));
                          picInsane24.BackgroundImage = cropImage(pic, new Rectangle(451, 271, 88, 88));

                          picInsane25.BackgroundImage = cropImage(pic, new Rectangle(1, 361, 88, 88));
                          picInsane26.BackgroundImage = cropImage(pic, new Rectangle(91, 361, 88, 88));
                          picInsane27.BackgroundImage = cropImage(pic, new Rectangle(181, 361, 88, 88));
                          picInsane28.BackgroundImage = cropImage(pic, new Rectangle(271, 361, 88, 88));
                          picInsane29.BackgroundImage = cropImage(pic, new Rectangle(361, 361, 88, 88));
                          picInsane30.BackgroundImage = cropImage(pic, new Rectangle(451, 361, 88, 88));

                          picInsane31.BackgroundImage = cropImage(pic, new Rectangle(1, 451, 88, 88));
                          picInsane32.BackgroundImage = cropImage(pic, new Rectangle(91, 451, 88, 88));
                          picInsane33.BackgroundImage = cropImage(pic, new Rectangle(181, 451, 88, 88));
                          picInsane34.BackgroundImage = cropImage(pic, new Rectangle(271, 451, 88, 88));
                          picInsane35.BackgroundImage = cropImage(pic, new Rectangle(361, 451, 88, 88));
                          picInsane36.BackgroundImage = cropImage(pic, new Rectangle(451, 451, 88, 88));
                    break;
            }
        }

        private void setPreview(Image img)
        {
            picPreview.BackgroundImage = img;
        }

        private void timerShuffle_Tick(object sender, EventArgs e)
        {
            if (!timerMoveAnimation.Enabled)
                if (Miscari.Count > 0)                // cat timp mai exista miscari de animat
                {
                    switch (Miscari[0])
                    {
                        case 0:
                            toAnimate = controller.getPicNearEmpty("dreapta");
                            controller.efectuazaMiscare(0);
                            animationCounter = 0;
                            timerMoveAnimation.Enabled = true;
                            break;

                        case 1:
                            toAnimate = controller.getPicNearEmpty("stanga");
                            animationCounter = 0;
                            controller.efectuazaMiscare(1);
                            timerMoveAnimation.Enabled = true;
                            break;

                        case 2:
                            toAnimate = controller.getPicNearEmpty("jos");
                            animationCounter = 0;
                            controller.efectuazaMiscare(2);
                            timerMoveAnimation.Enabled = true;
                            break;

                        case 3:
                            toAnimate = controller.getPicNearEmpty("sus");
                            animationCounter = 0;
                            controller.efectuazaMiscare(3);
                            timerMoveAnimation.Enabled = true;
                            break;
                    }
                }
                else
                {
                    timerShuffle.Enabled = false;
                    picJocNou.Enabled = true;
                    picJocNou.BackgroundImage = PuzzleGlisant.Properties.Resources.picJocNouNormal;
                    picReset.Enabled = true;
                    picReset.BackgroundImage = PuzzleGlisant.Properties.Resources.picResetNormal;
                    picSetari.Enabled = true;
                    picSetari.BackgroundImage = PuzzleGlisant.Properties.Resources.picSetariNormal;
                    gameState = true;
                }
        }

        private void timerMoveAnimation_Tick(object sender, EventArgs e)
        {
            if (animationCounter < animationCounterLimit)
                switch (Miscari[0])
                {
                    case 0: toAnimate.Location = new Point(toAnimate.Location.X - pixeli, toAnimate.Location.Y); animationCounter++; break;
                    case 1: toAnimate.Location = new Point(toAnimate.Location.X + pixeli, toAnimate.Location.Y); animationCounter++; break;
                    case 2: toAnimate.Location = new Point(toAnimate.Location.X, toAnimate.Location.Y - pixeli); animationCounter++; break;
                    case 3: toAnimate.Location = new Point(toAnimate.Location.X, toAnimate.Location.Y + pixeli); animationCounter++; break;
                }
            else
            {
                if (gameState)
                if (controller.isFinal())
                {
                    objStopWatch.Stop();
                    Timp.Enabled = false;
                    gameState = false;

                    controller.addScor(new Model.Scor(controller.getNume(), nrMiscari, lblTimp.Text));

                    picPauza.Enabled = false;
                    picReset.Enabled = false;
                    picPauza.BackgroundImage = PuzzleGlisant.Properties.Resources.picPauzaDisabled;
                    picReset.BackgroundImage = PuzzleGlisant.Properties.Resources.picResetDisabled;

                    switch (controller.getDificultate())
                    {
                        case 1: picEasy9.Visible = true; break;
                        case 2: picMedium16.Visible = true; break;
                        case 3: picHard25.Visible = true; break;
                        case 4: picInsane36.Visible = true; break;
                    }
                }
                Miscari.RemoveAt(0);
                timerMoveAnimation.Enabled = false;
                if(controller.isFinal())
                    MessageBox.Show("Felicitari " + controller.getNume() + ", ai reusit sa rezolvi puzzle-ul in " + lblTimp.Text + " cu " + nrMiscari + " miscari!");
            }
        }

        private void executaMiscare_Click(object sender, EventArgs e)
        {
            if (gameState)
                if (!timerMoveAnimation.Enabled)
                    if (controller.getMiscare((PictureBox)sender) != -1)   // daca miscarea e valida
                    {
                        nrMiscari++;
                        lblMiscari.Text = nrMiscari.ToString();

                        if (!gameState)
                            gameState = true;

                        if (!objStopWatch.IsRunning)
                        {
                            Timp.Enabled = true;
                            objStopWatch.Start();
                        }

                        if (!picPauza.Enabled)
                        {
                            picPauza.Enabled = true;
                            picPauza.BackgroundImage = PuzzleGlisant.Properties.Resources.picPauzaNormal;
                        }

                        switch (controller.getMiscare((PictureBox)sender))
                        {
                            case -1:    // miscare invalida
                                break;
                            case 0:     // miscare valida spre stanga
                                toAnimate = (PictureBox)sender;
                                Miscari.Add(0);
                                animationCounter = 0;
                                controller.efectuazaMiscare(0);
                                timerMoveAnimation.Enabled = true;
                                break;

                            case 1:     // miscare valida spre stanga
                                toAnimate = (PictureBox)sender;
                                Miscari.Add(1);
                                animationCounter = 0;
                                controller.efectuazaMiscare(1);
                                timerMoveAnimation.Enabled = true;
                                break;

                            case 2:     // miscare valida spre stanga
                                toAnimate = (PictureBox)sender;
                                Miscari.Add(2);
                                animationCounter = 0;
                                controller.efectuazaMiscare(2);
                                timerMoveAnimation.Enabled = true;
                                break;

                            case 3:
                                toAnimate = (PictureBox)sender;
                                Miscari.Add(3);
                                animationCounter = 0;
                                controller.efectuazaMiscare(3);
                                timerMoveAnimation.Enabled = true;
                                break;
                        }
                    }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (objStopWatch.IsRunning)
            {
                TimeSpan objTimeSpan = TimeSpan.FromMilliseconds(objStopWatch.ElapsedMilliseconds);
                lblTimp.Text = String.Format(CultureInfo.CurrentCulture, "{0:00}:{1:00}:{2:00}", objTimeSpan.Minutes, objTimeSpan.Seconds, objTimeSpan.Milliseconds / 10);
            }
        }

        public void setariModificaDificultate()
        {
            switch (controller.getDificultate())
            {
                case 1: 
                    panelEasy.Visible = true;
                    panelMedium.Visible = false;
                    panelHard.Visible = false;
                    panelInsane.Visible = false;

                    break;

                case 2: 
                    panelMedium.Visible = true;
                    panelEasy.Visible = false;
                    panelHard.Visible = false;
                    panelInsane.Visible = false;

                    break;

                case 3: 
                    panelHard.Visible = true; 
                    panelEasy.Visible = false;
                    panelMedium.Visible = false;
                    panelInsane.Visible = false;

                    break;

                case 4: 
                    panelInsane.Visible = true; 
                    panelEasy.Visible = false;
                    panelMedium.Visible = false;
                    panelHard.Visible = false;

                    break;
            }
            setImageToTiles(controller.getImage());
            Reset();
        }
        public void setariModificaImagine()
        {
            setImageToTiles(controller.getImage());
            setPreview(controller.getImage() );
        }

        private void Reset()
        {
            Timp.Enabled = false;
            objStopWatch.Reset();
            lblTimp.Text = "00:00:00";
            nrMiscari = 0;
            lblMiscari.Text = "0";
            gameState = false;
            
            if (picContinua.Visible)
            {
                picContinua.Visible = false;
                picPauza.Visible = true;
            }

            if (picPauza_.Visible)
                picPauza_.Visible = false;

            picReset.Enabled = false;
            picReset.BackgroundImage = PuzzleGlisant.Properties.Resources.picResetDisabled;

            if (picPauza.Enabled)
            {
                picPauza.Enabled = false;
                picPauza.BackgroundImage = PuzzleGlisant.Properties.Resources.picPauzaDisabled;
            }

            controller.reset();

            switch (controller.getDificultate())
            {
                case 1:
                    picEasy1.Location = new Point(0, 0);
                    picEasy2.Location = new Point(180, 0);
                    picEasy3.Location = new Point(360, 0);

                    picEasy4.Location = new Point(0, 180);
                    picEasy5.Location = new Point(180, 180);
                    picEasy6.Location = new Point(360, 180);

                    picEasy7.Location = new Point(0, 360);
                    picEasy8.Location = new Point(180, 360);
                    picEasy9.Visible = true;

                    break;

                case 2:
                    picMedium1.Location = new Point(0, 0);
                    picMedium2.Location = new Point(135, 0);
                    picMedium3.Location = new Point(270, 0);
                    picMedium4.Location = new Point(405, 0);

                    picMedium5.Location = new Point(0, 135);
                    picMedium6.Location = new Point(135, 135);
                    picMedium7.Location = new Point(270, 135);
                    picMedium8.Location = new Point(405, 135);

                    picMedium9.Location = new Point(0, 270);
                    picMedium10.Location = new Point(135, 270);
                    picMedium11.Location = new Point(270, 270);
                    picMedium12.Location = new Point(405, 270);

                    picMedium13.Location = new Point(0, 405);
                    picMedium14.Location = new Point(135, 405);
                    picMedium15.Location = new Point(270, 405);
                    picMedium16.Visible = true;

                    break;

                case 3:
                    picHard1.Location = new Point(0, 0);
                    picHard2.Location = new Point(108, 0);
                    picHard3.Location = new Point(216, 0);
                    picHard4.Location = new Point(324, 0);
                    picHard5.Location = new Point(432, 0);

                    picHard6.Location = new Point(0, 108);
                    picHard7.Location = new Point(108, 108);
                    picHard8.Location = new Point(216, 108);
                    picHard9.Location = new Point(324, 108);
                    picHard10.Location = new Point(432, 108);

                    picHard11.Location = new Point(0, 216);
                    picHard12.Location = new Point(108, 216);
                    picHard13.Location = new Point(216, 216);
                    picHard14.Location = new Point(324, 216);
                    picHard15.Location = new Point(432, 216);

                    picHard16.Location = new Point(0, 324);
                    picHard17.Location = new Point(108, 324);
                    picHard18.Location = new Point(216, 324);
                    picHard19.Location = new Point(324, 324);
                    picHard20.Location = new Point(432, 324);

                    picHard21.Location = new Point(0, 432);
                    picHard22.Location = new Point(108, 432);
                    picHard23.Location = new Point(216, 432);
                    picHard24.Location = new Point(324, 432);
                    picHard25.Visible = true;

                    break;

                case 4:
                    picInsane1.Location = new Point(0, 0);
                    picInsane2.Location = new Point(90, 0);
                    picInsane3.Location = new Point(180, 0);
                    picInsane4.Location = new Point(270, 0);
                    picInsane5.Location = new Point(360, 0);
                    picInsane6.Location = new Point(450, 0);

                    picInsane7.Location = new Point(0, 90);
                    picInsane8.Location = new Point(90, 90);
                    picInsane9.Location = new Point(180, 90);
                    picInsane10.Location = new Point(270, 90);
                    picInsane11.Location = new Point(360, 90);
                    picInsane12.Location = new Point(450, 90);

                    picInsane13.Location = new Point(0, 180);
                    picInsane14.Location = new Point(90, 180);
                    picInsane15.Location = new Point(180, 180);
                    picInsane16.Location = new Point(270, 180);
                    picInsane17.Location = new Point(360, 180);
                    picInsane18.Location = new Point(450, 180);

                    picInsane19.Location = new Point(0, 270);
                    picInsane20.Location = new Point(90, 270);
                    picInsane21.Location = new Point(180, 270);
                    picInsane22.Location = new Point(270, 270);
                    picInsane23.Location = new Point(360, 270);
                    picInsane24.Location = new Point(450, 270);

                    picInsane25.Location = new Point(0, 360);
                    picInsane26.Location = new Point(90, 360);
                    picInsane27.Location = new Point(180, 360);
                    picInsane28.Location = new Point(270, 360);
                    picInsane29.Location = new Point(360, 360);
                    picInsane30.Location = new Point(450, 360);

                    picInsane31.Location = new Point(0, 450);
                    picInsane32.Location = new Point(90, 450);
                    picInsane33.Location = new Point(180, 450);
                    picInsane34.Location = new Point(270, 450);
                    picInsane35.Location = new Point(360, 450);
                    picInsane36.Visible = true;

                    break;
            }
        }

        private void picJocNou_Click(object sender, EventArgs e)
        {
            picJocNou.Enabled = false;
            picJocNou.BackgroundImage = PuzzleGlisant.Properties.Resources.picJocNouDisabled;
            picReset.Enabled = false;
            picReset.BackgroundImage = PuzzleGlisant.Properties.Resources.picResetDisabled;
            picPauza.Enabled = false;
            picPauza.BackgroundImage = PuzzleGlisant.Properties.Resources.picPauzaDisabled;
            picSetari.Enabled = false;
            picSetari.BackgroundImage = PuzzleGlisant.Properties.Resources.picSetariDisabled;
            gameState = false;
            picPauza_.Visible = false;
            if (picContinua.Visible)
            {
                picContinua.Visible = false;
                picPauza.Visible = true;
            }
            lblTimp.Text = "00:00:00";
            lblMiscari.Text = "0";
            nrMiscari = 0;
            objStopWatch.Reset();

            switch (controller.getDificultate())
            {
                case 1: picEasy9.Visible = false; break;
                case 2: picMedium16.Visible = false; break;
                case 3: picHard25.Visible = false; break;
                case 4: picInsane36.Visible = false; break;
            }

            Miscari = controller.Amesteca();
            switch (controller.getDificultate())
            {
                case 1: pixeli = 9; animationCounterLimit = 20; break;
                case 2: pixeli = 9; animationCounterLimit = 15; break;
                case 3: pixeli = 9; animationCounterLimit = 12; break;
                case 4: pixeli = 9; animationCounterLimit = 10; break;
            }
            timerShuffle.Enabled = true;
        }

        private void picReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void picContinua_Click(object sender, EventArgs e)
        {
            picPauza_.Visible = false;
            objStopWatch.Start();
            Timp.Enabled = true;
            picContinua.Visible = false;
            picPauza.Visible = true;
        }

        private void picPauza_Click(object sender, EventArgs e)
        {
            picPauza_.Visible = true;
            objStopWatch.Stop();
            Timp.Enabled = false;
            picPauza.Visible = false;
            picContinua.Visible = true;
        }

        private void picSetari_Click(object sender, EventArgs e)
        {
            if (gameState)
                picPauza_Click(null, null);
            controller.deschideSetari(this);
            picSetari.BackgroundImage = PuzzleGlisant.Properties.Resources.picSetariNormal;
        }

        private void picScoruri_Click(object sender, EventArgs e)
        {
            if (gameState)
                picPauza_Click(null, null);
            controller.deschideScoruri(this);
        }

        private void picIesire_Click(object sender, EventArgs e)
        {
            controller.scrieAllInFisier();
            Application.Exit();
        }

        private void pic_MouseEnter(object sender, EventArgs e)
        {
            PictureBox _sender = (PictureBox)sender;

            switch (_sender.Name)
            {
                case "picJocNou": picJocNou.BackgroundImage = PuzzleGlisant.Properties.Resources.picJocNouHovered; break;
                case "picReset": picReset.BackgroundImage = PuzzleGlisant.Properties.Resources.picResetHovered; break;
                case "picPauza": picPauza.BackgroundImage = PuzzleGlisant.Properties.Resources.picPauzaHovered; break;
                case "picContinua": picContinua.BackgroundImage = PuzzleGlisant.Properties.Resources.picContinuaHovered; break;
                case "picScoruri": picScoruri.BackgroundImage = PuzzleGlisant.Properties.Resources.picScoruriHovered; break;
                case "picSetari": picSetari.BackgroundImage = PuzzleGlisant.Properties.Resources.picSetariHovered; break;
                case "picIesire": picIesire.BackgroundImage = PuzzleGlisant.Properties.Resources.picIesireHovered; break;
                case "picDezlantuieMagia": picDezlantuieMagia.BackgroundImage = PuzzleGlisant.Properties.Resources.picContinuaHovered; break;
            }
            
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox _sender = (PictureBox)sender;

            switch (_sender.Name)
            {
                case "picJocNou": picJocNou.BackgroundImage = PuzzleGlisant.Properties.Resources.picJocNouPressed; break;
                case "picReset": picReset.BackgroundImage = PuzzleGlisant.Properties.Resources.picResetPressed; break;
                case "picPauza": picPauza.BackgroundImage = PuzzleGlisant.Properties.Resources.picPauzaPressed; break;
                case "picContinua": picContinua.BackgroundImage = PuzzleGlisant.Properties.Resources.picContinuaPressed; break;
                case "picScoruri": picScoruri.BackgroundImage = PuzzleGlisant.Properties.Resources.picScoruriPressed; break;
                case "picSetari": picSetari.BackgroundImage = PuzzleGlisant.Properties.Resources.picSetariPressed; break;
                case "picIesire": picIesire.BackgroundImage = PuzzleGlisant.Properties.Resources.picIesirePressed; break;
                case "picDezlantuieMagia": picDezlantuieMagia.BackgroundImage = PuzzleGlisant.Properties.Resources.picContinuaPressed; break;
            }
        }

        private void pic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox _sender = (PictureBox)sender;

            switch (_sender.Name)
            {
                case "picJocNou": if (picJocNou.Enabled) picJocNou.BackgroundImage = PuzzleGlisant.Properties.Resources.picJocNouNormal; break;
                case "picReset": if (picReset.Enabled) picReset.BackgroundImage = PuzzleGlisant.Properties.Resources.picResetNormal; break;
                case "picPauza": picPauza.BackgroundImage = PuzzleGlisant.Properties.Resources.picPauzaNormal; break;
                case "picContinua": picContinua.BackgroundImage = PuzzleGlisant.Properties.Resources.picContinuaNormal; break;
                case "picScoruri": picScoruri.BackgroundImage = PuzzleGlisant.Properties.Resources.picScoruriNormal; break;
                case "picSetari": picSetari.BackgroundImage = PuzzleGlisant.Properties.Resources.picSetariNormal; break;
                case "picIesire": picIesire.BackgroundImage = PuzzleGlisant.Properties.Resources.picIesireNormal; break;
                case "picDezlantuieMagia": picDezlantuieMagia.BackgroundImage = PuzzleGlisant.Properties.Resources.picContinuaNormal; break;
            }
        }

        private void picDezlantuieMagia_Click(object sender, EventArgs e)
        {
            controller.setNume(txtNume.Text);
            panelInit.Visible = false;
            this.Size = new Size(952, 650);

            CenterToScreen();
        }
    }
}
