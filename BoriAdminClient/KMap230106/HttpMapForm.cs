using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMap230106
{
    public partial class HttpMapForm : Form
    {
        public HttpMapForm()
        {
            InitializeComponent();
        }
        private void HttpMapForm_Load(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.google.co.kr/maps");
        }
        public void mapChaging(double latitude,double longtitude)
        {
            string uri = string.Format("https://www.google.co.kr/maps/place/{0}+{1}", latitude, longtitude);
            webView21.Source = new Uri(uri);

        }
    }
}
