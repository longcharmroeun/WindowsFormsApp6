using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Diagnostics;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private BindingList<ProcessData> processDatas;
        Win32Window window;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            processDatas = new BindingList<ProcessData>();
            listBox1.DataSource = processDatas;
            window = Win32Window.FromDesktop();
            foreach (Win32Window item in window.Children)
            {
                if (item.Title != string.Empty)
                {
                    try
                    {
                        processDatas.Add(new ProcessData
                        {
                            Title = item.Title,
                            Process_Name = item.Process.ProcessName,
                            Location = item.Process.MainModule.FileName,
                            Process_ID = item.Process.Id.ToString(),
                            Parent_ID = item.Parent.Process.Id.ToString(),
                            Parent_Location = item.Parent.Process.MainModule.FileName
                        });
                    }
                    catch (System.ComponentModel.Win32Exception)
                    {
                        processDatas.Add(new ProcessData
                        {
                            Title = item.Title,
                            Process_Name = item.Process.ProcessName,
                            Location = "Adminitrator request",
                            Process_ID = "Adminitrator request",
                            Parent_ID = "Adminitrator request",
                            Parent_Location = "Adminitrator request"
                        });
                    }
                }
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (listBox1.SelectedIndex > 0)
                {
                    Tittle.Text = processDatas.ElementAt(listBox1.SelectedIndex).Title;
                    Process_name.Text = processDatas.ElementAt(listBox1.SelectedIndex).Process_Name;
                    Process_id.Text = processDatas.ElementAt(listBox1.SelectedIndex).Process_ID;
                    Location.Text = processDatas.ElementAt(listBox1.SelectedIndex).Location;
                    Parent_location.Text = processDatas.ElementAt(listBox1.SelectedIndex).Parent_Location;
                    Paren_id.Text = processDatas.ElementAt(listBox1.SelectedIndex).Parent_ID;
                }
            }
        }
    }
}
