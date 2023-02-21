using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Metrics;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using KMap230106.HttpServer;
using System.Data;
using System;
using System.IO.MemoryMappedFiles;
using KMap230106.Data;

namespace KMap230106
{

    public partial class AdminMainForm : Form
    {

        private readonly ImageForm ImgForm = new ImageForm();
        private readonly HttpMapForm mapForm = new HttpMapForm();

        private List<MapData> MapDatas = new List<MapData>();
        private List<MainData> MainDatas = new List<MainData>();
        private List<SubData> SubDatas = new List<SubData>();

        public Map_Httpwebrequest Map_httprequest = new Map_Httpwebrequest();
        public Main_Httpwebrequest Main_httprequest = new Main_Httpwebrequest();
        public Sub_Httpwebrequest Sub_httprequest = new Sub_Httpwebrequest();


        private int index;//���̵��� üũ�ϱ����� ���� 

    

        public AdminMainForm()
        {
            InitializeComponent();
            CreateListViewElement_Map();//������ ��� ��� �߰� 
            index = 1;
        }
        #region AllPrint�� ���� �޼���
        private async void Map_AllPrint()
        {
            LV_MarkData.Items.Clear();
            MapDatas = await Map_httprequest.RecData();
            if (MapDatas != null)
            {
                foreach (MapData md in MapDatas)
                {
                    ListViewItem item = new ListViewItem(md.id.ToString());
                    item.SubItems.Add(md.name);
                    item.SubItems.Add(md.imgname);
                    item.SubItems.Add(md.address);
                    item.SubItems.Add(md.description);
                    item.SubItems.Add(md.tag);
                    item.SubItems.Add(md.latitude.ToString());
                    item.SubItems.Add(md.longtitude.ToString());
                    LV_MarkData.Items.Add(item);

                }
                LV_MarkData.Sorting = SortOrder.Ascending;
                MapDatas.Sort((idA, idB) => idA.id.CompareTo(idB.id));

            }
        }
        

        private async void Main_allPrint()
        {
            LV_MarkData.Items.Clear();
            MainDatas = await Main_httprequest.RecData();
            if (MainDatas != null)
            {
                foreach (MainData md in MainDatas)
                {
                    ListViewItem item = new ListViewItem(md.id.ToString());
                    item.SubItems.Add(md.img);
                    item.SubItems.Add(md.imgurl);
                 
                    LV_MarkData.Items.Add(item);
                }
                LV_MarkData.Sorting = SortOrder.Ascending;
                MainDatas.Sort((idA, idB) => idA.id.CompareTo(idB.id));

            }
        }

        private async void Sub_allPrint()
        {
            LV_MarkData.Items.Clear();
            SubDatas = await Sub_httprequest.RecData();

            if (SubDatas != null)
            {
                foreach (SubData md in SubDatas)
                {
                    ListViewItem item = new ListViewItem(md.id.ToString());
                    item.SubItems.Add(md.title);
                    item.SubItems.Add(md.description);
                    item.SubItems.Add(md.img);
                    item.SubItems.Add(md.imgurl);

                    LV_MarkData.Items.Add(item);

                }
                LV_MarkData.Sorting = SortOrder.Ascending;
                SubDatas.Sort((idA, idB) => idA.id.CompareTo(idB.id));

            }

        }

        #endregion
        #region ��ư ������

