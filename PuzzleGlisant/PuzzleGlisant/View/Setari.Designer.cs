namespace PuzzleGlisant
{
    partial class Setari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radEasy = new System.Windows.Forms.RadioButton();
            this.radHard = new System.Windows.Forms.RadioButton();
            this.radInsane = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.comboImage = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radNumbers = new System.Windows.Forms.RadioButton();
            this.radImage = new System.Windows.Forms.RadioButton();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.picJocNou = new System.Windows.Forms.PictureBox();
            this.picDezlantuieMagia = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.picSalveazaSetarile = new System.Windows.Forms.PictureBox();
            this.picInchideSetarile = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJocNou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDezlantuieMagia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalveazaSetarile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInchideSetarile)).BeginInit();
            this.SuspendLayout();
            // 
            // radEasy
            // 
            this.radEasy.AutoSize = true;
            this.radEasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radEasy.Location = new System.Drawing.Point(11, 7);
            this.radEasy.Name = "radEasy";
            this.radEasy.Size = new System.Drawing.Size(48, 17);
            this.radEasy.TabIndex = 32;
            this.radEasy.Text = "Easy";
            this.radEasy.UseVisualStyleBackColor = true;
            this.radEasy.CheckedChanged += new System.EventHandler(this.radioChecked);
            // 
            // radHard
            // 
            this.radHard.AutoSize = true;
            this.radHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radHard.Location = new System.Drawing.Point(130, 7);
            this.radHard.Name = "radHard";
            this.radHard.Size = new System.Drawing.Size(48, 17);
            this.radHard.TabIndex = 33;
            this.radHard.Text = "Hard";
            this.radHard.UseVisualStyleBackColor = true;
            this.radHard.CheckedChanged += new System.EventHandler(this.radioChecked);
            // 
            // radInsane
            // 
            this.radInsane.AutoSize = true;
            this.radInsane.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radInsane.Location = new System.Drawing.Point(130, 26);
            this.radInsane.Name = "radInsane";
            this.radInsane.Size = new System.Drawing.Size(60, 17);
            this.radInsane.TabIndex = 34;
            this.radInsane.Text = "Insane!";
            this.radInsane.UseVisualStyleBackColor = true;
            this.radInsane.CheckedChanged += new System.EventHandler(this.radioChecked);
            // 
            // radMedium
            // 
            this.radMedium.AutoSize = true;
            this.radMedium.Checked = true;
            this.radMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radMedium.Location = new System.Drawing.Point(11, 26);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(62, 17);
            this.radMedium.TabIndex = 35;
            this.radMedium.TabStop = true;
            this.radMedium.Text = "Medium";
            this.radMedium.UseVisualStyleBackColor = true;
            this.radMedium.CheckedChanged += new System.EventHandler(this.radioChecked);
            // 
            // comboImage
            // 
            this.comboImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboImage.FormattingEnabled = true;
            this.comboImage.Items.AddRange(new object[] {
            "Earth",
            "Sports Car",
            "Dices",
            "Pyramid",
            "Tiger"});
            this.comboImage.Location = new System.Drawing.Point(152, 19);
            this.comboImage.Name = "comboImage";
            this.comboImage.Size = new System.Drawing.Size(121, 21);
            this.comboImage.TabIndex = 37;
            this.comboImage.SelectedIndexChanged += new System.EventHandler(this.comboImage_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.radInsane);
            this.panel1.Controls.Add(this.radEasy);
            this.panel1.Controls.Add(this.radHard);
            this.panel1.Controls.Add(this.radMedium);
            this.panel1.Location = new System.Drawing.Point(371, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 50);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.radNumbers);
            this.panel2.Controls.Add(this.comboImage);
            this.panel2.Controls.Add(this.radImage);
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 57);
            this.panel2.TabIndex = 40;
            // 
            // radNumbers
            // 
            this.radNumbers.AutoSize = true;
            this.radNumbers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radNumbers.Location = new System.Drawing.Point(15, 20);
            this.radNumbers.Name = "radNumbers";
            this.radNumbers.Size = new System.Drawing.Size(62, 17);
            this.radNumbers.TabIndex = 36;
            this.radNumbers.Text = "Numere";
            this.radNumbers.UseVisualStyleBackColor = true;
            this.radNumbers.CheckedChanged += new System.EventHandler(this.radioChecked);
            // 
            // radImage
            // 
            this.radImage.AutoSize = true;
            this.radImage.Checked = true;
            this.radImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radImage.Location = new System.Drawing.Point(88, 20);
            this.radImage.Name = "radImage";
            this.radImage.Size = new System.Drawing.Size(62, 17);
            this.radImage.TabIndex = 37;
            this.radImage.TabStop = true;
            this.radImage.Text = "Imagine";
            this.radImage.UseVisualStyleBackColor = true;
            this.radImage.CheckedChanged += new System.EventHandler(this.radioChecked);
            // 
            // picPreview
            // 
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPreview.Location = new System.Drawing.Point(15, 140);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(250, 250);
            this.picPreview.TabIndex = 38;
            this.picPreview.TabStop = false;
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.Location = new System.Drawing.Point(112, 26);
            this.txtNume.MaxLength = 15;
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(107, 23);
            this.txtNume.TabIndex = 41;
            this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            // 
            // picJocNou
            // 
            this.picJocNou.BackColor = System.Drawing.Color.Black;
            this.picJocNou.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picJocNou.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picJocNou.Location = new System.Drawing.Point(14, 139);
            this.picJocNou.Name = "picJocNou";
            this.picJocNou.Size = new System.Drawing.Size(252, 252);
            this.picJocNou.TabIndex = 49;
            this.picJocNou.TabStop = false;
            // 
            // picDezlantuieMagia
            // 
            this.picDezlantuieMagia.BackColor = System.Drawing.Color.Transparent;
            this.picDezlantuieMagia.BackgroundImage = global::PuzzleGlisant.Properties.Resources.picDificultate;
            this.picDezlantuieMagia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picDezlantuieMagia.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picDezlantuieMagia.Location = new System.Drawing.Point(371, 15);
            this.picDezlantuieMagia.Name = "picDezlantuieMagia";
            this.picDezlantuieMagia.Size = new System.Drawing.Size(212, 55);
            this.picDezlantuieMagia.TabIndex = 56;
            this.picDezlantuieMagia.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PuzzleGlisant.Properties.Resources.picImagine;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(52, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 55);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(360, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 120);
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(359, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(235, 122);
            this.pictureBox3.TabIndex = 59;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(11, 11);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(282, 404);
            this.pictureBox5.TabIndex = 61;
            this.pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.picPreview);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.picJocNou);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 402);
            this.panel3.TabIndex = 41;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::PuzzleGlisant.Properties.Resources.picNume;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox4.Location = new System.Drawing.Point(-9, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(122, 61);
            this.pictureBox4.TabIndex = 62;
            this.pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.txtNume);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Location = new System.Drawing.Point(360, 153);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 70);
            this.panel4.TabIndex = 40;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Black;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Location = new System.Drawing.Point(359, 152);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(235, 72);
            this.pictureBox6.TabIndex = 62;
            this.pictureBox6.TabStop = false;
            // 
            // picSalveazaSetarile
            // 
            this.picSalveazaSetarile.BackColor = System.Drawing.Color.Transparent;
            this.picSalveazaSetarile.BackgroundImage = global::PuzzleGlisant.Properties.Resources.picSalveazaSetarileDisabled;
            this.picSalveazaSetarile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picSalveazaSetarile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSalveazaSetarile.Enabled = false;
            this.picSalveazaSetarile.Location = new System.Drawing.Point(284, 290);
            this.picSalveazaSetarile.Name = "picSalveazaSetarile";
            this.picSalveazaSetarile.Size = new System.Drawing.Size(346, 55);
            this.picSalveazaSetarile.TabIndex = 64;
            this.picSalveazaSetarile.TabStop = false;
            this.picSalveazaSetarile.Click += new System.EventHandler(this.picSalveazaSetarile_Click);
            this.picSalveazaSetarile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.picSalveazaSetarile.MouseEnter += new System.EventHandler(this.pic_MouseEnter);
            this.picSalveazaSetarile.MouseLeave += new System.EventHandler(this.pic_MouseLeave);
            // 
            // picInchideSetarile
            // 
            this.picInchideSetarile.BackColor = System.Drawing.Color.Transparent;
            this.picInchideSetarile.BackgroundImage = global::PuzzleGlisant.Properties.Resources.picInchideSetarileNormal;
            this.picInchideSetarile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picInchideSetarile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picInchideSetarile.Location = new System.Drawing.Point(299, 350);
            this.picInchideSetarile.Name = "picInchideSetarile";
            this.picInchideSetarile.Size = new System.Drawing.Size(334, 55);
            this.picInchideSetarile.TabIndex = 63;
            this.picInchideSetarile.TabStop = false;
            this.picInchideSetarile.Click += new System.EventHandler(this.picInchideSetarile_Click);
            this.picInchideSetarile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.picInchideSetarile.MouseEnter += new System.EventHandler(this.pic_MouseEnter);
            this.picInchideSetarile.MouseLeave += new System.EventHandler(this.pic_MouseLeave);
            // 
            // Setari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PuzzleGlisant.Properties.Resources.Backgrounnd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 426);
            this.ControlBox = false;
            this.Controls.Add(this.picInchideSetarile);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.picDezlantuieMagia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.picSalveazaSetarile);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Setari";
            this.Text = "Setari";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJocNou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDezlantuieMagia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalveazaSetarile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInchideSetarile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radEasy;
        private System.Windows.Forms.RadioButton radHard;
        private System.Windows.Forms.RadioButton radInsane;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.ComboBox comboImage;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radNumbers;
        private System.Windows.Forms.RadioButton radImage;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.PictureBox picJocNou;
        private System.Windows.Forms.PictureBox picDezlantuieMagia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox picSalveazaSetarile;
        private System.Windows.Forms.PictureBox picInchideSetarile;
    }
}