namespace FSA_TileSheet_Converter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tileSheetPicBox = new System.Windows.Forms.PictureBox();
            this.TilesSetComboBox = new System.Windows.Forms.ComboBox();
            this.PaletteComboBox = new System.Windows.Forms.ComboBox();
            this.SpriteComboBox = new System.Windows.Forms.ComboBox();
            this.SpriteSheetPaletteComboBox = new System.Windows.Forms.ComboBox();
            this.spriteSheetPictureBox = new System.Windows.Forms.PictureBox();
            this.PalletNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SpriteObjectComboBox = new System.Windows.Forms.ComboBox();
            this.LevelSpriteComboBox = new System.Windows.Forms.ComboBox();
            this.SpritObjektIndexUpDown = new System.Windows.Forms.NumericUpDown();
            this.EnemySpriteComboBox = new System.Windows.Forms.ComboBox();
            this.SaveSpriteButton = new System.Windows.Forms.Button();
            this.spritePictureBox = new System.Windows.Forms.PictureBox();
            this.SpritePaletteComboBox = new System.Windows.Forms.ComboBox();
            this.SpritePalletNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ReplacePaletteIndexUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaveTileSheetButton = new System.Windows.Forms.Button();
            this.SaveSpriteSheetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tileSheetPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteSheetPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PalletNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpritObjektIndexUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spritePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpritePalletNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReplacePaletteIndexUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tileSheetPicBox
            // 
            this.tileSheetPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tileSheetPicBox.Location = new System.Drawing.Point(12, 119);
            this.tileSheetPicBox.Name = "tileSheetPicBox";
            this.tileSheetPicBox.Size = new System.Drawing.Size(256, 1024);
            this.tileSheetPicBox.TabIndex = 1;
            this.tileSheetPicBox.TabStop = false;
            // 
            // TilesSetComboBox
            // 
            this.TilesSetComboBox.FormattingEnabled = true;
            this.TilesSetComboBox.Location = new System.Drawing.Point(12, 52);
            this.TilesSetComboBox.Name = "TilesSetComboBox";
            this.TilesSetComboBox.Size = new System.Drawing.Size(256, 21);
            this.TilesSetComboBox.TabIndex = 4;
            this.TilesSetComboBox.SelectedIndexChanged += new System.EventHandler(this.TilesSetComboBox_SelectedIndexChanged);
            // 
            // PaletteComboBox
            // 
            this.PaletteComboBox.FormattingEnabled = true;
            this.PaletteComboBox.Location = new System.Drawing.Point(12, 92);
            this.PaletteComboBox.Name = "PaletteComboBox";
            this.PaletteComboBox.Size = new System.Drawing.Size(256, 21);
            this.PaletteComboBox.TabIndex = 5;
            this.PaletteComboBox.SelectedIndexChanged += new System.EventHandler(this.PaletteComboBox_SelectedIndexChanged);
            // 
            // SpriteComboBox
            // 
            this.SpriteComboBox.FormattingEnabled = true;
            this.SpriteComboBox.Location = new System.Drawing.Point(274, 52);
            this.SpriteComboBox.Name = "SpriteComboBox";
            this.SpriteComboBox.Size = new System.Drawing.Size(202, 21);
            this.SpriteComboBox.TabIndex = 6;
            this.SpriteComboBox.SelectedIndexChanged += new System.EventHandler(this.SpriteComboBox_SelectedIndexChanged);
            // 
            // SpriteSheetPaletteComboBox
            // 
            this.SpriteSheetPaletteComboBox.FormattingEnabled = true;
            this.SpriteSheetPaletteComboBox.Location = new System.Drawing.Point(274, 92);
            this.SpriteSheetPaletteComboBox.Name = "SpriteSheetPaletteComboBox";
            this.SpriteSheetPaletteComboBox.Size = new System.Drawing.Size(202, 21);
            this.SpriteSheetPaletteComboBox.TabIndex = 7;
            this.SpriteSheetPaletteComboBox.SelectedIndexChanged += new System.EventHandler(this.SpriteSheetPaletteComboBox_SelectedIndexChanged);
            // 
            // spriteSheetPictureBox
            // 
            this.spriteSheetPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spriteSheetPictureBox.Location = new System.Drawing.Point(274, 118);
            this.spriteSheetPictureBox.Name = "spriteSheetPictureBox";
            this.spriteSheetPictureBox.Size = new System.Drawing.Size(256, 256);
            this.spriteSheetPictureBox.TabIndex = 8;
            this.spriteSheetPictureBox.TabStop = false;
            // 
            // PalletNumericUpDown
            // 
            this.PalletNumericUpDown.Location = new System.Drawing.Point(482, 92);
            this.PalletNumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.PalletNumericUpDown.Name = "PalletNumericUpDown";
            this.PalletNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.PalletNumericUpDown.TabIndex = 9;
            this.PalletNumericUpDown.ValueChanged += new System.EventHandler(this.PalletNumericUpDown_ValueChanged);
            // 
            // SpriteObjectComboBox
            // 
            this.SpriteObjectComboBox.FormattingEnabled = true;
            this.SpriteObjectComboBox.Location = new System.Drawing.Point(536, 52);
            this.SpriteObjectComboBox.Name = "SpriteObjectComboBox";
            this.SpriteObjectComboBox.Size = new System.Drawing.Size(202, 21);
            this.SpriteObjectComboBox.TabIndex = 12;
            this.SpriteObjectComboBox.SelectedIndexChanged += new System.EventHandler(this.SpriteObjectComboBox_SelectedIndexChanged);
            // 
            // LevelSpriteComboBox
            // 
            this.LevelSpriteComboBox.FormattingEnabled = true;
            this.LevelSpriteComboBox.Location = new System.Drawing.Point(536, 92);
            this.LevelSpriteComboBox.Name = "LevelSpriteComboBox";
            this.LevelSpriteComboBox.Size = new System.Drawing.Size(202, 21);
            this.LevelSpriteComboBox.TabIndex = 13;
            this.LevelSpriteComboBox.SelectedIndexChanged += new System.EventHandler(this.LevelSpriteComboBox_SelectedIndexChanged);
            // 
            // SpritObjektIndexUpDown
            // 
            this.SpritObjektIndexUpDown.Location = new System.Drawing.Point(744, 52);
            this.SpritObjektIndexUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.SpritObjektIndexUpDown.Name = "SpritObjektIndexUpDown";
            this.SpritObjektIndexUpDown.Size = new System.Drawing.Size(48, 20);
            this.SpritObjektIndexUpDown.TabIndex = 14;
            this.SpritObjektIndexUpDown.ValueChanged += new System.EventHandler(this.SpritObjektIndex_ValueChanged);
            // 
            // EnemySpriteComboBox
            // 
            this.EnemySpriteComboBox.FormattingEnabled = true;
            this.EnemySpriteComboBox.Location = new System.Drawing.Point(536, 119);
            this.EnemySpriteComboBox.Name = "EnemySpriteComboBox";
            this.EnemySpriteComboBox.Size = new System.Drawing.Size(202, 21);
            this.EnemySpriteComboBox.TabIndex = 15;
            this.EnemySpriteComboBox.SelectedIndexChanged += new System.EventHandler(this.EnemySpriteComboBox_SelectedIndexChanged);
            // 
            // SaveSpriteButton
            // 
            this.SaveSpriteButton.Location = new System.Drawing.Point(536, 10);
            this.SaveSpriteButton.Name = "SaveSpriteButton";
            this.SaveSpriteButton.Size = new System.Drawing.Size(256, 23);
            this.SaveSpriteButton.TabIndex = 16;
            this.SaveSpriteButton.Text = "Save Sprite";
            this.SaveSpriteButton.UseVisualStyleBackColor = true;
            this.SaveSpriteButton.Click += new System.EventHandler(this.SaveSpriteButton_Click);
            // 
            // spritePictureBox
            // 
            this.spritePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spritePictureBox.Location = new System.Drawing.Point(610, 207);
            this.spritePictureBox.Name = "spritePictureBox";
            this.spritePictureBox.Size = new System.Drawing.Size(128, 128);
            this.spritePictureBox.TabIndex = 17;
            this.spritePictureBox.TabStop = false;
            // 
            // SpritePaletteComboBox
            // 
            this.SpritePaletteComboBox.FormattingEnabled = true;
            this.SpritePaletteComboBox.Location = new System.Drawing.Point(536, 159);
            this.SpritePaletteComboBox.Name = "SpritePaletteComboBox";
            this.SpritePaletteComboBox.Size = new System.Drawing.Size(202, 21);
            this.SpritePaletteComboBox.TabIndex = 18;
            this.SpritePaletteComboBox.SelectedIndexChanged += new System.EventHandler(this.SpritePaletteComboBox_SelectedIndexChanged);
            // 
            // SpritePalletNumericUpDown
            // 
            this.SpritePalletNumericUpDown.Location = new System.Drawing.Point(744, 147);
            this.SpritePalletNumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.SpritePalletNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.SpritePalletNumericUpDown.Name = "SpritePalletNumericUpDown";
            this.SpritePalletNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.SpritePalletNumericUpDown.TabIndex = 19;
            this.SpritePalletNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.SpritePalletNumericUpDown.ValueChanged += new System.EventHandler(this.SpritePalletNumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tile sheet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tile sheet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Palette:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Palette:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Sprite Attribute List:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tile sheet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(533, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Palette:";
            // 
            // ReplacePaletteIndexUpDown
            // 
            this.ReplacePaletteIndexUpDown.Location = new System.Drawing.Point(744, 173);
            this.ReplacePaletteIndexUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.ReplacePaletteIndexUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ReplacePaletteIndexUpDown.Name = "ReplacePaletteIndexUpDown";
            this.ReplacePaletteIndexUpDown.Size = new System.Drawing.Size(48, 20);
            this.ReplacePaletteIndexUpDown.TabIndex = 27;
            this.ReplacePaletteIndexUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ReplacePaletteIndexUpDown.ValueChanged += new System.EventHandler(this.SpritePalletNumericUpDown_ValueChanged);
            // 
            // SaveTileSheetButton
            // 
            this.SaveTileSheetButton.Location = new System.Drawing.Point(12, 10);
            this.SaveTileSheetButton.Name = "SaveTileSheetButton";
            this.SaveTileSheetButton.Size = new System.Drawing.Size(256, 23);
            this.SaveTileSheetButton.TabIndex = 28;
            this.SaveTileSheetButton.Text = "Save Tile Sheet";
            this.SaveTileSheetButton.UseVisualStyleBackColor = true;
            this.SaveTileSheetButton.Click += new System.EventHandler(this.SaveTileSheetButton_Click);
            // 
            // SaveSpriteSheetButton
            // 
            this.SaveSpriteSheetButton.Location = new System.Drawing.Point(274, 10);
            this.SaveSpriteSheetButton.Name = "SaveSpriteSheetButton";
            this.SaveSpriteSheetButton.Size = new System.Drawing.Size(256, 23);
            this.SaveSpriteSheetButton.TabIndex = 29;
            this.SaveSpriteSheetButton.Text = "Save Sprite Sheet";
            this.SaveSpriteSheetButton.UseVisualStyleBackColor = true;
            this.SaveSpriteSheetButton.Click += new System.EventHandler(this.SaveSpriteSheetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.ClientSize = new System.Drawing.Size(826, 381);
            this.Controls.Add(this.SaveSpriteSheetButton);
            this.Controls.Add(this.SaveTileSheetButton);
            this.Controls.Add(this.ReplacePaletteIndexUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpritePalletNumericUpDown);
            this.Controls.Add(this.SpritePaletteComboBox);
            this.Controls.Add(this.spritePictureBox);
            this.Controls.Add(this.SaveSpriteButton);
            this.Controls.Add(this.EnemySpriteComboBox);
            this.Controls.Add(this.SpritObjektIndexUpDown);
            this.Controls.Add(this.LevelSpriteComboBox);
            this.Controls.Add(this.SpriteObjectComboBox);
            this.Controls.Add(this.PalletNumericUpDown);
            this.Controls.Add(this.spriteSheetPictureBox);
            this.Controls.Add(this.SpriteSheetPaletteComboBox);
            this.Controls.Add(this.SpriteComboBox);
            this.Controls.Add(this.PaletteComboBox);
            this.Controls.Add(this.TilesSetComboBox);
            this.Controls.Add(this.tileSheetPicBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FSA Tile Converter";
            ((System.ComponentModel.ISupportInitialize)(this.tileSheetPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteSheetPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PalletNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpritObjektIndexUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spritePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpritePalletNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReplacePaletteIndexUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tileSheetPicBox;
        private System.Windows.Forms.ComboBox TilesSetComboBox;
        private System.Windows.Forms.ComboBox PaletteComboBox;
        private System.Windows.Forms.ComboBox SpriteComboBox;
        private System.Windows.Forms.ComboBox SpriteSheetPaletteComboBox;
        private System.Windows.Forms.PictureBox spriteSheetPictureBox;
        private System.Windows.Forms.NumericUpDown PalletNumericUpDown;
        private System.Windows.Forms.ComboBox SpriteObjectComboBox;
        private System.Windows.Forms.ComboBox LevelSpriteComboBox;
        private System.Windows.Forms.NumericUpDown SpritObjektIndexUpDown;
        private System.Windows.Forms.ComboBox EnemySpriteComboBox;
        private System.Windows.Forms.Button SaveSpriteButton;
        private System.Windows.Forms.PictureBox spritePictureBox;
        private System.Windows.Forms.ComboBox SpritePaletteComboBox;
        private System.Windows.Forms.NumericUpDown SpritePalletNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ReplacePaletteIndexUpDown;
        private System.Windows.Forms.Button SaveTileSheetButton;
        private System.Windows.Forms.Button SaveSpriteSheetButton;
    }
}

