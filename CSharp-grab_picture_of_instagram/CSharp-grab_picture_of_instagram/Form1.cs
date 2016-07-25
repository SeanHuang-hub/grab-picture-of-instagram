using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace CSharp_grab_picture_of_instagram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void grabButton_Click(object sender, EventArgs e)
        {
            if (folderPathBox.Text == "")
            {
                //show
                logBox.Text += "Failed grab image: Folder path Failed\r\n";
                return;
            }

            String rawUrl = websiteBox.Text;
            if (rawUrl != "")
            {
                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(rawUrl);
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    StreamReader streamReader = new StreamReader(response.GetResponseStream());
                    string code = streamReader.ReadToEnd();
                    int startIndex = code.IndexOf("og:image") + 19;
                    int endIndex = code.IndexOf(".jpg") + 4;
                    int length = endIndex - startIndex;

                    String imagePath = folderPathBox.Text + "\\";
                    String picUrl = code.Substring(startIndex, length);
                    int nameStartIndex = picUrl.LastIndexOf("/") + 1;
                    imagePath += picUrl.Substring(nameStartIndex);

                    HttpWebRequest picRequest = (HttpWebRequest)WebRequest.Create(picUrl);
                    HttpWebResponse picResponse = (HttpWebResponse)picRequest.GetResponse();
                    Stream stream = picResponse.GetResponseStream();
                    Image img = Image.FromStream(stream);
                    img.Save(imagePath);

                    //show
                    logBox.Text += "Success grab image: " + imagePath + "\r\n";
                }
                catch
                {
                    //show
                    logBox.Text += "Success grab image: URL failed\r\n";
                }
            }
            else
            {
                //show
                logBox.Text += "Failed grab image: URL Failed\r\n";
            }
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            folderPathBox.Text = path.SelectedPath;
        }

    }
}
