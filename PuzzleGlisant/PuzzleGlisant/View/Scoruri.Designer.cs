namespace PuzzleGlisant.View
{
    partial class Scoruri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ScorDataGridView = new System.Windows.Forms.DataGridView();
            this.Loc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radPuzzle3x3 = new System.Windows.Forms.RadioButton();
            this.grpTipPuzzle = new System.Windows.Forms.GroupBox();
            this.radPuzzle6x6 = new System.Windows.Forms.RadioButton();
            this.radPuzzle5x5 = new System.Windows.Forms.RadioButton();
            this.radPuzzle4x4 = new System.Windows.Forms.RadioButton();
            this.grpSortare = new System.Windows.Forms.GroupBox();
            this.radTimp = new System.Windows.Forms.RadioButton();
            this.radMiscari = new System.Windows.Forms.RadioButton();
            this.radNume = new System.Windows.Forms.RadioButton();
            this.radAscDesc = new System.Windows.Forms.GroupBox();
            this.radDesc = new System.Windows.Forms.RadioButton();
            this.radAscending = new System.Windows.Forms.RadioButton();
            this.picIesire = new System.Windows.Forms.PictureBox();
            this.picReset = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScorDataGridView)).BeginInit();
            this.grpTipPuzzle.SuspendLayout();
            this.grpSortare.SuspendLayout();
            this.radAscDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIesire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).BeginInit();
            this.SuspendLayout();
            // 
            // ScorDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            this.ScorDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ScorDataGridView.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ScorDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ScorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ScorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Loc,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.ScorDataGridView.EnableHeadersVisualStyles = false;
            this.ScorDataGridView.Location = new System.Drawing.Point(151, 12);
            this.ScorDataGridView.Name = "ScorDataGridView";
            this.ScorDataGridView.ReadOnly = true;
            this.ScorDataGridView.RowHeadersVisible = false;
            this.ScorDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScorDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ScorDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ScorDataGridView.Size = new System.Drawing.Size(376, 280);
            this.ScorDataGridView.TabIndex = 31;
            // 
            // Loc
            // 
            this.Loc.HeaderText = "Loc";
            this.Loc.Name = "Loc";
            this.Loc.ReadOnly = true;
            this.Loc.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "    Nume";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Numar Miscari";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 115;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "      Timp";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // radPuzzle3x3
            // 
            this.radPuzzle3x3.AutoSize = true;
            this.radPuzzle3x3.Checked = true;
            this.radPuzzle3x3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radPuzzle3x3.Location = new System.Drawing.Point(8, 19);
            this.radPuzzle3x3.Name = "radPuzzle3x3";
            this.radPuzzle3x3.Size = new System.Drawing.Size(86, 20);
            this.radPuzzle3x3.TabIndex = 32;
            this.radPuzzle3x3.TabStop = true;
            this.radPuzzle3x3.Text = "Puzzle 3x3";
            this.radPuzzle3x3.UseVisualStyleBackColor = true;
            this.radPuzzle3x3.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // grpTipPuzzle
            // 
            this.grpTipPuzzle.BackColor = System.Drawing.Color.Transparent;
            this.grpTipPuzzle.Controls.Add(this.radPuzzle6x6);
            this.grpTipPuzzle.Controls.Add(this.radPuzzle5x5);
            this.grpTipPuzzle.Controls.Add(this.radPuzzle4x4);
            this.grpTipPuzzle.Controls.Add(this.radPuzzle3x3);
            this.grpTipPuzzle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipPuzzle.Location = new System.Drawing.Point(22, 12);
            this.grpTipPuzzle.Name = "grpTipPuzzle";
            this.grpTipPuzzle.Size = new System.Drawing.Size(123, 117);
            this.grpTipPuzzle.TabIndex = 33;
            this.grpTipPuzzle.TabStop = false;
            this.grpTipPuzzle.Text = "Tip Puzzle";
            // 
            // radPuzzle6x6
            // 
            this.radPuzzle6x6.AutoSize = true;
            this.radPuzzle6x6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radPuzzle6x6.Location = new System.Drawing.Point(8, 88);
            this.radPuzzle6x6.Name = "radPuzzle6x6";
            this.radPuzzle6x6.Size = new System.Drawing.Size(86, 20);
            this.radPuzzle6x6.TabIndex = 35;
            this.radPuzzle6x6.Text = "Puzzle 6x6";
            this.radPuzzle6x6.UseVisualStyleBackColor = true;
            this.radPuzzle6x6.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radPuzzle5x5
            // 
            this.radPuzzle5x5.AutoSize = true;
            this.radPuzzle5x5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radPuzzle5x5.Location = new System.Drawing.Point(8, 65);
            this.radPuzzle5x5.Name = "radPuzzle5x5";
            this.radPuzzle5x5.Size = new System.Drawing.Size(86, 20);
            this.radPuzzle5x5.TabIndex = 34;
            this.radPuzzle5x5.Text = "Puzzle 5x5";
            this.radPuzzle5x5.UseVisualStyleBackColor = true;
            this.radPuzzle5x5.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radPuzzle4x4
            // 
            this.radPuzzle4x4.AutoSize = true;
            this.radPuzzle4x4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radPuzzle4x4.Location = new System.Drawing.Point(8, 42);
            this.radPuzzle4x4.Name = "radPuzzle4x4";
            this.radPuzzle4x4.Size = new System.Drawing.Size(86, 20);
            this.radPuzzle4x4.TabIndex = 33;
            this.radPuzzle4x4.Text = "Puzzle 4x4";
            this.radPuzzle4x4.UseVisualStyleBackColor = true;
            this.radPuzzle4x4.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // grpSortare
            // 
            this.grpSortare.BackColor = System.Drawing.Color.Transparent;
            this.grpSortare.Controls.Add(this.radTimp);
            this.grpSortare.Controls.Add(this.radMiscari);
            this.grpSortare.Controls.Add(this.radNume);
            this.grpSortare.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSortare.Location = new System.Drawing.Point(22, 135);
            this.grpSortare.Name = "grpSortare";
            this.grpSortare.Size = new System.Drawing.Size(123, 87);
            this.grpSortare.TabIndex = 36;
            this.grpSortare.TabStop = false;
            this.grpSortare.Text = "Sortare";
            // 
            // radTimp
            // 
            this.radTimp.AutoSize = true;
            this.radTimp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radTimp.Location = new System.Drawing.Point(8, 65);
            this.radTimp.Name = "radTimp";
            this.radTimp.Size = new System.Drawing.Size(55, 20);
            this.radTimp.TabIndex = 34;
            this.radTimp.Text = "Timp";
            this.radTimp.UseVisualStyleBackColor = true;
            this.radTimp.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radMiscari
            // 
            this.radMiscari.AutoSize = true;
            this.radMiscari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radMiscari.Location = new System.Drawing.Point(8, 42);
            this.radMiscari.Name = "radMiscari";
            this.radMiscari.Size = new System.Drawing.Size(108, 20);
            this.radMiscari.TabIndex = 33;
            this.radMiscari.Text = "Numar Miscari";
            this.radMiscari.UseVisualStyleBackColor = true;
            this.radMiscari.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radNume
            // 
            this.radNume.AutoSize = true;
            this.radNume.Checked = true;
            this.radNume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radNume.Location = new System.Drawing.Point(8, 19);
            this.radNume.Name = "radNume";
            this.radNume.Size = new System.Drawing.Size(59, 20);
            this.radNume.TabIndex = 32;
            this.radNume.TabStop = true;
            this.radNume.Text = "Nume";
            this.radNume.UseVisualStyleBackColor = true;
            this.radNume.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radAscDesc
            // 
            this.radAscDesc.BackColor = System.Drawing.Color.Transparent;
            this.radAscDesc.Controls.Add(this.radDesc);
            this.radAscDesc.Controls.Add(this.radAscending);
            this.radAscDesc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAscDesc.Location = new System.Drawing.Point(22, 228);
            this.radAscDesc.Name = "radAscDesc";
            this.radAscDesc.Size = new System.Drawing.Size(123, 64);
            this.radAscDesc.TabIndex = 37;
            this.radAscDesc.TabStop = false;
            this.radAscDesc.Text = "Tip";
            // 
            // radDesc
            // 
            this.radDesc.AutoSize = true;
            this.radDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radDesc.Location = new System.Drawing.Point(8, 42);
            this.radDesc.Name = "radDesc";
            this.radDesc.Size = new System.Drawing.Size(100, 20);
            this.radDesc.TabIndex = 33;
            this.radDesc.Text = "Descrescator";
            this.radDesc.UseVisualStyleBackColor = true;
            this.radDesc.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radAscending
            // 
            this.radAscending.AutoSize = true;
            this.radAscending.Checked = true;
            this.radAscending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radAscending.Location = new System.Drawing.Point(8, 19);
            this.radAscending.Name = "radAscending";
            this.radAscending.Size = new System.Drawing.Size(81, 20);
            this.radAscending.TabIndex = 32;
            this.radAscending.TabStop = true;
            this.radAscending.Text = "Crescator";
            this.radAscending.UseVisualStyleBackColor = true;
            this.radAscending.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // picIesire
            // 
            this.picIesire.BackColor = System.Drawing.Color.Transparent;
            this.picIesire.BackgroundImage = global::PuzzleGlisant.Properties.Resources.picIesireNormal;
            this.picIesire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picIesire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIesire.Location = new System.Drawing.Point(268, 298);
            this.picIesire.Name = "picIesire";
            this.picIesire.Size = new System.Drawing.Size(133, 59);
            this.picIesire.TabIndex = 54;
            this.picIesire.TabStop = false;
            this.picIesire.Click += new System.EventHandler(this.picIesire_Click);
            this.picIesire.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.picIesire.MouseEnter += new System.EventHandler(this.pic_MouseEnter);
            this.picIesire.MouseLeave += new System.EventHandler(this.pic_MouseLeave);
            // 
            // picReset
            // 
            this.picReset.BackColor = System.Drawing.Color.Transparent;
            this.picReset.BackgroundImage = global::PuzzleGlisant.Properties.Resources.picResetNormal;
            this.picReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReset.Location = new System.Drawing.Point(12, 298);
            this.picReset.Name = "picReset";
            this.picReset.Size = new System.Drawing.Size(133, 59);
            this.picReset.TabIndex = 55;
            this.picReset.TabStop = false;
            this.picReset.Click += new System.EventHandler(this.picReset_Click);
            this.picReset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.picReset.MouseEnter += new System.EventHandler(this.pic_MouseEnter);
            this.picReset.MouseLeave += new System.EventHandler(this.pic_MouseLeave);
            // 
            // Scoruri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PuzzleGlisant.Properties.Resources.Backgrounnd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(538, 352);
            this.ControlBox = false;
            this.Controls.Add(this.picReset);
            this.Controls.Add(this.picIesire);
            this.Controls.Add(this.radAscDesc);
            this.Controls.Add(this.grpSortare);
            this.Controls.Add(this.grpTipPuzzle);
            this.Controls.Add(this.ScorDataGridView);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Scoruri";
            this.Text = "Scoruri";
            ((System.ComponentModel.ISupportInitialize)(this.ScorDataGridView)).EndInit();
            this.grpTipPuzzle.ResumeLayout(false);
            this.grpTipPuzzle.PerformLayout();
            this.grpSortare.ResumeLayout(false);
            this.grpSortare.PerformLayout();
            this.radAscDesc.ResumeLayout(false);
            this.radAscDesc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIesire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ScorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.RadioButton radPuzzle3x3;
        private System.Windows.Forms.GroupBox grpTipPuzzle;
        private System.Windows.Forms.RadioButton radPuzzle6x6;
        private System.Windows.Forms.RadioButton radPuzzle5x5;
        private System.Windows.Forms.RadioButton radPuzzle4x4;
        private System.Windows.Forms.GroupBox grpSortare;
        private System.Windows.Forms.RadioButton radTimp;
        private System.Windows.Forms.RadioButton radMiscari;
        private System.Windows.Forms.RadioButton radNume;
        private System.Windows.Forms.GroupBox radAscDesc;
        private System.Windows.Forms.RadioButton radDesc;
        private System.Windows.Forms.RadioButton radAscending;
        private System.Windows.Forms.PictureBox picIesire;
        private System.Windows.Forms.PictureBox picReset;
    }
}