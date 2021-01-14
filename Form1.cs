using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_01_MID_3A713155.Properties;

namespace WP_2020_01_MID_3A713155
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 為圖片產生陣列
        /// </summary>
        List<Image> res = new List<Image>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// 判斷是否空白
            /// </summary>
            if (string.IsNullOrWhiteSpace(tex.Text))
            {
                MessageBox.Show("請輸入星座", "錯誤警告");
                return;//重新檢查
            }
            else
            {
                /// <summary>
                /// 選擇圖檔
                /// </summary>
                switch (tex.Text)
                {
                    case "天秤":
                        pic.Image = res[0];
                        break;
                    case "天秤座":
                        pic.Image = res[0];
                        break;
                    case "天蠍":
                        pic.Image = res[1];
                        break;
                    case "射手":
                        pic.Image = res[2];
                        break;
                    case "巨蟹":
                        pic.Image = res[3];
                        break;
                    case "水瓶":
                        pic.Image = res[4];
                        break;
                    case "牡羊":
                        pic.Image = res[5];
                        break;
                    case "獅子":
                        pic.Image = res[6];
                        break;
                    case "處女":
                        pic.Image = res[7];
                        break;
                    case "金牛":
                        pic.Image = res[8];
                        break;
                    case "雙子":
                        pic.Image = res[9];
                        break;
                    case "雙魚":
                        pic.Image = res[10];
                        break;
                    case "魔羯":
                        pic.Image = res[11];
                        break;
                    case "天蠍座":
                        pic.Image = res[1];
                        break;
                    case "射手座":
                        pic.Image = res[2];
                        break;
                    case "巨蟹座":
                        pic.Image = res[3];
                        break;
                    case "水瓶座":
                        pic.Image = res[4];
                        break;
                    case "牡羊座":
                        pic.Image = res[5];
                        break;
                    case "獅子座":
                        pic.Image = res[6];
                        break;
                    case "處女座":
                        pic.Image = res[7];
                        break;
                    case "金牛座":
                        pic.Image = res[8];
                        break;
                    case "雙子座":
                        pic.Image = res[9];
                        break;
                    case "雙魚座":
                        pic.Image = res[10];
                        break;
                    case "魔羯座":
                        pic.Image = res[11];
                        break;
                    default:
                        MessageBox.Show("文字不符，請重新輸入星座", "錯誤警告");
                        break;
                }
            }
            return;
        }
        /// <summary>
        /// 載入圖片
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            res.Add(Resources.天秤);
            res.Add(Resources.天蠍);
            res.Add(Resources.射手);
            res.Add(Resources.巨蟹);
            res.Add(Resources.水瓶);
            res.Add(Resources.牡羊);
            res.Add(Resources.獅子);
            res.Add(Resources.處女);
            res.Add(Resources.金牛);
            res.Add(Resources.雙子);
            res.Add(Resources.雙魚);
            res.Add(Resources.魔羯);
        }
    }
}
