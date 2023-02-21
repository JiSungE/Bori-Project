using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMap230106.Data
{
    public class MainData
    {
        public int id { get; private set; }
        public string img { get; private set; }
        public string imgurl { get; private set; }
 

        public MainData(int _id, string _img, string _imgurl)
        {
            id= _id;
            img= _img;
            imgurl= _imgurl;

        }
    }
}
