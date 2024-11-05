using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMeansColourReduction
{
    public partial class KMean : Form
    {
        public KMean()
        {
            InitializeComponent();
        }

        private void ChoosePicBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    // The image should be displayed in the picture box
                    Image image = Image.FromFile(filePath);
                    pictureBoxIn.Image = image;
                    // the imaage should be displayed accuratly not only a corner of the image
                    pictureBoxIn.SizeMode = PictureBoxSizeMode.StretchImage;
                    // TODO now we need to call the actual function that reduces the picture
                }
            }
        }

        private void ReducePictureKmeans(Image image)
        {
            // TODO get the image and call help functions
            Bitmap bitmap = new Bitmap(image);
            var pixels = GetPixels(bitmap);

            // TODO Step 1 create random centroids
            
           
            // TODO Step 2 every pixel is grouped to the nearest Zentroid

            // TODO Step 3 Move the centroid in the new centre of gravity
            
            // TODO Step 4 group the pixels freshly since the centroid moved

            // TODO Repeat step 3 and 4 until there are no differences anymore
        }

        /// <summary>
        /// Extracts the color of each pixel from the given bitmap and returns them as a list of Color objects.
        /// </summary>
        /// <param name="bitmap">The bitmap from which to extract pixel colors.</param>
        /// <returns>A list of Color objects representing the colors of each pixel in the bitmap.</returns>
        private List<Color> GetPixels(Bitmap bitmap)
        {
            List<Color> pixels = new List<Color>();
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    pixels.Add(pixelColor);
                }
            }
            return pixels;
        }
    }
}