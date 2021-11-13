namespace WaterMarker
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ButtonChooseFiles = new System.Windows.Forms.Button();
            this.ChooseWaterMark = new System.Windows.Forms.Button();
            this.MergeWaterMark = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.LabelCounter = new System.Windows.Forms.Label();
            this.RoundProgress = new WaterMarker.CircularProgressBar();
            this.DonateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonChooseFiles
            // 
            this.ButtonChooseFiles.BackColor = System.Drawing.Color.Transparent;
            this.ButtonChooseFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChooseFiles.FlatAppearance.BorderSize = 0;
            this.ButtonChooseFiles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonChooseFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonChooseFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChooseFiles.Location = new System.Drawing.Point(81, 185);
            this.ButtonChooseFiles.Name = "ButtonChooseFiles";
            this.ButtonChooseFiles.Size = new System.Drawing.Size(129, 39);
            this.ButtonChooseFiles.TabIndex = 0;
            this.ButtonChooseFiles.UseVisualStyleBackColor = false;
            this.ButtonChooseFiles.Click += new System.EventHandler(this.ButtonChooseFiles_Click);
            // 
            // ChooseWaterMark
            // 
            this.ChooseWaterMark.BackColor = System.Drawing.Color.Transparent;
            this.ChooseWaterMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseWaterMark.FlatAppearance.BorderSize = 0;
            this.ChooseWaterMark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ChooseWaterMark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ChooseWaterMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseWaterMark.Location = new System.Drawing.Point(169, 320);
            this.ChooseWaterMark.Name = "ChooseWaterMark";
            this.ChooseWaterMark.Size = new System.Drawing.Size(129, 39);
            this.ChooseWaterMark.TabIndex = 1;
            this.ChooseWaterMark.UseVisualStyleBackColor = false;
            this.ChooseWaterMark.Click += new System.EventHandler(this.ChooseWaterMark_Click);
            // 
            // MergeWaterMark
            // 
            this.MergeWaterMark.BackColor = System.Drawing.Color.Transparent;
            this.MergeWaterMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MergeWaterMark.FlatAppearance.BorderSize = 0;
            this.MergeWaterMark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MergeWaterMark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MergeWaterMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MergeWaterMark.Location = new System.Drawing.Point(368, 423);
            this.MergeWaterMark.Name = "MergeWaterMark";
            this.MergeWaterMark.Size = new System.Drawing.Size(214, 75);
            this.MergeWaterMark.TabIndex = 2;
            this.MergeWaterMark.UseVisualStyleBackColor = false;
            this.MergeWaterMark.Click += new System.EventHandler(this.Button2_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.Location = new System.Drawing.Point(852, 21);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(32, 35);
            this.MinimizeButton.TabIndex = 4;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(893, 21);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(38, 34);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LabelCounter
            // 
            this.LabelCounter.AutoSize = true;
            this.LabelCounter.BackColor = System.Drawing.Color.Transparent;
            this.LabelCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelCounter.Font = new System.Drawing.Font("Nunito Sans ExtraLight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCounter.ForeColor = System.Drawing.Color.Transparent;
            this.LabelCounter.Location = new System.Drawing.Point(343, 192);
            this.LabelCounter.Name = "LabelCounter";
            this.LabelCounter.Size = new System.Drawing.Size(0, 22);
            this.LabelCounter.TabIndex = 6;
            // 
            // RoundProgress
            // 
            this.RoundProgress.BackColor = System.Drawing.Color.Transparent;
            this.RoundProgress.BarColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(24)))), ((int)(((byte)(136)))));
            this.RoundProgress.BarColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            this.RoundProgress.BarWidth = 14F;
            this.RoundProgress.Font = new System.Drawing.Font("Nunito Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RoundProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            this.RoundProgress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.RoundProgress.LineColor = System.Drawing.Color.DimGray;
            this.RoundProgress.LineWidth = 1;
            this.RoundProgress.Location = new System.Drawing.Point(612, 129);
            this.RoundProgress.Maximum = ((long)(100));
            this.RoundProgress.MinimumSize = new System.Drawing.Size(100, 100);
            this.RoundProgress.Name = "RoundProgress";
            this.RoundProgress.ProgressShape = WaterMarker.CircularProgressBar._ProgressShape.Flat;
            this.RoundProgress.Size = new System.Drawing.Size(281, 281);
            this.RoundProgress.TabIndex = 7;
            this.RoundProgress.Text = "20";
            this.RoundProgress.TextMode = WaterMarker.CircularProgressBar._TextMode.Percentage;
            this.RoundProgress.Value = ((long)(20));
            this.RoundProgress.Visible = false;
            // 
            // DonateButton
            // 
            this.DonateButton.BackColor = System.Drawing.Color.Transparent;
            this.DonateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DonateButton.FlatAppearance.BorderSize = 0;
            this.DonateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DonateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DonateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DonateButton.ForeColor = System.Drawing.Color.Transparent;
            this.DonateButton.Location = new System.Drawing.Point(1, 497);
            this.DonateButton.Name = "DonateButton";
            this.DonateButton.Size = new System.Drawing.Size(323, 75);
            this.DonateButton.TabIndex = 8;
            this.DonateButton.UseVisualStyleBackColor = false;
            this.DonateButton.Click += new System.EventHandler(this.DonateButton_Click);
            // 
            // Main
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.DonateButton);
            this.Controls.Add(this.RoundProgress);
            this.Controls.Add(this.LabelCounter);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.MergeWaterMark);
            this.Controls.Add(this.ChooseWaterMark);
            this.Controls.Add(this.ButtonChooseFiles);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(145)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaterMarker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonChooseFiles;
        private System.Windows.Forms.Button ChooseWaterMark;
        private System.Windows.Forms.Button MergeWaterMark;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label LabelCounter;
        private CircularProgressBar RoundProgress;
        private System.Windows.Forms.Button DonateButton;
    }
}

