using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuzzleGlisant
{
    public partial class Setari : Form
    {
        private UI ui;
        private Controller.Controller controller;
        private bool init;

        public Setari(UI _ui, Controller.Controller _controller)
        {
            InitializeComponent();
            CenterToParent();

            ui = _ui;
            controller = _controller;

            init = true;

            switch (controller.getDificultate())
            {
                case 1: radEasy.Checked = true; break;
                case 2: radMedium.Checked = true; break;
                case 3: radHard.Checked = true; break;
                case 4: radInsane.Checked = true; break;
            }

            switch (controller.getImageNumbers())
            {
                case true:
                    radNumbers.Checked = true;
                    comboImage.Enabled = false;
                    comboImage.SelectedIndex = 0;
                    break;

                case false:

                    comboImage.SelectedIndex = controller.getImagineIndex();
                    radImage.Checked = true;
                    break;
            }

            picPreview.BackgroundImage = controller.getImage();

            txtNume.Text = controller.getNume();
            init = false;
        }

        private void setPreview()
        {
            if (radNumbers.Checked)
            {
                if (radEasy.Checked)
                    picPreview.BackgroundImage = controller.getImagineFromImaginiData(5);

                if (radMedium.Checked)
                    picPreview.BackgroundImage = controller.getImagineFromImaginiData(6);

                if (radHard.Checked)
                    picPreview.BackgroundImage = controller.getImagineFromImaginiData(7);

                if (radInsane.Checked)
                    picPreview.BackgroundImage = controller.getImagineFromImaginiData(8);
            }
            else
            {
                switch (comboImage.SelectedIndex)
                {
                    case -1: picPreview.BackgroundImage = picPreview.ErrorImage; break;
                    case 0: picPreview.BackgroundImage = controller.getImagineFromImaginiData(0); break;
                    case 1: picPreview.BackgroundImage = controller.getImagineFromImaginiData(1); break;
                    case 2: picPreview.BackgroundImage = controller.getImagineFromImaginiData(2); break;
                    case 3: picPreview.BackgroundImage = controller.getImagineFromImaginiData(3); break;
                    case 4: picPreview.BackgroundImage = controller.getImagineFromImaginiData(4); break;
                }
            }
        }

        private void radioChecked(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
                if (!init)
                {
                    if (sender == radImage)
                        comboImage.Enabled = true;
                    else
                        if (sender == radNumbers)
                            comboImage.Enabled = false;
                        
                    setPreview();

                    if (checkForSetariNoi())
                    {
                        picSalveazaSetarile.Enabled = true;
                        picSalveazaSetarile.BackgroundImage = PuzzleGlisant.Properties.Resources.picSalveazaSetarileNormal;
                    }
                    else
                    {
                        picSalveazaSetarile.Enabled = false;
                        picSalveazaSetarile.BackgroundImage = PuzzleGlisant.Properties.Resources.picSalveazaSetarileDisabled;
                    }
                }
        }

        private bool checkForSetariNoi()
        {
            if (getDificultate() != controller.getDificultate())
                return true;

            if (picPreview.BackgroundImage != controller.getImage())
                return true;

            if (txtNume.Text != controller.getNume())
                return true;

            return false;
        }

        private int getDificultate()
        {
            if (radEasy.Checked)
                return 1;
            if (radMedium.Checked)
                return 2;
            if (radHard.Checked)
                return 3;
            if (radInsane.Checked)
                return 4;

            return 0;
        }

        private void comboImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!init)
            {
                setPreview();

                if (checkForSetariNoi())
                {
                    picSalveazaSetarile.Enabled = true;
                    picSalveazaSetarile.BackgroundImage = PuzzleGlisant.Properties.Resources.picSalveazaSetarileNormal;
                }
                else
                {
                    picSalveazaSetarile.Enabled = false;
                    picSalveazaSetarile.BackgroundImage = PuzzleGlisant.Properties.Resources.picSalveazaSetarileDisabled;
                }
            }
        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {
            if(!init)
                if (checkForSetariNoi())
                {
                    picSalveazaSetarile.Enabled = true;
                    picSalveazaSetarile.BackgroundImage = PuzzleGlisant.Properties.Resources.picSalveazaSetarileNormal;
                }
                else
                {
                    picSalveazaSetarile.Enabled = false;
                    picSalveazaSetarile.BackgroundImage = PuzzleGlisant.Properties.Resources.picSalveazaSetarileDisabled;
                }
        }

        private void picSalveazaSetarile_Click(object sender, EventArgs e)
        {
            if (getDificultate() != controller.getDificultate())
            {
                controller.setDificultate(getDificultate());
                ui.setariModificaDificultate();
            }

            if (picPreview.BackgroundImage != controller.getImage())
            {
                controller.setImage(picPreview.BackgroundImage);
                ui.setariModificaImagine();
            }

            if (txtNume.Text != controller.getNume())
                controller.setNume(txtNume.Text);


            if (radNumbers.Checked)
                controller.setImageNumbers(true);
            else
                controller.setImageNumbers(false);

            picSalveazaSetarile.BackgroundImage = PuzzleGlisant.Properties.Resources.picSalveazaSetarileDisabled;
            picSalveazaSetarile.Enabled = false;
        }

        private void picInchideSetarile_Click(object sender, EventArgs e)
        {
            if (checkForSetariNoi())
                if (MessageBox.Show("Nu ati salvati modificarile! Doriti sa salvati modificarile inainte de a iesi?", "Atentie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    picSalveazaSetarile_Click(null, null);

            this.Close();
        }

        private void pic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox _sender = (PictureBox)sender;

            switch (_sender.Name)
            {
                case "picSalveazaSetarile": if(checkForSetariNoi()) picSalveazaSetarile.BackgroundImage = PuzzleGlisant.Properties.Resources.picSalveazaSetarileNormal; break;
                case "picInchideSetarile": picInchideSetarile.BackgroundImage = PuzzleGlisant.Properties.Resources.picInchideSetarileNormal; break;
            }
        }

        private void pic_MouseEnter(object sender, EventArgs e)
        {
            PictureBox _sender = (PictureBox)sender;

            switch (_sender.Name)
            {
                case "picSalveazaSetarile": picSalveazaSetarile.BackgroundImage = PuzzleGlisant.Properties.Resources.picSalveazaSetarileHovered; break;
                case "picInchideSetarile": picInchideSetarile.BackgroundImage = PuzzleGlisant.Properties.Resources.picInchideSetarileHovered; break;
            }
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox _sender = (PictureBox)sender;

            switch (_sender.Name)
            {
                case "picSalveazaSetarile": picSalveazaSetarile.BackgroundImage = PuzzleGlisant.Properties.Resources.picSalveazaSetarilePressed; break;
                case "picInchideSetarile": picInchideSetarile.BackgroundImage = PuzzleGlisant.Properties.Resources.picInchideSetarilePressed; break;
            }
        }
    }
}
