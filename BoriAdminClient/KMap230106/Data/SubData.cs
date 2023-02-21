using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMap230106.Data
{
    public class SubData
    {
        public int id { get; private set; }
        public string title { get; private set; }
        public string description { get; private set; }
        public string img { get; private set; }
        public string imgurl { get; private set; }

        public SubData(int _id, string _title, string _description, string _img, string _imgurl)
        {
            id=_id;
            title=_title;
            description=_description;
            img=_img;
            imgurl=_imgurl;

        }
    }
}
