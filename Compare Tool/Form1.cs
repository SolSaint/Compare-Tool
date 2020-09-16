using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Compare_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FolderBrowserDialog fbw = new FolderBrowserDialog();
        List<string> listData = new List<string>();
        List<string> outData = new List<string>();

        public void LoadDirectory(string Dir, TreeView c)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            TreeNode tds = c.Nodes.Add(di.Name);
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            LoadFiles(Dir, tds);
            LoadSubDirectories(Dir, tds);
        }

        private void LoadSubDirectories(string dir, TreeNode td)
        {
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tds = td.Nodes.Add(di.Name);
                tds.StateImageIndex = 0;
                tds.Tag = di.FullName;
                LoadFiles(subdirectory, tds);
                LoadSubDirectories(subdirectory, tds);
            }
        }

        private void LoadFiles(string dir, TreeNode td)
        {
            string[] Files = Directory.GetFiles(dir, "*.*");
            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo(file);
                TreeNode tds = td.Nodes.Add(fi.Name);
                tds.Tag = fi.FullName;
                tds.StateImageIndex = 1;
            }
        }

        public void PrintNodesRecursive(TreeNode oParentNode)
        {
            FileAttributes attr = File.GetAttributes(oParentNode.Tag.ToString());
            if ((attr & FileAttributes.Directory) != FileAttributes.Directory)
            {
                listData.Add(oParentNode.Tag.ToString());
                //Debug.WriteLine(oParentNode.Tag.ToString());
            }
            foreach (TreeNode oSubNode in oParentNode.Nodes)
            {
                PrintNodesRecursive(oSubNode);
            }
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            if (fbw.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(fbw.SelectedPath))
                {
                    listData.Clear();
                    patch.Text = fbw.SelectedPath;
                    folderO.Nodes.Clear();
                    toolTip1.ShowAlways = true;
                    if (!string.IsNullOrEmpty(patch.Text) && Directory.Exists(patch.Text))
                        LoadDirectory(patch.Text, folderO);
                    TreeNode oMainNode = this.folderO.Nodes[0];
                    PrintNodesRecursive(oMainNode);
                }
            }
        }

        private void btnb1_Click(object sender, EventArgs e)
        {
            if (fbw.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(fbw.SelectedPath))
                {
                    patch2.Text = fbw.SelectedPath;
                    folderT.Nodes.Clear();
                    toolTip1.ShowAlways = true;
                    if (!string.IsNullOrEmpty(patch2.Text) && Directory.Exists(patch2.Text))
                        LoadDirectory(patch2.Text, folderT);
                    TreeNode oMainNode = this.folderT.Nodes[0];
                    //PrintNodesRecursive(oMainNode);
                }
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            outData.Clear();
            if (!bgrworker.IsBusy)
                bgrworker.RunWorkerAsync();
        }

        private void bgrworker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < listData.Count; i++)
            {
                try
                {
                    string path = listData[i].Remove(0, patch.Text.Length);
                    using (var md5 = MD5.Create())
                    {
                        var stream = File.OpenRead(listData[i]);
                        var stream2 = File.OpenRead(patch2.Text + path);
                        string hash = BitConverter.ToString(md5.ComputeHash(stream));
                        string hash2 = BitConverter.ToString(md5.ComputeHash(stream2));
                        if (hash != hash2)
                        {
                            outData.Add(listData[i]);
                            Debug.WriteLine(listData[i]);
                            /*log.AppendText(listData[i] + "\n");
                            log.ScrollToCaret();*/
                        }
                    }
                }
                catch
                {
                    Debug.WriteLine("not found!");
                }
                bgrworker.ReportProgress((i + 1) * 100 / listData.Count);
                /*using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(filename))
                    {
                        byte[] hash = md5.ComputeHash(stream);
                    }
                }*/
            }
        }

        private void bgrworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            processb.Value = e.ProgressPercentage;
            countp.Text = string.Format("{0}%", e.ProgressPercentage);
            processb.Update();
            if (processb.Value == 100)
            {
                foreach (string s in outData)
                {
                    log.AppendText(s + "\n");
                    log.ScrollToCaret();
                }
            }
        }

        private void btnDump_Click(object sender, EventArgs e)
        {

        }
    }
}
