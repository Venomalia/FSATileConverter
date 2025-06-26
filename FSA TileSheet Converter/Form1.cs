using AuroraLib.Pixel;
using AuroraLib.Pixel.BitmapExtension;
using AuroraLib.Pixel.BlockProcessor;
using AuroraLib.Pixel.Image;
using AuroraLib.Pixel.PixelFormats;
using AuroraLib.Pixel.Processing;
using FSALib.Renderer;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FSA_TileSheet_Converter
{
    public partial class Form1 : Form
    {
        const string DataDirectory = "data";
        const string TileDirectory = DataDirectory + "/sch";
        const string SpriteObjectDirectory = DataDirectory + "/sob";
        const string PaletteDirectory = DataDirectory + "/scl";
        const string LayoutDirectory = DataDirectory + "/spl";

        readonly Bitmap tileBitmap;
        readonly TilesetRenderer<BGRA32> tilesetRenderer;

        readonly Bitmap spriteObjectBitmap;
        readonly SpriteRenderer<BGRA32> spriteRenderer;

        readonly Bitmap spriteSheetBitmap;
        readonly byte[] SCHSpriteSource = new byte[0x8000];
        readonly BGRA32[] SpritePalettes_SCL = new BGRA32[0x100];

        private void ValidateDirectoryExists(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                MessageBox.Show(
                    $"The directory '{directoryPath}' was not found.\n\n" +
                    "Please make sure to extract the 'data.arc' file to this location.",
                    "Directory Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                Environment.Exit(1);
            }
        }

        public Form1()
        {
            InitializeComponent();

            ValidateDirectoryExists(DataDirectory);
            ValidateDirectoryExists(TileDirectory);
            ValidateDirectoryExists(SpriteObjectDirectory);
            ValidateDirectoryExists(PaletteDirectory);
            ValidateDirectoryExists(LayoutDirectory);

            // Initialize tileset Renderer
            using (FileStream baseSch = new FileStream(TileDirectory + "/bg_base_sch.szs", FileMode.Open))
            using (FileStream spl = new FileStream(LayoutDirectory + "/bg_a_spl.szs", FileMode.Open))
            {
                tilesetRenderer = new TilesetRenderer<BGRA32>(spl, baseSch);
            }
            tileBitmap = new Bitmap(256, 1024);
            tileSheetPicBox.Image = tileBitmap;

            LoadDirectoryToComboBox(TilesSetComboBox, TileDirectory, "bg*", "bg_base", "bg_anim", "bg_tenso");
            LoadDirectoryToComboBox(PaletteComboBox, PaletteDirectory, "bg*");

            // Initialize spriteSheet Renderer
            spriteSheetBitmap = new Bitmap(256, 256, System.Drawing.Imaging.PixelFormat.Format8bppIndexed);
            spriteSheetPictureBox.Image = spriteSheetBitmap;
            LoadDirectoryToComboBox(SpriteComboBox, TileDirectory, "*");
            LoadDirectoryToComboBox(SpriteSheetPaletteComboBox, PaletteDirectory, "*");

            // Initialize spriteObject Renderer
            using (FileStream gb_ch_obj_base = new FileStream(TileDirectory + "/gb_ch_obj_base_sch.szs", FileMode.Open))
            using (FileStream enemy = new FileStream(TileDirectory + "/enemy_sch.szs", FileMode.Open))
            using (FileStream gals2 = new FileStream(TileDirectory + "/gals2_sch.szs", FileMode.Open))
            using (FileStream player = new FileStream(TileDirectory + "/player_sch.szs", FileMode.Open))
            using (FileStream gals = new FileStream(TileDirectory + "/gals_sch.szs", FileMode.Open))
            {
                spriteRenderer = new SpriteRenderer<BGRA32>(gb_ch_obj_base, enemy, gals2, player, gals);
            }
            spriteObjectBitmap = new Bitmap(128, 128);
            spritePictureBox.Image = spriteObjectBitmap;

            LoadDirectoryToComboBox(SpriteObjectComboBox, SpriteObjectDirectory, "*");
            LoadDirectoryToComboBox(LevelSpriteComboBox, TileDirectory, "gb_ch_obj_tr_*");
            LoadDirectoryToComboBox(EnemySpriteComboBox, TileDirectory, "en*");
            EnemySpriteComboBox.SelectedIndex = 1;
            LoadDirectoryToComboBox(SpritePaletteComboBox, PaletteDirectory, "*", "bg", "end_code");
        }

        private static void LoadDirectoryToComboBox(ComboBox comboBox, string directory, string searchPattern, params string[] ignore)
        {
            string[] tileFiles = Directory.GetFiles(directory, searchPattern);

            comboBox.Items.Clear();
            foreach (string file in tileFiles)
            {
                string fileName = Path.GetFileName(file);
                if (ignore.Any(prefix => fileName.StartsWith(prefix, StringComparison.OrdinalIgnoreCase)))
                    continue;

                comboBox.Items.Add(fileName);
            }
            comboBox.SelectedIndex = 0;
        }

        #region TileSheet
        private void TilesSetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tileFilePath = Path.Combine(TileDirectory, TilesSetComboBox.SelectedItem.ToString());
            using (FileStream sch = new FileStream(tileFilePath, FileMode.Open))
            {
                tilesetRenderer.LoadTiles(sch);
            }
            ConvertTileSheetButton_Click(sender, e);
        }

        private void PaletteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string paletteFilePath = Path.Combine(PaletteDirectory, PaletteComboBox.SelectedItem.ToString());
            using (FileStream scl = new FileStream(paletteFilePath, FileMode.Open))
            {
                tilesetRenderer.LoadPalettes(scl);
            }
            ConvertTileSheetButton_Click(sender, e);
        }

        private void FSATVPalette<TColor>(Span<TColor> palettes) where TColor : unmanaged, IRGBA<byte>
        {
            // Sets the transparency for the 8th, 9th and 10th color in the 13th palette
            Span<TColor> palette13 = palettes.Slice(13 * 16, 16);
            palette13[8].A = 80;
            palette13[9].A = 120;
            palette13[10].A = 160;
        }

        private void ConvertTileSheetButton_Click(object sender, EventArgs e)
        {
            using (var tileImage = (MemoryImage<BGRA32>)tileBitmap.AsAuroraImage())
            {
                tilesetRenderer.Draw(tileImage);
            }

            tileSheetPicBox.Refresh();
        }

        private void SaveTileSheetButton_Click(object sender, EventArgs e)
        {
            ConvertTileSheetButton_Click(sender, e);
            string name = Path.GetFileNameWithoutExtension(TilesSetComboBox.SelectedItem.ToString());
            tileBitmap.Save($"{name}-{PaletteComboBox.SelectedIndex}.png", System.Drawing.Imaging.ImageFormat.Png);
        }
        #endregion

        #region SpriteSheet

        private void SpriteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load Sprites
            string spritesFilePath = Path.Combine(TileDirectory, SpriteComboBox.SelectedItem.ToString());
            using (FileStream sprite = new FileStream(spritesFilePath, FileMode.Open))
            {
                sprite.Read(SCHSpriteSource, 0, (int)sprite.Length);
                SCHSpriteSource.AsSpan((int)sprite.Length).Fill(0);
            }
            ConvertSpriteSheetButton_Click(sender, e);
        }

        private void SpriteSheetPaletteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load Sprites Palettes
            string spritesPaletteFilePath = Path.Combine(PaletteDirectory, SpriteSheetPaletteComboBox.SelectedItem.ToString());
            ReadOnlySpan<BGR555> sourceSpritePalettes = MemoryMarshal.Cast<byte, BGR555>(File.ReadAllBytes(spritesPaletteFilePath));
            sourceSpritePalettes.To<BGR555, BGRA32>(SpritePalettes_SCL);
            SetPaletteTransparency(SpritePalettes_SCL.AsSpan());
            ConvertSpriteSheetButton_Click(sender, e);
        }

        private void SetPaletteTransparency<TColor>(Span<TColor> palettes) where TColor : unmanaged, IAlpha<byte>
        {
            // Set the first color of each palette to transparent.
            for (int i = 0; i < palettes.Length; i += 16)
            {
                palettes[i].A = 0;
            }
        }

        private void PalletNumericUpDown_ValueChanged(object sender, EventArgs e) => ConvertSpriteSheetButton_Click(sender, e);


        private void ConvertSpriteSheetButton_Click(object sender, EventArgs e)
        {
            using (var spriteImage = (MemoryPaletteImage<I8, BGRA32>)spriteSheetBitmap.AsAuroraImage())
            {
                spriteImage.Clear();

                ReadOnlySpan<BGRA32> palette = SpritePalettes_SCL.AsSpan((int)(PalletNumericUpDown.Value) * 16, 16);
                palette.CopyTo(spriteImage.Palette);

                var pixelData = (MemoryImage<I8>)spriteImage.GetBuffer();
                new I4Block().DecodeImageBuffer(SCHSpriteSource, MemoryMarshal.Cast<I8, I4>(pixelData.Pixel), pixelData.Stride);
                spriteImage.Dispose();
            }
            spriteSheetPictureBox.Refresh();
        }

        private void SaveSpriteSheetButton_Click(object sender, EventArgs e)
        {
            ConvertSpriteSheetButton_Click(sender, e);
            string sheet = Path.GetFileNameWithoutExtension(SpriteComboBox.SelectedItem.ToString());
            string palette = Path.GetFileNameWithoutExtension(SpriteSheetPaletteComboBox.SelectedItem.ToString());
            spriteSheetBitmap.Save($"{sheet}-{palette}-{PalletNumericUpDown.Value}.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        #endregion

        #region Sprite

        private void SpritObjektIndex_ValueChanged(object sender, EventArgs e) => DrawSprite();

        private void SpritePalletNumericUpDown_ValueChanged(object sender, EventArgs e) => DrawSprite();

        private void DrawSprite()
        {
            using (var spriteImage = (MemoryImage<BGRA32>)spriteObjectBitmap.AsAuroraImage())
            {
                spriteImage.Pixel.Clear();
                spriteRenderer.DrawSprite(spriteImage, 64, 64, (ushort)SpritObjektIndexUpDown.Value, (int)SpritePalletNumericUpDown.Value, (int)ReplacePaletteIndexUpDown.Value);
            }
            spritePictureBox.Refresh();
        }

        private void SpriteObjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sobFilePath = Path.Combine(SpriteObjectDirectory, SpriteObjectComboBox.SelectedItem.ToString());

            using (FileStream sob = new FileStream(sobFilePath, FileMode.Open))
            {
                spriteRenderer.LoadSpriteAttributeList(sob);
            }
            SpritObjektIndexUpDown.Value = 0;
            SpritObjektIndexUpDown.Maximum = spriteRenderer.spriteAttributes.Count - 1;
            DrawSprite();
        }

        private void LevelSpriteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string schFilePath = Path.Combine(TileDirectory, LevelSpriteComboBox.SelectedItem.ToString());

            using (FileStream sch = new FileStream(schFilePath, FileMode.Open))
            {
                spriteRenderer.LoadSpriteLevelIndices(sch);
            }
            DrawSprite();
        }

        private void EnemySpriteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string schFilePath = Path.Combine(TileDirectory, EnemySpriteComboBox.SelectedItem.ToString());

            using (FileStream sch = new FileStream(schFilePath, FileMode.Open))
            {
                spriteRenderer.LoadEnemyOrEnding(sch);
            }
            DrawSprite();
        }

        private void SaveSpriteButton_Click(object sender, EventArgs e)
        {
            DrawSprite();
            spriteObjectBitmap.Save($"{SpriteObjectComboBox.SelectedItem}-{SpritObjektIndexUpDown.Value}.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void SpritePaletteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string scleFilePath = Path.Combine(PaletteDirectory, SpritePaletteComboBox.SelectedItem.ToString());
            using (FileStream scl = new FileStream(scleFilePath, FileMode.Open))
            {
                spriteRenderer.LoadPalettes(scl);
            }
            DrawSprite();
        }
        #endregion
    }
}
