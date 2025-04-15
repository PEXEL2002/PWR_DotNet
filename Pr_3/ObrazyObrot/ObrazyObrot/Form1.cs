namespace ObrazyObrot
{
    public partial class Form1 : Form
    {
        private Bitmap? originalImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Obrazy (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|Wszystkie pliki (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(dialog.FileName);
                pictureBoxOriginal.Image = originalImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Najpierw wczytaj obraz.");
                return;
            }
            Bitmap img1 = new Bitmap(originalImage);
            Bitmap img2 = new Bitmap(originalImage);
            Bitmap img3 = new Bitmap(originalImage);
            Bitmap img4 = new Bitmap(originalImage);

            Parallel.Invoke(
                () => pictureBox4.Image = ApplyGrayscale(img1),
                () => pictureBox2.Image = ApplyNegative(img2),
                () => pictureBox3.Image = ApplyThreshold(img3, 100),
                () => pictureBox5.Image = ApplyMirror(img4)
            );
        }
        private Bitmap ApplyGrayscale(Bitmap img)
        {
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color c = img.GetPixel(x, y);
                    int gray = (c.R + c.G + c.B) / 3;
                    img.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            return img;
        }

        private Bitmap ApplyNegative(Bitmap img)
        {
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color c = img.GetPixel(x, y);
                    img.SetPixel(x, y, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                }
            }
            return img;
        }

        private Bitmap ApplyThreshold(Bitmap img, int threshold)
        {
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color c = img.GetPixel(x, y);
                    int avg = (c.R + c.G + c.B) / 3;
                    Color newColor = avg < threshold ? Color.Black : Color.White;
                    img.SetPixel(x, y, newColor);
                }
            }
            return img;
        }

        private Bitmap ApplyMirror(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width / 2; x++)
                {
                    Color temp = img.GetPixel(x, y);
                    img.SetPixel(x, y, img.GetPixel(width - x - 1, y));
                    img.SetPixel(width - x - 1, y, temp);
                }
            }
            return img;
        }

    }
}
