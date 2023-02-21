using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMap230106.HttpServer
{
    public partial class ImageForm : Form
    {
        public ImageForm()
        {
            InitializeComponent();
            
        }
        public void showimg()
        {

        }

        public void ImageLord(string url)
        {
            pictureBox.LoadAsync(url);
            pictureBox.SizeMode=PictureBoxSizeMode.StretchImage;
           
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
    
}
