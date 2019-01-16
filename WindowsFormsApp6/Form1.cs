using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        private Thread thread;
        private FileStream fileStream;
        private FileStream stream;
        private Thread thread1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string destFile = System.IO.Path.Combine(textBox2.Text, openFileDialog1.SafeFileName);
            if (!System.IO.Directory.Exists(textBox2.Text))
            {
                System.IO.Directory.CreateDirectory(textBox2.Text);
            }
            fileStream = new FileStream(textBox1.Text, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            progressBar1.Maximum = Convert.ToInt32(fileStream.Length.ToString());
            stream = new FileStream(destFile, FileMode.OpenOrCreate);
            thread = new Thread(new ThreadStart(() => Copy()));
            thread.Start();
            thread1 = new Thread(new ThreadStart(() => Progres()));
            thread1.Start();

            
        }
        private void Progres()
        {
            while (thread.IsAlive)
            {
                Invoke(new Action(() => progressBar1.Value = (int)stream.Length));
            }
        }

        private void Copy()
        {
            fileStream.CopyTo(stream, 100);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread1.IsAlive || thread.IsAlive)
            {
                MessageBox.Show("Do You Want to Exit!", "Wanring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    thread.Abort();
                    thread1.Abort();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
