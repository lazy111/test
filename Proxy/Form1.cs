using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proxy
{
    public partial class Form1 : Form
    {
        private string url = @"http://www.logoquan.com/upload/list/20150925/logoquan14517654322.PNG";

        public Form1()
        {
            InitializeComponent();
        }

        private abstract class Icon
        {
            public Image Image
            {
                get;
                set;
            }
            public abstract void PaintIcon();
        }

        private class ImageProxy : Icon
        {

            public ImageProxy(string url, PictureBox pb)
            {
                _pb = pb;
                _url = url;
            }
            private Icon _image;
            private string _url;
            private PictureBox _pb;
            private int _width = 260;
            private int _height = 235;
            public int Width()
            {
                return _image == null ? _width : _image.Image.Width;
            }
            public int Height()
            {
                return _image == null ? _height : _image.Image.Height;
            }

            public override void PaintIcon()
            {
                if (_image == null)
                {
                    _pb.Image = new Bitmap(new FileStream(@"C:\Users\wujc\Documents\Visual Studio 2012\Projects\WebApplication1\Proxy\logoquan14517654322.PNG", FileMode.OpenOrCreate));
  
                  
                    Thread retrieveThread = new Thread(
                               new ThreadStart(() =>
                               {
                                   Thread.Sleep(2000);
                                   _image = new ImageIcon(_url, _pb);
                                   _image.PaintIcon();

                               }));
                    retrieveThread.Start();
                }
            }
        }
        private class ImageIcon : Icon
        {

            private string _url;
            private PictureBox _pb;
            public ImageIcon(string url, PictureBox pb)
            {
                _url = url;
                _pb = pb;
            }
            public override void PaintIcon()
            {
                HttpWebRequest request = HttpWebRequest.Create(_url) as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                _pb.Image = Image.FromStream(response.GetResponseStream());
            }
        }

        private void btnLazyLoad_Click(object sender, EventArgs e)
        {
            ImageProxy proxy = new ImageProxy(url, pbLogo);
            proxy.PaintIcon();
        }
    }
}
