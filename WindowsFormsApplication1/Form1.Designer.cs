namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.すべて選択ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日付と日時ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.書式OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表示VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateButton = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintButton = new System.Windows.Forms.ToolStripMenuItem();
            this.QuitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Coppy = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.元に戻すToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取り消しToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォントToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ステータスバーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプhの表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // TextBox
            // 
            resources.ApplyResources(this.TextBox, "TextBox");
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Name = "TextBox";
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusBar});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            resources.ApplyResources(this.statusBar, "statusBar");
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.menuBar, "menuBar");
            this.menuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.編集EToolStripMenuItem,
            this.書式OToolStripMenuItem,
            this.表示VToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
            this.menuBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuBar.Name = "menuBar";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateButton,
            this.OpenButton,
            this.Save,
            this.toolStripSeparator2,
            this.PrintButton,
            this.toolStripSeparator1,
            this.QuitButton});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            resources.ApplyResources(this.ファイルToolStripMenuItem, "ファイルToolStripMenuItem");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Paste,
            this.Cut,
            this.Coppy,
            this.delete,
            this.toolStripSeparator3,
            this.元に戻すToolStripMenuItem,
            this.取り消しToolStripMenuItem,
            this.toolStripSeparator4,
            this.すべて選択ToolStripMenuItem,
            this.日付と日時ToolStripMenuItem});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            resources.ApplyResources(this.編集EToolStripMenuItem, "編集EToolStripMenuItem");
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // すべて選択ToolStripMenuItem
            // 
            this.すべて選択ToolStripMenuItem.Name = "すべて選択ToolStripMenuItem";
            resources.ApplyResources(this.すべて選択ToolStripMenuItem, "すべて選択ToolStripMenuItem");
            this.すべて選択ToolStripMenuItem.Click += new System.EventHandler(this.すべて選択ToolStripMenuItem_Click);
            // 
            // 日付と日時ToolStripMenuItem
            // 
            this.日付と日時ToolStripMenuItem.Name = "日付と日時ToolStripMenuItem";
            resources.ApplyResources(this.日付と日時ToolStripMenuItem, "日付と日時ToolStripMenuItem");
            this.日付と日時ToolStripMenuItem.Click += new System.EventHandler(this.日付と日時ToolStripMenuItem_Click);
            // 
            // 書式OToolStripMenuItem
            // 
            this.書式OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.フォントToolStripMenuItem});
            this.書式OToolStripMenuItem.Name = "書式OToolStripMenuItem";
            resources.ApplyResources(this.書式OToolStripMenuItem, "書式OToolStripMenuItem");
            // 
            // 表示VToolStripMenuItem
            // 
            this.表示VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ステータスバーToolStripMenuItem});
            this.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem";
            resources.ApplyResources(this.表示VToolStripMenuItem, "表示VToolStripMenuItem");
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ヘルプhの表示ToolStripMenuItem,
            this.バージョン情報ToolStripMenuItem});
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            resources.ApplyResources(this.ヘルプToolStripMenuItem, "ヘルプToolStripMenuItem");
            // 
            // CreateButton
            // 
            this.CreateButton.Image = global::WindowsFormsApplication1.Properties.Resources.outline_fiber_new_black_18dp;
            this.CreateButton.Name = "CreateButton";
            resources.ApplyResources(this.CreateButton, "CreateButton");
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Image = global::WindowsFormsApplication1.Properties.Resources.outline_open_in_new_black_18dp;
            this.OpenButton.Name = "OpenButton";
            resources.ApplyResources(this.OpenButton, "OpenButton");
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // Save
            // 
            this.Save.Image = global::WindowsFormsApplication1.Properties.Resources.outline_save_alt_black_18dp;
            this.Save.Name = "Save";
            resources.ApplyResources(this.Save, "Save");
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Image = global::WindowsFormsApplication1.Properties.Resources.outline_print_black_18dp;
            this.PrintButton.Name = "PrintButton";
            resources.ApplyResources(this.PrintButton, "PrintButton");
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Image = global::WindowsFormsApplication1.Properties.Resources.outline_power_settings_new_black_18dp;
            this.QuitButton.Name = "QuitButton";
            resources.ApplyResources(this.QuitButton, "QuitButton");
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // Paste
            // 
            this.Paste.Image = global::WindowsFormsApplication1.Properties.Resources.outline_list_alt_black_18dp;
            this.Paste.Name = "Paste";
            resources.ApplyResources(this.Paste, "Paste");
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Cut
            // 
            this.Cut.Image = global::WindowsFormsApplication1.Properties.Resources.outline_attach_file_black_18dp;
            this.Cut.Name = "Cut";
            resources.ApplyResources(this.Cut, "Cut");
            this.Cut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // Coppy
            // 
            this.Coppy.Image = global::WindowsFormsApplication1.Properties.Resources.outline_file_copy_black_18dp;
            this.Coppy.Name = "Coppy";
            resources.ApplyResources(this.Coppy, "Coppy");
            this.Coppy.Click += new System.EventHandler(this.Coppy_Click);
            // 
            // delete
            // 
            this.delete.Image = global::WindowsFormsApplication1.Properties.Resources.outline_delete_black_18dp1;
            this.delete.Name = "delete";
            resources.ApplyResources(this.delete, "delete");
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // 元に戻すToolStripMenuItem
            // 
            this.元に戻すToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.outline_undo_black_18dp;
            this.元に戻すToolStripMenuItem.Name = "元に戻すToolStripMenuItem";
            resources.ApplyResources(this.元に戻すToolStripMenuItem, "元に戻すToolStripMenuItem");
            this.元に戻すToolStripMenuItem.Click += new System.EventHandler(this.元に戻すToolStripMenuItem_Click);
            // 
            // 取り消しToolStripMenuItem
            // 
            this.取り消しToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.outline_redo_black_18dp;
            this.取り消しToolStripMenuItem.Name = "取り消しToolStripMenuItem";
            resources.ApplyResources(this.取り消しToolStripMenuItem, "取り消しToolStripMenuItem");
            this.取り消しToolStripMenuItem.Click += new System.EventHandler(this.取り消しToolStripMenuItem_Click);
            // 
            // フォントToolStripMenuItem
            // 
            this.フォントToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.outline_text_format_black_18dp;
            this.フォントToolStripMenuItem.Name = "フォントToolStripMenuItem";
            resources.ApplyResources(this.フォントToolStripMenuItem, "フォントToolStripMenuItem");
            this.フォントToolStripMenuItem.Click += new System.EventHandler(this.フォントToolStripMenuItem_Click);
            // 
            // ステータスバーToolStripMenuItem
            // 
            this.ステータスバーToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.outline_report_black_18dp;
            this.ステータスバーToolStripMenuItem.Name = "ステータスバーToolStripMenuItem";
            resources.ApplyResources(this.ステータスバーToolStripMenuItem, "ステータスバーToolStripMenuItem");
            this.ステータスバーToolStripMenuItem.Click += new System.EventHandler(this.ステータスバーToolStripMenuItem_Click);
            // 
            // ヘルプhの表示ToolStripMenuItem
            // 
            this.ヘルプhの表示ToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.outline_home_black_18dp1;
            this.ヘルプhの表示ToolStripMenuItem.Name = "ヘルプhの表示ToolStripMenuItem";
            resources.ApplyResources(this.ヘルプhの表示ToolStripMenuItem, "ヘルプhの表示ToolStripMenuItem");
            this.ヘルプhの表示ToolStripMenuItem.Click += new System.EventHandler(this.ヘルプhの表示ToolStripMenuItem_Click);
            // 
            // バージョン情報ToolStripMenuItem
            // 
            this.バージョン情報ToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.outline_info_black_18dp;
            this.バージョン情報ToolStripMenuItem.Name = "バージョン情報ToolStripMenuItem";
            resources.ApplyResources(this.バージョン情報ToolStripMenuItem, "バージョン情報ToolStripMenuItem");
            this.バージョン情報ToolStripMenuItem.Click += new System.EventHandler(this.バージョン情報ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.TextBox);
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 書式OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 表示VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem CreateButton;
        private System.Windows.Forms.ToolStripMenuItem OpenButton;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem PrintButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem QuitButton;
        private System.Windows.Forms.ToolStripMenuItem 元に戻すToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Paste;
        private System.Windows.Forms.ToolStripMenuItem Cut;
        private System.Windows.Forms.ToolStripMenuItem Coppy;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripMenuItem すべて選択ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日付と日時ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フォントToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ステータスバーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプhの表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 取り消しToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
    }
}

