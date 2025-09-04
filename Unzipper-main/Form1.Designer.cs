namespace Unzipper_main
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtBoxExport = new RichTextBox();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            openToolStripMenuItem = new ToolStripMenuItem();
            exportFolderToolStripMenuItem = new ToolStripMenuItem();
            unzipFolderToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItem1 = new ToolStripMenuItem();
            exportFolderToolStripMenuItem1 = new ToolStripMenuItem();
            unzipFolderToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripMenuItem2 = new ToolStripMenuItem();
            folderListToolStripMenuItem = new ToolStripMenuItem();
            unzipToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtBoxUnzip = new RichTextBox();
            toolStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBoxExport
            // 
            txtBoxExport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxExport.BackColor = SystemColors.ControlLight;
            txtBoxExport.BorderStyle = BorderStyle.None;
            txtBoxExport.Cursor = Cursors.IBeam;
            txtBoxExport.Font = new Font("Arial", 9F);
            txtBoxExport.Location = new Point(3, 3);
            txtBoxExport.Name = "txtBoxExport";
            txtBoxExport.ReadOnly = true;
            txtBoxExport.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtBoxExport.Size = new Size(394, 442);
            txtBoxExport.TabIndex = 7;
            txtBoxExport.Text = "";
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripSeparator3, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 15;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, toolStripSeparator1, toolStripMenuItem1, toolStripSeparator2, toolStripMenuItem2 });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(38, 22);
            toolStripDropDownButton1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportFolderToolStripMenuItem, unzipFolderToolStripMenuItem });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(112, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // exportFolderToolStripMenuItem
            // 
            exportFolderToolStripMenuItem.Name = "exportFolderToolStripMenuItem";
            exportFolderToolStripMenuItem.Size = new Size(143, 22);
            exportFolderToolStripMenuItem.Text = "Export Folder";
            exportFolderToolStripMenuItem.Click += exportFolderToolStripMenuItem_Click;
            // 
            // unzipFolderToolStripMenuItem
            // 
            unzipFolderToolStripMenuItem.Name = "unzipFolderToolStripMenuItem";
            unzipFolderToolStripMenuItem.Size = new Size(143, 22);
            unzipFolderToolStripMenuItem.Text = "Unzip Folder";
            unzipFolderToolStripMenuItem.Click += unzipFolderToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(109, 6);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { exportFolderToolStripMenuItem1, unzipFolderToolStripMenuItem1 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(112, 22);
            toolStripMenuItem1.Text = "Delete";
            // 
            // exportFolderToolStripMenuItem1
            // 
            exportFolderToolStripMenuItem1.Name = "exportFolderToolStripMenuItem1";
            exportFolderToolStripMenuItem1.Size = new Size(143, 22);
            exportFolderToolStripMenuItem1.Text = "Export Folder";
            exportFolderToolStripMenuItem1.Click += exportFolderToolStripMenuItem1_Click;
            // 
            // unzipFolderToolStripMenuItem1
            // 
            unzipFolderToolStripMenuItem1.Name = "unzipFolderToolStripMenuItem1";
            unzipFolderToolStripMenuItem1.Size = new Size(143, 22);
            unzipFolderToolStripMenuItem1.Text = "Unzip Folder";
            unzipFolderToolStripMenuItem1.Click += unzipFolderToolStripMenuItem1_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(109, 6);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { folderListToolStripMenuItem, unzipToolStripMenuItem, exportToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(112, 22);
            toolStripMenuItem2.Text = "Update";
            // 
            // folderListToolStripMenuItem
            // 
            folderListToolStripMenuItem.Name = "folderListToolStripMenuItem";
            folderListToolStripMenuItem.Size = new Size(107, 22);
            folderListToolStripMenuItem.Text = "All";
            folderListToolStripMenuItem.Click += folderListToolStripMenuItem_Click;
            // 
            // unzipToolStripMenuItem
            // 
            unzipToolStripMenuItem.Name = "unzipToolStripMenuItem";
            unzipToolStripMenuItem.Size = new Size(107, 22);
            unzipToolStripMenuItem.Text = "Unzip";
            unzipToolStripMenuItem.Click += unzipToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(107, 22);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(41, 22);
            toolStripButton1.Text = "Unzip";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtBoxExport, 0, 0);
            tableLayoutPanel1.Controls.Add(txtBoxUnzip, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 448);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // txtBoxUnzip
            // 
            txtBoxUnzip.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxUnzip.BackColor = SystemColors.ControlLight;
            txtBoxUnzip.BorderStyle = BorderStyle.None;
            txtBoxUnzip.Cursor = Cursors.IBeam;
            txtBoxUnzip.Font = new Font("Arial", 9F);
            txtBoxUnzip.Location = new Point(403, 3);
            txtBoxUnzip.Name = "txtBoxUnzip";
            txtBoxUnzip.ReadOnly = true;
            txtBoxUnzip.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtBoxUnzip.Size = new Size(394, 442);
            txtBoxUnzip.TabIndex = 9;
            txtBoxUnzip.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 473);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Unzipper v.0.01 [base]";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox txtBoxExport;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem exportFolderToolStripMenuItem;
        private ToolStripMenuItem unzipFolderToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem exportFolderToolStripMenuItem1;
        private ToolStripMenuItem unzipFolderToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem folderListToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton1;
        private ToolStripMenuItem unzipToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox txtBoxUnzip;
    }
}
