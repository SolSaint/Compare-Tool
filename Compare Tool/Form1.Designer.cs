namespace Compare_Tool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.log = new System.Windows.Forms.RichTextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.patch = new System.Windows.Forms.TextBox();
            this.patch2 = new System.Windows.Forms.TextBox();
            this.btnb = new System.Windows.Forms.Button();
            this.btnb1 = new System.Windows.Forms.Button();
            this.btnDump = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.folderO = new System.Windows.Forms.TreeView();
            this.folderT = new System.Windows.Forms.TreeView();
            this.bgrworker = new System.ComponentModel.BackgroundWorker();
            this.processb = new System.Windows.Forms.ProgressBar();
            this.countp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(12, 206);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(644, 227);
            this.log.TabIndex = 0;
            this.log.Text = "";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(298, 82);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(72, 64);
            this.btnCompare.TabIndex = 3;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // patch
            // 
            this.patch.Location = new System.Drawing.Point(12, 12);
            this.patch.Name = "patch";
            this.patch.Size = new System.Drawing.Size(230, 20);
            this.patch.TabIndex = 4;
            // 
            // patch2
            // 
            this.patch2.Location = new System.Drawing.Point(376, 12);
            this.patch2.Name = "patch2";
            this.patch2.Size = new System.Drawing.Size(230, 20);
            this.patch2.TabIndex = 5;
            // 
            // btnb
            // 
            this.btnb.Location = new System.Drawing.Point(248, 10);
            this.btnb.Name = "btnb";
            this.btnb.Size = new System.Drawing.Size(43, 23);
            this.btnb.TabIndex = 6;
            this.btnb.Text = "...";
            this.btnb.UseVisualStyleBackColor = true;
            this.btnb.Click += new System.EventHandler(this.btnb_Click);
            // 
            // btnb1
            // 
            this.btnb1.Location = new System.Drawing.Point(612, 10);
            this.btnb1.Name = "btnb1";
            this.btnb1.Size = new System.Drawing.Size(44, 23);
            this.btnb1.TabIndex = 7;
            this.btnb1.Text = "...";
            this.btnb1.UseVisualStyleBackColor = true;
            this.btnb1.Click += new System.EventHandler(this.btnb1_Click);
            // 
            // btnDump
            // 
            this.btnDump.Location = new System.Drawing.Point(581, 443);
            this.btnDump.Name = "btnDump";
            this.btnDump.Size = new System.Drawing.Size(75, 23);
            this.btnDump.TabIndex = 8;
            this.btnDump.Text = "Dump";
            this.btnDump.UseVisualStyleBackColor = true;
            this.btnDump.Click += new System.EventHandler(this.btnDump_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Logs";
            // 
            // folderO
            // 
            this.folderO.Location = new System.Drawing.Point(12, 47);
            this.folderO.Name = "folderO";
            this.folderO.Size = new System.Drawing.Size(280, 140);
            this.folderO.TabIndex = 10;
            // 
            // folderT
            // 
            this.folderT.Location = new System.Drawing.Point(376, 47);
            this.folderT.Name = "folderT";
            this.folderT.Size = new System.Drawing.Size(280, 140);
            this.folderT.TabIndex = 11;
            // 
            // bgrworker
            // 
            this.bgrworker.WorkerReportsProgress = true;
            this.bgrworker.WorkerSupportsCancellation = true;
            this.bgrworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgrworker_DoWork);
            this.bgrworker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgrworker_ProgressChanged);
            // 
            // processb
            // 
            this.processb.Location = new System.Drawing.Point(12, 443);
            this.processb.Name = "processb";
            this.processb.Size = new System.Drawing.Size(563, 23);
            this.processb.TabIndex = 12;
            // 
            // countp
            // 
            this.countp.AutoSize = true;
            this.countp.BackColor = System.Drawing.Color.Transparent;
            this.countp.Location = new System.Drawing.Point(295, 448);
            this.countp.Name = "countp";
            this.countp.Size = new System.Drawing.Size(21, 13);
            this.countp.TabIndex = 13;
            this.countp.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 478);
            this.Controls.Add(this.countp);
            this.Controls.Add(this.processb);
            this.Controls.Add(this.folderT);
            this.Controls.Add(this.folderO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDump);
            this.Controls.Add(this.btnb1);
            this.Controls.Add(this.btnb);
            this.Controls.Add(this.patch2);
            this.Controls.Add(this.patch);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compare Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.TextBox patch;
        private System.Windows.Forms.TextBox patch2;
        private System.Windows.Forms.Button btnb;
        private System.Windows.Forms.Button btnb1;
        private System.Windows.Forms.Button btnDump;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TreeView folderO;
        private System.Windows.Forms.TreeView folderT;
        private System.ComponentModel.BackgroundWorker bgrworker;
        private System.Windows.Forms.ProgressBar processb;
        private System.Windows.Forms.Label countp;
    }
}

