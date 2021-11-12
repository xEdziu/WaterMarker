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
            this.Placement = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ButtonChooseFiles
            // 
            this.ButtonChooseFiles.BackColor = System.Drawing.Color.Transparent;
            this.ButtonChooseFiles.FlatAppearance.BorderSize = 0;
            this.ButtonChooseFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChooseFiles.Location = new System.Drawing.Point(80, 167);
            this.ButtonChooseFiles.Name = "ButtonChooseFiles";
            this.ButtonChooseFiles.Size = new System.Drawing.Size(129, 39);
            this.ButtonChooseFiles.TabIndex = 0;
            this.ButtonChooseFiles.UseVisualStyleBackColor = false;
            this.ButtonChooseFiles.Click += new System.EventHandler(this.ButtonChooseFiles_Click);
            this.ButtonChooseFiles.MouseEnter += new System.EventHandler(this.ChooseFiles_MouseEnter);
            this.ButtonChooseFiles.MouseLeave += new System.EventHandler(this.ChooseFiles_MouseLeave);
            this.ButtonChooseFiles.MouseHover += new System.EventHandler(this.ChooseFiles_MouseHover);
            // 
            // ChooseWaterMark
            // 
            this.ChooseWaterMark.BackColor = System.Drawing.Color.Transparent;
            this.ChooseWaterMark.FlatAppearance.BorderSize = 0;
            this.ChooseWaterMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseWaterMark.Location = new System.Drawing.Point(167, 279);
            this.ChooseWaterMark.Name = "ChooseWaterMark";
            this.ChooseWaterMark.Size = new System.Drawing.Size(129, 39);
            this.ChooseWaterMark.TabIndex = 1;
            this.ChooseWaterMark.UseVisualStyleBackColor = false;
            // 
            // MergeWaterMark
            // 
            this.MergeWaterMark.BackColor = System.Drawing.Color.Transparent;
            this.MergeWaterMark.FlatAppearance.BorderSize = 0;
            this.MergeWaterMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MergeWaterMark.Location = new System.Drawing.Point(368, 423);
            this.MergeWaterMark.Name = "MergeWaterMark";
            this.MergeWaterMark.Size = new System.Drawing.Size(214, 75);
            this.MergeWaterMark.TabIndex = 2;
            this.MergeWaterMark.UseVisualStyleBackColor = false;
            this.MergeWaterMark.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Placement
            // 
            this.Placement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(0)))), ((int)(((byte)(214)))));
            this.Placement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Placement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Placement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Placement.ForeColor = System.Drawing.Color.White;
            this.Placement.FormattingEnabled = true;
            this.Placement.Items.AddRange(new object[] {
            "Lewy Górny Róg",
            "Lewy Dolny Róg",
            "Prawy Górny Róg",
            "Prawy Dolny Róg",
            "Środek"});
            this.Placement.Location = new System.Drawing.Point(180, 389);
            this.Placement.Name = "Placement";
            this.Placement.Size = new System.Drawing.Size(116, 21);
            this.Placement.TabIndex = 3;
            this.Placement.SelectedIndexChanged += new System.EventHandler(this.Placement_SelectedIndexChanged);
            // 
            // Main
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.Placement);
            this.Controls.Add(this.MergeWaterMark);
            this.Controls.Add(this.ChooseWaterMark);
            this.Controls.Add(this.ButtonChooseFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaterMarker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonChooseFiles;
        private System.Windows.Forms.Button ChooseWaterMark;
        private System.Windows.Forms.Button MergeWaterMark;
        private System.Windows.Forms.ComboBox Placement;
    }
}

