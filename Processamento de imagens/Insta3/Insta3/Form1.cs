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

        Image imagem;
        Boolean Aberto = false;
        

        void openImage()
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                imagem = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = imagem;
                Aberto = true;
            }
        }

        void reload()
        {
            if (!Aberto)
            {

            }
            else
            {
                imagem = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = imagem;
                Aberto = true;
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

        void filtro2()
        {
            label1.Text = trackBar1.Value.ToString();
            label2.Text = trackBar2.Value.ToString();
            label3.Text = trackBar3.Value.ToString();

            float mudaVermelho = trackBar1.Value * 0.001f;
            float mudaVerde = trackBar2.Value * 0.001f;
            float mudaAzul = trackBar3.Value * 0.001f;

            if (!Aberto)
            {

            }
            else
            {
                //pega a imagem do pictureBox e salva em uma variavel Image
                Image image = pictureBox1.Image;
                // Cria um bitmap do tamanho da nossa imagem armazenada em Image
                Bitmap bitmapInvertido = new Bitmap(image.Width, image.Height);

                //cria um objeto do tipo atributo da imagem, 
                //contendo informações de como as cores do bitmap são manipuladas
                ImageAttributes imageAttributes = new ImageAttributes();

                ColorMatrix colorMatrixFoto = new ColorMatrix(new float[][]
                {
                    new float[] {1+mudaVermelho,  0,  0,  0, 0},        // red scaling factor of 2
                    new float[] {0,  1+mudaVerde,  0,  0, 0},        // green scaling factor of 1
                    new float[] {0,  0,  1+mudaAzul,  0, 0},        // blue scaling factor of 1
                    new float[] {0,  0,  0,  1, 0},        // alpha scaling factor of 1
                    new float[] {0,  0,  0,  0, 1}      // three translations of 0.2*/
                });

                imageAttributes.SetColorMatrix(colorMatrixFoto);
                Graphics graphics = Graphics.FromImage(bitmapInvertido);

                graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
                graphics.Dispose();
                imageAttributes.Dispose();
                pictureBox1.Image = bitmapInvertido;
            }
        }

        Image brilho(Image imagem, float brilho)
        {
            //Image image = pictureBox1.Image;
            Bitmap bitmapInvertido = new Bitmap(imagem.Width, imagem.Height);
            ImageAttributes Attributes = new ImageAttributes();
            float FinalValue = brilho / 255.0f;
            ColorMatrix colorMatrixFoto = new ColorMatrix(new float[][]
                {
                    new float[] {1, 0, 0, 0, 0},
                    new float[] {0, 1, 0, 0, 0},
                    new float[] {0, 0, 1, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] { FinalValue, FinalValue, FinalValue, FinalValue, 1}
                });

            Attributes.SetColorMatrix(colorMatrixFoto);
            Graphics NewGraphics = Graphics.FromImage(bitmapInvertido);
            Rectangle retangulo = new Rectangle(0, 0, bitmapInvertido.Width, bitmapInvertido.Height);
            
            NewGraphics.DrawImage(bitmapInvertido, retangulo, 0, 0, bitmapInvertido.Width, bitmapInvertido.Height, GraphicsUnit.Pixel, Attributes);
            NewGraphics.DrawImage(imagem, retangulo);
            Attributes.Dispose();
            NewGraphics.Dispose();
            //bitmapInvertido.Dispose();

            //pictureBox1.Image = bitmapInvertido;
            return (Image)bitmapInvertido;
        }
        
        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            label6.Text = trackBar6.Value.ToString();
            pictureBox1.Image = brilho(pictureBox1.Image, trackBar6.Value);
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
            filtro2();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            filtro2();
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            filtro2();
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            filtro2();
        }

        private void button10_Click(object sender, EventArgs e)
        {
       
        }

    }
}
