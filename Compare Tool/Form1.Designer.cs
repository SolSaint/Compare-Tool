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
            this.log = new System.Windows.Forms.RichTextBox();
            this.folderO = new System.Windows.Forms.ListView();
            this.folderT = new System.Windows.Forms.ListView();
            this.btnCompare = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnb = new System.Windows.Forms.Button();
            this.btnb1 = new System.Windows.Forms.Button();
            this.btnDump = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // folderO
            // 
            this.folderO.HideSelection = false;
            this.folderO.Location = new System.Drawing.Point(12, 47);
            this.folderO.Name = "folderO";
            this.folderO.Size = new System.Drawing.Size(280, 140);
            this.folderO.TabIndex = 1;
            this.folderO.UseCompatibleStateImageBehavior = false;
            // 
            // folderT
            // 
            this.folderT.HideSelection = false;
            this.folderT.Location = new System.Drawing.Point(376, 47);
            this.folderT.Name = "folderT";
            this.folderT.Size = new System.Drawing.Size(280, 140);
            this.folderT.TabIndex = 2;
            this.folderT.UseCompatibleStateImageBehavior = false;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(298, 80);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(72, 64);
            this.btnCompare.TabIndex = 3;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(376, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 20);
            this.textBox2.TabIndex = 5;
            // 
            // btnb
            // 
            this.btnb.Location = new System.Drawing.Point(248, 10);
            this.btnb.Name = "btnb";
            this.btnb.Size = new System.Drawing.Size(43, 23);
            this.btnb.TabIndex = 6;
            this.btnb.Text = "...";
            this.btnb.UseVisualStyleBackColor = true;
            // 
            // btnb1
            // 
            this.btnb1.Location = new System.Drawing.Point(612, 10);
            this.btnb1.Name = "btnb1";
            this.btnb1.Size = new System.Drawing.Size(44, 23);
            this.btnb1.TabIndex = 7;
            this.btnb1.Text = "...";
            this.btnb1.UseVisualStyleBackColor = true;
            // 
            // btnDump
            // 
            this.btnDump.Location = new System.Drawing.Point(581, 443);
            this.btnDump.Name = "btnDump";
            this.btnDump.Size = new System.Drawing.Size(75, 23);
            this.btnDump.TabIndex = 8;
            this.btnDump.Text = "Dump";
            this.btnDump.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDump);
            this.Controls.Add(this.btnb1);
            this.Controls.Add(this.btnb);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.folderT);
            this.Controls.Add(this.folderO);
            this.Controls.Add(this.log);
            this.Name = "Form1";
            this.Text = "Compare Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.ListView folderO;
        private System.Windows.Forms.ListView folderT;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnb;
        private System.Windows.Forms.Button btnb1;
        private System.Windows.Forms.Button btnDump;
        private System.Windows.Forms.Label label1;
    }
}

