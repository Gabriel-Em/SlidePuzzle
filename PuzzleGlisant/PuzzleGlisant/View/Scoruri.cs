using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuzzleGlisant.View
{
    public partial class Scoruri : Form
    {
        private UI ui;
        private Controller.Controller controller;

        public Scoruri(UI _ui, Controller.Controller _controller)
        {
            InitializeComponent();
            CenterToParent();
            ui = _ui;
            controller = _controller;
            afisare(3);
        }

        private void afisare(int puzzle)
        {
            int nr = 1;
            List<Model.Scor> scoruri = controller.getScoruri(puzzle);

            ScorDataGridView.Rows.Clear();

            for (int i = 0; i < scoruri.Count(); i++)
            {
                ScorDataGridView.Rows.Add();
                ScorDataGridView.Rows[i].Cells[1].Value = scoruri[i].Nume;
                ScorDataGridView.Rows[i].Cells[2].Value = scoruri[i].NrMiscari;
                ScorDataGridView.Rows[i].Cells[3].Value = scoruri[i].Timp;
            }

            switch (getSortare())
            {
                case 1:
                    switch (getTip())
                    {
                        case 1: ScorDataGridView.Sort(ScorDataGridView.Columns[1], ListSortDirection.Ascending); break;
                        case 2: ScorDataGridView.Sort(ScorDataGridView.Columns[1], ListSortDirection.Descending); break;
                    }
                    break;

                case 2:
                    switch (getTip())
                    {
                        case 1: ScorDataGridView.Sort(ScorDataGridView.Columns[2], ListSortDirection.Ascending); break;
                        case 2: ScorDataGridView.Sort(ScorDataGridView.Columns[2], ListSortDirection.Descending); break;
                    }
                    break;

                case 3:
                    switch (getTip())
                    {
                        case 1: ScorDataGridView.Sort(ScorDataGridView.Columns[3], ListSortDirection.Ascending); break;
                        case 2: ScorDataGridView.Sort(ScorDataGridView.Columns[3], ListSortDirection.Descending); break;
                    }
                    break;
            }

            for (int i = 0; i < scoruri.Count(); i++)
            {
                ScorDataGridView.Rows[i].Cells[0].Value = nr;
                nr++;
            }
        }

        private int getPuzzle()
        {
            if (radPuzzle3x3.Checked)
                return 3;
            else
                if (radPuzzle4x4.Checked)
                    return 4;
                else
                    if (radPuzzle5x5.Checked)
                        return 5;
                    else
                        return 6;
        }

        private int getSortare()
        {
            if (radNume.Checked)
                return 1;
            else
                if (radMiscari.Checked)
                    return 2;
                else
                    return 3;
        }

        private int getTip()
        {
            if (radAscending.Checked)
                return 1;
            else
                return 2;
        }

        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
                afisare(getPuzzle());
        }

        private void picIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox _sender = (PictureBox)sender;
            switch (_sender.Name)
            {
                case "picIesire": picIesire.BackgroundImage = PuzzleGlisant.Properties.Resources.picIesirePressed; break;
                case "picReset": picReset.BackgroundImage = PuzzleGlisant.Properties.Resources.picResetPressed; break;
            }
        }

        private void pic_MouseEnter(object sender, EventArgs e)
        {
            PictureBox _sender = (PictureBox)sender;
            switch (_sender.Name)
            {
                case "picIesire": picIesire.BackgroundImage = PuzzleGlisant.Properties.Resources.picIesireHovered; break;
                case "picReset": picReset.BackgroundImage = PuzzleGlisant.Properties.Resources.picResetHovered; break;
            }
        }

        private void pic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox _sender = (PictureBox)sender;
            switch (_sender.Name)
            {
                case "picIesire": picIesire.BackgroundImage = PuzzleGlisant.Properties.Resources.picIesireNormal; break;
                case "picReset": picReset.BackgroundImage = PuzzleGlisant.Properties.Resources.picResetNormal; break;
            }
        }

        private void picReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Toate scorurile puzzle-ului selectat vor fi sterse! Continuati?", "Atentie", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ScorDataGridView.Rows.Clear();
                controller.resetScor(getPuzzle());
            }
        }
    }
}
