using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Association
{
    public partial class FMmain : Form
    {
        public static string strExePath = "";
        public static string strIcoPath = "";

        public FMmain()
        {
            InitializeComponent();
        }




        private void BTNexe_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                OFD.Filter = "*.exe|*.exe";
                //OFD.InitialDirectory = pPath == "" ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop) : pPath;
                //OFD.InitialDirectory = "";
                OFD.InitialDirectory = "E:\\code\\Products\\vb6.0\\brackets\\1.3\\brackets 1.3.12 beta版";
                
                if (OFD.ShowDialog() == DialogResult.OK)
                    strExePath = OFD.FileName;
                else
                    strExePath = string.Empty;
                LBLexePath.Text = strExePath;
            }
        }

        private void PBfileIco_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                OFD.Filter = "*.ico|*.ico";
                //OFD.InitialDirectory = pPath == "" ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop) : pPath;
                //OFD.InitialDirectory = "";
                OFD.InitialDirectory = "E:\\code\\Products\\vb6.0\\brackets\\1.3\\brackets 1.3.12 beta版";

                if (OFD.ShowDialog() == DialogResult.OK)
                    strIcoPath = OFD.FileName;
                else
                    strIcoPath = string.Empty;
                PBfileIco.Image = Image.FromFile(strIcoPath);
            }
        }

        private void BTNassociation_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey MyReg = Registry.ClassesRoot.CreateSubKey(TXTextension.Text);
                MyReg.SetValue("", TXTfileDiscribe.Text);
                MyReg.SetValue("Content Type", TXTcontent.Text);

                RegistryKey MyReg1 = MyReg.CreateSubKey("shell\\open\\command");//设置默认程序
                MyReg1.SetValue("", strExePath + " \"%1\"");//传入参数两侧加上引号，使传入路径不会被空格截断

                RegistryKey MyReg2 = MyReg.CreateSubKey("DefaultIcon");//设置文件图标
                MyReg2.SetValue("", strIcoPath + ",0", RegistryValueKind.String);

                MyReg.Close();
                //删除系统图标缓存
                System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + @"\Res\RefreshIconCache.bat");
                RefreshSystem();
                System.Windows.Forms.MessageBox.Show("文件关联成功。", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "信息提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }

        private void TXTextension_TextChanged(object sender, EventArgs e)
        {
            TXTfileDiscribe.Text = TXTextension.Text.Substring(1, TXTextension.Text.Length - 1) + "文件";
            TXTcontent.Text = TXTextension.Text.Substring(1, TXTextension.Text.Length - 1) + "文件";
        }


        public static void RefreshSystem()//刷新进程
        {
            System.Diagnostics.Process[] mprocess;
            mprocess = System.Diagnostics.Process.GetProcessesByName("explorer");//创建进程组件的数组，并将它们与共享“explorer”进程名称的所有进程资源关联。
            foreach (System.Diagnostics.Process mp in mprocess)
            {
                mp.Kill();
            }
        }

    }
}
