using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.CSharp;
using System.CodeDom.Compiler;

namespace EulerProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            

            string counterstring = "";
            try
            {
                WebClient wc = new WebClient();
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                counterstring = wc.DownloadString("http://www.adnan92.ch/Counter.txt");
            }
            catch (WebException we)
            {
                // add error processing
                MessageBox.Show(we.ToString());
            }


            // Fill Combobox with Items
            for (int i = 1; Int16.Parse(counterstring) >= i; i++)
            {
                ProjektComboBox.Items.Add("Euler" + i);

            }

        }
            
            // Download Code and put it in CodeTextBox
            private void loadButton_Click(object sender, EventArgs e)
        {

            String line;

            string codestring = "";
            try
            {
                WebClient wc = new WebClient();
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                codestring = wc.DownloadString("http://www.adnan92.ch/Euler/Euler" + ProjektComboBox.Text.Substring(5) + ".cpp");
                
                codeTextBox.Text = codestring;
            }
            catch (WebException we)
            {
                // add error processing
                MessageBox.Show(we.ToString());
            }

        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            string remoteUri = "http://www.adnan92.ch/Euler/";
            string fileName = ProjektComboBox.Text + ".exe", myStringWebResource = null;

            // Create a new WebClient instance.
            WebClient myWebClient = new WebClient();

            // Concatenate the domain with the Web resource filename.
            myStringWebResource = remoteUri + fileName;

            // Download the Web resource and save it into the current filesystem folder.
            myWebClient.DownloadFile(myStringWebResource, fileName);


            Process.Start(ProjektComboBox.Text + ".exe");

        }


  


    }
}

