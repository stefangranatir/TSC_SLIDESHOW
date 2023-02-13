using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;


namespace TSC_SlideShowbyStefanG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = "ftp://192.168.1.206:8021";
        private void button1_Click(object sender, EventArgs e)
        {
            
            Process.Start("explorer.exe", path);

        }
        string lokalna = "C:\\TSC_SlideShow";
        string zipanje = "";

        

       
    }
}
