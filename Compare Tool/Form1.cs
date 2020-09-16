using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Debug.WriteLine(oParentNode.Tag.ToString());
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

        }
    }
}
