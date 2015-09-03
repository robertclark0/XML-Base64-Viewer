namespace Base64_Viewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runningDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_add = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_remove = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_removeAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_URL = new System.Windows.Forms.ToolStripButton();
            this.listBox_files = new System.Windows.Forms.ListBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_expand = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_collapse = new System.Windows.Forms.ToolStripButton();
            this.treeView_files = new System.Windows.Forms.TreeView();
            this.imageList_treeIcons = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_preview = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel_zoom = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox_type = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton_save = new System.Windows.Forms.ToolStripButton();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.webBrowser_previewer = new System.Windows.Forms.WebBrowser();
            this.listView_details = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel_URL = new System.Windows.Forms.Panel();
            this.textBox_URL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_download = new System.Windows.Forms.Button();
            this.comboBox_server = new System.Windows.Forms.ComboBox();
            this.textBox_PayID = new System.Windows.Forms.TextBox();
            this.label_payID = new System.Windows.Forms.Label();
            this.label_Server = new System.Windows.Forms.Label();
            this.linkLabel_DR = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.panel_URL.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runningDirectoryToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // runningDirectoryToolStripMenuItem
            // 
            this.runningDirectoryToolStripMenuItem.Name = "runningDirectoryToolStripMenuItem";
            this.runningDirectoryToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.runningDirectoryToolStripMenuItem.Text = "Running Directory";
            this.runningDirectoryToolStripMenuItem.Click += new System.EventHandler(this.runningDirectoryToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 650);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(891, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer1.Size = new System.Drawing.Size(891, 626);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(287, 626);
            this.splitContainer2.SplitterDistance = 164;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.panel_URL);
            this.splitContainer3.Panel2.Controls.Add(this.listBox_files);
            this.splitContainer3.Size = new System.Drawing.Size(285, 162);
            this.splitContainer3.SplitterDistance = 25;
            this.splitContainer3.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_add,
            this.toolStripButton_remove,
            this.toolStripButton_removeAll,
            this.toolStripSeparator2,
            this.toolStripButton_URL});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(285, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_add
            // 
            this.toolStripButton_add.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_add.Image")));
            this.toolStripButton_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_add.Name = "toolStripButton_add";
            this.toolStripButton_add.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton_add.Text = "Add";
            this.toolStripButton_add.Click += new System.EventHandler(this.toolStripButton_add_Click);
            // 
            // toolStripButton_remove
            // 
            this.toolStripButton_remove.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_remove.Image")));
            this.toolStripButton_remove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_remove.Name = "toolStripButton_remove";
            this.toolStripButton_remove.Size = new System.Drawing.Size(70, 22);
            this.toolStripButton_remove.Text = "Remove";
            this.toolStripButton_remove.Click += new System.EventHandler(this.toolStripButton_remove_Click);
            // 
            // toolStripButton_removeAll
            // 
            this.toolStripButton_removeAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_removeAll.Image")));
            this.toolStripButton_removeAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_removeAll.Name = "toolStripButton_removeAll";
            this.toolStripButton_removeAll.Size = new System.Drawing.Size(87, 22);
            this.toolStripButton_removeAll.Text = "Remove All";
            this.toolStripButton_removeAll.Click += new System.EventHandler(this.toolStripButton_removeAll_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_URL
            // 
            this.toolStripButton_URL.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_URL.Image")));
            this.toolStripButton_URL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_URL.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButton_URL.Name = "toolStripButton_URL";
            this.toolStripButton_URL.Size = new System.Drawing.Size(48, 22);
            this.toolStripButton_URL.Text = "URL";
            this.toolStripButton_URL.Click += new System.EventHandler(this.toolStripButton_URL_Click);
            // 
            // listBox_files
            // 
            this.listBox_files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_files.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox_files.FormattingEnabled = true;
            this.listBox_files.IntegralHeight = false;
            this.listBox_files.Location = new System.Drawing.Point(0, 0);
            this.listBox_files.Name = "listBox_files";
            this.listBox_files.Size = new System.Drawing.Size(285, 133);
            this.listBox_files.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.toolStrip2);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.treeView_files);
            this.splitContainer4.Size = new System.Drawing.Size(285, 456);
            this.splitContainer4.SplitterDistance = 25;
            this.splitContainer4.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_expand,
            this.toolStripButton_collapse});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(285, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton_expand
            // 
            this.toolStripButton_expand.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_expand.Image")));
            this.toolStripButton_expand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_expand.Name = "toolStripButton_expand";
            this.toolStripButton_expand.Size = new System.Drawing.Size(82, 22);
            this.toolStripButton_expand.Text = "Expand All";
            this.toolStripButton_expand.Click += new System.EventHandler(this.toolStripButton_expand_Click);
            // 
            // toolStripButton_collapse
            // 
            this.toolStripButton_collapse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_collapse.Image")));
            this.toolStripButton_collapse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_collapse.Name = "toolStripButton_collapse";
            this.toolStripButton_collapse.Size = new System.Drawing.Size(89, 22);
            this.toolStripButton_collapse.Text = "Collapse All";
            this.toolStripButton_collapse.Click += new System.EventHandler(this.toolStripButton_collapse_Click);
            // 
            // treeView_files
            // 
            this.treeView_files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_files.ImageIndex = 0;
            this.treeView_files.ImageList = this.imageList_treeIcons;
            this.treeView_files.Location = new System.Drawing.Point(0, 0);
            this.treeView_files.Name = "treeView_files";
            this.treeView_files.SelectedImageIndex = 0;
            this.treeView_files.Size = new System.Drawing.Size(285, 427);
            this.treeView_files.TabIndex = 0;
            this.treeView_files.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_files_AfterSelect);
            // 
            // imageList_treeIcons
            // 
            this.imageList_treeIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_treeIcons.ImageStream")));
            this.imageList_treeIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_treeIcons.Images.SetKeyName(0, "1420013917_LineCheck.png");
            this.imageList_treeIcons.Images.SetKeyName(1, "1420013917_Check.png");
            this.imageList_treeIcons.Images.SetKeyName(2, "1420054082_XML.png");
            this.imageList_treeIcons.Images.SetKeyName(3, "1420054101_64bit.png");
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.trackBar1);
            this.splitContainer5.Panel1.Controls.Add(this.toolStrip3);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer5.Size = new System.Drawing.Size(598, 624);
            this.splitContainer5.SplitterDistance = 25;
            this.splitContainer5.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(101, 2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_preview,
            this.toolStripButton2,
            this.toolStripLabel_zoom,
            this.toolStripSeparator1,
            this.toolStripComboBox_type,
            this.toolStripButton_save});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(598, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButton_preview
            // 
            this.toolStripButton_preview.Checked = true;
            this.toolStripButton_preview.CheckOnClick = true;
            this.toolStripButton_preview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButton_preview.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_preview.Image")));
            this.toolStripButton_preview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_preview.Name = "toolStripButton_preview";
            this.toolStripButton_preview.Size = new System.Drawing.Size(68, 22);
            this.toolStripButton_preview.Text = "Preview";
            this.toolStripButton_preview.CheckedChanged += new System.EventHandler(this.toolStripButton_preview_CheckedChanged);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Zoom";
            // 
            // toolStripLabel_zoom
            // 
            this.toolStripLabel_zoom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel_zoom.Margin = new System.Windows.Forms.Padding(98, 0, 1, 0);
            this.toolStripLabel_zoom.Name = "toolStripLabel_zoom";
            this.toolStripLabel_zoom.Size = new System.Drawing.Size(34, 25);
            this.toolStripLabel_zoom.Text = "100%";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboBox_type
            // 
            this.toolStripComboBox_type.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBox_type.Items.AddRange(new object[] {
            "pdf",
            "tif"});
            this.toolStripComboBox_type.Margin = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.toolStripComboBox_type.Name = "toolStripComboBox_type";
            this.toolStripComboBox_type.Size = new System.Drawing.Size(75, 25);
            this.toolStripComboBox_type.Text = "File Type";
            this.toolStripComboBox_type.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_type_SelectedIndexChanged);
            this.toolStripComboBox_type.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripComboBox_type_KeyDown);
            // 
            // toolStripButton_save
            // 
            this.toolStripButton_save.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_save.Image")));
            this.toolStripButton_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_save.Name = "toolStripButton_save";
            this.toolStripButton_save.Size = new System.Drawing.Size(72, 22);
            this.toolStripButton_save.Text = "Save File";
            this.toolStripButton_save.Click += new System.EventHandler(this.toolStripButton_save_Click);
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer6.IsSplitterFixed = true;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.webBrowser_previewer);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.listView_details);
            this.splitContainer6.Size = new System.Drawing.Size(598, 595);
            this.splitContainer6.SplitterDistance = 485;
            this.splitContainer6.TabIndex = 0;
            // 
            // webBrowser_previewer
            // 
            this.webBrowser_previewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_previewer.Location = new System.Drawing.Point(0, 0);
            this.webBrowser_previewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_previewer.Name = "webBrowser_previewer";
            this.webBrowser_previewer.Size = new System.Drawing.Size(598, 485);
            this.webBrowser_previewer.TabIndex = 0;
            // 
            // listView_details
            // 
            this.listView_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_details.GridLines = true;
            this.listView_details.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView_details.Location = new System.Drawing.Point(0, 0);
            this.listView_details.Name = "listView_details";
            this.listView_details.Size = new System.Drawing.Size(598, 106);
            this.listView_details.TabIndex = 0;
            this.listView_details.UseCompatibleStateImageBehavior = false;
            this.listView_details.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 300;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // panel_URL
            // 
            this.panel_URL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_URL.Controls.Add(this.linkLabel_DR);
            this.panel_URL.Controls.Add(this.label_Server);
            this.panel_URL.Controls.Add(this.label_payID);
            this.panel_URL.Controls.Add(this.textBox_PayID);
            this.panel_URL.Controls.Add(this.comboBox_server);
            this.panel_URL.Controls.Add(this.button_download);
            this.panel_URL.Controls.Add(this.label1);
            this.panel_URL.Controls.Add(this.textBox_URL);
            this.panel_URL.Location = new System.Drawing.Point(0, 0);
            this.panel_URL.Name = "panel_URL";
            this.panel_URL.Size = new System.Drawing.Size(285, 133);
            this.panel_URL.TabIndex = 1;
            this.panel_URL.Visible = false;
            // 
            // textBox_URL
            // 
            this.textBox_URL.Location = new System.Drawing.Point(35, 3);
            this.textBox_URL.Name = "textBox_URL";
            this.textBox_URL.Size = new System.Drawing.Size(242, 20);
            this.textBox_URL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // button_download
            // 
            this.button_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_download.Location = new System.Drawing.Point(202, 29);
            this.button_download.Name = "button_download";
            this.button_download.Size = new System.Drawing.Size(75, 23);
            this.button_download.TabIndex = 2;
            this.button_download.Text = "Download";
            this.button_download.UseVisualStyleBackColor = true;
            // 
            // comboBox_server
            // 
            this.comboBox_server.FormattingEnabled = true;
            this.comboBox_server.Items.AddRange(new object[] {
            "http://server1",
            "http://server2",
            "http://server3"});
            this.comboBox_server.Location = new System.Drawing.Point(92, 98);
            this.comboBox_server.Name = "comboBox_server";
            this.comboBox_server.Size = new System.Drawing.Size(185, 21);
            this.comboBox_server.TabIndex = 3;
            this.comboBox_server.Visible = false;
            this.comboBox_server.SelectedIndexChanged += new System.EventHandler(this.comboBox_server_SelectedIndexChanged);
            // 
            // textBox_PayID
            // 
            this.textBox_PayID.Location = new System.Drawing.Point(92, 72);
            this.textBox_PayID.Name = "textBox_PayID";
            this.textBox_PayID.Size = new System.Drawing.Size(185, 20);
            this.textBox_PayID.TabIndex = 4;
            this.textBox_PayID.Visible = false;
            this.textBox_PayID.TextChanged += new System.EventHandler(this.textBox_PayID_TextChanged);
            // 
            // label_payID
            // 
            this.label_payID.AutoSize = true;
            this.label_payID.Location = new System.Drawing.Point(32, 75);
            this.label_payID.Name = "label_payID";
            this.label_payID.Size = new System.Drawing.Size(59, 13);
            this.label_payID.TabIndex = 5;
            this.label_payID.Text = "Payload ID";
            this.label_payID.Visible = false;
            // 
            // label_Server
            // 
            this.label_Server.AutoSize = true;
            this.label_Server.Location = new System.Drawing.Point(32, 101);
            this.label_Server.Name = "label_Server";
            this.label_Server.Size = new System.Drawing.Size(38, 13);
            this.label_Server.TabIndex = 6;
            this.label_Server.Text = "Server";
            this.label_Server.Visible = false;
            // 
            // linkLabel_DR
            // 
            this.linkLabel_DR.AutoSize = true;
            this.linkLabel_DR.Location = new System.Drawing.Point(32, 34);
            this.linkLabel_DR.Name = "linkLabel_DR";
            this.linkLabel_DR.Size = new System.Drawing.Size(51, 13);
            this.linkLabel_DR.TabIndex = 7;
            this.linkLabel_DR.TabStop = true;
            this.linkLabel_DR.Text = "Data Rail";
            this.linkLabel_DR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_DR_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 672);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Base64 Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.ResumeLayout(false);
            this.panel_URL.ResumeLayout(false);
            this.panel_URL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListBox listBox_files;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.TreeView treeView_files;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.ListView listView_details;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripButton toolStripButton_add;
        private System.Windows.Forms.ToolStripButton toolStripButton_remove;
        private System.Windows.Forms.ToolStripButton toolStripButton_removeAll;
        private System.Windows.Forms.ToolStripButton toolStripButton_expand;
        private System.Windows.Forms.ToolStripButton toolStripButton_collapse;
        private System.Windows.Forms.ToolStripButton toolStripButton_preview;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.WebBrowser webBrowser_previewer;
        private System.Windows.Forms.ToolStripButton toolStripButton_save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList_treeIcons;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_type;
        private System.Windows.Forms.ToolStripButton toolStripButton_URL;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_zoom;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem runningDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel_URL;
        private System.Windows.Forms.LinkLabel linkLabel_DR;
        private System.Windows.Forms.Label label_Server;
        private System.Windows.Forms.Label label_payID;
        private System.Windows.Forms.TextBox textBox_PayID;
        private System.Windows.Forms.ComboBox comboBox_server;
        private System.Windows.Forms.Button button_download;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_URL;
    }
}

