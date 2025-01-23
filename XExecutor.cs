using ForlornApi;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace XExecutor_Final_Edition
{
    public partial class XExecutor : RoundedForm
    {
        Timer time = new Timer();
        public Point mouseLocation;
        public XExecutor()
        {
            InitializeComponent();
             time.Tick += timertick;
            time.Start();
        }
        private void timertick(object sender, EventArgs e)
        {
            if (ForlornApi.Api.IsRobloxOpen())
            {
                robloxopen.Text = "Roblox Open: ✅";
                robloxopen.ForeColor = Color.LightGreen;  // Change text color to green
            }
            else
            {
                robloxopen.Text = "Roblox Open: ❌";
                robloxopen.ForeColor = Color.Red;  // Change text color to red
            }

            if (ForlornApi.Api.IsInjected())
            {
                status.Text = "Status: Injected!";
                status.ForeColor = Color.LightGreen;  // Change text color to green
            }
            else
            {
                status.Text = "Status: Not Injected!";
                status.ForeColor = Color.Red;  // Change text color to red
            }
        }


        private void Editor_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Inject_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.Inject();
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.ExecuteScript(editor.Text);
        }

        private void XExecutor_Load(object sender, EventArgs e)
        {
          
        }

        private void status_Click(object sender, EventArgs e)
        {
            
        }

        private void robloxopen_Click(object sender, EventArgs e)
        {

        }

        private void AutoInject_CheckedChanged(object sender, EventArgs e)
        {
            ForlornApi.Api.SetAutoInject(true);
        }

        private void Killer_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.KillRoblox();
        }

        private void x_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void List1_SelectedIndexChanged(object sender, EventArgs e)
        {
            editor.Text = File.ReadAllText($"./Scripts/{List1.SelectedItem}");
        }

        class functions
        {
            public static void PopulateListBox(System.Windows.Forms.ListBox lsb, string Folder, string FileType)
            {
                DirectoryInfo dinfo = new DirectoryInfo(Folder);
                FileInfo[] Files = dinfo.GetFiles(FileType);
                foreach (FileInfo file in Files)
                {
                    lsb.Items.Add(file.Name);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List1.Items.Clear();
            functions.PopulateListBox(List1, "./Scripts", "*.lua");
            functions.PopulateListBox(List1, "./Scripts", "*.txt");

        }

        private void XExecutor_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void XExecutor_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void XExecutor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
    }
}
