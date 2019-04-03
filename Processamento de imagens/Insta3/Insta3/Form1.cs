using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Insta3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image imagemOriginal;
        Image imagemEditada;
        Boolean Aberto = false;


        void openImage()
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                imagemOriginal = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = imagemOriginal;
                Aberto = true;
            }
        }

        void reload()
        {
            if (!Aberto)
            {
                // MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                if (Aberto)
                {
                    imagemEditada = pictureBox1.Image;
                    pictureBox1.Image = imagemEditada;
                    Aberto = true;
                }
            }
        }
        void saveImage()
        {
            if (Aberto)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Images|*.png;*.bmp;*.jpg;";
                ImageFormat imageFormat = ImageFormat.Png;
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    String external = Path.GetExtension(saveFileDialog.FileName);
                    switch (external)
                    {
                        case ".jpg":
                            imageFormat = ImageFormat.Jpeg;
                            break;
                        case ".png":
                            imageFormat = ImageFormat.Png;
                            break;

                    }
                    pictureBox1.Image.Save(saveFileDialog.FileName, imageFormat);
                }
            }
            else { MessageBox.Show("Nenhuma imagem carregada, carregue a imagem primeiro."); }
        }
        void /*Image*/ rgb(Image imagem, float red, float green, float blue)
        {
            float mudaVermelho = red / 255.0f;
            float mudaVerde = green / 255.0f;
            float mudaAzul = blue / 255.0f;

            //reload();
            if (!Aberto)
            {
                //return imagem;
            }
            else
            {
                Bitmap image = (Bitmap)imagem;
                Bitmap bitmapInvertido = new Bitmap(image, image.Width, image.Height);
                ImageAttributes imageAttributes = new ImageAttributes();
                Graphics graphics = Graphics.FromImage(bitmapInvertido);
                Rectangle retangulo = new Rectangle(0, 0, bitmapInvertido.Width, bitmapInvertido.Height);

                ColorMatrix colorMatrixFoto = new ColorMatrix(new float[][]
                {
                    new float[] {1+mudaVermelho,  0,  0,  0, 0},
                    new float[] {0,  1+mudaVerde,  0,  0, 0},
                    new float[] {0,  0,  1+mudaAzul,  0, 0},
                    new float[] {0,  0,  0,  1, 0},
                    new float[] {0,  0,  0,  0, 1}
                });

                imageAttributes.SetColorMatrix(colorMatrixFoto);
                graphics.DrawImage(image, retangulo, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
                graphics.Dispose();
                imageAttributes.Dispose();
                pictureBox1.Image = bitmapInvertido;
                imagemEditada = pictureBox1.Image;
                //return (Image)bitmapInvertido;
            }
        }
        void /*Image*/ brilho(Image imagem, float brilho)
        {
            //reload();
            Image bmap = imagem;
            ImageAttributes Attributes = new ImageAttributes();
            Bitmap bitmapInvertido = new Bitmap(bmap, bmap.Width, bmap.Height);
            Graphics NewGraphics = Graphics.FromImage(bitmapInvertido);
            Rectangle retangulo = new Rectangle(0, 0, bmap.Width, bmap.Height);

            float FinalValue = brilho / 255.0f;
            ColorMatrix colorMatrixFoto = new ColorMatrix(new float[][]
                {
                    new float[] {1, 0, 0, 0, 0},
                    new float[] {0, 1, 0, 0, 0},
                    new float[] {0, 0, 1, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {FinalValue, FinalValue, FinalValue, 0, 1}
                });

            Attributes.SetColorMatrix(colorMatrixFoto);

            NewGraphics.DrawImage(bmap, retangulo, 0, 0, bmap.Width, bmap.Height, GraphicsUnit.Pixel, Attributes);
          
            NewGraphics.Dispose();
            pictureBox1.Image = bitmapInvertido;
            imagemEditada = pictureBox1.Image;
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            openImage();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            saveImage();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }


        void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            rgb(imagemOriginal, 0, trackBar1.Value, 0);
            
        }

        void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = trackBar2.Value.ToString();
            rgb(imagemOriginal, 0, trackBar2.Value, 0);
           
            
        }

        void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = trackBar3.Value.ToString();
                rgb(imagemOriginal, 0, trackBar3.Value, 0);
           
        }

        void trackBar6_Scroll(object sender, EventArgs e)
        {
            label6.Text = trackBar6.Value.ToString();
            brilho(imagemOriginal, trackBar6.Value);
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
