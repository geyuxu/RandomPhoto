using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RandomPhoto
{
    public partial class frmMain : Form
    {
        List<int> randomNums = new List<int>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnChoujiang_Click(object sender, EventArgs e)
        {
            if (btnChoujiang.Text == "开始抽奖！")
            {
                tm.Start();
                btnChoujiang.Text = "停！";
            }
            else
            {
                tm.Stop();
                btnChoujiang.Text = "开始抽奖！";
                
                //File.Delete(filename);
                files.Remove(filename);
            }
        }

        string filename = null;


        private void tm_Tick(object sender, EventArgs e)
        {

            pic.Image = null;
            Random r = new Random();
            int rNext = r.Next(0, files.Count);
            filename = files[rNext];
            //pic.Image = Image.FromFile(filename);

            FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            pic.Image = Image.FromStream(fileStream);
            //g.DrawImage(Image.FromStream(fileStream), new Point());
            fileStream.Close();
            fileStream.Dispose(); 

           // pic.Image = images[rNext];

        }

        List<string> files = new List<string>();
        //List<Image> images = new List<Image>();
        Graphics g;
        private void frmMain_Load(object sender, EventArgs e)
        {
           // pic.Image = Image.FromFile(@"D:\video\images\" + "DSC00626.JPG");
            DirectoryInfo folder = new DirectoryInfo(@"D:\video\images");

            foreach (FileInfo file in folder.GetFiles("*.jpg"))
            {
               // Console.WriteLine(file.FullName);
                files.Add(file.FullName);
                //images.Add(Image.FromFile(file.FullName));
            }

            g = pic.CreateGraphics();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
