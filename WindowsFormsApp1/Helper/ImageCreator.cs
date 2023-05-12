using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Helper
{
    public class ImageCreator
    {
        public static void Crear(PictureBox pictureBox)
        {
            string photopath;
            byte[] binaryphoto;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "JPG(*.JPG)|*.jpg|*.jpeg|JPEG(*.JPEG)";
            file.Title = "Por favor selecciona una imagen";

            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(file.OpenFile());
                photopath = file.FileName;
                FileStream fs = new FileStream(photopath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                binaryphoto = br.ReadBytes((int)fs.Length);
                fs.Close();
            }
        }
    }
}
