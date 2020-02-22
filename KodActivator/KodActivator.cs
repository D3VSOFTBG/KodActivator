using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KodActivator
{
    public partial class KodActivator : Form
    {
        public KodActivator()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://kodbulgaria.com");
        }

        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void KA_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void windows10ProToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk W269N-WFGWX-YVC9B-4J6C9-T83GX & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows10ProNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk MH37W-N47XK-V7XM9-C7227-GCQG9 & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windowsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows10ProForWorkstationsNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk 9FNHH-K3HBT-3W4TD-6383H-6XYWF & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows10ProEducationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk 6TP4R-GNPTD-KYYHQ-7B7DP-J447Y & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows10ProEducationNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk YVWGF-BXNMC-HTQYQ-CPQ99-66QFC & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows10EducationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk NW6C2-QMPVW-D7KKK-3GKT6-VCFB2 & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows10EducationNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows10EnterpriseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk NPPR9-FWDCX-D2C8J-H872K-2YT43 & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows10EnterpriseNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4 & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void Windows10EnterpriseGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk YYVX9-NTFWV-6MDM3-9PT4T-4M68B & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows10EnterpriseGNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk 44RPN-FTY23-9VTTB-MP9BX-T84FV & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows81ProToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk GCRJD-8NW9H-F2CDX-CCM8D-9D6T9 & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows81ProNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk HMCNV-VVBFX-7HMBH-CTY9B-B4FXY & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows81EnterpriseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk MHF9N-XY6XB-WVXMC-BTDCT-MKKG7 & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows81EnterpriseNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk TT4HM-HN7YT-62K67-RGRQJ-JFFXW & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows8ProToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk NG4HW-VH26C-733KW-K6F98-J8CK4 & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows8ProNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk XCVCF-2NXM9-723PB-MHCB7-2RYQQ & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows8EnterpriseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk 32JNW-9KQ84-P47T8-D8GGY-CWCK7 & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows8EnterpriseNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk JMNMF-RHW7P-DMY6X-RF3DR-X2BQT & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows7ProfessionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk FJ82H-XT6CR-J8D7P-XQJJ2-GPDD4 & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows7ProfessionalNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk MRPKT-YTG23-K7D7T-X2JMM-QY7MG & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows7ProfessionalEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk W82YF-2Q76Y-63HXB-FGJG9-GF7QX & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows7EnterpriseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk 33PXH-7Y6KF-2VJC9-XBBR8-HVTHH & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows7EnterpriseNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk YDRBP-3D83W-TY26F-D46B2-XCKRJ & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void windows7EnterpriseEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "slmgr /ipk C29WB-22CC8-VJ326-GHFJW-H9DH4 & slmgr /skms kms8.msguides.com & slmgr /ato";
            proc1.UseShellExecute = true;

            proc1.WorkingDirectory = @"C:\Windows\System32";

            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.Verb = "runas";
            proc1.Arguments = "/c " + anyCommand;
            proc1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(proc1);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.microsoft.com/en-us/download/details.aspx?id=11936");
        }
    }
}