        private void Btn_on()
        {
            btn_delete.Enabled = true;
            btn_update.Enabled = true;

            btn_mf_delete.Enabled = true;
            
            btn_sub_delete.Enabled = true;  
            btn_sub_createNupdate.Enabled = true;

        }
        private void Btn_off()
        {
            btn_delete.Enabled = false;
            btn_update.Enabled = false;

            btn_mf_delete.Enabled = false;

            btn_sub_delete.Enabled = false;
        }
        private void TextBoxClear()
        {
            tb_id.Text = "";
            tb_name.Text = "";
            tb_imgname.Text = "";
            tb_address.Text = "";
            tb_description.Text = "";
            tb_tag.Text = "";
            tb_latitude.Text = "";
            tb_longtitude.Text =  "";

            tb_mf_id.Text = "";
            tb_mf_img.Text = "";
            tb_mf_imgurl.Text = "";

            tb_sub_id.Text = "";
            tb_sub_title.Text = "";
            tb_sub_description.Text = "";
            tb_sub_img.Text = "";
            tb_sub_imgurl.Text = "";

            Btn_off();

        }
        //sub���� update�� ���� create������ �Ǵ��ϴ� �޼ҵ�
        private bool create_updateSelect(int id)
        {
            bool isResult=false;
            for (int i =0; i < LV_MarkData.Items.Count; i++)
            {
                ListViewItem item = LV_MarkData.Items[i]; ;
                isResult = item.SubItems[0].Text.Contains(id.ToString());
                if (isResult) return isResult;
            }
            return isResult;
        }
        private async void btn_sub_createNupdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Sub_allPrint(); ����ȭ ���������� ������ ���� ��� �Ұ��� 
                if (tb_sub_id.Text == "")
                {
                    string title = tb_sub_title.Text;
                    string description = tb_sub_description.Text;
                    string img = tb_sub_img.Text;
                    string imgurl = tb_sub_imgurl.Text;
                    tb_result.Text = await Sub_httprequest.CreateMarkerPost(title, description, img, imgurl);
                    TextBoxClear();
                    Sub_allPrint();
                    tb_tureFalse.Text = "����";
                    MessageBox.Show("����");
                }
                else if (create_updateSelect(int.Parse(tb_sub_id.Text)))
                {
                    int id =int.Parse( tb_sub_id.Text);
                    string title = tb_sub_title.Text;
                    string description = tb_sub_description.Text;
                    string img = tb_sub_img.Text;
                    string imgurl = tb_sub_imgurl.Text;
                    tb_result.Text = await Sub_httprequest.UpdateDataPost(id, title, description, img, imgurl);
                    TextBoxClear();
                    Sub_allPrint();
                    tb_tureFalse.Text = "����";
                    MessageBox.Show("������Ʈ");
                }
                else
                {
                    MessageBox.Show("�������� �ʴ� Ű���� �ԷµǾ����ϴ� Ȯ�����ּ��� (Create�� �ʿ��Ͻø� Ű���� �Է�����������)");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("�Է°��� �������� Ȯ�����ּ��� \n ������ :  " + ex, "���");
                tb_tureFalse.Text = "False"+ex;
            }

        }
        private async void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tb_name.Text;
                string imgname = tb_imgname.Text;
                string address = tb_address.Text;
                string description = tb_description.Text;
                string tag = tb_tag.Text;
                double lat = Double.Parse(tb_latitude.Text);
                double lng = Double.Parse(tb_longtitude.Text);
                tb_result.Text = await Map_httprequest.CreateMarkerPost(name, imgname, address, description, tag, lat, lng);
                TextBoxClear();
                Map_AllPrint();
                tb_tureFalse.Text = "����";

            }
            catch(Exception ex )
            {
                MessageBox.Show("�Է��� �߸��Ǿ��ְų� ������ ������ �ֽ��ϴ�.");
                tb_tureFalse.Text = String.Format("���� {0}", ex.ToString());
            }
       

        }
        
        private async void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tb_id.Text);
                string name = tb_name.Text;
                string imgname = tb_imgname.Text;
                string address = tb_address.Text;
                string description = tb_description.Text;
                string tag = tb_tag.Text;
                double lat = Double.Parse(tb_latitude.Text);
                double lng = Double.Parse(tb_longtitude.Text);
                tb_result.Text = await Map_httprequest.UpdateDataPost(id, name, imgname, address, description, tag, lat, lng);
                TextBoxClear();
                Map_AllPrint();
                tb_tureFalse.Text = "����";
            }
            catch (Exception ex)
            {
                MessageBox.Show("�Է��� �߸��Ǿ��ְų� ������ ������ �ֽ��ϴ�.");
                tb_tureFalse.Text = String.Format("���� {0}", ex.ToString());
               
            }
  
        }
        private async void btn_sub_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tb_sub_id.Text);
                tb_result.Text = await Sub_httprequest.DeleteMarkerPost(id);
                TextBoxClear();
                Sub_allPrint();
                tb_tureFalse.Text = "����";
            }
            catch (Exception ex)
            {
                MessageBox.Show("�Է��� �߸��Ǿ��ְų� ������ ������ �ֽ��ϴ�.");
                tb_tureFalse.Text = String.Format("���� {0}", ex.ToString());
            }

        }
        private async void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tb_id.Text);
                tb_result.Text = await Map_httprequest.DeleteMarkerPost(id);
                TextBoxClear();
                Map_AllPrint();
                tb_tureFalse.Text = "����";
            }
            catch (Exception ex)
            {
                MessageBox.Show("�Է��� �߸��Ǿ��ְų� ������ ������ �ֽ��ϴ�.");
                tb_tureFalse.Text = String.Format("���� {0}" ,ex.ToString());
            }
        }
        private async void btn_mf_create_Click(object sender, EventArgs e)
        {
            try
            {
                string img = tb_mf_img.Text;
                string imgurl = tb_mf_imgurl.Text;     
                tb_result.Text = await Main_httprequest.CreateMainFormPost(img,imgurl);
                TextBoxClear();
                Main_allPrint();
                tb_tureFalse.Text = "����";

            }
            catch (Exception ex)
            {
                MessageBox.Show("�Է��� �߸��Ǿ��ְų� ������ ������ �ֽ��ϴ�.");
                tb_tureFalse.Text = String.Format("���� {0}", ex.ToString());
            }
        }

        private async void btn_mf_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tb_mf_id.Text);
                tb_result.Text = await Main_httprequest.DeleteMarkerPost(id);
                TextBoxClear();
                Main_allPrint();
                tb_tureFalse.Text = "����";
            }
            catch (Exception ex)
            {
                MessageBox.Show("�Է��� �߸��Ǿ��ְų� ������ ������ �ֽ��ϴ�.");
                tb_tureFalse.Text = String.Format("���� {0}", ex.ToString());
            }

        }

        //�ؽ�Ʈ�信 ��������ϴ� ��� 
        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                if (index==1)
                {
                    Map_AllPrint();
                    TextBoxClear();

                }
                else if (index==2)
                {
                    Main_allPrint();
                    TextBoxClear();
                  
                }
                else if (index == 3)
                {
                    Sub_allPrint();
                    TextBoxClear();

                }
                tb_tureFalse.Text = "����";
            }
            catch(Exception ex)
            {
                MessageBox.Show("������ ������ �����߽��ϴ�..");
                tb_tureFalse.Text = String.Format("���� {0}", ex.ToString());
            }

        }
       
        #endregion
        private void LV_MarkData_SelectedIndexChanged(object sender, EventArgs e)
        {
            try{
                if (index == 1)
                {
                    if (LV_MarkData.FocusedItem.Index >= 0)
                    {
                        int index = LV_MarkData.FocusedItem.Index;
                        tb_id.Text = MapDatas[index].id.ToString();
                        tb_name.Text=MapDatas[index].name.ToString(); ;
                        tb_imgname.Text = MapDatas[index].imgname.ToString();
                        tb_address.Text= MapDatas[index].address.ToString();
                        tb_description.Text = MapDatas[index].description.ToString();
                        tb_tag.Text = MapDatas[index].tag.ToString();
                        tb_latitude.Text = MapDatas[index].latitude.ToString();
                        tb_longtitude.Text = MapDatas[index].longtitude.ToString();
                        Btn_on();   //��ư Ȱ��ȭ ������Ʈ�� �������
                        ImgForm.ImageLord(MapDatas[index].imgname.ToString());
                        mapForm.mapChaging(Double.Parse( MapDatas[index].latitude),Double.Parse( MapDatas[index].longtitude));
                    }   
                }
                else if (index == 2)
                {
                    if (LV_MarkData.FocusedItem.Index >= 0)
                    {
                        int index = LV_MarkData.FocusedItem.Index;
                        tb_mf_id.Text = MainDatas[index].id.ToString();
                        tb_mf_img.Text = MainDatas[index].img.ToString() ;
                        tb_mf_imgurl.Text = MainDatas[index].imgurl.ToString(); 
                        Btn_on();   //��ư Ȱ��ȭ ������Ʈ�� �������
                        //ImgForm.ImageLord(tb_imgname.Text = MapDatas[index].imgName.ToString());
                        PB_img.LoadAsync(MainDatas[index].img.ToString());
                        PB_img.SizeMode = PictureBoxSizeMode.StretchImage;
                        PB_imgurl.LoadAsync(MainDatas[index].imgurl.ToString());
                        PB_imgurl.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                }
                else if (index == 3)
                {
                    if (LV_MarkData.FocusedItem.Index >= 0)
                    {
                        int index = LV_MarkData.FocusedItem.Index;
                        tb_sub_id.Text = SubDatas[index].id.ToString();
                        tb_sub_title.Text = SubDatas[index].title.ToString();
                        tb_sub_description.Text = SubDatas[index].description.ToString();
                        tb_sub_img.Text = SubDatas[index].img.ToString();
                        tb_sub_imgurl.Text = SubDatas[index].imgurl.ToString();
                        Btn_on();   //��ư Ȱ��ȭ ������Ʈ�� �������
                        //ImgForm.ImageLord(tb_imgname.Text = MapDatas[index].imgName.ToString());
                        pb_sub_img.LoadAsync(SubDatas[index].img.ToString());
                        pb_sub_img.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb_sub_imgurl.LoadAsync(SubDatas[index].imgurl.ToString());
                        pb_sub_imgurl.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                    Btn_on();
                }

                tb_tureFalse.Text = "����";


            }
            catch (Exception ex)
            {
                //��ҹٲܽ� ȣ�⿡�� �߻������� ���� 
            }

        }

        //�������ε�� ��� ������ ����������
        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            ImgForm.StartPosition = FormStartPosition.Manual;
            ImgForm.Location = new Point(120,10);
            ImgForm.Show();
            ImgForm.Focus();

            mapForm.StartPosition=FormStartPosition.Manual;
            mapForm.Location = new Point(240, 10);
            mapForm.Show();
            mapForm.Focus();

        }


        #region ����Ʈ�� ���(��)���� 

        private void CreateListViewElement_Map()
        {
            LV_MarkData.Clear();
            LV_MarkData.View = View.Details;
            LV_MarkData.FullRowSelect = true;
            LV_MarkData.Columns.Add("ID", 60);
            LV_MarkData.Columns.Add("NAME", 80);
            LV_MarkData.Columns.Add("IMGNAME", 120);
            LV_MarkData.Columns.Add("ADDRESS", 120);
            LV_MarkData.Columns.Add("DESCRIPTION", 200);
            LV_MarkData.Columns.Add("TAG", 120);
            LV_MarkData.Columns.Add("LATITUDE", 100);
            LV_MarkData.Columns.Add("LONGTITUDE", 100);
            /*  //LV_MarkData
              // columnHeader1
              this.columnHeader1.Text = "id";
              // 
              // columnHeader2
              this.columnHeader2.Text = "name";
              this.columnHeader2.Width = 80;
              // 
              // columnHeader3
              // 
              this.columnHeader3.Text = "imgName";
              this.columnHeader3.Width = 120;
              // 
              // columnHeader4
              // 
              this.columnHeader4.Text = "address";
              this.columnHeader4.Width = 120;
              // 
              // columnHeader5
              // 
              this.columnHeader5.Text = "description";
              this.columnHeader5.Width = 200;
              // 
              // columnHeader6
              // 
              this.columnHeader6.Text = "tag";
              this.columnHeader6.Width = 120;
              // 
              // columnHeader7
              // 
              this.columnHeader7.Text = "latitude";
              this.columnHeader7.Width = 100;
              // 
              // columnHeader8
              // 
              this.columnHeader8.Text = "longtitude";
              this.columnHeader8.Width = 100;
              // 
              // tb_tureFalse
              // */
        }
        private void CreateListViewElement_Main()
        {
            LV_MarkData.Clear();
            LV_MarkData.View = View.Details;
            LV_MarkData.FullRowSelect = true;
            LV_MarkData.Columns.Add("ID", 60);
            LV_MarkData.Columns.Add("IMG", 360);
            LV_MarkData.Columns.Add("IMGURL", 360);

          
        }
        private void CreateListViewElement_SubMain()
        {
            LV_MarkData.Clear();
            LV_MarkData.View = View.Details;
            LV_MarkData.FullRowSelect = true;
            LV_MarkData.Columns.Add("ID", 60);
            LV_MarkData.Columns.Add("TITLE", 120);
            LV_MarkData.Columns.Add("DESCRIPTION", 200);
            LV_MarkData.Columns.Add("IMG", 250);
            LV_MarkData.Columns.Add("IMGURL", 250);
        }
        #endregion

        #region �������� �̵��� ���� �Լ�
        private void TP_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(TP_Map.Focus())
            {
                CreateListViewElement_Map();//��� �ʱ�ȭ
                index = 1;
            }
           else if(TP_MainForm.Focus())
            {
                CreateListViewElement_Main();//��� �ʱ�ȭ
                index = 2;
            }
            else if(TP_SubMain.Focus())
            {
                CreateListViewElement_SubMain();//��� �ʱ�ȭ
                index = 3;
            };
        }


        #endregion

        private void LV_MarkData_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (LV_MarkData.Sorting == SortOrder.Ascending)
            {
                LV_MarkData.Sorting = SortOrder.Descending;
                MainDatas.Sort((idA, idB) => idB.id.CompareTo(idA.id));
                MapDatas.Sort((idA, idB) => idB.id.CompareTo(idA.id));
                SubDatas.Sort((idA, idB) => idB.id.CompareTo(idA.id));



            }
            else
            {
                LV_MarkData.Sorting = SortOrder.Ascending;
                MainDatas.Sort((idA, idB) => idA.id.CompareTo(idB.id));
                MapDatas.Sort((idA, idB) => idA.id.CompareTo(idB.id));
                SubDatas.Sort((idA, idB) => idA.id.CompareTo(idB.id));


            }
        }
    }
}