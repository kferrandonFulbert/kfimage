using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace kfImage
{
    public partial class fenImage : Form
    {
        public fenImage()
        {
            InitializeComponent();
        }
        private Image loadedImage;

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                loadedImage = Image.FromFile(openFileDialog.FileName);
                picImage.SizeMode = PictureBoxSizeMode.AutoSize;
                picImage.Image = loadedImage;
            }
        }
        private Bitmap bwImage;
        private void btnBlackWhite_Click(object sender, EventArgs e)
        {
            if (loadedImage != null)
            {
                bwImage = new Bitmap(loadedImage);
                for (int i = 0; i < bwImage.Width; i++)
                {
                    for (int j = 0; j < bwImage.Height; j++)
                    {
                        Color pixelColor = bwImage.GetPixel(i, j);
                        int grayscale = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                        bwImage.SetPixel(i, j, Color.FromArgb(grayscale, grayscale, grayscale));
                    }
                }
                
                picImage.Image = bwImage;
                
            }
        }

        private void btnRAZ_Click(object sender, EventArgs e)
        {
            picImage.Image = loadedImage;
        }

        private void btnBinaire_Click(object sender, EventArgs e)
        {
            if (loadedImage != null)
            {
                bwImage = new Bitmap(loadedImage);
                for (int i = 0; i < bwImage.Width; i++)
                {
                    for (int j = 0; j < bwImage.Height; j++)
                    {
                        Color pixelColor = bwImage.GetPixel(i, j);
                        int blackOrWhite = 0;
                        int grayscale = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                        if (grayscale > 121)
                            blackOrWhite = 255;
                        bwImage.SetPixel(i, j, Color.FromArgb(blackOrWhite, blackOrWhite, blackOrWhite));
                    }
                }
                picImage.Image = bwImage;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (picImage.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Fichiers PNG (*.png)|*.png|Fichiers JPEG (*.jpg)|*.jpg|Tous les fichiers (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picImage.Image.Save(saveFileDialog.FileName);
                }
            }
        }

        private void tckLumiere_Scroll(object sender, EventArgs e)
        {
            if (loadedImage != null)
            {
                bwImage = new Bitmap(loadedImage);
                for (int i = 0; i < bwImage.Width; i++)
                {
                    for (int j = 0; j < bwImage.Height; j++)
                    {
                        Color pixelColor = bwImage.GetPixel(i, j);
                        int blackOrWhite = 0;
                        int R, G, B;
                        R = pixelColor.R;
                        G = pixelColor.G;
                        B = pixelColor.B;

                        if(R+tckLumiere.Value > 255) { R = 255; }
                        else { R = R + tckLumiere.Value; }
                        if (G + tckLumiere.Value > 255) { G = 255; }
                        else { G = G + tckLumiere.Value; }
                        if (B + tckLumiere.Value > 255) { B = 255; }
                        else { B = B + tckLumiere.Value;}
                        bwImage.SetPixel(i, j, Color.FromArgb(R, G, B));
                    }
                }
                picImage.Image = bwImage;

            }
        }

        private void btnLumiere_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (loadedImage != null)
            {
                bwImage = new Bitmap(loadedImage);
                for (int i = 0; i < bwImage.Width; i++)
                {
                    for (int j = 0; j < bwImage.Height; j++)
                    {
                        Color pixelColor = bwImage.GetPixel(i, j);
                        int blackOrWhite = 0;
                        int R, G, B;
                        R = pixelColor.R;
                        G = pixelColor.G;
                        B = pixelColor.B;

                        if (R + int.Parse(txtPas.Text) > 255) { R = 255; }
                        else { R = R + int.Parse(txtPas.Text); }
                        if (G + int.Parse(txtPas.Text) > 255) { G = 255; }
                        else { G = G + int.Parse(txtPas.Text); }
                        if (B + int.Parse(txtPas.Text) > 255) { B = 255; }
                        else { B = B + int.Parse(txtPas.Text); }
                        bwImage.SetPixel(i, j, Color.FromArgb(R, G, B));
                    }
                }
                picImage.Image = bwImage;
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
