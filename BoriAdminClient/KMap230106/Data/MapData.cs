using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMap230106.HttpServer
{
    public class MapData 
    {
        public int id { get; private set; }
        public string name { get; private set; }
        public string imgname { get; private set; }
        public string address { get; private set; }
        public string description { get; private set; }
        public string tag { get; private set; }
        public string latitude { get; private set; }
        public string longtitude { get; private set; }


        public MapData(int _id, string _name, string _imgname, string _address, string _description, string _tag, string _lat, string _lng)
        {
            id = _id;
            name = _name;
            imgname = _imgname;
            address = _address;
            description = _description;
            tag = _tag;
            latitude = _lat;
            longtitude = _lng;
        }

    }
}
